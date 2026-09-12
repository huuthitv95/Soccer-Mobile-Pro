# Ma trận áp dụng cơ chế FC Online M

> [Chỉ mục](../../index.md) · [Nghiên cứu](fc-online-m-research.md) · [Inventory](fc-online-m-feature-mechanic-inventory.md) · [Sổ nguồn](fc-online-m-source-register.md) · [TODO](../../../TODO.md)

## 0. Mục lục

- [1. Quy tắc quyết định](#decision-rules)
- [2. Account và shell](#shell-decisions)
- [3. Thẻ, đội hình và tiến trình](#card-decisions)
- [4. Kinh tế](#economy-decisions)
- [5. Mode, gameplay và xã hội](#mode-decisions)
- [6. Decision register](#open-decisions)

<a id="decision-rules"></a>

## 1. Quy tắc quyết định

- `Adopt`: giữ intent và mechanic; đưa vào contract foundation với control của Soccer Mobile Pro.
- `Adapt`: giữ intent nhưng đổi mechanic/control vì fairness, UX, compliance hoặc kiến trúc.
- `Experiment`: chỉ prototype/simulation; chưa là policy production.
- `Reject`: không phù hợp nguyên tắc sản phẩm hoặc rủi ro vượt lợi ích.

Mục tiêu parity 100% nghĩa là **mọi tính năng đều có tương ứng chức năng**; `Adapt` vẫn được tính parity nếu người chơi đạt cùng mục đích. Không sao chép giá, odds, cap, thuế, cadence hay formula; mọi tham số do Economy/Product của Soccer Mobile Pro quyết định và có version. Vì inventory hiện `Unverified`, các quyết định dưới đây ở trạng thái `Proposed` và phải rà lại sau P1-05b.

<a id="shell-decisions"></a>

## 2. Account và shell

| Mechanic | Intent | Tác dụng phụ | Hiện trạng Soccer | Quyết định + control |
| --- | --- | --- | --- | --- |
| Đăng nhập nhà phát hành + chọn server | Danh tính ổn định, dùng chung dữ liệu | Khóa vào provider, không có guest | P0-03 contract, fake adapter | `Adapt`: guest-first + link provider; region config server, không chọn server thủ công trừ khi cần |
| Tải tài nguyên ban đầu có gate | Cài nhỏ, tải theo nhu cầu | Dung lượng/thời gian chờ | Addressables local groups | `Adopt`: SC-03 với determinate progress, resume, checksum |
| Home đội hình 3D + banner | Showcase, discover | FOMO, tải nặng | Chưa có shell | `Adapt`: một CTA chính, slot budget, model LOD theo tier |
| Điểm danh hàng ngày | Retention | Áp lực đăng nhập | Chưa có | `Adopt`: không phạt bỏ lỡ, server time |
| Cài đặt đầy đủ nhiều nhóm | Kiểm soát trải nghiệm | Phức tạp | P1-01 registry + panel | `Adopt`: mở rộng theo schema có migration |

<a id="card-decisions"></a>

## 3. Thẻ, đội hình và tiến trình

| Mechanic | Intent | Tác dụng phụ | Hiện trạng Soccer | Quyết định + control |
| --- | --- | --- | --- | --- |
| Thẻ theo mùa | Nội dung mới liên tục, sưu tầm | Power creep, lạm phát | P1-02 catalog có version | `Adopt`: `CardSeason` trong catalog, rights version theo mùa |
| Nâng cấp +1…+10 có tỷ lệ | Tiến trình dài hạn, giá trị thẻ | Regret khi thất bại, cờ bạc hóa | P1-03 preview/receipt deterministic | `Adapt`: tỷ lệ công bố trong UI, preview rõ kết quả thất bại, tùy chọn bảo hiểm không ép mua, log audit; rule thất bại chờ FOM-Q02 |
| Huấn luyện | Tiến trình không ngẫu nhiên | Grind | Chưa runtime | `Adopt`: nguồn điểm rõ, cap theo version |
| Đổi vị trí | Linh hoạt đội hình | Meta lệch | P1-03 position choice | `Adopt` |
| Team Color | Bonus dễ hiểu, khuyến khích sưu tầm theo CLB/quốc gia | Ép mua theo bộ | Chưa có | `Adopt`: rule set version, preview text không chỉ màu (accessibility) |
| Lương đội hình | Ràng buộc chiến thuật, chống stack | Trần cứng gây frustration | Chưa có | `Adapt`: cap version hóa, mở rộng qua tiến trình không chỉ mua; áp dụng dự bị chờ FOM-Q05 |
| Đấu pháp/HLV card | Biểu đạt chiến thuật | Thêm một lớp gacha | Chưa có | `Adapt`: HLV là tiến trình/unlock, không random pack ở giai đoạn đầu |
| Nhiều slot đội hình, kit/sân/bóng | Tiện dụng, cá nhân hóa | Bán slot | Chưa có | `Adopt`: số slot cơ bản miễn phí đủ dùng |
| Bộ sưu tập/đổi thưởng | Sink thẻ thừa | Nộp nhầm | P1-03 fusion atomic | `Adopt`: xác nhận hai bước, khóa thẻ được tôn trọng |

<a id="economy-decisions"></a>

## 4. Kinh tế

| Mechanic | Intent | Tác dụng phụ | Hiện trạng Soccer | Quyết định + control |
| --- | --- | --- | --- | --- |
| Chuyển nhượng người chơi với người chơi | Thị trường sống, giá trị thẻ | Rửa BP, bot, multi-account, thao túng | Chưa có | `Adapt`: dải giá động server, thuế version, giới hạn/ngày, cooldown thẻ mới, phát hiện bất thường (P4-07); mở sau anti-abuse |
| Lịch sử giá công khai | Minh bạch | Tải dữ liệu | Chưa có | `Adopt` (cũng là P8-06) |
| Tuyển dụng pack có odds | Doanh thu, bất ngờ | P2W, compliance, trẻ vị thành niên | Bị gate theo AGENTS.md | `Experiment` → chỉ production sau odds công bố, age/privacy review, entitlement reconciliation, quyết định compliance ghi văn bản |
| Cửa hàng/IAP premium | Doanh thu | Refund/fraud | Chưa có | `Adopt`: receipt reconcile server, pending state |
| BP là tiền mềm kiếm bằng chơi | F2P progression | Lạm phát | Ledger foundation | `Adopt`: nguồn/sink có telemetry, cap mềm |

<a id="mode-decisions"></a>

## 5. Mode, gameplay và xã hội

| Mechanic | Intent | Tác dụng phụ | Hiện trạng Soccer | Quyết định + control |
| --- | --- | --- | --- | --- |
| Xếp hạng 1v1 real-time + tier mùa | Cạnh tranh cốt lõi | Netcode, toxic, smurf | P1-04 foundation offline | `Adopt`: server authority, reconnect ≤ 60 s, forfeit policy công bố |
| Giao hữu bạn bè/mã phòng | Xã hội | Lạm dụng để farm | Chưa có | `Adopt`: không thưởng ranked |
| Đấu với máy theo độ khó | Học chơi, offline | AI cheat gây frustration | Heuristic AI | `Adopt` + P3-06: khó không cheat physics |
| Chế độ Quản lý | Retention nhẹ, chơi nhanh | Mô phỏng phải công bằng | Chưa có | `Adopt` nếu FOM-Q01 xác nhận có trên mobile; nếu không, `Experiment` trong P8 |
| Giải đấu/Cup | Sự kiện cạnh tranh | Dispute | P1-04 bracket foundation | `Adopt` |
| Sự kiện/mini game | Đa dạng | Nội dung tạm | Chưa có | `Adapt`: dựa trên match core, không mini game rời rạc giai đoạn đầu |
| Điều khiển tùy chỉnh, assist, camera | Accessibility | Ưu thế cạnh tranh từ assist | P0-02 profile | `Adopt`: assist công bố, ranked policy rõ |
| Bình luận tiếng Việt | Bản địa hóa | Dung lượng | Chưa có | `Adopt`: tải theo nhu cầu, caption |
| Replay/highlight/VAR | Trình bày | Lệch với luật | Spec có | `Adopt`: presentation-only trên deterministic log |
| Câu lạc bộ (guild), chat | Cộng đồng | Moderation | Chưa có | `Adapt`: chat có filter/report, vai trò tối giản giai đoạn đầu |
| Bạn bè/hồ sơ/lịch sử | Xã hội | Privacy | Chưa có | `Adopt`: privacy default an toàn |
| Nhiệm vụ/thành tựu/Pass | Tiến trình | FOMO | Chưa có | `Adapt`: Pass không mất tiến độ đã mở, copy không FOMO |
| Hộp thư/mã quà/membership | LiveOps | Lạm dụng mã | Spec có | `Adopt`: grant ledger idempotent |

<a id="open-decisions"></a>

## 6. Decision register

| ID | Quyết định | Owner | Gate | Trạng thái |
| --- | --- | --- | --- | --- |
| FOM-D01 | Rule thất bại khi nâng cấp thẻ (giữ/hạ/mất) và bảo hiểm | Economy + Product | FOM-Q02 xác minh; mô phỏng kinh tế | `Proposed` (fixture P1-06 đã mô tả và test cả ba outcome; chờ transaction B3) |
| FOM-D02 | Tham số Team Color và lương đội hình phiên bản 1 | Product + Gameplay | FOM-Q04/Q05; scenario balance | `Proposed` (P1-06 B1–B2 đã thêm rule set fixture versioned và test, chờ Unity runner/balance trước khi nâng lifecycle) |
| FOM-D03 | Mở chuyển nhượng P2P chỉ sau anti-abuse tối thiểu | Economy + Integrity | P4-07 signal, rate limit, audit | `Proposed` |
| FOM-D04 | Tuyển dụng pack production | Product + Legal | Odds, age/privacy, reconciliation, compliance | `Proposed` |
| FOM-D05 | Chế độ Quản lý thuộc parity hay P8 | Product | FOM-Q01 | `Proposed` |
| FOM-D06 | Mô hình netcode ranked (server-authoritative vs lockstep) | Backend + Gameplay | Prototype packet-loss test | `Proposed` |
