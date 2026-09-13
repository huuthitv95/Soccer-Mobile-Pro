# Kế hoạch P1-06 squad rules, Team Color, lương, nâng cấp bậc và huấn luyện

> [Chỉ mục](../index.md) · [TODO](../../TODO.md) · [Cards/progression spec](../systems/player-cards-skills-progression-market-and-exchange.md) · [P1-03 plan](p1-player-items-skills-and-progression-plan.md) · [Nghiên cứu FC Online M](../research/fc-online-m/fc-online-m-research.md) · [Adoption FC Online M](../research/fc-online-m/fc-online-m-adoption-decision-matrix.md)

**Trạng thái:** `InProgress` ngày 12/09/2026. Batch **B1, B2, B2b và B3 đã triển khai** ở mức domain (B1/B2 qua tuyến `feat/p1-06-b1-squad-rules-contracts` / `feat/p1-06-b2-squad-validation`, B2b và B3 commit trực tiếp lên `main`); xem [nhật ký P1-06](p1-06-squad-rules-and-card-tiers-implementation.md) để biết kết quả, sai khác so với kế hoạch và giới hạn. Các batch còn lại (B4–B6) phải chạy trong môi trường có Unity MCP để chạy test runner trước khi commit; toàn bộ test B1–B3 cũng cần được chạy lần đầu.

## 0. Mục lục

