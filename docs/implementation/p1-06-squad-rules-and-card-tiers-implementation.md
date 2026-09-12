# Nhật ký P1-06 squad rules, Team Color, lương và bậc thẻ — batch B1–B2

> [Chỉ mục](../index.md) · [Kế hoạch P1-06](p1-06-squad-rules-and-card-tiers-plan.md) · [Cards/progression spec](../systems/player-cards-skills-progression-market-and-exchange.md) · [Nhật ký P1-03](p1-player-items-skills-and-progression-implementation.md) · [Adoption FC Online M](../research/fc-online-m/fc-online-m-adoption-decision-matrix.md)

**Ngày:** 12/09/2026 · **Baseline vào batch:** `9d3b4ee` (main) · **Commit batch:** `ae8aac7` (B1), `c579b71` (B2) · **Trạng thái:** B1, B2 xong ở mức domain; B2b, B3–B6 chưa làm.

## 0. Mục lục

- [1. Kết quả và phạm vi](#result)
- [2. Understand brief](#understand-brief)
- [3. Contract và boundary](#contracts)
- [4. Sai khác so với kế hoạch](#deviations)
- [5. Rule set fixture v1](#fixture)
- [6. Bằng chứng kiểm thử](#evidence)
- [7. Decision lifecycle](#decisions)
- [8. Giới hạn còn lại và batch kế tiếp](#limitations)

<a id="result"></a>

## 1. Kết quả và phạm vi

Batch này hiện thực hai batch đầu của [kế hoạch P1-06](p1-06-squad-rules-and-card-tiers-plan.md) trong assembly domain thuần `SoccerMobilePro.PlayerItems`:

- **B1:** contract `CardSeasonDefinition`, `UpgradeTierStep`/`IUpgradeTierRuleSet`, `ITrainingRuleSet`, `ITeamColorRuleSet`, `ISalaryRuleSet`, `ISquadRuleSet`, `SquadDefinition`, `SquadValidationResult`; rule set `Fixed*` đọc từ fixture JSON versioned `Runtime/PlayerItems/Fixtures/SquadRulesFixture.json`; `OwnedPlayerItem` thêm `SeasonId`, `UpgradeTier`, `TrainingLevel`, `TrainingPoints`, `SalaryOverride`; snapshot inventory lên schema **N = 3** với migration N-1.
- **B2:** `CatalogTeamColorTagResolver`, `CatalogPositionGroupResolver`, `CatalogSalaryCalculator`, `TeamColorCalculator`, `SquadValidator`, `SquadCodec`, `InMemorySquadRepository`, `FileSquadStore`; roster fixture P1-06 (33 item một owner + roster owner thứ hai).

**Ngoài phạm vi batch này:** transaction nâng cấp bậc (B3), transaction huấn luyện (B4), projection/diagnostic panel và PlayMode (B5), áp Team Color vào match core, backend thật, UI, market/tuyển dụng, số cân bằng production. Không chạm legacy scene, `MatchCore`, `Input`; không đổi `ProjectSettings/` hay `Packages/manifest.json`.

<a id="understand-brief"></a>

## 2. Understand brief

Knowledge graph của họ skill Understand **không khả dụng** trong session này; brief dưới đây dựng bằng đọc trực tiếp mã nguồn (`rg`, `git log`, đọc file) theo đúng quy tắc thay thế trong AGENTS.md.

- **Boundary:** `catalog (P1-02) + rule set fixture → OwnedPlayerItem → SquadDefinition draft → validate (pure) → SquadValidationResult`. Không có Unity API trong domain; `noEngineReferences` của assembly được giữ.
- **Owner module:** `SquadRuleContracts.cs` (entity/interface/policy), `SquadRuleSets.cs` (rule set cố định + codec fixture), `SquadValidation.cs` (resolver catalog, calculator, validator), `SquadPersistence.cs` (codec/repository squad), `PlayerItemsFixtureFactory.cs` (roster và squad fixture). `PlayerItemContracts.cs`, `InventoryPersistence.cs`, `ProgressionRules.cs` chỉ được mở rộng, không đổi hành vi cũ.
- **Invariant giữ được:** revision squad tăng đơn điệu và `TrySave` từ chối `expectedRevision` lệch; item `Consumed`/`Reserved` không xếp được đội hình; item `Locked` vẫn được xếp (khóa chống tiêu hao, không chống ra sân); version rules/catalog lệch bị chặn trước khi tính toán; Team Color và lương là pure function, không lưu làm authority.
- **Serialized data:** `InventorySnapshot` schema 3, đọc được schema 2 với default an toàn và cờ runtime `MigrationApplied`; `SquadEnvelope` schema 1 (chưa có N-1 nên chỉ nhận đúng schema 1).
- **Rủi ro và rollback:** `SquadValidator` nhận `featureEnabled` — tắt cờ trả đúng một lỗi `FeatureDisabled` và không đọc squad; pin `rulesVersion` cũ; file store giữ `.bak` last-known-good và chuyển read-only khi active hỏng.

<a id="contracts"></a>

## 3. Contract và boundary

| Thành phần | Vai trò | Ghi chú |
| --- | --- | --- |
| `ICardSeasonRuleSet` | Mùa thẻ và map `programId → seasonId`, có default | `ResolveSeasonId` luôn trả mùa đã khai báo |
| `IUpgradeTierRuleSet` | Bảng bậc +1…+N: tỷ lệ, chi phí, `failureOutcome`, bảo hiểm, scaling chỉ số | Chỉ dữ liệu; roll và ledger thuộc B3 |
| `ITrainingRuleSet` | Ngưỡng điểm theo level và gain chỉ số | `TryGetPointsRequiredForLevel` trả `false` ngoài dải level |
| `ITeamColorRuleSet` + `ITeamColorCalculator` | Đếm thuộc tính theo scope và map ngưỡng → bonus profile | Xuất `TeamColorBonusProfile`, **chưa** áp vào match |
| `ISalaryRuleSet` + `ISalaryCalculator` | Lương theo dải overall × scaling theo bậc, tôn trọng `SalaryOverride` | Làm tròn nửa lên bằng số nguyên, deterministic |
| `ISquadRuleSet` + `ISquadValidator` | Formation/slot/nhóm vị trí, cap lương, số slot đội hình, luật validate | Trả `IsValid`, `IsPlayable`, `CanSave`, `SalaryTotal/Cap`, Team Color, errors/warnings |
| `ISquadRepository` | Lưu squad theo `(ownerId, slotIndex)` với kiểm tra revision | In-memory và file; chưa gắn state item |

Phân loại lỗi: `SquadValidationPolicy.SaveableErrorCodes` = `{ BenchCountMismatch, SalaryCapExceeded }`. Đội hình chỉ chứa các lỗi này vẫn **save được** với `IsPlayable = false`; mọi lỗi khác chặn save. Lệch nhóm vị trí mà item không có proficiency cho slot chỉ là **warning**.

<a id="deviations"></a>

## 4. Sai khác so với kế hoạch

| Kế hoạch | Thực hiện | Lý do |
| --- | --- | --- |
| Thêm `seasonId`, `baseSalary`, `teamColorTags` vào `ItemDefinition` (catalog) | Suy ra club/nation/league/season từ đồ thị FK catalog P1-02 bằng `CatalogTeamColorTagResolver`; lương suy ra từ dải overall trong fixture | Không phải bump schema/version catalog và không nhân đôi authority cho dữ liệu dẫn xuất |
| `salaryScalingPerTier` nằm trong `UpgradeTierRuleSet` | Chuyển sang `ISalaryRuleSet.TierSalaryScalingBasisPoints` | Tách trục "chỉ số" khỏi trục "tiền"; đổi tham số lương không chạm bảng nâng cấp |
| — | Thêm `goalkeeperPositionGroup` + `positionSlotGroups` vào fixture squad | Cần để validate nhóm vị trí, đảm bảo đúng một slot GK mỗi formation và để fixture dựng được đội hình deterministic |
| `SquadRuleSet` giữ cap mở rộng | Mức mở rộng thực tế nằm trên `SquadDefinition.SalaryCapExpansion`, bị clamp theo `SalaryCapExpansionMax` | Mở rộng cap là trạng thái của người chơi, không phải hằng số rule set (**giả định**, chờ FOM-Q05) |
| B2 gồm cả `Save` chuyển item sang `InSquad` | Tách phần commit state item thành **B2b** | Việc này phải đi qua cùng transaction với inventory ledger; gộp vào B2 sẽ tạo hai authority ghi song song |

<a id="fixture"></a>

## 5. Rule set fixture v1

`SquadRulesFixture.json` mang `fixtureVersion = p1-06-fixture-v1`, `rulesVersion = 000000010601` và `claimLabel = hypothesis`. Mọi số là **đề xuất nội bộ Soccer Mobile Pro**, không sao chép tham số của tham chiếu và không dùng làm số cân bằng production.

| Rule set | Fixture v1 | Gate mở khóa |
| --- | --- | --- |
| Bậc thẻ | `maxTier = 10`; tỷ lệ 9500 → 700 basis point; `Keep` ở bậc 0–3, `Downgrade` 4–6, `Consume` 7–9; hai loại bảo hiểm hư cấu | FOM-Q02 |
| Huấn luyện | `maxLevel = 5`; ngưỡng 40/90/160/260/400 điểm; gain 60 → 400 basis point | FOM-Q03 |
| Team Color | Đếm `Club` và `Nation`, scope `StartingXI`, ngưỡng 3/5/8 → ba bonus profile | FOM-Q04 |
| Lương | 5 dải overall (10 → 52) × scaling theo bậc (0 → 7000 basis point) | FOM-Q05 |
| Đội hình | `4-3-3`, `4-4-2`, `4-2-3-1`; 11 chính + 7 dự bị; cap 260 + mở rộng tối đa 60; 3 slot | FOM-Q05 |
| Mùa thẻ | `SEASON_BASE`, `SEASON_ICON_FIX` với `statProfileId` khác nhau | FOM-Q06 |

Codec từ chối fixture sai cấu trúc trước khi rule set được dùng: thiếu `rulesVersion`, bảng bậc không liên tục, tỷ lệ ngoài dải 0…10000, ngưỡng Team Color không tăng dần hoặc trỏ profile chưa khai báo, formation lệch `startingCount`, formation không có đúng một slot GK, dải lương không bắt đầu từ overall 0, map `programSeasons` trỏ mùa chưa khai báo.

Roster fixture (`PlayerItemsFixtureFactory.CreateSquadInventory`) tạo 33 item cho một owner từ catalog hư cấu P1-02: 11 item CLB 1 dựng đủ đội hình `4-3-3` hợp lệ (lương 168/260), 11 item CLB 2 ở bậc cao nhất dựng đội hình vượt cap (lương 479/260), một item `Locked` nằm trong đội hình hợp lệ, một item `Consumed` để test không xếp được, cùng roster owner thứ hai cho test owner mismatch.

<a id="evidence"></a>

## 6. Bằng chứng kiểm thử

| Gate | Kết quả ngày 12/09/2026 | Phạm vi |
| --- | --- | --- |
| Biên dịch domain | Pass | `SoccerMobilePro.Platform` + `Catalog` + `PlayerItems` biên dịch sạch với LangVersion 9 |
| Test domain P1-06 | 44/44 pass | 20 test rule set/fixture/schema (B1) + 24 test salary/Team Color/validator/persistence (B2) |
| Regression P1-03 | 22/22 pass | Toàn bộ `PlayerItemsTransactionTests` và `PlayerItemsPersistenceTests` sau khi bump schema N=3 |
| Unity EditMode/PlayMode runner | **Chưa chạy** | Session không có Unity Editor/Unity MCP |
| Unity console | **Chưa kiểm tra** | Phụ thuộc runner ở trên |
| Device/operations | Chưa chạy | Ngoài phạm vi batch domain |

**Cách chạy test:** vì session không có Unity, 66 test EditMode nói trên được chạy bằng NUnit trên .NET 8 với cùng file nguồn trong repo (project harness nằm ngoài repo, không commit, theo đúng quy tắc "không tạo helper script trong repo"). Đây là bằng chứng cho **domain thuần C#**, không thay thế Unity Test Runner: trước khi coi P1-06 đạt gate Automated evidence, phải chạy lại `tests-run` trong Unity để xác nhận biên dịch asmdef, đếm test toàn project (kỳ vọng 102 + 44 = 146 EditMode) và console sạch.

Hai test cập nhật theo schema mới: `Codec_RoundTripsUnknownFields` dùng schema 3, `Codec_MigratesNMinusOneAndRejectsNMinusTwo` migrate 2 → 3 và từ chối schema 1. Test mới phủ: parse/validate fixture, mọi biến thể `failureOutcome`, clamp scaling, dải level huấn luyện, ngưỡng Team Color (gồm scope `StartingXI` vs `MatchSquad` và property "thêm item cùng CLB không giảm count"), lương theo bậc và `SalaryOverride`, clamp cap mở rộng, validator (formation lạ, trùng item, item owner khác, item `Consumed`, thiếu dự bị vẫn save được, captain/người đá phạt ngoài XI, slot ngoài dải, version lệch, warning nhóm vị trí và cách proficiency triệt tiêu warning), migration N-1, round-trip schema 3, round-trip squad snapshot, revision/slot độc lập của repository.

<a id="decisions"></a>

## 7. Decision lifecycle

- `FOM-D01` (rule thất bại nâng cấp + bảo hiểm): giữ `Proposed`. Fixture đã chứng minh cả ba `failureOutcome` được mô tả và validate, nhưng transaction áp dụng outcome thuộc B3 nên chưa đủ điều kiện `TestReady`.
- `FOM-D02` (tham số Team Color và lương v1): `Proposed → TestReady`. Cả hai scope đếm, ba ngưỡng, dải lương, scaling theo bậc và hành vi vượt cap đều có automated test và đổi được bằng dữ liệu fixture, không cần sửa code. `Approved` vẫn chờ P1-05b và balance review.
- `PCS-D01`/`PCS-D02` giữ `InValidation`: batch không thêm bằng chứng mô phỏng kinh tế hoặc playtest.

<a id="limitations"></a>

## 8. Giới hạn còn lại và batch kế tiếp

**Giới hạn:**

- Chưa chạy Unity Test Runner, chưa có PlayMode/console/device evidence; feature vẫn ở mức domain nên không đổi trạng thái gate Runtime integration.
- Team Color chỉ xuất `TeamColorBonusProfile`; match core chưa nhận modifier nào.
- Catalog fixture P1-02 chỉ có một `ProgramId` nên mọi item fixture rơi vào `SEASON_BASE`; trục mùa chỉ được test qua map và fallback, chưa qua dữ liệu nhiều mùa.
- Lương, cap, ngưỡng Team Color, tỷ lệ nâng cấp đều là `hypothesis`; không được dùng cho build công bố ra người chơi.
- `SquadDefinition` chưa gắn state `InSquad` của item và chưa có transaction lưu đội hình.

**Batch kế tiếp đề xuất — B2b (state đội hình) rồi B3 (nâng cấp bậc):**

| Mục | Nội dung |
| --- | --- |
| Phạm vi B2b | `SquadSaveService` commit đội hình và chuyển item `Available ↔ InSquad` trong cùng transaction inventory, dùng lại `IInventoryRepository.TryCommit` với idempotency key; item rời mọi slot mới về `Available` |
| Phạm vi B3 | `UpgradeTierAttemptPreview/Command/Receipt`, `IUpgradeRollSource` deterministic theo `(serverSeed, idempotencyKey, rulesVersion)`, ledger cân bằng cho vật liệu/bảo hiểm, `rollAuditHash` trong receipt |
| Phụ thuộc | B1/B2 đã xong; cần môi trường có Unity MCP để chạy `tests-run` trước khi commit |
| Rủi ro | RNG làm mất determinism ở test khác → giữ domain nhận `rollValue` làm input, adapter riêng cấp roll; vượt cap lương sau nâng cấp không được rollback nâng cấp |
| Acceptance | Retry cùng key trả cùng receipt và cùng outcome; item `Locked`/`InSquad` bị từ chối trước roll khi outcome là `Consume`; state item và squad revision nhất quán sau save; toàn bộ EditMode/PlayMode pass trong Unity |
| Vì sao đây là bước giá trị nhất | B2b khóa lại invariant state duy nhất còn hở của B2; B3 là cơ chế meta có rủi ro kinh tế cao nhất nên cần contract và test trước khi có UI/backend |
