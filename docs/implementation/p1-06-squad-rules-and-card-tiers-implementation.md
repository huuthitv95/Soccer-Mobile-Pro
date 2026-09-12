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

---

# Lô B2 — Quỹ lương, Team Color, kiểm tra hợp lệ và kho lưu đội hình

## 7. Phạm vi lô B2

1. `FixedSalaryCalculator`: lương từng thẻ (dải lương theo `BaseOverall` → override fixture → override trên
   thẻ sở hữu → hệ số theo bậc nâng) và tổng quỹ lương theo phạm vi đếm của rule set, kèm trần lương.
2. `FixedTeamColorCalculator`: đếm liên kết theo từng trục được cấu hình, so ngưỡng và trả về hồ sơ thưởng.
3. `SquadValidator`: toàn bộ cổng kiểm tra đội hình, phân biệt `IsValid` (không có lỗi) và `IsPlayable`
   (được phép ra sân).
4. `SquadSavePolicy.CanSave`: cho phép lưu đội hình chưa hoàn chỉnh nếu mọi lỗi đều nằm trong
   `allowInvalidSave` của fixture.
5. `SquadCodec` + `SquadEnvelope`, `InMemorySquadStore`, `FileSquadStore` (ghi atomic, `.bak`, chế độ chỉ đọc).
6. `SquadSaveService`: đường ghi duy nhất — validate → `CanSave` → commit atomic kèm biên lai và sổ kế toán,
   có replay theo idempotency key.
7. 42 test EditMode mới trong ba nhóm: `SquadEconomyTests`, `SquadValidatorTests`, `SquadRepositoryTests`.

## 8. File thay đổi (B2)

