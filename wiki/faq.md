# FAQ và xử lý sự cố

## Test Runner

**Hỏi: `SquadRulesContractTests` báo không tìm thấy fixture.**
Kiểm tra `Assets/SoccerMobilePro/Runtime/PlayerItems/Fixtures/SquadRulesFixture.json` đã được import (có file `.meta`). Test đọc fixture qua `Application.dataPath` + `SquadRulesFixture.AssetRelativePath`, không qua `Resources`.

**Hỏi: Test bị huỷ giữa chừng, lần sau fail vì file cũ.**
`SquadRepositoryTests` và các test file store tạo thư mục tạm trong `Path.GetTempPath()/soccer-mobile-squads/<guid>` và dọn ở `[TearDown]`. Xoá thủ công thư mục đó nếu còn sót.

**Hỏi: Vì sao test P1-06 được commit mà chưa chạy?**
Hai lô gần nhất được viết trong môi trường không có Unity Editor/compiler. Nhật ký ghi rõ điều này và giữ item ở `[~]`. **Việc đầu tiên khi mở project là chạy EditMode Run All**; nếu có lỗi biên dịch, sửa bằng commit `fix:` và ghi vào nhật ký P1-06.

**Hỏi: PlayMode fail ngẫu nhiên sau khi sửa scene.**
Lưu scene trước khi chạy; PlayMode load scene từ disk. Kiểm tra console không có lỗi trước khi chạy.

## Feature flag

**Hỏi: Tôi bật Match Core / Input mới / Squad rules nhưng game vẫn chạy legacy.**
Đúng thiết kế. Mọi foundation mới chạy sau feature flag **mặc định tắt** (`PlayerItems.SquadRules`, shadow adapter Match Core, Input contextual). Gate Runtime integration chỉ đạt khi flag bật mặc định — xem P0-01b/P0-02b trong `TODO.md`.

**Hỏi: `SquadValidator` trả `FeatureDisabled` dù đội hình đúng.**
Truyền `FixedSquadRulesFeatureFlag(true)` (test) hoặc bật flag trong adapter. Flag tắt thì validator không đánh giá gì thêm để tránh lỗi giả.

## Giao dịch và dữ liệu

**Hỏi: `StaleRevision` khi lưu đội hình.**
`SquadLineupSaveCommand` cần **cả** `ExpectedSquadRevision` (−1 nếu owner chưa có đội hình) và `ExpectedInventoryRevision`. Tải lại hai aggregate rồi gửi lại với key mới; gửi lại **cùng key** với payload khác sẽ nhận `IdempotencyConflict`.

**Hỏi: Thẻ đang `InSquad` nhưng không nằm trong đội hình nào.**
Dữ liệu từ trước B2b hoặc từ `SquadSaveService` (không đổi state). Lưu lại đội hình qua `SquadLineupSaveService`: reconciler trả thẻ thừa về `Available` trong cùng commit.

**Hỏi: File store chuyển sang chế độ chỉ đọc.**
File chính hỏng, store đã đọc `.bak` và tự khoá ghi để không đè dữ liệu người chơi. Sao lưu cả hai file, khôi phục thủ công, không xoá `.bak`.

**Hỏi: Snapshot cũ không load được.**
Codec chỉ chấp nhận schema N và N-1 (`InventoryCodec` 2/1, `CompetitionCodec` 2/1, `SquadCodec` 1/1). Ngoài cửa sổ này phải có migration riêng.

## Unity MCP / Codex

**Hỏi: Bridge Editor mất kết nối sau khi sửa script.**
Domain reload cố ý ngắt và nối lại. Chờ compile xong, chạy `unity-mcp-cli status <project>`. **Không** bấm Reconfigure hay sinh lại `.agents/skills` chỉ vì bridge tạm mất.

**Hỏi: CLI lệch phiên bển package.**
Giữ `unity-mcp-cli` = `com.ivanmurzak.unity.mcp` = `0.90.0`. Windows: `npm.cmd install -g unity-mcp-cli@0.90.0`. Endpoint duy nhất: `http://localhost:22113` trong `.codex/config.toml`.

## Git / CI

**Hỏi: Clone xong thiếu video/ảnh tham chiếu.**
Chạy `git lfs install && git lfs pull`.

**Hỏi: Wiki trên GitLab không đổi sau khi tôi sửa `wiki/`.**
Job `wiki:publish` chỉ chạy trên `main` khi biến CI/CD `WIKI_PUSH_TOKEN` tồn tại (Project Access Token, scope `write_repository`, role Developer+). Thiếu biến → job không được tạo. Đồng bộ tay:

```bash
git clone https://gitlab.com/fpt-college/Soccer-Mobile-Pro.wiki.git
rsync -a --delete --exclude .git wiki/ Soccer-Mobile-Pro.wiki/
cd Soccer-Mobile-Pro.wiki && git add -A && git commit -m "docs(wiki) sync" && git push origin HEAD:main
```

**Hỏi: Tôi sửa trực tiếp trên giao diện Wiki được không?**
Không. Lần đồng bộ kế tiếp ghi đè. Sửa trong `wiki/` của repo chính và commit `docs:`.