- [1. Mục tiêu và phạm vi](#goal)
- [2. Understand brief](#understand)
- [3. Contract và boundary](#contracts)
- [4. Rule set và fixture](#rulesets)
- [5. Luồng transaction và validation](#flows)
- [6. Failure, abuse và rollback](#failure)
- [7. Test và acceptance](#tests)
- [8. Evidence, decision lifecycle và docs](#evidence)
- [9. Thứ tự triển khai theo batch](#delivery)

<a id="goal"></a>

## 1. Mục tiêu và phạm vi

Mục tiêu là mở rộng domain P1-03 để mọi cơ chế meta cốt lõi của tham chiếu FC Online M có **contract thuần C#, rule set versioned, fixture deterministic và automated test**, làm đầu vào cho UI P2-06 và hệ thống P5-01…P5-05. Batch không quyết định số cân bằng production; mọi tham số nằm trong rule set fixture có version và được đánh dấu `hypothesis`.

**Trong phạm vi:** `CardSeason`, `UpgradeTier` (+1…+N) với preview/receipt, `Training` theo điểm/level, `TeamColor` theo tập thuộc tính, `SquadSalaryCap`, `SquadDefinition` với formation/slot/tactic/set-piece/captain và `SquadValidator`. Serialization N/N-1 cho inventory snapshot mở rộng. Fixture dùng catalog hư cấu P1-02.

**Ngoài phạm vi:** backend thật, UI production, market/tuyển dụng, HLV card, kit/sân/bóng asset thật, gameplay modifier từ Team Color vào match core (chỉ xuất `TeamColorBonusProfile`, chưa áp dụng), số cân bằng production, random pack.

**Liên kết quyết định:** [FOM-D01](../research/fc-online-m/fc-online-m-adoption-decision-matrix.md#open-decisions) (rule thất bại nâng cấp), FOM-D02 (tham số Team Color/lương). Cả hai ở `Proposed`; batch này thiết kế để **đổi tham số không cần đổi code** nên có thể triển khai trước khi P1-05b xác minh.

<a id="understand"></a>

## 2. Understand brief

- **Ranh giới hệ thống:** assembly `SoccerMobilePro.PlayerItems` (domain thuần) và `SoccerMobilePro.PlayerItemsUnity` (adapter/file/diagnostic). Không chạm legacy scene, `MatchCore`, `Input`.
- **Owner module hiện tại:** `PlayerItemContracts.cs` (entity/preview/command/receipt), `ProgressionRules.cs` (rule set, eligibility, cap), `InventoryTransactions.cs` (atomic transaction, ledger, idempotency), `InventoryPersistence.cs` (snapshot N/N-1), `PlayerItemsFixtureFactory.cs` (owner/roster fixture). Catalog entity/ID/FK từ `Runtime/Catalog`.
- **Luồng dữ liệu:** `catalog/rules version → OwnedPlayerItem → preview → command (idempotency) → atomic ledger + delta → receipt → projection`. P1-06 thêm hai trục mới trên cùng luồng (`UpgradeTier`, `Training`) và một aggregate mới (`SquadDefinition`) được validate bằng rule set nhưng **không** đi qua ledger vì không tiêu tài nguyên.
- **Invariant phải giữ:** revision tăng đơn điệu; item `Locked`/`InSquad` không bị consume; cùng idempotency key trả cùng receipt; rules/catalog version mismatch bị reject trước mutation; không Unity API trong domain.
- **Serialized data:** `InventorySnapshot` thêm trường; snapshot cũ phải load được với default (`tier = 0`, `trainingLevel = 0`, `seasonId` từ catalog). `SquadSnapshot` là file mới.
- **Test hiện có:** 22 EditMode + 2 PlayMode cho P1-03; toàn bộ 102/19 phải tiếp tục pass.
- **Rủi ro chính:** phình `OwnedPlayerItem`; RNG nâng cấp làm mất deterministic; Team Color scope (XI hay 18) chưa xác minh. **Rollback:** feature flag `PlayerItems.SquadRules`, rule set version pin, snapshot N-1 vẫn đọc được.

<a id="contracts"></a>

## 3. Contract và boundary

```text
CardSeasonDefinition { seasonId, displayNameKey, releasedAt, statProfileId,
  marketClass, rightsVersion, rulesVersion }

ItemDefinition (+) { seasonId, baseSalary, teamColorTags: { clubId, nationId, seasonId, leagueId } }

OwnedPlayerItem (+) { upgradeTier, trainingLevel, trainingPoints, salaryOverride? }

UpgradeTierRuleSet { rulesVersion, maxTier,
  tiers[ { tier, successRateBasisPoints, materialCost[], currencyCost,
           failureOutcome: Keep|Downgrade|Consume, insuranceItemId? } ],
  statScalingPerTier[], salaryScalingPerTier[] }

UpgradeTierAttemptPreview { previewHash, itemRevision, rulesVersion, fromTier, toTier,
  successRateBasisPoints, cost, onSuccess, onFailure, insuranceApplied, expiresAt }
UpgradeTierAttemptCommand { itemId, expectedRevision, previewHash, useInsurance, idempotencyKey }
UpgradeTierAttemptReceipt : TransactionReceipt (+) { outcome: Success|Failure, rollAuditHash, resultTier }

TrainingRuleSet { rulesVersion, maxLevel, pointsRequiredPerLevel[], statGainPerLevel[], pointSources[] }
TrainingCommand { itemId, expectedRevision, pointsToApply, previewHash, idempotencyKey }

TeamColorRuleSet { rulesVersion, countedAttributes: [Club|Nation|Season|League],
  countingScope: StartingXI|MatchSquad, thresholds[ { minCount, bonusProfileId } ] }
TeamColorBonusProfile { profileId, statModifiers[], traceLabelKey }

SquadRuleSet { rulesVersion, formationIds[], startingCount, benchCount,
  salaryCapBase, salaryCapExpansionMax, salaryCountingScope: StartingXI|MatchSquad, maxSquadSlots }

SquadDefinition { squadId, ownerId, slotIndex, formationId,
  assignments[ { positionSlotId, itemId } ], benchItemIds[],
  tacticProfileId, setPieceTakers { fk, pk, ck, throwIn }, captainItemId,
  kitId, stadiumId, ballId, revision, rulesVersion }
SquadValidationResult { isValid, salaryTotal, salaryCap, teamColor { attribute, count, profileId },
  errors[ { code, positionSlotId?, itemId? } ], warnings[] }
```

**Interfaces:** `IUpgradeTierRuleSet`, `IUpgradeRollSource` (server-side; fixture deterministic theo seed + idempotency key), `ITrainingRuleSet`, `ITeamColorRuleSet`, `ITeamColorCalculator`, `ISalaryCalculator`, `ISquadRuleSet`, `ISquadValidator`, `ISquadRepository`.

**Boundary:** client chỉ build `SquadDefinition` draft, gọi validate/preview và gửi command. Authority giả lập kiểm tra owner, catalog/rules version, revision, lock/state, balance, idempotency; chỉ authority tạo receipt, roll và delta. `rollAuditHash = H(serverSeed, idempotencyKey, rulesVersion)` được ghi vào receipt để audit không lộ seed. Team Color và lương là **pure function** của squad + catalog + rule set, không lưu kết quả làm authority.

<a id="rulesets"></a>

## 4. Rule set và fixture

| Rule set | Fixture v1 (hypothesis) | Ghi chú |
| --- | --- | --- |
| `UpgradeTierRuleSet` | `maxTier = 10`; bảng tỷ lệ giảm dần theo tier; tier thấp `Keep`, tier cao `Downgrade`; có insurance item hư cấu | Rule thất bại thật chờ FOM-Q02; fixture phải chứng minh cả ba `failureOutcome` đều test được |
| `TrainingRuleSet` | `maxLevel = 5`; điểm cần tăng dần; gain nhỏ, không vượt cap stat | Ngăn training thay thế upgrade |
| `TeamColorRuleSet` | Đếm `Club` và `Nation`; scope `StartingXI`; ba ngưỡng | Scope thật chờ FOM-Q04; fixture có test cho cả hai scope |
| `SquadRuleSet` | Formation `4-3-3`, `4-4-2`, `4-2-3-1`; 11 chính + 7 dự bị; `salaryCapBase` và `salaryCapExpansionMax`; 3 slot đội hình | Cap thật chờ FOM-Q05 |
| `CardSeasonDefinition` | Hai mùa hư cấu `SEASON_BASE`, `SEASON_ICON_FIX` với `statProfileId` khác nhau | Không dùng tên mùa của bên thứ ba |

Fixture roster P1-03 được mở rộng để có: item đủ Team Color ngưỡng 1 nhưng vượt lương; item `Locked` trong đội hình; item tier cao có lương vượt cap sau khi nâng; hai owner để test owner mismatch. Mọi giá trị fixture đặt trong một file JSON versioned tại `Runtime/Catalog/Fixtures` hoặc `Runtime/PlayerItems`, không hard-code trong test.

<a id="flows"></a>

## 5. Luồng transaction và validation

**Nâng cấp bậc:** `Preview(itemId, useInsurance)` → hash gồm rules/catalog version, tier, cost, outcome table, expiry → `Confirm(command)` → authority: verify → reserve material/currency → `roll = IUpgradeRollSource.Roll(key)` → áp dụng `Success` (tier+1) hoặc `failureOutcome` → ledger cân bằng (consume material, consume insurance nếu dùng) → delta → receipt có `outcome`, `rollAuditHash`, `resultTier`. Retry cùng key trả cùng receipt kể cả outcome.

**Huấn luyện:** `Preview(itemId, points)` → `Confirm` → consume điểm từ ledger, tăng `trainingPoints`, level up khi đủ ngưỡng, không vượt `maxLevel`; dư điểm giữ lại. Không randomness.

**Squad validate/save:** `Validate(SquadDefinition)` chạy tuần tự: formation tồn tại → mỗi slot có item thuộc owner, không trùng, item `Available|InSquad` → vị trí đủ proficiency (cảnh báo nếu lệch) → tính lương với `salaryScalingPerTier` → so cap → tính Team Color theo scope → trả `SquadValidationResult`. `Save` chỉ nhận squad `isValid` hoặc có lỗi thuộc tập `allowInvalidSave` (ví dụ thiếu dự bị) với cờ `isPlayable = false`; chuyển item sang `InSquad` và item rời đội hình về `Available` trong cùng commit; revision tăng.

**Projection:** `OwnedPlayerItemProjection` thêm `upgradeTier`, `trainingLevel`, `salary`, `seasonId`; `SquadProjection` thêm `salaryTotal/Cap`, `teamColor`, `isPlayable`.

<a id="failure"></a>

## 6. Failure, abuse và rollback

| Failure/abuse | Kết quả bắt buộc |
| --- | --- |
| Retry cùng key sau `Unknown` | Cùng receipt, cùng outcome, không roll lại |
| Client gửi outcome hoặc roll | Trường không tồn tại trong command; reject payload lạ |
| Preview hết hạn/rule version đổi | `StalePreview`, không mutation |
| Nâng cấp item `Locked`/`InSquad` khi outcome `Consume` | Reject `ProtectedItem` trước roll |
| Insurance không đủ/không hợp lệ | Reject trước reserve |
| Vượt lương sau nâng cấp | Squad chuyển `isPlayable = false` với lỗi `SalaryCapExceeded`; item vẫn nâng thành công |
| Item trong hai squad slot khác | Cho phép (slot độc lập) nhưng state `InSquad` giữ tới khi rời mọi slot |
| Snapshot N-1 thiếu trường | Default an toàn, ghi `migrationApplied` |
| Rules/catalog tamper | Version + hash mismatch reject; audit correlation |

**Rollback:** flag `PlayerItems.SquadRules` tắt → validator trả `NotEnabled`, upgrade tier/training không nhận command; snapshot format N-1 đọc được; pin `rulesVersion` cũ; không xóa lịch sử ledger, chỉ compensating entry.

<a id="tests"></a>

## 7. Test và acceptance

**EditMode (mục tiêu ≥ 30 case mới):**

- Upgrade tier: success/failure ba loại outcome; insurance; idempotency với cùng key; stale preview; protected item; ledger cân bằng; `rollAuditHash` ổn định theo key.
- Training: level up đúng ngưỡng; dư điểm; cap; idempotency.
- Team Color: đúng ngưỡng theo `Club`/`Nation`; scope XI vs MatchSquad; item trùng thuộc tính nhiều trục chỉ đếm theo trục được cấu hình; property test: thêm item cùng CLB không giảm count.
- Salary: tổng theo tier scaling; cap mở rộng; cảnh báo vượt.
- Squad validator: formation sai, trùng item, owner sai, item `Locked` của owner khác, thiếu dự bị cho phép save `isPlayable=false`; state `InSquad` chuyển đúng khi thay người; revision.
- Persistence: snapshot N-1 load với default; round-trip N; squad snapshot round-trip.

**PlayMode (≥ 2 case):** diagnostic panel sau flag hiển thị squad projection với lương/Team Color và cập nhật sau upgrade fixture; không lỗi console.

**Acceptance:** toàn bộ regression trước đó pass (102 EditMode + 19 PlayMode) cộng case mới; console sạch; snapshot N-1 rehearsal; docs mục 8 cập nhật; feature flag mặc định tắt; không có số production trong code, chỉ trong fixture JSON có version.

<a id="evidence"></a>

## 8. Evidence, decision lifecycle và docs

- Nhật ký triển khai: `docs/implementation/p1-06-squad-rules-and-card-tiers-implementation.md` (test count, runner output, giới hạn).
- Cập nhật cùng change set: [cards/progression spec](../systems/player-cards-skills-progression-market-and-exchange.md) (entity mới, state `InSquad` mở rộng, quyết định PCS mới), [competitions spec](../systems/competitions-leagues-clubs-and-social.md) nếu `SquadDefinition` được trận dùng, [audit backlog](unity-implementation-audit-and-backlog.md) (thêm hàng P1-06), [coverage audit](../research/fc-mobile-vn-coverage-audit.md), [TODO](../../TODO.md) (P1-06 → `[x]`, dòng parity #7, #8, #10, #11, #12, #13 → `Một phần`).
- Decision: FOM-D01/FOM-D02 chuyển `Proposed → TestReady` khi có fixture test cho mọi biến thể rule; `Approved` chỉ sau P1-05b và balance review.

<a id="delivery"></a>

## 9. Thứ tự triển khai theo batch

| Batch | Nội dung | Đầu ra | Ước lượng |
| --- | --- | --- | --- |
| B1 | Contract + rule set interface + fixture JSON v1; mở rộng `OwnedPlayerItem`, snapshot N/N-1 | Đã triển khai code; cần Unity Test Runner | 0.5 ngày |
| B2 | `ISalaryCalculator`, `ITeamColorCalculator`, `ISquadValidator`, `ISquadRepository` in-memory/file | Đã triển khai code; cần Unity Test Runner | 1 ngày |
| B2b | `SquadLineupSaveService` + `ISquadInventoryStore` (`SquadLineupTransactions.cs`): lưu đội hình và chuyển item `Available ↔ InSquad` trong cùng một commit với inventory (tách ra từ B2) | Đã triển khai code (in-memory store, 10 EditMode); cần Unity Test Runner; file store hai aggregate dời sang B5 | 0.5 ngày |
| B3 | `UpgradeTierPreviewService` + `UpgradeTierService` (`UpgradeTierTransactions.cs`): preview/command/receipt, `IUpgradeRollSource` deterministic, số dư tài nguyên suy từ ledger, marker outcome cho replay | Đã triển khai code (12 EditMode); cần Unity Test Runner | 1 ngày |
| B4 | Training preview/command | EditMode training | 0.5 ngày |
| B5 | Projection + diagnostic panel sau flag; PlayMode | PlayMode 2 case, screenshot | 0.5 ngày |
| B6 | Docs/evidence/TODO cập nhật; Understand diff; commit từng batch riêng theo convention `feat:`/`test:`/`docs:` | Nhật ký P1-06 | 0.5 ngày |

Mỗi batch commit và push riêng lên `main` sau khi test runner pass. Nếu B3 phát hiện RNG làm regression determinism ở test khác, tách `IUpgradeRollSource` thành assembly adapter và giữ domain nhận `rollValue` làm input.
