# Play Asset Delivery runtime check — 2026-09-26

## Scope and setup

- Used the existing LDPlayer instance `SoccerGlobalConfigPlay` at index 4. It was already present and running before this audit; no instance was created. `SoccerGlobalConfigFinal` was left untouched.
- Device reports Android 9 / API 28, model `PHZ110`. Google Play Store 53.2.23-24 and Google Play services 39.7.34-21 are installed. Android reports the Wi-Fi network as validated.
- SHA-256 comparison against the previous audit snapshot matched all 17 pre-existing modified `LightingData.asset` files.
- Google Play page: `https://play.google.com/store/apps/details?id=com.football.soccer.league`.
- Package `com.football.soccer.league` reports versionCode **216**, versionName **0.2.16**, installer `com.android.vending`, first install `2026-09-26 20:54:10` local time.
- PackageManager lists `base.apk`, `split_sound.apk`, and `split_stadium_metlife.apk` (plus arm64 and Vietnamese configuration splits). This verifies that both named pack splits are installed in this Play-sourced package. The app's private files and Play Core's in-process pack state were not directly inspected.

## Launch result

The first capture attempt had a PowerShell variable-name collision and missed the requested 10/30-second instants. It was retained as exploratory evidence. A corrected capture then force-stopped only the app process (no app data was cleared) and relaunched the same installed build on the same instance.

| Target | Actual elapsed time | Observation |
|---:|---:|---|
| 1 s | 2.19 s | Black launch screen |
| 10 s | 10.86 s | Main menu visible |
| 30 s | 30.75 s | Main menu visible |
| 60 s | 60.82 s | Main menu visible |

The Unity activity stayed resumed and the process remained alive at every capture. The corrected screenshots are `retry-t01.png`, `retry-t10.png`, `retry-t30.png`, and `retry-t60.png` in the run folder below.

## Log and storage findings

- The post-launch logcat contains no matches for `API_NOT_AVAILABLE`, `friendly.db`, `ExternalDataArchives`, `ExternalDataPacketManager`, `MainView.Start`, `PlayCore`, or SQLite-open errors. This is a finding about the captured log, not proof that no private database exists.
- Public app storage contains an empty `files/ExternalData` directory and a `bundles/commentator_vi.unity3d` file. The app-private `/data/user/0/...` tree was not inspected.
- Logcat does contain a GoogleApiManager `DEVELOPER_ERROR` / unknown-calling-package message and ad SDK errors. They did not prevent the menu from appearing in this run; they are separate from the prior PAD `API_NOT_AVAILABLE` and `friendly.db` messages.

## Assessment

The exact version 216 installed by Google Play has both PAD-named split APKs present, the prior `API_NOT_AVAILABLE` and `friendly.db` messages did not recur in the captured launch, and the main menu was visible by 10.86 seconds. This strongly points to the earlier PAD/database symptoms being associated with the sideload install path or its runtime state. The capture does not establish which of those two factors caused the difference, and it does not establish the contents or provenance of `friendly.db`.

No APK or Unity source change is justified by this evidence. If a code-level fix is considered later, first reproduce the database error with the Play-installed build or inspect the original database/asset producer. Do not add an empty database or substitute gameplay behavior based on this run.

## Evidence

Full captures, logcat, package dumps, and inventories:

`C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Recovery\Runs\PlayAssetDelivery-20260926-204944`

The per-file LightingData comparison is `lightingdata-hash-comparison.csv` in that run folder.

The prior sideload comparison is documented in `RuntimeAudit-20260926.md` and its run folder `ProjectAudit-20260926-175532`.
