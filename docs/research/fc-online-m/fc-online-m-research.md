# Nghiên cứu FC Online M

> [Chỉ mục](../../index.md) · [Sổ nguồn](fc-online-m-source-register.md) · [Inventory](fc-online-m-feature-mechanic-inventory.md) · [Adoption](fc-online-m-adoption-decision-matrix.md) · [TODO](../../../TODO.md)

## 0. Mục lục

- [1. Mục tiêu và trạng thái bằng chứng](#goal)
- [2. Vị trí sản phẩm và mối quan hệ với FC Online PC](#positioning)
- [3. Bản đồ thuật ngữ](#terminology)
- [4. Khác biệt trọng yếu so với FC Mobile VN](#differences)
- [5. Cấu trúc tính năng cấp cao](#feature-map)
- [6. Câu hỏi nghiên cứu mở](#open-questions)
- [7. Quy trình xác minh P1-05b](#verification)

<a id="goal"></a>

## 1. Mục tiêu và trạng thái bằng chứng

Tài liệu này là authority nghiên cứu cho **tham chiếu mục tiêu FC Online M** theo [TODO](../../../TODO.md#goal). Nó bổ sung, không thay thế, [nghiên cứu FC Mobile VN](../fc-mobile-vn-research.md) và [eFootball Mobile](../efootball-mobile/efootball-mobile-research.md).

**Trạng thái bằng chứng tại 11/09/2026:** toàn bộ nội dung dưới đây là **Suy luận thiết kế** từ hiểu biết công khai chung về dòng game FC Online/FIFA Online 4 và bản mobile, **chưa có nguồn chính thức được truy cập và ghi ngày**. Không claim nào được dùng làm policy production cho đến khi [P1-05b](#verification) hoàn tất và [sổ nguồn](fc-online-m-source-register.md) có URL + ngày truy cập. Mọi số cân bằng (tỷ lệ, giá, cap, thuế, cooldown) được để trống theo quy ước corpus.

<a id="positioning"></a>

## 2. Vị trí sản phẩm và mối quan hệ với FC Online PC

| Nội dung | Suy luận thiết kế | Cần xác minh |
| --- | --- | --- |
| Nhà phát triển / phát hành VN | Nexon phát triển; phát hành tại Việt Nam bởi đối tác địa phương | Tên pháp nhân phát hành, store listing, tuổi rating |
| Mô hình | Ứng dụng mobile **dùng chung tài khoản và dữ liệu** với FC Online PC: đội hình, kho thẻ, BP, chuyển nhượng, tiến trình | Phạm vi đồng bộ thực tế và tính năng chỉ có trên PC |
| Vai trò | Vừa là client chơi trận đầy đủ trên mobile, vừa là companion để quản lý đội hình/kinh tế khi không ở PC | Danh sách mode có trên mobile so với PC |
| Đăng nhập | Qua tài khoản nhà phát hành; có thể liên kết nhà cung cấp khác | Provider list, guest mode, recovery |

**Hàm ý cho Soccer Mobile Pro:** mục tiêu parity không yêu cầu một client PC, nhưng yêu cầu **kiến trúc server-authoritative đủ mạnh để mở client thứ hai sau này** (web/PC companion). Điều này đã khớp với nguyên tắc server authority trong AGENTS.md và [account spec](../../systems/account-localization-and-settings.md).

<a id="terminology"></a>

## 3. Bản đồ thuật ngữ

| FC Online M (VN) | FC Mobile VN | Soccer Mobile Pro (canonical) | Ghi chú |
| --- | --- | --- | --- |
| Đội hình | Squad/Đội hình | `Squad` | Nhiều slot đội hình, đấu pháp gắn theo slot |
| Mùa thẻ (season/class) | Program/Event card | `CardSeason` | Ảnh hưởng chỉ số, giá, Team Color |
| Nâng cấp (+1…+10) | Rank up/Training | `CardUpgradeTier` | Có tỷ lệ thành công công bố; thất bại có thể hạ bậc hoặc giữ nguyên tùy rule, **cần xác minh** |
| Team Color / Màu đội | Chemistry | `TeamColor` | Bonus theo số cầu thủ cùng CLB/quốc gia/mùa |
| Lương đội hình | Không có tương ứng trực tiếp | `SquadSalaryCap` | Tổng lương cầu thủ trong đội hình không vượt cap |
| Huấn luyện | Training | `PlayerTraining` | Nguồn điểm, level, giới hạn cần xác minh |
| Chuyển nhượng | Market | `TransferMarket` | Giao dịch bằng BP, có dải giá và thuế **cần xác minh** |
| Tuyển dụng | Pack/Store | `RecruitPack` | Random item có công bố tỷ lệ |
| BP / tiền tệ premium | Coins/Gems | `SoftCurrency` / `PremiumCurrency` | Tên hiển thị do brand quyết định |
| Đấu xếp hạng | Head-to-Head / Division Rivals | `RankedMatch` | 1v1 real-time, tier theo mùa |
| Giao hữu | Friendly | `FriendlyMatch` | Bạn bè hoặc mã phòng |
| Chế độ Quản lý | Không có tương ứng trực tiếp | `ManagerMode` | Mô phỏng tự động có can thiệp chiến thuật, **cần xác minh có trên mobile** |
| Đấu pháp / HLV | Tactics / Manager | `Tactics` / `CoachCard` | Slider và preset |
| Câu lạc bộ (guild) | League | `Guild` | Tránh nhầm với `Club` bóng đá trong catalog |
| Hộp thư / Mã quà tặng | Inbox / Gift code | `Inbox` / `GiftCode` | Grant ledger server |

<a id="differences"></a>

## 4. Khác biệt trọng yếu so với FC Mobile VN

Các khác biệt này quyết định phần mở rộng domain ở [TODO P1-06](../../../TODO.md#phases). Tất cả là **Suy luận thiết kế**.

1. **Kinh tế thẻ theo mùa và nâng cấp bậc**: giá trị thẻ phụ thuộc mùa và bậc nâng cấp; thị trường người chơi định giá. FC Mobile VN nghiêng về OVR/Rank up và market kiểm soát chặt hơn.
2. **Lương đội hình**: ràng buộc xây đội hình độc lập với Team Color; cần rule set version, item mở rộng cap và cảnh báo vượt cap trong squad editor.
3. **Team Color** thay cho chemistry theo link vị trí: bonus tính theo tập cầu thủ cùng thuộc tính, dễ preview và giải thích hơn.
4. **Dùng chung dữ liệu với PC**: đòi hỏi mọi thao tác meta đều đi qua server và có audit; không có state chỉ tồn tại trên client.
5. **Chế độ Quản lý** (mô phỏng) là mode có giá trị retention cao ngoài trận real-time; nếu xác minh có trên mobile thì nằm trong parity, nếu chỉ trên PC thì đưa sang P8 như lợi thế vượt tham chiếu.
6. **Chuyển nhượng người chơi với người chơi** với dải giá/thuế: cần thiết kế chống thao túng, rửa BP và multi-account từ đầu.

<a id="feature-map"></a>

## 5. Cấu trúc tính năng cấp cao

```text
Đăng nhập/Chọn server
  → Tải tài nguyên → Home (đội hình 3D, banner, thông báo, điểm danh)
      ├─ Thi đấu: Xếp hạng · Giao hữu · Đấu máy · Quản lý(?) · Giải/Sự kiện
      ├─ Đội hình: Formation · Đấu pháp/HLV · Team Color · Lương · Kit/Sân/Bóng
      ├─ Cầu thủ: Kho thẻ · Chi tiết/So sánh · Nâng cấp · Huấn luyện · Đổi vị trí
      ├─ Kinh tế: Chuyển nhượng · Tuyển dụng · Cửa hàng · Bộ sưu tập/Đổi thưởng
      ├─ Tiến trình: Nhiệm vụ · Thành tựu · Pass · Điểm danh
      ├─ Xã hội: Bạn bè · Hồ sơ/Lịch sử · Câu lạc bộ (guild) · Chat · Báo cáo
      └─ Hệ thống: Hộp thư · Mã quà tặng · Sự kiện webview · Cài đặt
```

Chi tiết từng cơ chế nằm trong [inventory](fc-online-m-feature-mechanic-inventory.md); quyết định áp dụng nằm trong [adoption matrix](fc-online-m-adoption-decision-matrix.md).

<a id="open-questions"></a>

## 6. Câu hỏi nghiên cứu mở

| ID | Câu hỏi | Ảnh hưởng | Owner |
| --- | --- | --- | --- |
| FOM-Q01 | Mode nào thực sự có trên mobile (đặc biệt Quản lý, giải đấu, sự kiện mini game)? | Ranh giới parity P5-08 | Research |
| FOM-Q02 | Rule nâng cấp thất bại: giữ nguyên, hạ bậc hay mất thẻ? Có vật phẩm bảo hiểm? | Domain P1-06, compliance | Research + Economy |
| FOM-Q03 | Cấu trúc thuế/dải giá chuyển nhượng và giới hạn giao dịch theo ngày | Anti-abuse P5-06 | Research + Economy |
| FOM-Q04 | Team Color: thuộc tính nào được tính, ngưỡng và bonus | Domain P1-06 | Research |
| FOM-Q05 | Lương: cap mặc định, cách mở rộng, áp dụng cho dự bị hay chỉ đội chính | Domain P1-06 | Research |
| FOM-Q06 | Điều khiển mobile: layout mặc định, tùy chỉnh, assist, camera | P0-02b, P3-04 | Research + Gameplay |
| FOM-Q07 | Netcode PvP: dấu hiệu công khai về host/relay, reconnect, xử phạt thoát trận | P4-04 | Research + Backend |
| FOM-Q08 | Ranked tier/mùa: tên bậc, reset, phần thưởng, decay | P4-05 | Research |
| FOM-Q09 | Guild (Câu lạc bộ): quy mô, vai trò, hoạt động, phần thưởng | P5-09 | Research |
| FOM-Q10 | Công bố tỷ lệ Tuyển dụng và quy định tuổi/pháp lý VN áp dụng | P5-07 compliance | Research + Legal |

<a id="verification"></a>

## 7. Quy trình xác minh P1-05b

1. Thu thập nguồn chính thức theo thứ tự ưu tiên trong [sổ nguồn §2](fc-online-m-source-register.md#sources): trang chủ/hỗ trợ nhà phát hành VN, Google Play/App Store listing, thông báo cập nhật, luật giải chính thức, trang công bố tỷ lệ.
2. Với mỗi nguồn: ghi URL, ngày truy cập, phiên bản/mùa, claim chính và giới hạn.
3. Nâng claim từ `Thấp` lên `Trung bình/Cao` chỉ khi nguồn chính thức nói trực tiếp; cập nhật cột trạng thái trong inventory từ `Unverified` sang `Current/Versioned/NotPublic`.
4. Cập nhật cùng change set: [GDD](../../product/gdd-soccer-mobile-pro.md), [coverage audit](../fc-mobile-vn-coverage-audit.md), [UI catalogue](../../product/ui-design-system-and-screen-catalogue.md) (bổ sung SC-16…SC-18), [TODO §5](../../../TODO.md#parity).
5. Chỉ dùng nguồn công khai; không truy cập API riêng, không trích xuất asset hay client tham chiếu.
