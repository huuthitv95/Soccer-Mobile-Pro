# Friendly database provenance and PAD comparison — 2026-09-26

## Result

**The analyzed original ARM64 game binary implements `friendly.db` as a locally created SQLite save archive.** It builds the archive from an in-memory `Srv.FriendlyData` root, creates tables, and serializes root/player/team/match data. Neither inspected PAD payload supplies a standalone database. This establishes a local producer; it does not establish when either installation first saved a database, the provenance of every value in the save, or the contents of private storage.

The sideload failure is in the **existing-archive read/open path**, before schema validation. Its logged SQLite error precedes the logged PAD error. There is no evidence that downloading `sound` or `stadium_metlife` would repair that database-open failure. The precise reason SQLite cannot open the path remains unresolved within this audit's access constraints.

An additional comparison limit was found: **versionCode 216 does not imply byte-identical code**. Metadata and both pack payloads match, but several DEX files differ. The Play native configuration split was outside the authorized three-file pull, so native equality with Play remains unverified.

## Scope and preservation

- Unity repository baseline: `main`, `646cd5aaca2e4ac81e79c54517cd72c0bdc4bae9`.
- APK repository baseline: `main`, `07554a07e844f37e802ddf98fc706900aeec4afa`.
- Only existing LDPlayer index 4, `SoccerGlobalConfigPlay`, was addressed for package information and public installed-APK reads. PackageManager reports `216` / `0.2.16`, installer `com.android.vending`. Only `base.apk`, `split_sound.apk`, and `split_stadium_metlife.apk` were copied successfully.
- No instance was created. Before/after instance lists match, including running Play index 4 and stopped `SoccerGlobalConfigFinal` index 3. No app launch, reinstall, data clearing, private app-storage read, root, hook, or patch was performed in this audit.
- All **17/17** pre-existing modified `LightingData.asset` hashes match. All **5/5** original binary/metadata/IDA/payload input hashes match after analysis. The original IDA database was preserved; IDA worked on its run-folder copy. Ghidra processed the existing analysis project with `-readOnly -noanalysis`, discarding database changes.
- Working-tree comparison after analysis matched the baseline. The only intentional repository addition is this report. APK/source/Unity/package/schema changes and test/build runs were not performed.

Evidence root, referred to as `RUN` below:

`C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Recovery\Runs\FriendlyDatabase-20260926-225435`

## APK, payload, database, and runtime evidence

| Layer | Observed | What it establishes / limit |
|---|---|---|
| Installed APKs | Version 216; installer `com.android.vending`; both pack splits listed and readable | Installation inventory, not an in-process PAD location result |
| `sound` payload | SHA-256 identical in original APK, extracted sideload asset, and Play split | Same 9,806,497-byte UnityFS payload; 60 AudioClip objects and one AssetBundle object |
| `stadium_metlife` payload | SHA-256 identical across those sources | Same 7,906,162-byte UnityFS payload; scene/model/texture and related objects |
| Database inventory | No ZIP entry named `friendly` or ending `.db` in original APK or three pulled APKs; neither inspected pack has TextAsset objects or a standalone DB entry | No packaged `friendly.db` found in the inspected inventories; not a recursive exclusion of every possible encoded value in all base assets |
| IL2CPP metadata | Play base metadata matches original APK and analyzed metadata | Names/signatures/field offsets match; metadata alone does not establish identical native method bodies |
| Native implementation | Analyzed ARM64 `libil2cpp.so` hash matches original APK entry | Native findings apply directly to that original APK; Play base has no `lib/` entries and its ARM64 split was not pulled |
| DEX | `classes.dex`, `classes2`, `classes5`, `classes6`, `classes8` match; `classes3`, `classes4`, `classes7` differ; original also has `classes9.dex`, absent from Play base | Same version is not a controlled code-identical comparison; source of differences was not established |
| Runtime PAD | Previous sideload capture logs service error `-5` / `API_NOT_AVAILABLE`; previous Play capture lacks that error | No direct return value from app `getPackLocation()` was captured |
| Runtime DB | Previous sideload capture logs the failing private path; previous Play capture lacks the exception | Neither database's existence/content was directly inspected; menu visibility does not prove DB health |

SHA-256 reference values:

