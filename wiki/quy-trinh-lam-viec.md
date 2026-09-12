# Quy trình làm việc

> Authority: [`AGENTS.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/AGENTS.md) (tiếng Anh) và mục 3/9 của [`TODO.md`](https://gitlab.com/fpt-college/Soccer-Mobile-Pro/-/blob/main/TODO.md). Trang này tóm tắt bằng tiếng Việt; khi mâu thuẫn, `AGENTS.md` thắng.

## 1. Chín bước cho mọi task

1. **Phân loại:** research / docs / Unity implementation / bug fix / UI-UX / asset / performance / release-operations.
2. **Đọc context:** docs liên quan + script/scene/asset hiện có. Thiếu yêu cầu thì nêu giả định rõ ràng.
3. **Chọn skill hếp nhất:** Unity MCP skill trong `.agents/skills/` cho việc Editor; skill cài sẵn cho research/plan.
4. **Lên kế hoạch trước khi sửa rộng:** multi-file, kiến trúc, kinh tế, networking, cân bằng → có plan ngắn với rủi ro + acceptance.
5. **Triển khai tăng dần:** giữ hành vi đang chạy; không refactor ngoài phạm vi.
6. **Kiểm chứng:** test liên quan, console sạch, lưu scene/asset, screenshot/profiler khi cần.
7. **Tài liệu:** cập nhật `docs/` khi đổi quyết định, data contract, UI flow, control mapping, chính sách vận hành, giới hạn.
8. **Commit và push** lên `origin/main` sau mỗi lô hoàn tất.
9. **Đề xuất lô kế tiếp:** scope, phụ thuộc, rủi ro, acceptance, vì sao đây là bước giá trị nhất.

## 2. Understand brief (bắt buộc cho thay đổi không tầm thường)

Trước khi sửa code, ghi ngắn gọn trong phản hồi hoặc design note:

- Nhiệm vụ và ranh giới hệ thống.
- Module/file owner chính và trách nhiệm.
- Luồng điều khiển/dữ liệu end-to-end (UI/input → domain → persistence/network → side effect).
- State transition, invariant, serialized data, event subscription, phụ thuộc ẩn.
- Test hiện có, scene/prefab/asset liên quan, kế hoạch kiểm chứng.
- Rủi ro chính, cách rollback, mục GDD/spec phải cập nhật.

Bỏ qua chỉ khi: sửa typo docs, sửa comment một dòng, format-only, hoặc file đã map và không đổi hành vi.

## 3. Bốn gate và cách tính %

| Gate | 25% | Đạt khi |
| --- | --- | --- |
| Contract | ✓ | Spec/domain/API rõ, code domain có interface + fixture versioned. |
| Runtime integration | ✓ | Chạy trong scene/build thật, **flag bật mặc định**. |
| Automated evidence | ✓ | EditMode/PlayMode/contract test pass trên Unity Test Runner, có runner output trong nhật ký. |
| Device/Operations evidence | ✓ | Android/iOS device matrix, backend staging, rehearsal rollback. |

- `[ ]` chưa bắt đầu → `[~]` đang làm → `[x]` chỉ khi đủ 4 gate và có link evidence trong `docs/implementation/`.
- Không làm tròn lên. Parity: `Đạt` = 1, `Một phần` = 0.5.
- Cập nhật `TODO.md` **cùng commit** với thay đổi làm đổi trạng thái.

## 4. Commit convention

| Prefix | Dùng cho |
| --- | --- |
| `feat:` | Hành vi gameplay/product mới |
| `fix:` | Sửa lỗi |
| `test:` | Chỉ test |
| `perf:` | Hiệu năng **có số đo** |
| `docs:` | GDD, research, spec, operations, nhật ký, TODO, wiki |
| `chore:` | Tooling/cấu hình/CI |

Commit nhỏ, mô tả rõ. Không gộp docs + gameplay + asset + package. Mỗi lô (B1, B2, …) commit riêng.

## 5. Nhãn bằng chứng nghiên cứu

| Nhãn | Ý nghĩa |
| --- | --- |
| **Thông tin công khai đã xác minh** | Nguồn chính thức/công khai đáng tin, kèm URL và ngày truy cập. |
| **Quan sát từ video** | Thấy trực tiếp trong video, kèm tên video và timestamp. |
| **Suy luận thiết kế** | Diễn giải hợp lý, không phải xác nhận kiến trúc nội bộ của bên thứ ba. |
| **Đề xuất cho Soccer Mobile Pro** | Quyết định của dự án, không gán cho EA/Garena/Nexon. |

Khi research đổi quyết định: cập nhật file Markdown liên quan và ghi chú nguồn/độ chắc chắn **trong cùng change set**.

## 6. Luật an toàn

- Không commit credential, token, receipt, PII, dữ liệu người chơi thật.
- Không sửa `ProjectSettings/` hay `Packages/manifest.json` khi chưa nêu tương thích + tác động test + rollback.
- Không xoá asset/scene/script/data khi chưa kiểm tra reference và có đường rollback.
- Không thêm random-pack monetization khi chưa có odds công bố, age/privacy review, entitlement reconciliation và quyết định compliance.
- Không tạo thư mục `tools/` hay script helper dài hạn cho validate Markdown/knowledge graph.

## 7. Definition of Done

Hành vi/tài liệu khớp GDD/spec · scope và giả định rõ · scene/asset đã lưu, console không lỗi mới · test pass hoặc fail có giải thích + bước kế · UX có loading/empty/error/accessibility · perf có số đo · docs cập nhật · `git status` sạch sau commit + push `origin/main`.
