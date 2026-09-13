# Domain thẻ cầu thủ và đội hình (P1-03 / P1-06)

> Authority: [Cards/progression spec](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/player-cards-skills-progression-market-and-exchange.md) · [Nhật ký P1-03](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-player-items-skills-and-progression-implementation.md) · [Kế hoạch P1-06](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-06-squad-rules-and-card-tiers-plan.md) · [Nhật ký P1-06](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-06-squad-rules-and-card-tiers-implementation.md)

Assembly: `SoccerMobilePro.PlayerItems` (domain thuần) và `SoccerMobilePro.PlayerItems.Unity` (adapter).

## 1. Entity chính

| Entity | File | Vai trò |
| --- | --- | --- |
| `OwnedPlayerItem` | `PlayerItemContracts.cs` | Thẻ sở hữu: `ItemDefinitionId` (FK catalog), `State`, `LockState`, `Revision`, progression, và 5 trục P1-06 (`UpgradeTier`, `TrainingLevel`, `TrainingPoints`, `SalaryOverride`, `SeasonId`). |
| `InventorySnapshot` | `PlayerItemContracts.cs` | Aggregate inventory của một owner: `Revision`, `CatalogVersion`, `RulesVersion`, `Items`. Schema 2. |
| `TransactionReceipt` + `LedgerEntry` | `PlayerItemContracts.cs` | Biên lai bất biến (`sealed`), `InventoryDelta`, bút toán tổng 0. |
| `SquadDefinition` | `SquadRulesContracts.cs` | Đội hình: formation, 11 assignment, 7 dự bị, đội trưởng, set-piece takers, kit/sân/bóng, `Revision`. |
| `SquadSnapshot` | `SquadRulesContracts.cs` | Aggregate đội hình của owner: tối đa `MaxSquadSlots` (fixture: 3), `SalaryCapExpansion`. Schema 1. |

## 2. State machine của thẻ

```text
              grant
   (none) ──────────► Available ◄─────────────┐
                          │  lưu đội hình có thẻ   │ rời MỌI slot đội hình
                          ▼                       │
                        InSquad ─────────────────┘

   Available ── giao dịch khác đang giữ ──► Reserved ──► Available | Consumed
   Available ── fuse/tiêu huỷ ──► Consumed (terminal)
```

- `LockState = Locked` là **khoá giao dịch** (chống bán/tiêu nhầm), **không** chặn ra sân; validator chỉ cảnh báo `ItemLocked`.
- `Reserved`/`Consumed` bị validator từ chối khỏi đội hình (`ItemUnavailable`) và reconciler không bao giờ đụng.
- Mọi thay đổi state tăng `Revision` +1 để preview đang mở trên thẻ đó bị `StaleRevision`.

## 3. Luồng giao dịch

### 3.1 Progression (P1-03)

`IProgressionPreviewService.Build` → `ProgressionPreview` (hash canonical, `ExpiresAt`) → `InventoryTransactionService.Execute(command, preview)`:

1. Replay theo `IdempotencyKey` (cùng payload → cùng receipt; khác payload → `IdempotencyConflict`).
2. Kiểm tra inventory/item revision, catalog/rules version, preview hash, expiry, intent.
3. Thế `AfterItem`, xoá source item nếu fuse, `Revision` +1, ledger `inventory:<operation>` ±1.
4. `IInventoryRepository.TryCommit(expectedRevision)` → `Committed` hoặc `AtomicCommitFailed`.

### 3.2 Lưu đội hình (P1-06 B2/B2b)

| Service | Kho | Chuyển state thẻ | Dùng khi |
| --- | --- | --- | --- |
| `SquadSaveService` | `ISquadRepository` | **Không** | Storage chỉ sở hữu aggregate đội hình. |
| `SquadLineupSaveService` | `ISquadInventoryStore` | **Có**, trong cùng một commit | Mặc định cho client/authority giả lập. |

Luồng `SquadLineupSaveService.Save`: guard → replay → load inventory (thiếu → `ItemNotFound`) → kiểm tra **cả hai** revision → `SquadValidator.Validate` → `SquadSavePolicy.CanSave` → upsert draft (`draft.Revision` +1) → `SquadLineupStateReconciler.Reconcile` trên **toàn bộ** snapshot → một `TryCommit` 7 tham số với `InventoryDelta` và bút toán `squad.lineup` ±1 + `inventory:squadstate` ±N.

