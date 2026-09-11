# Inventory tính năng và cơ chế FC Online M

> [Chỉ mục](../../index.md) · [Nghiên cứu](fc-online-m-research.md) · [Sổ nguồn](fc-online-m-source-register.md) · [Adoption](fc-online-m-adoption-decision-matrix.md) · [TODO §5](../../../TODO.md#parity)

## 0. Mục lục

- [1. Contract record](#record-contract)
- [2. Account, bootstrap và shell](#shell)
- [3. Thẻ cầu thủ và tiến trình](#cards)
- [4. Đội hình, đấu pháp và HLV](#squad)
- [5. Kinh tế: chuyển nhượng, tuyển dụng, cửa hàng](#economy)
- [6. Mode thi đấu và xếp hạng](#modes)
- [7. Gameplay và điều khiển](#gameplay)
- [8. Xã hội, tiến trình và liveops](#social)
- [9. Coverage summary](#inventory-coverage)

<a id="record-contract"></a>

## 1. Contract record

Mỗi hàng là một mechanic có ID ổn định `FOM-<nhóm>-<số>` và ánh xạ tới dòng trong [TODO §5](../../../TODO.md#parity). `Entry/Input → State/Output` mô tả hành vi kỳ vọng ở mức công khai, không phải API của bên thứ ba. `Authority` là nơi Soccer Mobile Pro đặt quyền quyết định.

```text
MechanicRecord {
  id, name, status, entryCondition, input, stateTransition, output,
  costReward, limitExpiryRandomness, uiFailureAccessibility,
  proposedAuthority, evidenceIds, todoRow, adoptionLink
}
```

Status: `Unverified` (mặc định hiện tại), `Current`, `Versioned`, `Historical`, `NotPublic`. Mọi số cân bằng để trống cho đến khi có nguồn.

<a id="shell"></a>

## 2. Account, bootstrap và shell

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, failure, accessibility | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-ACC-01 | Đăng nhập nhà phát hành / Unverified | Title → chọn provider → session + profile | Provider lỗi, callback, merge conflict | Identity backend | FOMC-001 | #1 |
| FOM-ACC-02 | Chọn server/khu vực / Unverified | Sau login → chọn server → dữ liệu theo server | Không chuyển server; hiển thị tình trạng | Identity + region config | FOMC-001 | #1 |
| FOM-ACC-03 | Liên kết/khôi phục/xóa tài khoản / Unverified | Settings → link/recovery/delete → trạng thái mới + email xác nhận | Re-auth cho thao tác phá hủy | Identity + support | FOMC-001, FOMC-019 | #2 |
| FOM-BOOT-01 | Tải tài nguyên ban đầu / Unverified | Sau login → download gate → sẵn sàng vào Home | Dung lượng thấp, đổi mạng, checksum fail | Signed catalog + client downloader | FOMC-001 | #3 |
| FOM-BOOT-02 | Bảo trì / cập nhật bắt buộc / Unverified | Version check → gate với thời gian và link store | Copy đọc được, không dead-end | Remote config | — | #3 |
| FOM-UI-01 | Home với đội hình 3D, banner, quick menu / Unverified | Home → slot remote + shell ổn định | Slot lỗi bị ẩn, không phá shell | Client shell + CMS | FOMC-015 | #4 |
| FOM-UI-02 | Điểm danh hàng ngày / Unverified | Home → lịch điểm danh → nhận thưởng | Server time, đã nhận, hết hạn | Grant ledger | FOMC-015 | #5 |
| FOM-UI-03 | Cài đặt đầy đủ / Unverified | Settings → nhóm đồ họa/điều khiển/âm thanh/bình luận/tài khoản/thông báo | Migration, unsupported tier, sync conflict | Setting owner theo field | FOMC-017 | #38 |

<a id="cards"></a>

## 3. Thẻ cầu thủ và tiến trình

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, randomness, failure | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-CARD-01 | Thẻ theo mùa với chỉ số/OVR/đặc tính/skill moves / Unverified | Catalog + mùa → projection chỉ số, giá tham chiếu | Mùa mới thay đổi meta; stale catalog | Catalog server | FOMC-006 | #6 |
| FOM-CARD-02 | Nâng cấp bậc +1…+10 / Unverified | Chọn thẻ + vật liệu/BP → preview tỷ lệ → thành công/thất bại → bậc mới hoặc giữ/hạ | Tỷ lệ công bố; rule thất bại **cần xác minh**; bảo hiểm | Progression server + ledger | FOMC-007 | #7 |
| FOM-CARD-03 | Huấn luyện / Unverified | Điểm huấn luyện + thẻ → level → bonus chỉ số | Giới hạn level, nguồn điểm | Progression server | FOMC-010 | #8 |
| FOM-CARD-04 | Đổi vị trí/vị trí phụ / Unverified | Thẻ + vật phẩm → vị trí mới → projection | Eligibility theo vị trí gốc | Progression server | FOMC-006 | #9 |
| FOM-CARD-05 | Kho thẻ: lọc/sắp xếp/khóa/so sánh / Unverified | Inventory → filter/lock/compare → view | Empty/no result, stale revision | Inventory server | FOMC-006 | #6 |
| FOM-CARD-06 | Bộ sưu tập và đổi thưởng / Unverified | Bộ điều kiện → nộp thẻ → phần thưởng | Không hoàn tác; thẻ khóa/trong đội hình | Exchange ledger | FOMC-015 | #17 |

<a id="squad"></a>

## 4. Đội hình, đấu pháp và HLV

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, failure, accessibility | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-SQ-01 | Formation editor và vai trò / Unverified | Chọn formation → kéo thả thẻ → đội hình hợp lệ | Sai vị trí, trùng thẻ, thiếu người | Rule set client preview + server validate | FOMC-001 | #10 |
| FOM-SQ-02 | Team Color / Unverified | Tập cầu thủ → tính thuộc tính chung → bonus theo ngưỡng | Rule version, preview rõ, không chỉ dùng màu | Rule set version server | FOMC-008 | #11 |
| FOM-SQ-03 | Lương đội hình / Unverified | Tổng lương thẻ → so cap → hợp lệ/cảnh báo | Cap mở rộng bằng vật phẩm; áp dụng dự bị **cần xác minh** | Rule set version server | FOMC-009 | #12 |
| FOM-SQ-04 | Đấu pháp/HLV / Unverified | Preset + slider + HLV card → tactic profile | Đổi trong trận giới hạn; giải thích ảnh hưởng | Tactic profile server; match core áp dụng | FOMC-001 | #10 |
| FOM-SQ-05 | Nhiều slot đội hình, kit/sân/bóng / Unverified | Slot → cấu hình riêng → chọn khi vào trận | Slot khóa, kit clash rule | Squad server | FOMC-001 | #13 |
| FOM-SQ-06 | Người đá phạt, đội trưởng / Unverified | Đội hình → chỉ định → dùng trong set piece | Mặc định hợp lý khi thiếu | Squad server; match core | — | #10 |

<a id="economy"></a>

## 5. Kinh tế: chuyển nhượng, tuyển dụng, cửa hàng

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, randomness, failure | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-ECO-01 | Niêm yết bán thẻ / Unverified | Thẻ chưa khóa + giá trong dải → listing → bán/hết hạn | Thuế, giới hạn/ngày, thẻ trong đội hình | Market server authoritative | FOMC-011 | #14 |
| FOM-ECO-02 | Mua thẻ / Unverified | Tìm kiếm/lọc → chọn listing → BP trừ → thẻ vào kho | Giá đổi, hết hàng, không đủ BP | Market server | FOMC-011 | #14 |
| FOM-ECO-03 | Lịch sử giá và bộ lọc / Unverified | Thẻ → lịch sử giao dịch → biểu đồ | Dữ liệu trễ, thao túng | Market analytics | FOMC-011 | #14 |
| FOM-ECO-04 | Tuyển dụng (pack) / Unverified | Gói + tiền tệ → mở → thẻ ngẫu nhiên theo odds công bố | Odds hiển thị trước mua; duplicate; tuổi/privacy | Offer + RNG service + entitlement ledger | FOMC-012 | #15 |
| FOM-ECO-05 | Cửa hàng/IAP / Unverified | Store → SKU → thanh toán → entitlement | Receipt reconcile, hoàn tiền, pending | Commerce + entitlement ledger | FOMC-013 | #16 |
| FOM-ECO-06 | Tiền tệ: BP và premium / Unverified | Nguồn/sink → số dư → hiển thị top bar | Pending balance có label | Economy ledger | FOMC-011, FOMC-013 | #16 |

<a id="modes"></a>

## 6. Mode thi đấu và xếp hạng

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, failure, accessibility | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-MODE-01 | Đấu xếp hạng 1v1 / Unverified | Queue → match → kết quả → điểm tier | Reconnect, forfeit, rating | Matchmaking + match authority | FOMC-002, FOMC-018 | #18 |
| FOM-MODE-02 | Tier/mùa, phần thưởng cuối mùa / Unverified | Điểm → bậc → reset mùa → thưởng | Decay, rollover, đã nhận | Season server + grant ledger | FOMC-018 | #18 |
| FOM-MODE-03 | Giao hữu bạn bè/mã phòng / Unverified | Mời/mã → phòng → trận | Không thưởng ranked; huỷ phòng | Room service | FOMC-003 | #19 |
| FOM-MODE-04 | Đấu với máy theo độ khó / Unverified | Chọn độ khó → trận offline/online → thưởng giới hạn | Không cấp thưởng khi offline | Client match core; server nếu có thưởng | FOMC-004 | #20 |
| FOM-MODE-05 | Chế độ Quản lý (mô phỏng) / Unverified | Đội hình + đấu pháp → mô phỏng nhanh → kết quả/thưởng | Có trên mobile **cần xác minh** | Server simulation nếu có thưởng | FOMC-005 | #21 |
| FOM-MODE-06 | Giải đấu/Cup / Unverified | Đăng ký → bracket → trận → thưởng | Roster lock, late, dispute | Competition server | — | #22 |
| FOM-MODE-07 | Sự kiện đặc biệt/mini game / Unverified | Lịch sự kiện → mode giới hạn → thưởng | Eligibility, hết hạn | Event config + grant ledger | FOMC-015 | #23 |

<a id="gameplay"></a>

## 7. Gameplay và điều khiển

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, failure, accessibility | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-PLAY-01 | Điều khiển cảm ứng có/không bóng, set piece, GK / Unverified | Joystick + nút context → command → match core | Đa chạm, mất focus, hủy | Client input; server nhận command | FOMC-017 | #24 |
| FOM-PLAY-02 | Tùy chỉnh layout/assist/camera / Unverified | Settings → preset/remap/scale → áp dụng trận | Left-handed, opacity, dead-zone | Client settings | FOMC-017 | #25 |
| FOM-PLAY-03 | Luật đầy đủ, thay người, đấu pháp nhanh / Unverified | Trận → sự kiện luật → restart; pause → sub/tactic | Giới hạn thay người, thời gian pause online | Match core deterministic | — | #26 |
| FOM-PLAY-04 | Animation, skill moves, ăn mừng / Unverified | Command + context → clip/blend → physics sync | Ngân sách tier low | Presentation client | — | #27 |
| FOM-PLAY-05 | Bình luận tiếng Việt, âm thanh sân / Unverified | Sự kiện trận → cue → audio | Caption, mixer, tải theo nhu cầu | Presentation client | FOMC-020 | #28 |
| FOM-PLAY-06 | Replay/highlight / Unverified | Event log → replay → chia sẻ | Skip, reduced motion | Client từ deterministic log | — | #29 |
| FOM-PLAY-07 | VAR trình bày / Unverified | Incident → quyết định luật → overlay/replay | Skip vẫn hiện quyết định | Rule result immutable | — | #30 |
| FOM-PLAY-08 | Reconnect, chỉ báo độ trễ, forfeit / Unverified | Mất kết nối → cửa sổ reconnect → resume/forfeit | Policy công bố, không double result | Match authority | FOMC-002 | #31 |

<a id="social"></a>

## 8. Xã hội, tiến trình và liveops

| FOM-ID | Cơ chế / status | Entry/Input → State/Output | Limit, failure, accessibility | Authority đề xuất | Evidence | TODO |
| --- | --- | --- | --- | --- | --- | --- |
| FOM-SOC-01 | Bạn bè, hồ sơ, lịch sử trận, danh hiệu / Unverified | Tìm/thêm → chấp nhận → danh sách; hồ sơ → thống kê | Chặn, pending, rate limit | Social server + moderation | FOMC-014 | #32 |
| FOM-SOC-02 | Câu lạc bộ (guild), chat, League CLB / Unverified | Tạo/tham gia → vai trò → hoạt động/thưởng | Moderation, kick, kho thưởng | Guild server | FOMC-014 | #33 |
| FOM-SOC-03 | Báo cáo/chặn/moderation / Unverified | Report → case → sanction/appeal | Correlation ID, duplicate report | Integrity service | FOMC-019 | #34 |
| FOM-PROG-01 | Nhiệm vụ ngày/tuần, thành tựu, Pass / Unverified | Điều kiện → tiến độ → claim | Reset theo server time, đã nhận | Objective + grant ledger | FOMC-016 | #35 |
| FOM-LIVE-01 | Sự kiện, hộp thư, mã quà tặng, coupon / Unverified | Config → eligibility → grant → inbox | Hết hạn, một lần, chống lạm dụng | Event config + grant ledger | FOMC-015 | #36 |
| FOM-LIVE-02 | Membership / Unverified | Mua → quyền lợi theo kỳ → gia hạn/hết hạn | Entitlement reconcile | Commerce + entitlement | FOMC-013 | #37 |
| FOM-CONT-01 | Dữ liệu cầu thủ/CLB/giải theo mùa / Unverified | Catalog publish → client sync | Delta, rollback, rights version | Catalog server + license register | FOMC-006 | #39 |
| FOM-CONT-02 | Model/kit/sân/huy hiệu chính hãng / Unverified | Asset manifest → Addressables → render | Budget tier, fallback generic | Content pipeline | — | #40 |

<a id="inventory-coverage"></a>

## 9. Coverage summary

| Nhóm | Số mechanic | Unverified | Current/Versioned | NotPublic |
| --- | ---: | ---: | ---: | ---: |
| Shell/account | 8 | 8 | 0 | 0 |
| Thẻ/tiến trình | 6 | 6 | 0 | 0 |
| Đội hình | 6 | 6 | 0 | 0 |
| Kinh tế | 6 | 6 | 0 | 0 |
| Mode | 7 | 7 | 0 | 0 |
| Gameplay | 8 | 8 | 0 | 0 |
| Xã hội/liveops/content | 8 | 8 | 0 | 0 |
| **Tổng** | **49** | **49** | **0** | **0** |

Toàn bộ 40 dòng trong [TODO §5](../../../TODO.md#parity) đã có ít nhất một mechanic tương ứng. Bước tiếp theo là P1-05b: xác minh nguồn và nâng status.
