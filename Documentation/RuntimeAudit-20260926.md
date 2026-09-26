# Runtime and project audit — 2026-09-26

## Project audit

- Both repositories are on `main`: Unity `e04c5d67a`; APK/tools `07554a07e`.
- Unity is `2020.3.49f1`. The original GlobalConfig prefab hash is unchanged.
- `-ValidateLobbyFlow` passed: compile/assets passed, 36/36 PlayMode tests passed, zero asset issues and zero missing scripts. Its before/after source fingerprint matched, including the 17 pre-existing modified `LightingData.asset` files.
- `Test-BootFlowPipeline.ps1` passed its parser, six mode-exclusivity pairs and existing-project overwrite refusal.
- `Test-MilestonePipeline.ps1` stopped at line 63: `foreach ($error ...)` attempts to assign PowerShell's automatic `$Error` variable. The aggregate runner therefore did not complete its remaining synthetic checks. This audit did not alter the APK/tools repository to work around it.

## APK runtime findings

- The installed APK hash matches `9a3894f8db0f8a9b11e58f135c1906613e0491646671eb56f5aa2f20aebef841`; runtime reports package version `0.2.16`.
- The dedicated `SoccerGlobalConfigFinal` instance was the only running LDPlayer, mapped to `emulator-5560`. It was shut down after capture; no app data was cleared.
- A capture about one second after launch is black. Repeated captures show the main menu by 10.49 seconds and keep it visible at 30.39 and 60.40 seconds. The app process remains alive and its Unity activity is resumed. The earlier persistent-black conclusion was caused by capturing too early.
- Logcat still records Play Asset Delivery error `-5` (`API_NOT_AVAILABLE`), a SQLite open failure for `files/Archives/Friendly/friendly.db`, and a `NullReferenceException` in `ExternalDataArchives.LoadName` called from `MainView.Start`. These errors occur while the menu becomes visible; they are not evidence that this run crashed.
- The APK contains two UnityFS PAD payload entries (`sound`, `stadium_metlife`) and uses `asset-delivery.properties` version 2.2.1. The non-debuggable package rejects `run-as`, so private app files could not be independently inventoried. The public storage inventory and full logs are in the run archive.

## Recommended next step

Do not patch the Unity recovery harness to address the black screenshot. First verify the same APK through an install path and Android environment that support Play Asset Delivery, then compare pack state and the `friendly.db` open result. If that install path is unavailable, identify the original asset/database source before proposing a local fallback; the current evidence does not establish the database schema or a safe replacement.

Full logs, screenshots, snapshots and runtime command records: `C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Recovery\Runs\ProjectAudit-20260926-175532`.