`IsValid` (không lỗi) ≠ `IsPlayable` (được ra sân) ≠ `CanSave` (mọi lỗi thuộc `allowInvalidSave`, fixture: `BenchIncomplete`, `PositionMismatch`). Người chơi lưu được đội hình thiếu dự bị nhưng không ra trận được.

### 3.3 Nâng bậc thẻ (P1-06 B3)

`UpgradeTierPreviewService.Build(snapshot, itemId, useInsurance)` → `UpgradeTierAttemptPreview` (tỉ lệ, chi phí, outcome hiệu lực, hash, hết hạn 5 phút) → `UpgradeTierService.Confirm(command, preview)`:

1. Replay theo key (outcome dựng lại từ marker ledger, **không roll lại**).
2. Guard: revision, catalog, rules, hash, `UseInsurance` khớp preview, tier khớp, số dư đủ.
3. `ProtectedItem` nếu outcome hiệu lực là `Consume` và thẻ `Locked`/`InSquad` — **trước** roll.
4. `roll = IUpgradeRollSource.Roll(key, rulesVersion)`; thành công khi `roll < successRateBasisPoints`.
5. Áp Success (+1) / Keep / Downgrade (−1) / Consume (`State = Consumed`, giữ bản ghi). Bảo hiểm biến mọi thất bại thành Keep và luôn bị tiêu.
6. Một commit: thẻ mới + bút toán `owner −N / sink:upgrade +N` cho từng tài nguyên + marker outcome.

Số dư tài nguyên (`fixture-material-core`, `currency.bp`, bảo hiểm…) **suy từ ledger** qua `IResourceBalanceLedger`; kho từ chối mọi commit làm owner âm.

## 4. Lương và Team Color (pure function)

- **Lương thẻ** = dải lương theo `BaseOverall` → override fixture theo `ItemDefinitionId` → `SalaryOverride` trên thẻ → nhân `salaryScalingPerTier[UpgradeTier]` (basis point, làm tròn nửa lên bằng `long`).
- **Quỹ lương** tính theo `SalaryCountingScope` (fixture: `StartingXI`); cap = `SalaryCapBase` + `SalaryCapExpansion` (≤ `SalaryCapExpansionMax`). Vượt cap → lỗi `SalaryCapExceeded` → `TransactionFailureCode.SalaryCapExceeded`.
- **Team Color** đếm liên kết theo từng trục cấu hình (`Club`, `Nation`, `Season`, `League`) trong scope; so ngưỡng → `BonusProfileId`. **Chưa áp modifier vào match core** (chỉ xuất profile).

## 5. Fixture và test

| Fixture | Nội dung |
| --- | --- |
| `SquadRulesFixtures.Inventory()` | 18 thẻ `owned-01..18` (→ `fixture-item-01..18`), 01–11 `InSquad`, 12–18 `Available`, revision 4. |
| `SquadRulesFixtures.Squad(bundle)` | Đội hình 4-3-3 hợp lệ, đội trưởng `owned-01`, penalty `owned-02`, corner `owned-12`. |
| `SquadRulesFixture.json` | `maxTier 10`, ba `failureOutcome` (`Keep` 1–4, `Downgrade` 5–7, `Consume` 8–10), Team Color ngưỡng 3/6/9, cap 1200+400. |

Nhóm test EditMode: `SquadRulesContractTests` (19), `SquadEconomyTests` + `SquadValidatorTests` + `SquadRepositoryTests` (42), `SquadLineupTransactionTests` (10), `UpgradeTierTransactionTests` (12). Tất cả **chưa chạy Unity Test Runner** — đây là gát đầu tiên cần đóng.

## 6. Còn mở

- **B4** huấn luyện (training points là tài nguyên ledger, không randomness). **B5** projection + diagnostic panel + PlayMode + `FileSquadInventoryStore`. **B6** docs/evidence.
- Backend authority thật, UI production (P2-06), áp Team Color vào match core (P5-03).