| Artifact | SHA-256 |
|---|---|
| Original `Soccer-Mobile-Pro.apk` | `9a3894f8db0f8a9b11e58f135c1906613e0491646671eb56f5aa2f20aebef841` |
| Original ARM64 `libil2cpp.so` | `e49404a390fa4e7ac1a3bc212c4b29bee0408d9d6af5ff8d9bc7ff9e6b7d5c07` |
| `global-metadata.dat` | `77f9d35d5db3025cd9bfa72f75fa5b251eebdcf186035f0d4fbe3cbb7d88826e` |
| UnityFS `sound` | `e987aa5b7405e92fbb02fb24fb7d9abcb6eb9d46028a54816e0dd9705ba6b489` |
| UnityFS `stadium_metlife` | `8c7b90b4dabcfad71bd52fdda2295a013ef16af3345850b01c14ef039777beb5` |

Complete pulled-APK/Dex hashes and comparison results are in `apk-comparison.json`; payload comparisons and inventories are separate files in RUN.

## Native lifecycle

Addresses below are original IL2CPP RVAs. Ghidra's imported image uses an additional `0x100000` base; annotated exports normalize method labels to RVAs. DummyDll/dump.cs supplied names, signatures, enums and field offsets only. Statements about behavior come from native instructions/decompilation.

| Step | Method / RVA | Native evidence |
|---|---|---|
| Construct archive | `LocalArchivesManager..cctor`, `0xD0FD5C`; `FriendlyDataLocalArchives..ctor`, `0xE0CEBC` | Creates a Friendly archive named `friendly`; allocates a `Srv.FriendlyData` root and configures the base archive |
| Resolve path | `LocalArchives.get_basePath`, `0xD06698`; `get_databasePath`, `0xD069F4` | Uses `PlayerSetting.Savepath` (static offset `0x18`), `/Archives/`, archive type, file name and `.db`; Friendly resolves to `<Savepath>/Archives/Friendly/friendly.db` |
| Discover existing archives | `LocalArchivesManager.LoadFromFile`, `0xD0A200`; `Load`, `0xD096E4` | Creates missing archive directories; enumerates `.db`, legacy `.dat`/`.bk`, and an external `.ext` fallback; `.db` entries go through `ReadRootPayload`. Legacy import can call `Save` |
| Read existing database | `ArchiveSqliteStore.ReadRootPayload`, `0x1116050` | Requires a valid path and checks `System.IO.File.Exists`; a missing path throws before SQLite open. Otherwise opens, checks schema version, then reads required root |
| Open for read workflow | `OpenForReadWithRecovery`, `0x1116278` | Calls SQLiteConnection constructor with flag `2` (`ReadWrite`), without `Create`; despite its name, this small method does not implement a separate recovery fallback |
| Persist current archive | `LocalArchives.SavePendingChanges`, `0xD07AE8`; `ArchiveSqliteStore.Save`, `0x1117EA8` | Supplies database path and root/layout/dirty data, creates parent directory; new database uses a `.tmp` path and flags `6` (`ReadWrite | Create`), then moves completed file to final path; existing database uses flag `2` |
| Create and populate schema | `CreateSchema`, `0x1119160`; save transaction callback, `0xDA5C68` | Creates `archive_blob`, `player_blob`, `team_blob`, `match_blob`, sets schema user_version 1; serializes root without split entity data and writes root row `id=1` plus entity blobs |

The save transaction includes `INSERT OR REPLACE INTO archive_blob (id, payload) VALUES (1, ?)`. This is direct producer evidence for a structured local archive, not just a string containing a database filename. The inspected constructor initializes a data root; the save persists current state. The origin of all gameplay/team/player values later added to that root was not exhaustively traced.

IDA and Ghidra agree on the core existence check, SQLite open flags, path construction, and local save/schema path. Raw IDA assembly exports are retained. Some large decompilations have exception-handling, function-boundary, tail-call and shared-generic naming artifacts; annotated pseudocode is an analysis aid, not recovered compilable C#. Initial failed/partial exports remain in RUN; use `ida-fixed-*`, `asm-*`, and final `ghidra.c.txt` / `ghidra-0x*.txt` for this report.

## PAD wrapper and startup order

JADX output from the pulled Play base is under `RUN/Java`. The adapter `com.unity3d.player.a` obtains its manager through `AssetPackManagerFactory`; its path accessor calls `getPackLocation(str)` and returns an empty string if null, otherwise `assetsPath()`. Fetch/state callbacks propagate pack state and error codes. The inspected wrapper/adapter take pack names as arguments; actual `sound` and `stadium_metlife` names are evidenced by package paths and payloads. This static accessor is not evidence of either runtime return value.

The `PlayAssetDeliveryUnityWrapper` decompilation contains unresolved/decompiler artifacts, including an incompletely reconstructed initialization path. Its class-availability checks cannot by themselves explain the captured Play Core service error `-5`, nor establish which wrapper path the game exercised. No Java wrapper patch is justified.

