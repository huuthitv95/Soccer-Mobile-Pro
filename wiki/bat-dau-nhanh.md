# Bắt đầu nhanh

## 1. Yêu cầu môi trường

| Thành phần | Phiên bản | Ghi chú |
| --- | --- | --- |
| Unity Editor | **2022.3.62f3** (`ProjectSettings/ProjectVersion.txt`) | Không nâng phiên bển Editor khi chưa có quyết định kỹ thuật. |
| Git + Git LFS | mới nhất | Video tham chiếu và ảnh phân tích nằm trong LFS; `git lfs install` trước khi clone. |
| Package chính | Input System 1.14.2, Addressables 1.25.0, Localization 1.5.12, Newtonsoft JSON 3.0.2, Cinemachine, Test Framework, URP | Không sửa `Packages/manifest.json` nếu không giải thích tương thích + rollback. |
| Unity MCP (tùy chọn) | core package + CLI `0.90.0`, NuGet plugin `8.3.0`, endpoint `http://localhost:22113` | Dùng cho agent thao tác Editor; cấu hình trong `.codex/config.toml`. |

## 2. Mở project

```bash
git lfs install
git clone https://gitlab.com/fpt-college/Soccer-Mobile-Pro.git
```

Mở thư mục repo bằng Unity Hub với đúng phiên bển. Build Settings bắt đầu từ `Assets/Scenes/SplashScene.unity` → `MainMenu` → `GameSelectionScene` → chọn đội/cup → `KickOffScene` → `MatchScene` → `FinalCeleberation`.

**Không commit** `Library/`, `Temp/`, `Logs/`, `UserSettings/`, credential, token, dữ liệu người chơi thật.

## 3. Chạy test

`Window → General → Test Runner`:

- **EditMode**: toàn bộ domain thuần C# (Match Core, Catalog, Player Items, Squad rules, Competition, Localization/Settings). Baseline 102 case pass; P1-06 thêm 71 case chưa chạy lần đầu.
- **PlayMode**: Quick Match/Cup regression, Settings UI, Catalog Addressables, Player Items diagnostic. Baseline 19 case.

Trước khi chạy PlayMode: lưu mọi scene đang dirty. Sau khi chạy: console không được có lỗi mới.

Fixture dùng chung:

- Catalog hư cấu: `CatalogFixtureFactory.Create()` (2 giải, 4 CLB, 44 cầu thủ, catalog version `202607160001`).
- Squad rules: `Assets/SoccerMobilePro/Runtime/PlayerItems/Fixtures/SquadRulesFixture.json` (rules version `000000000106`, `claimStatus: hypothesis`).

## 4. Quy ước Git tối thiểu

- Làm việc và push trực tiếp lên `origin/main` sau mỗi lô hoàn tất, trừ khi chủ dự án yêu cầu nhánh/MR.
- Prefix commit: `feat:` `fix:` `test:` `perf:` `docs:` `chore:`. Không gộp docs + gameplay + asset + package vào một commit.
- Đổi trạng thái item trong `TODO.md` phải nằm **cùng commit** với code/docs gây ra thay đổi đó.

Chi tiết đầy đủ: [Quy trình làm việc](quy-trinh-lam-viec).

## 5. Đọc gì trước khi sửa code

1. [`AGENTS.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/AGENTS.md) — luật làm việc của repo.
2. [`TODO.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/TODO.md) — item nào đang mở, lô nào kế tiếp.
3. Nhật ký triển khai của hệ thống liên quan trong [`docs/implementation/`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/tree/main/docs/implementation) — mỗi nhật ký ghi rõ quyết định, sai khác so với kế hoạch và cổng chưa đạt.