| File | Trạng thái |
| --- | --- |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadCalculators.cs` | Mới |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadValidation.cs` | Mới |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadPersistence.cs` | Mới |
| `Assets/SoccerMobilePro/Runtime/PlayerItems/SquadSaveService.cs` | Mới |
| `Assets/SoccerMobilePro/Tests/EditMode/SquadRulesFixtures.cs` | Mới |
| `Assets/SoccerMobilePro/Tests/EditMode/SquadEconomyTests.cs` | Mới |
| `Assets/SoccerMobilePro/Tests/EditMode/SquadValidatorTests.cs` | Mới |
| `Assets/SoccerMobilePro/Tests/EditMode/SquadRepositoryTests.cs` | Mới |

Không sửa file nào của lô B1: B2 chỉ hiện thực các contract đã khai báo sẵn.

## 9. Quyết định thiết kế và sai khác so với kế hoạch (B2)

### 9.1 `PositionMismatch` và `ItemLocked` là cảnh báo, không phải lỗi

Kế hoạch xếp hai mã này chung nhóm kiểm tra. Trong hiện thực, cả hai chỉ tạo **cảnh báo**:

- Sai vị trí là lựa chọn chiến thuật hợp lệ (và `PlayerItemDefinition` hiện chưa có trường vị trí, nên chỉ
  đối chiếu được khi thẻ sở hữu có `PositionProficiencies`).
- Thẻ bị khoá là khoá **giao dịch** (chống bán/tiêu nhầm), không phải khoá sử dụng.

Nhờ vậy `allowInvalidSave` trong fixture vẫn đúng nghĩa: `PositionMismatch` nằm trong danh sách đó chỉ để
dự phòng khi sau này nâng nó lên thành lỗi.

### 9.2 `SquadCodec.BackwardSchemaWindow = 0`

Snapshot đội hình mới có v1 nên chưa tồn tại bản N-1 nào để đọc; mở cửa sổ tương thích ngay bây giờ chỉ tạo
nhánh code không ai kiểm chứng được. Codec từ chối mọi `schemaVersion` ngoài `[1, 1]` và test khẳng định điều
này, kèm ghi chú nâng lên 1 khi v2 xuất hiện.

### 9.3 Chưa chuyển trạng thái thẻ khi lưu đội hình

`SquadSaveService` **không** đổi `PlayerItemState` (`Available` ↔ `InSquad`) của các thẻ được xếp. Việc đó
chạm vào aggregate inventory và cần một giao dịch chung với `InventoryTransactionService` (hai kho, một biên
lai). Ghi nhận là nợ kỹ thuật của lô sau; hiện tại validator chỉ **đọc** trạng thái thẻ.

### 9.4 Chỉ envelope giữ được trường lạ

`[JsonExtensionData]` nằm ở `SquadEnvelope`. `SquadSnapshot` và `SquadDefinition` (khai báo ở B1) không có, nên
trường lạ ở cấp đội hình sẽ mất khi round-trip. Nếu B3+ cần forward-compatibility ở cấp đó thì phải bổ sung
vào chính hai lớp này.

### 9.5 Ánh xạ lỗi đội hình sang mã giao dịch

`SquadSaveService` trả về `TransactionFailureCode` để client dùng lại đúng luồng xử lý lỗi của P1-03:
`FeatureDisabled` → `FeatureDisabled`, `RulesVersionMismatch` → `StaleRules`, `OwnerMismatch` → `OwnerMismatch`,
`ItemNotFound` → `ItemNotFound`, `DuplicateItem` → `DuplicateItem`, `ItemUnavailable` → `InvalidState`,
`SalaryCapExceeded` → `SalaryCapExceeded`, `SquadSlotLimitExceeded` → `CapExceeded`, còn lại → `SquadInvalid`.

### 9.6 Làm tròn nửa lên bằng số nguyên

Hệ số lương theo bậc tính bằng `((base * (10000 + bp)) + 5000) / 10000` trên `long`, không dùng số thực, để
kết quả giống hệt nhau trên mọi nền tảng (điều kiện cần cho hash canonical và kiểm tra trần lương phía máy chủ).

### 9.7 Payload hash của lệnh lưu

`SquadCanonical.Value` sắp xếp assignment theo `PositionSlotId` và ghế dự bị theo id, nên thay đổi thứ tự
không đổi hash, còn đổi nội dung (đội trưởng, người sút, kit, sơ đồ, phiên bản luật…) thì đổi. `transactionId`
sinh từ `hash(idempotencyKey|payloadHash)` nên tái lập được khi cần đối soát.

## 10. Cổng kiểm chứng chưa đạt (B2)

- **Chưa chạy test.** Môi trường vẫn không có Unity Editor và không có trình biên dịch C#, nên 42 test mới
  của B2 **chưa được biên dịch và chưa được chạy**.
- P1-06 trong `TODO.md` vẫn giữ `[~]`.
- Nhánh B2 xếp chồng lên nhánh B1 (`feat/p1-06-b1-squad-rules-contracts`); cần merge B1 trước.

### Cách chạy kiểm chứng

1. Mở project bằng Unity `2022.3.62f3`.
2. `Window → General → Test Runner → EditMode → Run All`, chú ý ba nhóm mới:
   `SquadEconomyTests`, `SquadValidatorTests`, `SquadRepositoryTests`.
3. Chạy tiếp tab `PlayMode` để xác nhận nền test không hồi quy.
4. `SquadRepositoryTests` tạo thư mục tạm trong `Path.GetTempPath()/soccer-mobile-squads` và tự dọn ở
   `[TearDown]`; nếu test bị huỷ giữa chừng, xoá thư mục đó thủ công.

## 11. Lô tiếp theo (B3)

1. Dịch vụ nâng bậc: preview (tỉ lệ, chi phí, vật phẩm, bảo hiểm) + commit dùng `DeterministicUpgradeRollSource`.
2. Biên lai nâng bậc và bút toán tiêu hao vật phẩm/tiền tệ, tái sử dụng `SquadSaveService` làm khuôn mẫu chính sách.
3. Chuyển trạng thái thẻ giữa inventory và đội hình trong cùng một giao dịch (nợ kỹ thuật ở mục 9.3).
4. Test EditMode cho: roll xác định, replay biên lai, thất bại có/không bảo hiểm, tiêu hao vật phẩm.