`PlayerSetting.LoadSavePath` (`0x12BA918`) calls, in order:

1. `PlayerSetting.Load` (`0x12BAB7C`), which calls `LocalArchivesManager.LoadFromFile`.
2. Firebase dependency setup.
3. `ExternalDataPacketManager.Load`.
4. `ExternalDataArchives.Load` (`0xEA789C`), leading to its file-load/agent setup (`0xEA78F4`).

`ExternalDataArchives.LoadName` (`0xEA840C`) checks the static agent and raises a null-reference exception if absent. It is reached through `ExternalDataPacketManager.LoadName` (`0xEAB914`) and `EditableName.get_Value`; the captured stack continues through GUI team/challenge updates to `MainView.Start`.

**Supported hypothesis, not a proven runtime causal chain:** the earlier archive-load exception may prevent the later agent initialization in `LoadSavePath`, leaving the subsequent name lookup without an agent. A direct runtime observation of the agent and exception propagation was not collected. There is no established causal edge from PAD failure to the database open.

## Prior captures and the unresolved open failure

The sideload log contains two consistent sequences:

| Capture sequence | SQLite `CannotOpen`, errno 2 | PAD `onError(-5)` | `ExternalDataArchives.LoadName` null-reference stack |
|---|---|---|---|
| First | `18:09:08.426` | `18:09:08.578` | `18:09:11.150` |
| Second | `18:11:51.481` | `18:11:51.618` | `18:11:53.768` |

SQLite's reported path is `/data/user/0/com.football.soccer.league/files/Archives/Friendly/friendly.db`. The stack is SQLiteConnection constructor → OpenForReadWithRecovery → ReadRootPayload → LocalArchivesManager.Load → LoadFromFile → PlayerSetting.Load. Thus the observed failure happens before reading root/schema data, and the PAD error is logged 137–152 ms later.

The native existence guard is important: the open call is reached after `File.Exists` succeeds in the analyzed implementation. `errno=2` therefore cannot safely be reduced to “the APK lacks friendly.db.” Possible explanations still include a path/state change between calls, different managed/native filesystem behavior in the emulator, or installation/code differences. None was established. No empty database, automatic deletion, or create-on-read change is justified.

The previous Play capture shows the menu at +10.86 seconds and no matching SQLite/PAD/name-lookup errors during that capture. A fresh installation with no saved archives could also avoid the existing-DB read branch. This is a hypothesis, since private data was not read. See [Play runtime audit](PlayAssetDeliveryAudit-20260926.md) and [sideload runtime audit](RuntimeAudit-20260926.md).

## Completion and next priority

The provenance objective is complete to the permitted evidence boundary: a concrete local database producer, path, schema writer, failing open site, and separated PAD comparison are documented. The exact sideload open-failure cause is still blocked by missing evidence:

1. Play ARM64 native binary equality has not been checked, and DEX differences have not been localized to classes/methods.
2. No before-open managed/native path observations or file/parent state from the failing installation are available; private storage remains out of scope.
3. No direct `getPackLocation()` results or startup agent-state observations are available.

**Next priority:** statically trace `SQLiteConnection` → connection-string/path handling → the `libgilzoide-sqlite-net.so` open bridge, and localize the differing DEX code relevant to startup/PAD. Use existing artifacts and the same preservation rules. This can narrow the managed/native open discrepancy without changing the installed app or exposing private saves. If it remains inconclusive, define the minimal additional observation needed before requesting any broader access. No APK/Unity fix is proposed until a concrete cause is established.

## Evidence index

- Input/preservation: `inputs-before.csv`, `inputs-comparison.csv`, `lighting-before.csv`, `lighting-comparison.csv`, before/after git snapshots and instance lists.
- Package acquisition: `package.txt`, `apk-paths.txt`, `pull.log`; copies of the three permitted APKs.
- Packaging: `apk-comparison.json`, `payload-comparison.json`, `*-inventory.json`, `unityfs-inventory.json`.
- Analysis: original binary/metadata/payload copies, copied IDA database, `methods.json`, `direct-call-edges.json`, raw/final IDA and Ghidra exports, Java exports, tool logs and helper scripts.
- Prior runtime source logs: `ProjectAudit-20260926-175532/runtime/runtime-repeat.logcat` and `PlayAssetDelivery-20260926-204944/retry-logcat-after.txt`; copied into this run with source paths/hashes in `runtime-source-manifest.csv`.
