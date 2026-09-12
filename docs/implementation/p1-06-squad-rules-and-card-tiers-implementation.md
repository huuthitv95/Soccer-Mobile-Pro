# P1-06 — Nhật ký triển khai luật đội hình và bậc thẻ

## 1. Bối cảnh

Hạng mục P1-06 (`TODO.md`) yêu cầu nền tảng dữ liệu và luật cho: mùa thẻ, nâng bậc (upgrade tier),
huấn luyện (training), Team Color, quỹ lương và đội hình. Kế hoạch chi tiết nằm ở
`docs/implementation/p1-06-squad-rules-and-card-tiers-plan.md`, chia công việc thành 6 lô B1–B6.

Tài liệu này ghi lại **lô B1: hợp đồng (contract), rule set và fixture v1**.

## 2. Phạm vi lô B1

1. Mở rộng `OwnedPlayerItem` với 5 trục trạng thái mới: `UpgradeTier`, `TrainingLevel`,
   `TrainingPoints`, `SalaryOverride`, `SeasonId`.
2. Bổ sung mã lỗi giao dịch cho các luồng P1-06 (`FeatureDisabled` → `SquadNotFound`, 17–23).
3. Khai báo toàn bộ contract cho upgrade tier, training, Team Color, quỹ lương, đội hình và
   kho lưu đội hình (`ISquadRepository`).
4. Hiện thực các rule set cố định đọc từ fixture JSON v1, kèm bộ kiểm tra tính hợp lệ của fixture.
5. Nguồn roll xác định (deterministic) cho nâng bậc, có audit hash không lộ server seed.
6. Migration mặc định an toàn cho snapshot inventory cũ (N-1).
7. 19 test EditMode phủ các bất biến trên.

## 3. File thay đổi

| File | Trạng thái |
| --- | --- |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/PlayerItemContracts.cs` | Sửa |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/ProgressionRules.cs` | Sửa |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadRulesContracts.cs` | Mới |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadRuleSets.cs` | Mới |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadRulesMigration.cs` | Mới |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/Fixtures/SquadRulesFixture.json` | Mới |
| `Assets/SoccerMobilePro/Tests/EditMode/SquadRulesContractTests.cs` | Mới |

## 4. Quyết định thiết kế và sai khác so với kế hoạch

### 4.1 Biên lai nâng bậc dùng composition

Kế hoạch đề xuất `UpgradeTierAttemptReceipt : TransactionReceipt`. `TransactionReceipt` của P1-03 là
`sealed`, nên biên lai mới **chứa** một `TransactionReceipt` (thuộc tính `Transaction`) thay vì kế thừa.
Giữ `sealed` để không ai thêm trạng thái ngoài sổ kế toán.

### 4.2 Hash canonical mở rộng tương thích ngược

`ProgressionHash.CanonicalItem` nay nối thêm hậu tố `p106:<tier>:<level>:<points>:<salary>:<season>`.
Hậu tố **chỉ xuất hiện khi có trục khác mặc định**, nên chuỗi canonical của dữ liệu P1-03 không đổi và
mọi hash cũ giữ nguyên. Mục đích: `InventoryTransactionService.Execute` sao chép nguyên `preview.AfterItem`,
nếu các trục mới nằm ngoài hash thì client có thể sửa tier/lương mà không bị phát hiện.

### 4.3 Không đổi `InventoryCodec.CurrentSchemaVersion`

Các trục mới là additive-optional: snapshot thiếu trường sẽ nhận default an toàn. Vì vậy schema vẫn là 2.
Nâng lên 3 sẽ phá `Codec_RoundTripsUnknownFields` và `Codec_MigratesNMinusOneAndRejectsNMinusTwo`, trong khi
không thu được lợi ích gì cho B1. `SquadSchemaMigration.Inspect` / `ReadSnapshot` báo cáo số bản ghi
đã nhận default để kiểm toán khi cần.

### 4.4 Lớp phủ kinh tế thay vì sửa schema catalog

`FixtureSquadEconomyCatalog` suy ra club/league/nation từ `CatalogSnapshot` (registration + identity) và
lương từ dải lương theo `BaseOverall`, cộng các override trong fixture. Nhờ vậy B1 không phải sửa
`PlayerItemDefinition` và không phải sinh lại fixture catalog 35 KB.

### 4.5 Fixture là giả thuyết, không phải số liệu sản phẩm

`SquadRulesFixture.json` mang `claimStatus: "hypothesis"` và một `sourceNote` nói rõ đây là giá trị giả định
phục vụ kiểm thử contract, chưa đối chiếu sản phẩm thương mại; các câu hỏi mở vẫn là FOM-Q01…FOM-Q10.
Test khẳng định nhãn này để không ai vô tình coi fixture là dữ liệu đã kiểm chứng.

## 5. Cổng kiểm chứng chưa đạt

- **Chưa chạy test.** Môi trường thực hiện thay đổi này không có Unity Editor và không có trình biên dịch
  C# (`dotnet` / `mono` / `csc`), nên 19 test mới cùng nền 102 EditMode + 19 PlayMode **chưa được chạy**.
- Vì vậy P1-06 trong `TODO.md` vẫn giữ `[~]`; không cập nhật trạng thái trong lô này.
- Thay đổi được đưa qua nhánh và pull request thay vì đẩy trực tiếp lên `main`.

### Cách chạy kiểm chứng

1. Mở project bằng Unity `2022.3.62f3`.
2. `Window → General → Test Runner → EditMode → Run All` (nhóm mới:
   `SoccerMobilePro.MatchCore.Tests.SquadRulesContractTests`).
3. Chạy tiếp tab `PlayMode` để xác nhận nền 19 test không hồi quy.
4. Nếu `SquadRulesContractTests` báo không tìm thấy fixture, kiểm tra file
   `Assets/SoccerMobilePro/Runtime/PlayerItems/Fixtures/SquadRulesFixture.json` đã được import.

## 6. Lô tiếp theo (B2)

1. `ISalaryCalculator` và `ITeamColorCalculator` (đếm theo `StartingXI`, nhân hệ số lương theo tier).
2. `ISquadValidator`: kiểm tra slot, trùng thẻ, chủ sở hữu, trạng thái thẻ, đội trưởng, người thực hiện
   tình huống cố định, quỹ lương; phân biệt `IsValid` và `IsPlayable`; tôn trọng danh sách `allowInvalidSave`.
3. `ISquadRepository` bản in-memory và bản file, có kiểm tra `expectedRevision` như P1-03.
4. Test EditMode cho từng bất biến, kèm ca biên: vượt quỹ lương, thiếu ghế dự bị, sai vị trí.
