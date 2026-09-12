# Soccer Mobile Pro — Wiki

> **Nguồn sự thật của wiki này là thư mục [`wiki/`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/tree/main/wiki) trên nhánh `main`.** Job CI `wiki:publish` đồng bộ sang GitLab Wiki; sửa trực tiếp trên giao diện Wiki sẽ bị ghi đè ở lần đồng bộ kế tiếp. Quyết định sản phẩm/kỹ thuật vẫn nằm trong [`docs/`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/index.md); wiki chỉ là lớp định hướng, không sao chép authority.

## Soccer Mobile Pro là gì

Game bóng đá mobile xây bằng **Unity 2022.3.62f3**, mục tiêu **100% parity tính năng và giao diện với FC Online M** (bản Việt Nam) làm mốc tối thiểu, sau đó vượt tham chiếu ở gameplay, UX, hiệu năng và live service. Checkout hiện tại gồm **match prototype legacy** (scene flow, joystick cảm ứng, AI heuristic) cộng **foundation mới** (Match Core deterministic, Input theo context, Platform contract, Catalog, Player Items, Competition) chạy sau feature flag.

## Ba nguyên tắc không thương lượng

1. **Server authority** cho kinh tế, tiến trình, mua hàng, ranked, anti-cheat, reward. Client chỉ preview và gửi command có idempotency key.
2. **Deterministic match core** là nền của gameplay, replay, VAR, AI, netcode. Không có logic luật trong presentation.
3. **Mọi item chỉ "xong" khi qua đủ 4 gate**: Contract → Runtime integration → Automated evidence → Device/Operations evidence. "Decision-complete" trong docs không thay thế code.

## Điều hướng

| Trang | Dành cho |
| --- | --- |
| [Bắt đầu nhanh](bat-dau-nhanh) | Người mới clone repo: mở project, chạy test, quy ước Git. |
| [Kiến trúc và assembly](kien-truc) | Bản đồ 13 assembly, luồng dữ liệu end-to-end, ranh giới legacy/foundation. |
| [Domain thẻ cầu thủ và đội hình](domain-the-cau-thu-va-doi-hinh) | Inventory, transaction, ledger, squad rules, Team Color, lương (P1-03/P1-06). |
| [Quy trình làm việc](quy-trinh-lam-viec) | 9 bước workflow, 4 gate, commit convention, Definition of Done, nhãn bằng chứng. |
| [Tiến độ và lộ trình](tien-do-va-lo-trinh) | Snapshot Phase P0–P9, milestone M1–M5, lô đang làm. |
| [Bản đồ tài liệu](ban-do-tai-lieu) | Đọc gì trước khi đụng vào từng hệ thống. |
| [FAQ và xử lý sự cố](faq) | Test Runner, fixture, Unity MCP reload, feature flag, Git LFS. |

## Trạng thái nhanh (12/09/2026)

- Tiến độ toàn dự án có trọng số ≈ **18%**; parity tính năng ≈ 13%; parity giao diện ≈ 6%.
- Đang chạy: **P1-06** (squad rules, Team Color, lương, nâng cấp bậc, huấn luyện) — lô B1, B2, B2b đã có code; lô kế tiếp là **B3 nâng cấp bậc**.
- Baseline test: 102 EditMode + 19 PlayMode pass (16/07/2026); test P1-06 (71 case) **chưa chạy Unity Test Runner** — xem [FAQ](faq).
- Chưa có CI compile/test/build (TODO P9-01); `.gitlab-ci.yml` hiện chỉ có job đồng bộ wiki.

Số liệu chi tiết và cách tính %: [`TODO.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/TODO.md).
