# Tiến độ và lộ trình

> Authority: [`TODO.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/TODO.md). Snapshot dưới đây lấy ngày **12/09/2026**; khi lệch, `TODO.md` đúng.

## 1. Phase

| Phase | Tên | Trọng số | % | Trạng thái |
| --- | --- | ---: | ---: | --- |
| P0 | Foundation kỹ thuật (Match Core, Input, Platform) | 10% | 70% | Runtime integration chưa bật mặc định |
| P1 | Meta foundation + khóa tham chiếu FC Online M | 10% | 58% | P1-06 B1–B2b domain xong, chưa chạy runner |
| P2 | Product shell + 15 màn hình meta | 15% | 5% | Chưa bắt đầu production |
| P3 | Match gameplay production | 15% | 15% | Prototype legacy |
| P4 | Backend và live service | 15% | 3% | Chỉ contract/fake adapter |
| P5 | Hệ thống meta FC Online M | 15% | 11% | Domain squad/Team Color/lương |
| P6 | Content pipeline bản quyền | 8% | 5% | Fixture hư cấu |
| P7 | LiveOps, monetization, membership | 5% | 0% | Spec xong |
| P8 | Vượt tham chiếu | 4% | 0% | Ý tưởng |
| P9 | Chất lượng, hiệu năng, bảo mật, release | 3% | 5% | Test runner ổn, chưa CI/device farm |

**Tổng ≈ 18%** · Parity tính năng ≈ 13% (0 `Đạt`, 16 `Một phần` / 40) · Parity giao diện ≈ 6% (4 `Một phần` / 18).

## 2. Milestone

| Milestone | Đóng Phase | Go/no-go | Mục tiêu |
| --- | --- | --- | --- |
| **M1** Foundation on by default | P0, P1-05…P1-08, P9-01 | APK/IPA smoke pass, 100% test pass, console sạch | 25% |
| **M2** Vertical slice meta | P2-01…P2-06, P4-01…P4-03, P5-01…P5-05 | login → sửa đội hình → nâng cấp → trận AI | 45% |
| **M3** Playable online | P4-04…P4-07, P5-06…P5-11, P6-01…P6-03, P2-07/08 | 100 người closed alpha, reconnect ≥ 95%, không double-grant | 65% |
| **M4** Feature parity 100% | P3, P5-12, P6-04…P6-07, P7 | Closed beta, crash-free ≥ 99.5%, 60 fps tier mid | 85% |
| **M5** Vượt tham chiếu + launch | P8, P9 | Soft launch KPI, incident rehearsal | 100% |

## 3. Đang làm và kế tiếp

| Item | Trạng thái | Lô kế tiếp |
| --- | --- | --- |
| P1-06 Squad rules / Team Color / lương / bậc thẻ | `[~]` B1, B2, B2b có code | **B3** nâng cấp bậc → B4 huấn luyện → B5 projection/PlayMode → B6 docs |
| P0-01b Match Core điều khiển physics/HUD/result | `[~]` | Bật flag mặc định, xoá state phân tán |
| P0-02b HUD touch production | `[~]` | Thay `SoccerInput`/joystick legacy |
| P1-05b Xác minh nguồn FC Online M | `[ ]` | Điền 14 slot nguồn, trả lời FOM-Q01…Q10 |
| P9-01 GitLab CI | `[ ]` | compile → EditMode/PlayMode → lint markdown → build Android/iOS; hiện chỉ có job `wiki:publish` |

## 4. Rủi ro hàng đầu

1. Chưa có backend thật — mọi authority là fake/file → chặn M2.
2. Netcode PvP real-time trên mạng di động VN → chặn Ranked; phải chọn mô hình sớm (P4-04).
3. Legacy coupling (scene name, static, `GameObject.Find`) → regression khó lường; P0-04 tách legacy.
4. Drift tham chiếu theo mùa → rà soát ma trận parity mỗi quý.
