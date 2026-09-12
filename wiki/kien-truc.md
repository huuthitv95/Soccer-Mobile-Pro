# Kiến trúc và assembly

> Authority: [Audit Unity và backlog](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/unity-implementation-audit-and-backlog.md). Trang này là bản đồ định hướng, không thay thế audit.

## 1. Hai tầng code trong một repo

| Tầng | Vị trí | Đặc điểm | Trạng thái |
| --- | --- | --- | --- |
| **Legacy prototype** | `Assets/SoccerMobilePro/Runtime/Legacy/**`, assembly mặc định `Assembly-CSharp` | `GameManager` singleton, scene name string, `GameObject.Find`, static flag, legacy `Animation`, `OnGUI`, `PlayerPrefs` | Vẫn là **runtime mặc định** của Quick Match/Cup. Sẽ bị thay dần theo P0-01b/P0-02b/P0-04. |
| **Foundation** | `Assets/SoccerMobilePro/Runtime/<Domain>/` với `.asmdef` riêng | Domain thuần C# (`noEngineReferences: true`), rule set versioned, snapshot N/N-1, receipt + ledger, feature flag mặc định tắt | Có automated test; chạy dưới dạng shadow adapter/diagnostic panel. |

Quy tắc cứng: **không thêm hệ thống mới vào assembly mặc định**; không dùng `UnityEngine` trong assembly domain; adapter Unity nằm trong assembly `*.Unity` hoặc `SettingsUI`.

## 2. Bản đồ 13 assembly

```text
SoccerMobilePro.Platform            (account/session/catalog contract, fake adapter, hash)
   ↑            ↑
SoccerMobilePro.Catalog             SoccerMobilePro.Competition
   ↑   (entity, ID/FK validator,        (rules version, SE/RR bracket, roster lock,
   │    snapshot/delta, atomic store)     result receipt, reconnect, dispute)
   │
SoccerMobilePro.PlayerItems         (owned item, inventory transaction, ledger,
   ↑                                 progression, squad rules, Team Color, lương,
   │                                 squad+inventory atomic store)
SoccerMobilePro.PlayerItems.Unity   (file repository, diagnostic panel)
SoccerMobilePro.Catalog.Unity       (Addressables loader, model resolver + fallback)
SoccerMobilePro.SettingsUI          (typed settings registry, locale, MainMenu panel)

SoccerMobilePro.MatchCore           (phase/command/snapshot/event/hash deterministic)
   ↑
SoccerMobilePro.Input               (5 action map, 3 scheme, remap, profile)

SoccerMobilePro.Editor              (Editor-only guard/tooling)

Tests: SoccerMobilePro.MatchCore.Tests (EditMode, chứa cả test Catalog/PlayerItems/Competition)
       SoccerMobilePro.MatchCore.PlayModeTests
       SoccerMobilePro.SettingsUI.PlayModeTests
```

| Assembly | Phụ thuộc | Engine refs | Ghi chú |
| --- | --- | --- | --- |
| `Platform` | — | không | Contract nền: `CatalogManifest`, `CatalogIntegrity`, session. |
| `Catalog` | Platform, Newtonsoft | không | `CatalogSnapshot`/`CatalogDelta`, `FileCatalogStore`, `CatalogInstaller`. |
| `Catalog.Unity` | Catalog, Addressables, ResourceManager | có | `AddressableCatalogLoader`, `AddressableModelAssetResolver`. |
| `PlayerItems` | Catalog, Platform, Newtonsoft | không | Xem [Domain thẻ cầu thủ và đội hình](domain-the-cau-thu-va-doi-hinh). |
| `PlayerItems.Unity` | PlayerItems | có | Adapter file + diagnostic. |
| `Competition` | Platform, Newtonsoft | không | `TournamentSnapshot` schema 2, `FileCompetitionRepository`. |
| `SettingsUI` | Platform, Localization | có | Panel Settings trong MainMenu. |
| `MatchCore` | — | không | Shadow adapter sau flag, chưa điều khiển physics/HUD. |
| `Input` | MatchCore, Input System | có | Flag mặc định tắt; `SoccerInput`/joystick legacy vẫn chạy. |

## 3. Luồng dữ liệu phải trace trước khi sửa

- **Trận đấu:** `input → match state → player/ball/AI decision → animation/physics → HUD/replay → result/reward telemetry`.
- **Thẻ/kinh tế:** `catalog/version → inventory/card instance → upgrade/market transaction → server authority → UI projection → analytics/audit log`.
- **UI:** entry point → navigation state → view-model → async loading → error/empty state → localization key → accessibility → back-navigation.
- **LiveOps:** CMS/config version → eligibility → grant ledger → inbox/reward → expiry → recovery/rollback → anti-abuse.

## 4. Mẫu thiết kế lặp lại trong foundation

| Mẫu | Ý nghĩa | Ví dụ |
| --- | --- | --- |
| **Versioned rule set** | Số cân bằng nằm trong fixture JSON có `rulesVersion`, không hard-code | `SquadRulesFixture.json`, `CompetitionRules` |
| **Preview → Command → Receipt** | Client preview, server xác nhận hash preview + revision + idempotency key rồi mới mutate | `ProgressionPreview`, `InventoryTransactionService.Execute` |
| **Atomic commit + balanced ledger** | Một commit ghi snapshot + receipt + bút toán tổng 0 | `InMemoryInventoryStore`, `InMemorySquadInventoryStore` |
| **Snapshot N/N-1** | Codec chấp nhận schema hiện tại và N-1, giữ unknown field qua `[JsonExtensionData]` | `InventoryCodec`, `CompetitionCodec`, `SquadCodec` |
| **Atomic file store + .bak read-only** | Ghi `.tmp` → `File.Replace` → `.bak`; file hỏng thì đọc `.bak` ở chế độ chỉ đọc | `FileCatalogStore`, `FileSquadStore` |
| **Feature flag mặc định tắt** | Runtime mới chỉ bật khi flag on; rollback = tắt flag | `PlayerItems.SquadRules`, Match Core shadow adapter |
| **Canonical string → SHA-256** | Hash ổn định giữa client/server, không phụ thuộc thứ tự list | `SquadCanonical.Value`, `ProgressionHash` |

## 5. Không được làm

- `GetComponent`/`GameObject.Find`/LINQ/string concat trong `Update`/`FixedUpdate`.
- `public` field thay cho `[SerializeField] private`.
- Logic luật trận trong MonoBehaviour presentation.
- Float cho tiền/lương: dùng `long` + basis point, làm tròn nửa lên bằng số nguyên.
- Random không seed trong domain: roll phải deterministic theo `(serverSeed, idempotencyKey, rulesVersion)`.
