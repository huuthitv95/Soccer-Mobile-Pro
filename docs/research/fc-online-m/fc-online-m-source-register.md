# Sổ nguồn và claim register FC Online M

> [Chỉ mục](../../index.md) · [Nghiên cứu](fc-online-m-research.md) · [Inventory](fc-online-m-feature-mechanic-inventory.md) · [Adoption](fc-online-m-adoption-decision-matrix.md)

## 0. Mục lục

- [1. Quy ước](#conventions)
- [2. Nguồn chính thức cần thu thập](#sources)
- [3. Claim register](#claims)
- [4. Coverage và khoảng trống](#coverage)
- [5. Quy trình cập nhật](#update-process)

<a id="conventions"></a>

## 1. Quy ước

Corpus khởi tạo ngày **11/09/2026** ở trạng thái **chưa xác minh**: chưa có nguồn nào được truy cập trong phiên lập tài liệu. Vì vậy bảng §2 là **danh sách slot nguồn cần thu thập**, không phải danh sách nguồn đã đọc; cột URL/ngày truy cập để trống cho đến P1-05b.

Nhãn dùng chung: **Thông tin công khai đã xác minh**, **Suy luận thiết kế**, **Đề xuất cho Soccer Mobile Pro**. Độ chắc chắn: `Cao` khi authority nói trực tiếp; `Trung bình` khi đúng trong một phiên bản/mùa nhưng có drift; `Thấp` cho suy luận hoặc chưa xác nhận. Không dùng nguồn cộng đồng làm baseline; nếu bổ sung, cần hai nguồn độc lập và không mâu thuẫn nguồn chính thức.

Không ghi endpoint, cấu trúc gói dữ liệu, thuật toán hay nội dung nội bộ của bên thứ ba. Không điền số cân bằng nếu nguồn không nêu.

<a id="sources"></a>

## 2. Nguồn chính thức cần thu thập

| ID | Loại nguồn | Kỳ vọng claim | URL | Ngày truy cập | Trạng thái |
| --- | --- | --- | --- | --- | --- |
| FOM-S01 | Trang chủ FC Online M của nhà phát hành VN | Giới thiệu mode, tính năng, dùng chung dữ liệu với PC | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S02 | Google Play listing | Mô tả tính năng, IAP/random item, data safety, rating tuổi | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S03 | App Store listing | Tương tự S02 cho iOS, kích thước app, IAP | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S04 | Trang hỗ trợ/FAQ nhà phát hành | Tài khoản, liên kết, khôi phục, mã quà tặng, hộp thư | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S05 | Thông báo cập nhật/patch notes gần nhất | Thay đổi mode, thẻ mùa mới, cân bằng | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S06 | Hướng dẫn nâng cấp thẻ chính thức | Rule thành công/thất bại, vật phẩm liên quan, tỷ lệ công bố | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S07 | Hướng dẫn Team Color và lương đội hình | Thuộc tính tính bonus, ngưỡng, cap và mở rộng | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S08 | Hướng dẫn chuyển nhượng | Dải giá, thuế, giới hạn, quy tắc niêm yết | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S09 | Trang công bố tỷ lệ Tuyển dụng | Odds theo gói, cách hiển thị | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S10 | Luật giải/esports chính thức | Eligibility, format, xử phạt, dispute | _chưa điển_ | _chưa_ | Chưa thu thập |
| FOM-S11 | Điều khoản dịch vụ và chính sách riêng tư | Cấm chia sẻ tài khoản, xử phạt, dữ liệu | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S12 | Hướng dẫn điều khiển mobile | Layout, tùy chỉnh, assist, camera | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S13 | Trang xếp hạng/mùa giải | Tên tier, reset, phần thưởng | _chưa điền_ | _chưa_ | Chưa thu thập |
| FOM-S14 | Trang Câu lạc bộ (guild) | Quy mô, vai trò, hoạt động, phần thưởng | _chưa điền_ | _chưa_ | Chưa thu thập |

<a id="claims"></a>

## 3. Claim register

Toàn bộ claim hiện ở mức `Thấp` và nhãn **Suy luận thiết kế**; cột nguồn trỏ tới slot cần xác minh.

| Claim ID | Claim | Nguồn kỳ vọng | Chắc chắn | Trạng thái |
| --- | --- | --- | --- | --- |
| FOMC-001 | FC Online M dùng chung tài khoản, đội hình, kho thẻ và BP với FC Online PC | FOM-S01, FOM-S04 | Thấp | Unverified |
| FOMC-002 | Có mode đấu xếp hạng 1v1 real-time trên mobile | FOM-S01, FOM-S02 | Thấp | Unverified |
| FOMC-003 | Có mode giao hữu với bạn bè | FOM-S01 | Thấp | Unverified |
| FOMC-004 | Có mode đấu với máy theo độ khó | FOM-S01 | Thấp | Unverified |
| FOMC-005 | Chế độ Quản lý (mô phỏng) có mặt trên mobile | FOM-S01, FOM-S05 | Thấp | Unverified, xem FOM-Q01 |
| FOMC-006 | Thẻ cầu thủ chia theo mùa với chỉ số/giá khác nhau | FOM-S05, FOM-S06 | Thấp | Unverified |
| FOMC-007 | Nâng cấp thẻ theo bậc +1…+10 với tỷ lệ thành công công bố | FOM-S06 | Thấp | Unverified, xem FOM-Q02 |
| FOMC-008 | Team Color cho bonus chỉ số theo tập cầu thủ cùng thuộc tính | FOM-S07 | Thấp | Unverified, xem FOM-Q04 |
| FOMC-009 | Đội hình bị ràng buộc bởi tổng lương | FOM-S07 | Thấp | Unverified, xem FOM-Q05 |
| FOMC-010 | Có huấn luyện cầu thủ bằng điểm/level | FOM-S06 | Thấp | Unverified |
| FOMC-011 | Chuyển nhượng giữa người chơi bằng BP có dải giá và thuế | FOM-S08 | Thấp | Unverified, xem FOM-Q03 |
| FOMC-012 | Tuyển dụng là random item có công bố tỷ lệ | FOM-S02, FOM-S09 | Thấp | Unverified, xem FOM-Q10 |
| FOMC-013 | Có cửa hàng tiền tệ premium và IAP | FOM-S02, FOM-S03 | Thấp | Unverified |
| FOMC-014 | Có Câu lạc bộ (guild) với chat và hoạt động chung | FOM-S14 | Thấp | Unverified, xem FOM-Q09 |
| FOMC-015 | Có hộp thư, mã quà tặng, sự kiện webview, điểm danh | FOM-S04 | Thấp | Unverified |
| FOMC-016 | Có nhiệm vụ ngày/tuần và thành tựu | FOM-S01 | Thấp | Unverified |
| FOMC-017 | Điều khiển mobile có tùy chỉnh layout và assist | FOM-S12 | Thấp | Unverified, xem FOM-Q06 |
| FOMC-018 | Xếp hạng có tier/mùa và phần thưởng cuối mùa | FOM-S13 | Thấp | Unverified, xem FOM-Q08 |
| FOMC-019 | Điều khoản cấm chia sẻ/mua bán tài khoản và có xử phạt | FOM-S11 | Thấp | Unverified |
| FOMC-020 | Có bình luận tiếng Việt trong trận | FOM-S01, FOM-S05 | Thấp | Unverified |

<a id="coverage"></a>

## 4. Coverage và khoảng trống

| Nhóm | Claim | Đã xác minh | Khoảng trống |
| --- | --- | ---: | --- |
| Tài khoản/nền tảng | 001, 019 | 0/2 | Provider, recovery, guest |
| Mode | 002–005 | 0/4 | Danh sách mode mobile chính thức |
| Thẻ/tiến trình | 006–010 | 0/5 | Rule nâng cấp, Team Color, lương |
| Kinh tế | 011–013 | 0/3 | Thuế/dải giá, odds |
| Xã hội/liveops | 014–016 | 0/3 | Guild, inbox, missions |
| Gameplay | 017, 020 | 0/2 | Controls, commentary |
| Ranked | 018 | 0/1 | Tier/mùa |

<a id="update-process"></a>

## 5. Quy trình cập nhật

1. Khi thu thập nguồn: điền URL, ngày truy cập, đổi trạng thái slot thành `Đã đọc`; thêm hàng mới nếu có nguồn ngoài danh sách.
2. Khi xác minh claim: đổi `Unverified` thành `Current`/`Versioned`/`Historical`/`NotPublic`, nâng độ chắc chắn tương ứng, ghi phiên bản/mùa.
3. Đồng bộ cùng change set với [inventory](fc-online-m-feature-mechanic-inventory.md), [nghiên cứu](fc-online-m-research.md#open-questions) và [TODO §5](../../../TODO.md#parity).
4. Không dẫn nguồn cho claim mà nguồn không nói; nếu nguồn mâu thuẫn, ghi cả hai và đánh `Trung bình` kèm drift note.
