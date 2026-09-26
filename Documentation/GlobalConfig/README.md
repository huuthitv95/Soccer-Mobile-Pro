# Offline recovery milestone: Boot → Start → Lobby → GlobalConfig

This milestone runs in **Unity Editor 2020.3.49f1**. Open **Recovery → Open Lobby Recovery**, enter Play Mode, press **BẮT ĐẦU**, then open **Cấu hình offline** in Lobby. Real cloud/account/IAP services and gameplay remain unrecovered. This is not an Android build-readiness claim.

## What GlobalConfig restores

`Win_GlobalConfig` is a functional offline replacement, not the original class implementation. Its global type name, `Assembly-CSharp` assembly and script GUID `6b28ac2d25f6486b3da95bd206b9d665` match the surviving MonoScript identity. The original prefab is byte-identical; the GUID now resolves to the replacement. Only the recovery Lobby creates and initializes the panel.

Four editable recovery settings have implemented consumers: profile banner visibility, panel opacity (0.65–1.00), profile label (1–32 characters), and accent color. Save applies and persists them; Cancel discards edits; Defaults changes the draft until saved. Search filters rows. Five native-looking settings remain read-only and unsupported.

The version-1 JSON file lives at `Application.persistentDataPath/Recovery/global-config-v1.json`. Writes use a temporary file and replacement. Invalid or unsupported-version files are preserved and defaults are used; write failure leaves the applied settings unchanged. No original game save or cloud configuration is modified.

## Evidence and limits

The original component is 108 bytes: 32 bytes of known Unity header plus **76 bytes without a verified field layout**. Neither matching metadata/dummy assemblies nor independent bundle parsing recovered the class schema or behavior. Shared type hashes and `FLTest.GlobalConfig.SimpleConfig` do not prove this component's fields or inheritance. Reopen native-schema investigation only when new matching source, DLL, typed bundle, development build or equivalent evidence becomes available.

Small evidence files are under [Evidence](Evidence/): independent asset audit, parser comparison, assembly comparison and source hashes. [The historical investigation report](Evidence/FINAL-REPORT.md) records the prior analysis, runtime limitations and seven passing GlobalConfig tests; its test results predate the unified validator. Large binary/database/runtime artifacts remain in `Soccer-Unity-Recovery/Runs/GlobalConfig-Final-20260925-222110`, outside imported Assets.

## Reproduce the complete validation

Close this project's Editor; the runner refuses to stop an open Editor. From the sibling APK/tools repository:

```powershell
.\Test-MilestonePipeline.ps1
.\Recover-SoccerUnity.ps1 -ValidateLobbyFlow
```

Requirements: Windows PowerShell 5.1, Git, Python 3.11+ (snapshot uses only the standard library), installed Unity 2020.3.49f1 and its existing local license/.NET toolchain. No new service, cloud CI or secret is required. `-StageTimeoutSeconds` bounds each child stage; the Boot wrapper receives their combined budget.

The single entry point validates compile/assets, **4 UI + 12 Boot + 13 Lobby + 7 GlobalConfig = 36 tests**, Boot/Lobby traces, four UI screenshots and the GlobalConfig Lobby screenshot. Missing/skipped/failed tests, malformed XML, wrong suite, duplicate test identities, failed Unity logs, missing images, nonzero exit or timeout fail the run. The Boot report path is emitted as `Boot validation report: <absolute path>` and accepted only with the matching project, Unity version, unique validation ID, passing status and zero asset issues.

Read the exact path printed as `Lobby validation report: ...`. Its `lobby-validation.json` includes per-suite success/counts, `totalPassedTests`, `artifacts` (XML/log/image paths), `baseReport`, and `sourceSnapshotBefore`/`sourceSnapshotAfter`. Snapshots record both Git HEADs, dirty/untracked file lists and SHA-256 hashes of nonignored working-tree files. A changed input or original-prefab hash fails validation. Source snapshots and full logs stay outside the repos.

The seven GlobalConfig tests cover pointer interaction/search/read-only fields, save and reload of all four settings, invalid values, cancel/default transactions, corrupt/future JSON preservation, storage failure, and original-prefab identity plus Lobby integration. Synthetic pipeline checks also exercise stale/wrong reports and bounded process failure. View `globalconfig-lobby.png` as the visual handoff artifact.

## Review and rollback

Review the coordinated changes in both repos together. Preserve the replacement source and its `.meta` as a pair, the runtime/test assembly dependencies, and the Lobby prefab reference. Restore only deliberately selected files from an earlier reviewed snapshot with Unity closed; do not remove the GUID binding in isolation or overwrite existing recovery work. Build Settings, original scenes, packages and Unity version are unchanged. Nothing is published automatically.

## Fresh verification — 2026-09-26

[validation.json](validation.json) records a fresh unified pass: **36/36 PlayMode tests**, zero missing scripts/asset issues, plus **41 synthetic pipeline checks** and six mode-exclusivity pairs/overwrite refusal. All 71,193 fingerprinted working-tree files were unchanged during validation. The original prefab hash matches the preserved baseline. See [asset-integrity.json](asset-integrity.json) for baseline and protected-path checks.

The exact run is `LobbyValidation-20260926-054028-bcfa3b14`; its four NUnit XML results and [GlobalConfig screenshot](globalconfig-lobby.png) are copied here for review. Visual inspection confirmed the panel's editable controls, search, close/cancel/default/save buttons and unsupported-field labels render without overlapping at 1920×1080. This screenshot captures the configuration panel created in the Lobby scene, not original-game visual parity.

Only documentation/verification artifacts and Git whitespace policy were finalized after that run; runtime, validation code and serialized metadata remain the hashed versions. Full logs and both source manifests remain in the external run directory.

See [the pre-publication audit](AUDIT-20260926.md) for the cleanup scope, tooling fixes and main-only workflow.
