# TODO — Kế hoạch đưa Soccer Mobile Pro đạt 100% tính năng và giao diện FC Online M, sau đó vượt lên

> [Chỉ mục tài liệu](docs/index.md) · [GDD](docs/product/gdd-soccer-mobile-pro.md) · [Audit Unity](docs/implementation/unity-implementation-audit-and-backlog.md) · [Coverage audit](docs/research/fc-mobile-vn-coverage-audit.md) · [UI catalogue](docs/product/ui-design-system-and-screen-catalogue.md)

**Mốc lập kế hoạch:** 11/09/2026 · **Cập nhật tiến độ:** 11/09/2026 (P1-05a) · **Baseline code:** `965f398b` (main) · **Unity:** 2022.3.62f3 · **Chủ sở hữu file:** Product + Tech Lead

## 0. Mục lục

- [1. Mục tiêu, phạm vi và nguyên tắc](#goal)
- [2. Bảng tiến độ tổng thể](#dashboard)
- [3. Cách tính % tiến độ](#method)
- [4. Chi tiết theo Phase](#phases)
- [5. Ma trận parity tính năng FC Online M](#parity)
- [6. Ma trận parity giao diện (screen)](#ui-parity)
- [7. Lộ trình milestone](#milestones)
- [8. Rủi ro chính và biện pháp](#risks)
- [9. Quy tắc cập nhật file này](#update-rules)

<a id="goal"></a>

## 1. Mục tiêu, phạm vi và nguyên tắc

**Mục tiêu:** Soccer Mobile Pro đạt **100% parity tính năng và giao diện** với FC Online M (bản Việt Nam) làm mốc tối thiểu, sau đó **phát triển và tối ưu vượt tham chiếu** ở gameplay, UX, hiệu năng, live service và hỗ trợ cộng đồng.

**Giả định bản quyền (do chủ dự án xác nhận):** dự án đã có đầy đủ quyền sử dụng cầu thủ, câu lạc bộ, giải đấu, hình ảnh, âm thanh. Kế hoạch coi đây là **đầu vào dữ liệu và asset chính hãng được cấp qua đối tác bản quyền**, không phải trích xuất từ client game khác.

**Nguyên tắc bắt buộc:**

1. **Parity tính năng, không sao chép nguyên bản.** UI/UX, code, shader, asset và text do Soccer Mobile Pro tự thiết kế theo [design system](docs/product/ui-design-system-and-screen-catalogue.md); tham chiếu chỉ để xác định *chức năng, luồng và trạng thái* cần có.
2. **Server authority** cho kinh tế, tiến trình, mua hàng, ranked, anti-cheat và reward (theo AGENTS.md).
3. **Deterministic match core** là nền của gameplay, replay, VAR, AI và netcode; không tồn tại logic luật nằm trong presentation.
4. **Mọi item chỉ được đánh dấu xong khi qua đủ 4 gate** (xem mục 3). Trạng thái "decision-complete" trong docs không thay thế code.
5. Ghi rõ nhãn nghiên cứu: **Thông tin công khai đã xác minh / Suy luận thiết kế / Đề xuất cho Soccer Mobile Pro**. Danh mục tính năng FC Online M ở mục 5 là **Suy luận thiết kế** từ quan sát công khai, cần đối chiếu lại với bản build hiện hành của tham chiếu mỗi mùa.

**Lưu ý thuật ngữ:** tài liệu `docs/research/` hiện lấy mốc **FC Mobile VN** (EA/Garena). Tham chiếu mục tiêu của file này là **FC Online M** (Nexon, phát hành VN). Hai game có tập tính năng tương tự nhưng khác ở: cơ chế nâng cấp +1…+10, Team Color, lương đội hình, Chuyển nhượng BP, chế độ Quản lý và cấu trúc mùa thẻ. Phase 1 có task cập nhật research để khóa lại tham chiếu.

<a id="dashboard"></a>

## 2. Bảng tiến độ tổng thể

**Tiến độ toàn dự án (có trọng số): ≈ 17%** · Parity tính năng FC Online M: **≈ 12%** · Parity giao diện: **≈ 6%**

| Phase | Tên | Trọng số | % hoàn thành | Trạng thái | Phụ thuộc |
| --- | --- | ---: | ---: | --- | --- |
| P0 | Foundation kỹ thuật (Match Core, Input, Platform contract) | 10% | 70% | Đang chạy, runtime integration chưa bật mặc định | — |
| P1 | Meta foundation (Localization, Catalog, Player Items, Competition) và khóa tham chiếu FC Online M | 10% | 56% | Đang chạy, fake/file authority; khung research FC Online M xong, chưa xác minh nguồn | P0 |
| P2 | Product shell và toàn bộ màn hình meta (SC-01…SC-12, SC-15) | 15% | 5% | Chưa bắt đầu ở mức production | P1 |
| P3 | Match gameplay production (animation, physics, HUD, camera, AI, VAR, replay) | 15% | 15% | Prototype legacy | P0 |
| P4 | Backend và live service (account, economy, market, competition, telemetry, CMS) | 15% | 3% | Chỉ có contract/fake adapter | P0, P1 |
| P5 | Hệ thống meta FC Online M (Squad/Team Color, Nâng cấp, Huấn luyện, Chuyển nhượng, Tuyển dụng, Ranked, Quản lý, CLB) | 15% | 10% | Domain foundation, chưa có UI/backend | P2, P4 |
| P6 | Content pipeline bản quyền (dữ liệu cầu thủ/CLB/giải, model 3D, kit, sân, âm thanh, bình luận) | 8% | 5% | Fixture hư cấu, chưa nhập data thật | P1 |
| P7 | LiveOps, monetization, membership, inbox, gift code, sự kiện | 5% | 0% | Spec xong, code chưa có | P4, P5 |
| P8 | Phát triển vượt tham chiếu (tính năng và UX mới) | 4% | 0% | Ý tưởng | P5, P7 |
| P9 | Chất lượng, hiệu năng, bảo mật, release và vận hành | 3% | 5% | Test runner ổn, chưa có CI/device farm | Xuyên suốt |

<a id="method"></a>

## 3. Cách tính % tiến độ

- Mỗi work item được chấm theo **4 gate**, mỗi gate 25%: **Contract** (spec/domain/API rõ) → **Runtime integration** (chạy trong scene/build thật, flag bật mặc định) → **Automated evidence** (EditMode/PlayMode/contract test pass) → **Device/Operations evidence** (Android/iOS device matrix, backend staging, rehearsal rollback).
- % Phase = trung bình có trọng số của work item trong Phase. % toàn dự án = Σ (trọng số Phase × % Phase).
- % parity tính năng = số dòng ở mục 5 đạt trạng thái `Đạt` / tổng số dòng; `Một phần` tính 0.5.
- Không làm tròn lên. Không đánh dấu `[x]` khi còn gate chưa đạt; dùng `[~]` cho đang làm.
- Số liệu baseline lấy từ [audit Unity 16/07/2026](docs/implementation/unity-implementation-audit-and-backlog.md): 121 script, 14 scene, 19 prefab, 13 asmdef, 102 EditMode + 19 PlayMode test pass.

<a id="phases"></a>

## 4. Chi tiết theo Phase

### P0 — Foundation kỹ thuật · 70%

**Mục tiêu:** Match Core deterministic, input theo context và platform contract trở thành **runtime mặc định**, không còn là shadow adapter sau feature flag.

- [x] P0-01 Match Core: phase/command/snapshot/event/hash, shadow adapter, EditMode/PlayMode test.
- [~] P0-01b Match Core điều khiển physics, HUD, result thay legacy `InitGame`/`GameManager` (bật flag mặc định, xóa state phân tán).
- [x] P0-02 Input Actions 5 map (`Match_OnBall`, `Match_OffBall`, `SetPiece`, `Goalkeeper`, `UI`), 3 scheme, remap/left-handed profile.
- [~] P0-02b Thay `SoccerInput`/joystick legacy bằng HUD touch production, controller reconnect, focus loss.
- [x] P0-03 Account/session/catalog contract, fake/offline adapter, contract test.
- [ ] P0-04 Tách toàn bộ legacy khỏi assembly mặc định; xóa `GameObject.Find`, scene-name string, static flag; scene registry typed.
- [ ] P0-05 Android/iOS build pipeline chạy hết bước APK/IPA; smoke test tự động trên device.

**Acceptance:** Quick Match và Cup chạy hoàn toàn trên Match Core; replay cùng seed cho cùng hash; input production trên touch/gamepad/keyboard; console không lỗi; APK smoke pass.

### P1 — Meta foundation và khóa tham chiếu · 56%

- [x] P1-01 Localization `vi-VN`/`en`, typed settings registry, migration N/N-1, panel Settings trong MainMenu.
- [x] P1-02 Football catalog entity, ID/FK validator, snapshot/delta, atomic store, local Addressables model resolver, generic fallback.
- [x] P1-03 Player item domain: card instance, inventory, preview/receipt, skill/position/fusion, ledger atomic, rollback.
- [x] P1-04 Competition foundation: rules version, Single Elimination/Round Robin, roster lock, reconnect, dispute.
- [x] P1-05a **Khung research FC Online M**: đã tạo [`docs/research/fc-online-m/`](docs/research/fc-online-m/fc-online-m-research.md) gồm research, sổ nguồn (14 slot), inventory 49 mechanic FOM-* ánh xạ đủ 40 dòng mục 5, adoption matrix và 6 decision `Proposed`. Toàn bộ claim ở mức `Unverified`.
- [ ] P1-05b **Xác minh nguồn FC Online M**: điền URL/ngày truy cập cho 14 slot, nâng claim/status, trả lời FOM-Q01…Q10, cập nhật GDD, coverage audit, UI catalogue (SC-16…SC-18) và mục 5/6 file này trong cùng change set.
- [ ] P1-06 Mở rộng domain theo FC Online M: Team Color/chemistry, lương đội hình (salary cap), nâng cấp +1…+10 với tỷ lệ công bố, huấn luyện (training points), mùa thẻ (season/class), HLV/chiến thuật.
- [ ] P1-07 Nối fixture catalog/inventory vào scene chọn đội và trận đấu (thay texture/team name gắn Inspector).
- [ ] P1-08 Localize toàn bộ legacy UI; brand font vi/en qua contrast test (UI-D01).

### P2 — Product shell và màn hình meta · 5%

**Mục tiêu:** dựng app shell (top bar, navigation, modal, toast, skeleton, webview handoff) và **toàn bộ 15 screen** trong [UI catalogue](docs/product/ui-design-system-and-screen-catalogue.md#screens) với đủ state loading/empty/error/offline, safe area, text scale 100–200%, aspect 16:9–22:9.

- [ ] P2-01 UI framework: UI Toolkit hoặc uGUI + MVVM, navigation stack, route/deep-link, design tokens ScriptableObject, theme/high-contrast.
- [ ] P2-02 Shell component: Primary button, Player/reward card, Top resource bar, Tab/rail, Modal, Toast, Skeleton, Webview handoff.
- [ ] P2-03 SC-01 Bootstrap/locale, SC-02 Account/provider, SC-03 Core asset gate.
- [ ] P2-04 SC-04 Home (3D showcase đội hình, banner slot remote, quick menu, thông báo, check-in).
- [ ] P2-05 SC-05 Profile/friends, SC-06 Settings đầy đủ (đồ họa, điều khiển, âm thanh, bình luận, tài khoản, thông báo).
- [ ] P2-06 SC-07 Club/squad editor, SC-08 Player inventory/detail/so sánh, SC-09 Upgrade/Training.
- [ ] P2-07 SC-10 Market/exchange, SC-11 Event/missions/pass, SC-12 Mode/tournament lobby.
- [ ] P2-08 SC-15 Result/report, Inbox, Shop, Gift code, Collection.
- [ ] P2-09 Screenshot baseline + accessibility audit trên QA matrix (locale, text scale, aspect, notch, tier).

### P3 — Match gameplay production · 15%

- [~] P3-01 Match rules đầy đủ: offside, ném biên, phạt góc, phạt đền, thẻ, thay người, hiệp phụ, luân lưu, bù giờ.
- [ ] P3-02 Animation: Animator/graph thay legacy `Animation`; gameplay-event sync; motion set chuyền/sút/tắc bóng/rê/ăn mừng/GK; skill moves.
- [ ] P3-03 Ball physics chuẩn: xoáy, nảy, ma sát, thời tiết; ngân sách 60 fps tier mid.
- [ ] P3-04 HUD production: joystick, nút context, radar, scoreboard, chỉ báo cầu thủ, gợi ý chuyền, latency indicator, quick tactics, pause/sub.
- [ ] P3-05 Camera Cinemachine: broadcast, tele, dynamic, replay, VAR, celebration; thiết lập theo người dùng.
- [ ] P3-06 AI offline P2-02: perception, team shape, role assignment, utility decision, pressing/marking, difficulty không cheat; scenario suite.
- [ ] P3-07 VAR P2-01: incident record, deterministic decision, timeline presentation, skip/fail-safe.
- [ ] P3-08 Replay/highlight: ghi event log, xem lại sau trận, chia sẻ clip.
- [ ] P3-09 Bình luận tiếng Việt, âm thanh sân, nhạc; audio mixer và accessibility (caption).
- [ ] P3-10 Sân vận động, thời tiết, ngày/đêm, kit clash rule, bóng thi đấu.

### P4 — Backend và live service · 3%

- [ ] P4-01 Kiến trúc backend: dịch vụ Account/Identity, Catalog/CMS, Inventory/Economy ledger, Market, Competition/Matchmaking, Telemetry, Inbox/Grant; môi trường dev/staging/prod; API versioning.
- [ ] P4-02 Account: đăng nhập nhà phát hành/Google/Apple/guest, link/recovery/xóa tài khoản, consent, secure storage.
- [ ] P4-03 Economy ledger idempotent, receipt, audit log, compensating transaction; entitlement reconciliation với store.
- [ ] P4-04 Real-time PvP netcode: server-authoritative hoặc deterministic lockstep + rollback, relay theo khu vực, reconnect ≤ 60 s, forfeit policy.
- [ ] P4-05 Matchmaking/Ranked: rating, tier/division, season rollover, decay, phần thưởng server-side.
- [ ] P4-06 Telemetry/observability P2-03: schema registry, consent, offline queue, dashboards, kill switch, remote config ký số.
- [ ] P4-07 Anti-cheat và integrity: signal, report, sanction, appeal, correlation ID (theo [integrity spec](docs/systems/competitive-integrity-and-esports.md)).
- [ ] P4-08 CMS/live config: catalog publish, event schedule, banner slot, maintenance/update-required gate.

### P5 — Hệ thống meta FC Online M · 10%

- [~] P5-01 Thẻ cầu thủ: mùa thẻ, OVR/chỉ số, đặc tính, skill moves, vị trí phụ, giá trị; projection từ catalog + inventory.
- [ ] P5-02 Đội hình: formation editor, vai trò, chiến thuật (slider tấn công/phòng ngự, pressing, chiều rộng), người đá phạt, đội trưởng, nhiều slot đội hình, kit/sân/bóng.
- [ ] P5-03 Team Color/chemistry và lương đội hình: rule set version, preview, cảnh báo vượt lương.
- [ ] P5-04 Nâng cấp thẻ +1…+10: tỷ lệ công bố, vật liệu, bảo hiểm/khóa, lịch sử; server preview và receipt.
- [ ] P5-05 Huấn luyện: training points, level, nguồn điểm, giới hạn.
- [ ] P5-06 Chuyển nhượng (BP market): niêm yết, mua/bán, dải giá, thuế, lịch sử giá, bộ lọc, chống thao túng.
- [ ] P5-07 Tuyển dụng (pack): odds công bố, pity/ceiling nếu có, xác nhận tuổi/privacy, đối soát entitlement (theo AGENTS.md compliance).
- [ ] P5-08 Chế độ chơi: Ranked 1v1 real-time, Giao hữu (bạn bè/mã phòng), Đấu AI theo độ khó, Quản lý (mô phỏng có can thiệp chiến thuật), Tournament/Cup, sự kiện đặc biệt.
- [ ] P5-09 Câu lạc bộ (guild): tạo/tham gia, vai trò, chat, nhiệm vụ CLB, League CLB, kho thưởng.
- [ ] P5-10 Bạn bè, hồ sơ, lịch sử trận, thống kê, danh hiệu, avatar/khung, xem lại trận.
- [ ] P5-11 Nhiệm vụ hàng ngày/tuần/thành tựu, Pass mùa, điểm danh.
- [ ] P5-12 Bộ sưu tập, đổi thưởng (exchange), HLV/vật phẩm hỗ trợ.

### P6 — Content pipeline bản quyền · 5%

- [ ] P6-01 License register: quyền theo lãnh thổ/mùa/loại asset, `rightsVersion`, ngày hết hạn, quy trình gia hạn/gỡ.
- [ ] P6-02 Nhập dữ liệu chính hãng: giải đấu, CLB, cầu thủ, chỉ số, ảnh chân dung, huy hiệu, kit; validator FK/checksum; phiên bản catalog theo mùa.
- [ ] P6-03 Model 3D: rig chuẩn, LOD, material budget theo tier, face scan/likeness pipeline, kit texture atlas; đo trên device.
- [ ] P6-04 Sân vận động và môi trường theo giải; đám đông; bảng quảng cáo động.
- [ ] P6-05 Âm thanh: bình luận VN, tên cầu thủ/CLB đọc được, nhạc, SFX sân; delivery Addressables remote.
- [ ] P6-06 CDN/remote Addressables, ký số bundle, delta update, rollback pin version.
- [ ] P6-07 Cập nhật mùa (season rollover), chuyển nhượng thực tế, roster update lịch tuần.

### P7 — LiveOps, monetization, membership · 0%

- [ ] P7-01 Shop: tiền tệ premium/BP, gói, vật phẩm, membership; IAP iOS/Android, reconcile receipt, hoàn tiền.
- [ ] P7-02 Sự kiện: lịch, eligibility, grant ledger, webview event, sự kiện in-game, mini game.
- [ ] P7-03 Inbox/thông báo, gift code, coupon; chống lạm dụng.
- [ ] P7-04 Membership/VIP: quyền lợi, gia hạn, hết hạn.
- [ ] P7-05 Quy trình vận hành: incident response, hotfix config, đền bù, support tool (theo [operations](docs/operations/live-data-and-operations.md)).

### P8 — Vượt tham chiếu · 0%

**Đề xuất cho Soccer Mobile Pro** (cần validation người chơi trước khi cam kết):

- [ ] P8-01 Chế độ **Co-op 2v2** và **CLB vs CLB** thời gian thực.
- [ ] P8-02 **Trợ lý chiến thuật AI**: phân tích trận, gợi ý đội hình/chiến thuật theo dữ liệu trận của người chơi (client-side, có consent).
- [ ] P8-03 **Replay studio**: camera tự do, chia sẻ clip, highlight tự động theo event log deterministic.
- [ ] P8-04 **Accessibility vượt chuẩn**: one-handed layout, color-blind palette, caption bình luận, reduced motion, remap đầy đủ.
- [ ] P8-05 **Offline-first**: chơi AI/Quản lý không mạng, đồng bộ an toàn khi online, không cấp reward offline.
- [ ] P8-06 **Kinh tế minh bạch**: lịch sử giá thị trường công khai, odds pack minh bạch, cảnh báo chi tiêu.
- [ ] P8-07 **Tối ưu hiệu năng**: 60 fps tier mid, tải trận < 8 s, dung lượng cài đặt ban đầu < 1.5 GB nhờ Addressables theo nhu cầu.
- [ ] P8-08 **Esports tooling**: chế độ khán giả, bracket công khai, anti-cheat báo cáo, giải đấu cộng đồng tự tổ chức.

### P9 — Chất lượng, hiệu năng, bảo mật, release · 5%

- [x] Test runner EditMode/PlayMode chạy được cục bộ (102 + 19).
- [ ] P9-01 GitLab CI: compile, EditMode/PlayMode, lint markdown, build Android/iOS, upload artifact; MR gate.
- [ ] P9-02 Device farm và device matrix low/mid/high; profiler baseline mỗi milestone.
- [ ] P9-03 Bảo mật: secret scanning, cert pinning, obfuscation, anti-tamper, kiểm tra quyền riêng tư.
- [ ] P9-04 Closed alpha → closed beta → soft launch → launch; tiêu chí go/no-go từng bước.
- [ ] P9-05 Localization QA, store listing, age rating, chính sách odds/pack theo quy định.

<a id="parity"></a>

## 5. Ma trận parity tính năng FC Online M

Nhãn: **Suy luận thiết kế** từ quan sát công khai FC Online M; cần khóa lại trong P1-05. Trạng thái: `Đạt` / `Một phần` / `Chưa`.

| # | Nhóm | Tính năng FC Online M | Trạng thái | Phase | Ghi chú Soccer Mobile Pro |
| --- | --- | --- | --- | --- | --- |
| 1 | Tài khoản | Đăng nhập nhà phát hành/Google/Apple, chọn server, điều khoản | Một phần | P4-02 | Contract + fake adapter |
| 2 | Tài khoản | Liên kết/khôi phục/xóa tài khoản | Một phần | P4-02 | Test contract có |
| 3 | Khởi động | Tải asset ban đầu, cập nhật bắt buộc, bảo trì | Chưa | P2-03, P4-08 | |
| 4 | Home | Lobby 3D đội hình, banner, quick menu, thông báo | Chưa | P2-04 | |
| 5 | Home | Điểm danh hàng ngày | Chưa | P5-11 | |
| 6 | Thẻ cầu thủ | Mùa thẻ, OVR, chỉ số, đặc tính, skill moves | Một phần | P5-01 | Fixture hư cấu 44 cầu thủ |
| 7 | Thẻ cầu thủ | Nâng cấp +1…+10 với tỷ lệ | Một phần | P5-04 | Domain preview/receipt có |
| 8 | Thẻ cầu thủ | Huấn luyện (training) | Chưa | P5-05 | |
| 9 | Thẻ cầu thủ | Vị trí phụ/đổi vị trí | Một phần | P1-03 | |
| 10 | Đội hình | Formation editor, chiến thuật, vai trò | Chưa | P5-02 | Legacy chỉ chọn đội |
| 11 | Đội hình | Team Color/chemistry | Chưa | P5-03 | |
| 12 | Đội hình | Lương đội hình (salary cap) | Chưa | P5-03 | |
| 13 | Đội hình | Nhiều slot đội hình, kit/sân/bóng | Chưa | P5-02 | |
| 14 | Kinh tế | Chuyển nhượng BP (mua/bán/niêm yết) | Chưa | P5-06 | |
| 15 | Kinh tế | Tuyển dụng pack với odds công bố | Chưa | P5-07 | Gate compliance |
| 16 | Kinh tế | Shop, tiền tệ premium, IAP | Chưa | P7-01 | |
| 17 | Kinh tế | Bộ sưu tập, đổi thưởng | Chưa | P5-12 | |
| 18 | Chế độ | Ranked 1v1 real-time, tier/mùa | Một phần | P4-04, P4-05 | Competition foundation offline |
| 19 | Chế độ | Giao hữu bạn bè/mã phòng | Chưa | P5-08 | |
| 20 | Chế độ | Đấu AI theo độ khó | Một phần | P3-06 | Heuristic AI |
| 21 | Chế độ | Quản lý (mô phỏng) | Chưa | P5-08 | |
| 22 | Chế độ | Tournament/Cup | Một phần | P1-04 | Cup cục bộ 8 trận |
| 23 | Chế độ | Sự kiện đặc biệt/mini game | Chưa | P7-02 | |
| 24 | Trận đấu | Điều khiển cảm ứng có/không bóng, set piece, GK | Một phần | P0-02, P3-04 | Action map có, HUD legacy |
| 25 | Trận đấu | Tùy chỉnh layout nút, assist, camera | Một phần | P0-02, P3-05 | Profile Standard/LeftHanded |
| 26 | Trận đấu | Luật đầy đủ, thay người, chiến thuật nhanh | Một phần | P3-01 | Goal/foul/corner cơ bản |
| 27 | Trận đấu | Animation/skill moves/ăn mừng | Một phần | P3-02 | Legacy Animation |
| 28 | Trận đấu | Bình luận tiếng Việt, âm thanh sân | Chưa | P3-09 | |
| 29 | Trận đấu | Replay/highlight | Chưa | P3-08 | |
| 30 | Trận đấu | VAR trình bày | Chưa | P3-07 | Spec hoàn chỉnh |
| 31 | Trận đấu | Reconnect, latency indicator, forfeit | Một phần | P4-04 | Reconnect foundation |
| 32 | Xã hội | Bạn bè, hồ sơ, lịch sử trận, danh hiệu | Chưa | P5-10 | |
| 33 | Xã hội | Câu lạc bộ (guild), chat, League CLB | Chưa | P5-09 | |
| 34 | Xã hội | Báo cáo, chặn, moderation | Chưa | P4-07 | |
| 35 | Tiến trình | Nhiệm vụ ngày/tuần, thành tựu, Pass | Chưa | P5-11 | |
| 36 | LiveOps | Sự kiện, inbox, gift code, coupon | Chưa | P7-02, P7-03 | |
| 37 | LiveOps | Membership | Chưa | P7-04 | |
| 38 | Cài đặt | Ngôn ngữ, đồ họa, âm thanh, điều khiển, thông báo | Một phần | P1-01, P2-05 | Locale + panel cơ bản |
| 39 | Nội dung | Dữ liệu cầu thủ/CLB/giải thật theo mùa | Chưa | P6-02 | |
| 40 | Nội dung | Model/kit/sân/huy hiệu chính hãng | Chưa | P6-03, P6-04 | |

**Tính toán:** 0 `Đạt` + 14 `Một phần` (×0.5 = 7) trên 40 dòng → **≈ 17.5% điểm parity thô**, hạ xuống **≈ 12%** vì các dòng `Một phần` chủ yếu chỉ đạt gate Contract/Automated, chưa có Runtime/Device.

<a id="ui-parity"></a>

## 6. Ma trận parity giao diện (screen)

| ID | Màn hình | Trạng thái | Phase | Gate còn thiếu |
| --- | --- | --- | --- | --- |
| SC-01 | Bootstrap/locale | Một phần | P2-03 | Runtime shell, device |
| SC-02 | Account/provider | Chưa | P2-03 | Tất cả |
| SC-03 | Core asset gate | Chưa | P2-03 | Tất cả |
| SC-04 | Home | Chưa | P2-04 | Tất cả (MainMenu legacy không đạt chuẩn) |
| SC-05 | Profile/friends | Chưa | P2-05 | Tất cả |
| SC-06 | Settings | Một phần | P2-05 | Đầy đủ nhóm setting, device |
| SC-07 | Club/squad | Chưa | P2-06 | Tất cả |
| SC-08 | Player inventory/detail | Chưa | P2-06 | Tất cả |
| SC-09 | Upgrade/Training | Chưa | P2-06 | Tất cả |
| SC-10 | Market/exchange | Chưa | P2-07 | Tất cả |
| SC-11 | Event/missions/pass | Chưa | P2-07 | Tất cả |
| SC-12 | Mode/tournament | Chưa | P2-07 | Tất cả |
| SC-13 | Match loading/gameplay HUD | Một phần | P3-04 | HUD production, device |
| SC-14 | VAR presentation | Chưa | P3-07 | Tất cả |
| SC-15 | Result/report | Một phần | P2-08 | Report, reconcile, device |
| SC-16 | Shop | Chưa | P2-08 | Tất cả (bổ sung vào catalogue) |
| SC-17 | Inbox/gift code | Chưa | P2-08 | Tất cả (bổ sung vào catalogue) |
| SC-18 | Collection/exchange | Chưa | P2-08 | Tất cả (bổ sung vào catalogue) |

**Parity giao diện ≈ 6%** (4 `Một phần` × 0.5 / 18, hạ theo gate).

<a id="milestones"></a>

## 7. Lộ trình milestone

| Milestone | Mục tiêu tích lũy | Phase đóng | Tiêu chí go/no-go | Tiến độ dự án mục tiêu |
| --- | --- | --- | --- | --- |
| M1 — Foundation on by default | Match Core, input, platform là runtime mặc định; research FC Online M khóa; CI xanh | P0, P1-05…P1-08, P9-01 | APK/IPA smoke pass, 100% test pass, console sạch | 25% |
| M2 — Vertical slice meta | Shell + Home + Squad + Inventory + Upgrade + Settings chạy với backend staging | P2-01…P2-06, P4-01…P4-03, P5-01…P5-05 | 1 người chơi hoàn thành login → sửa đội hình → nâng cấp → chơi trận AI | 45% |
| M3 — Playable online | Ranked 1v1, Giao hữu, Market, Tuyển dụng, Missions, Inbox; content chính hãng đợt 1 | P4-04…P4-07, P5-06…P5-11, P6-01…P6-03, P2-07, P2-08 | 100 người chơi closed alpha, reconnect ≥ 95%, không double-grant | 65% |
| M4 — Feature parity 100% | Toàn bộ mục 5 và 6 `Đạt`; VAR, replay, bình luận, CLB, Quản lý, Shop/IAP, membership | P3, P5-12, P6-04…P6-07, P7 | Closed beta, KPI D1/D7, crash-free ≥ 99.5%, 60 fps tier mid | 85% |
| M5 — Vượt tham chiếu và launch | P8 tính năng mới, tối ưu, esports tooling, soft launch → launch | P8, P9 | Soft launch KPI đạt, vận hành incident rehearsal | 100% |

Ước lượng thời gian tương đối (đội 8–12 người, gồm backend): M1 ≈ 2 tháng, M2 ≈ +3 tháng, M3 ≈ +4 tháng, M4 ≈ +4 tháng, M5 ≈ +3 tháng. Ước lượng sẽ được chốt lại sau khi P1-05 hoàn tất và backend team xác nhận.

<a id="risks"></a>

## 8. Rủi ro chính và biện pháp

| Rủi ro | Ảnh hưởng | Biện pháp |
| --- | --- | --- |
| Chưa có backend thật; mọi authority hiện là fake/file | Chặn M2 trở đi | Ưu tiên P4-01…P4-03 song song P2; giữ adapter offline để client không chờ |
| Netcode real-time PvP trên mạng di động VN | Chặn Ranked | Chọn mô hình sớm (P4-04), test packet-loss/jitter, relay khu vực, reconnect policy |
| Nhầm sao chép asset/UI tham chiếu thay vì parity chức năng | Rủi ro pháp lý và brand | Nguyên tắc mục 1; review art/UI theo design system; asset chỉ từ pipeline bản quyền P6 |
| Pack/odds và kinh tế | Compliance, niềm tin người chơi | Odds công bố, age/privacy review, entitlement reconciliation trước khi bật |
| Legacy coupling (scene name, static, `GameObject.Find`) | Regression khó lường | P0-04 tách legacy, test PlayMode flow, feature flag rollback |
| Ngân sách hiệu năng model/kit/sân chính hãng | Rớt fps, OOM tier low | P6-03 LOD/material budget, profiler baseline mỗi milestone, Addressables theo nhu cầu |
| Drift tham chiếu (FC Online M cập nhật theo mùa) | Parity trôi | P1-05 research có ngày cutoff; rà soát mục 5 mỗi quý |

<a id="update-rules"></a>

## 9. Quy tắc cập nhật file này

1. Cập nhật `TODO.md` trong **cùng commit** với thay đổi code/docs làm đổi trạng thái item (`docs: update TODO progress after <item>`).
2. Chỉ đổi `[ ]` → `[~]` khi bắt đầu, `[~]` → `[x]` khi đủ 4 gate và có link evidence trong `docs/implementation/`.
3. Tính lại % Phase, % tổng, % parity theo mục 3 mỗi lần đổi trạng thái; ghi ngày ở đầu file.
4. Thêm dòng vào mục 5/6 khi research P1-05 phát hiện tính năng/màn hình mới của tham chiếu; không xóa dòng, chỉ đánh dấu `Bỏ` với lý do.
5. Không ghi credential, dữ liệu người chơi thật hoặc endpoint nội bộ của bên thứ ba vào file này.
