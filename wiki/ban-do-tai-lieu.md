# Bản đồ tài liệu

> Cổng vào chính thức: [`docs/index.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/index.md). Trang này trả lời câu hỏi "đọc gì trước khi đụng vào X".

## 1. Theo công việc

| Bạn sắp làm | Đọc trước |
| --- | --- |
| Bất kỳ việc gì | [`AGENTS.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/AGENTS.md), [`TODO.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/TODO.md) |
| Gameplay trận, điều khiển, set piece, VAR | [Match controls, set pieces và VAR](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/match-controls-set-pieces-and-var.md), [Nhật ký P0](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p0-foundation-implementation.md) |
| AI offline | [Offline AI, tactics và difficulty](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/offline-ai-tactics-and-difficulty.md) |
| Thẻ cầu thủ, nâng cấp, đội hình, market | [Cards/progression/market spec](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/player-cards-skills-progression-market-and-exchange.md), [Kế hoạch P1-03](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-player-items-skills-and-progression-plan.md), [Kế hoạch P1-06](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-06-squad-rules-and-card-tiers-plan.md), [Nhật ký P1-06](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-06-squad-rules-and-card-tiers-implementation.md) |
| Catalog giải/CLB/cầu thủ, model 3D, Addressables | [Football catalog spec](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/football-catalog-player-database-and-model-assets.md), [Nhật ký P1-02](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-football-catalog-and-model-foundation.md) |
| Giải đấu, ranked, CLB, social, reconnect | [Competitions spec](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/competitions-leagues-clubs-and-social.md), [Competitive integrity](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/competitive-integrity-and-esports.md), [Nhật ký P1-04](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-competition-and-integrity-foundation.md) |
| Account, localization, settings | [Account/localization/settings spec](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/systems/account-localization-and-settings.md), [Nhật ký P1-01](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/p1-localization-settings-implementation.md) |
| UI/UX màn hình meta | [UX wireflows và states](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/product/ux-wireflows-and-states.md), [UI design system và screen catalogue](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/product/ui-design-system-and-screen-catalogue.md) |
| LiveOps, shop, membership, inbox | [LiveOps/monetization/membership](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/operations/liveops-monetization-and-membership.md), [Live data và operations](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/operations/live-data-and-operations.md) |
| Đổi tên/di chuyển asset Unity | [Sổ migration asset](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/implementation/asset-naming-migration-register.md) |
| Nghiên cứu tham chiếu | [FC Mobile VN](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/research/fc-mobile-vn-research.md), [eFootball Mobile](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/research/efootball-mobile/efootball-mobile-research.md), [FC Online M](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/research/fc-online-m/fc-online-m-research.md), [Coverage audit](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/docs/research/fc-mobile-vn-coverage-audit.md) |

## 2. Theo loại tài liệu

| Loại | Thư mục | Quy ước |
| --- | --- | --- |
| Product (GDD, UX, UI) | `docs/product/` | GDD là canonical cho quyết định sản phẩm. |
| Research | `docs/research/` | Mọi claim mang một trong bốn nhãn bằng chứng; sổ nguồn có URL + ngày truy cập. |
| Systems spec | `docs/systems/` | Phải có input/output, client/server, analytics, abuse/failure, accessibility, QA, rollback, open questions. |
| Operations | `docs/operations/` | Versioning, CMS, economy ops, telemetry, incident. |
| Implementation | `docs/implementation/` | `*-plan.md` (Understand brief, contract, batch) và `*-implementation.md` (kết quả, sai khác, cổng chưa đạt, lô kế). |

## 3. Quy tắc viết

- Tiếng Việt cho docs dự án; `AGENTS.md` tiếng Anh.
- Mỗi file một H1; H2 đánh số.
- Liên kết nội bộ trong `docs/` dùng đường dẫn tương đối; wiki dùng URL tuyệt đối vì là repo riêng.
- Không sao chép đoạn dài giữa file; liên kết tới authority.
- Knowledge graph canonical: `.understand-anything/knowledge-graph.json`; không tạo graph lồng trong `docs/`.
