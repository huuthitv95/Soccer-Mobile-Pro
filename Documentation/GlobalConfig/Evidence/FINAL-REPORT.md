# Win_GlobalConfig final recovery report

**Result:** the original serialized schema and class behavior were not recoverable from the available APK/workspaces. The recovery project now has a working, clearly labeled offline replacement attached to the existing prefab GUID and launched from `LobbyOffline`. This is a functional replacement, not restoration of the original game's configuration or behavior.

## Preserved source evidence

- APK: `Soccer-Mobile-Pro.apk`, SHA-256 `9a3894f8db0f8a9b11e58f135c1906613e0491646671eb56f5aa2f20aebef841`.
- Original prefab was archived outside `Assets` before changes and remains byte-for-byte unchanged: SHA-256 `0d73cd094b52bc85c4bdb01680365c24b8cfeb49ee9ae2d662e2575625b10b2c` for both the project prefab and the archived copy. Its missing script reference now resolves through the restored GUID.
- Unity version stored in the bundle: literal `2020.3.49f1\n2`. Both parsers read this exact value; the meaning of suffix `2` is unknown. Class database selection used Unity `2020.3.49f1`.
- AssetsTools.NET independently read bundle `ui.unity3d`, MonoBehaviour PathID `5332196853466566746`, byte size 108, and `m_Script` PPtr `(fileID 0, PathID 4126250031869780553)`.
- The linked MonoScript was independently parsed as class `Win_GlobalConfig`, namespace empty, assembly `Assembly-CSharp.dll`, PropertiesHash `ca05a555ae91149f32dd75c7e9937305`. Its script ID hash is `32b474b53b9bd25a7cfc160d94513b98`; serialized type hash is `ca05a555ae91149f32dd75c7e9937305`.
- Type tree is disabled. The parser reads the 32-byte Unity MonoBehaviour header; 76 bytes have no verified field layout. Raw dump SHA-256 is `9d31bf90b73ed77a46e30991bb91e2e195faca5c443afac4fd2b318d3fffa10f`. The UnityPy provenance dump matches byte-for-byte and has the same SHA-256.
- MonoScript fields and raw hash were independently compared against the existing UnityPy evidence for both the component's script and the global MonoScript. All class/namespace/assembly/properties/raw-hash checks match.
- Artifact audit inventoried 1,155 files across the three workspaces and examined 35 unique serialized asset files; there were no scan errors. Eight MonoBehaviours in the UI bundle share the type hash, including `Win_Empty`, but this hash alone does not identify `Win_GlobalConfig`'s inheritance or fields.
- Il2CppDumper identifies `Win_Empty : Common.WindowBase`; this is a useful sibling lead only. It does not prove that the absent `Win_GlobalConfig` type had that same base class. The sibling parser attempt below did not recover fields or round-trip bytes.
- AssetsTools.NET's MonoCecil sibling attempt exposed only the four standard header fields; its serialized read consumed 108 bytes but its emitted value was 32 bytes and failed raw round-trip. It did not recover a schema.
- Cpp2IL and Il2CppDumper were run on the same hashed ARM64 `libil2cpp.so` and `global-metadata.dat`. Their generated Assembly-CSharp outputs contain 4,167 and 4,161 type definitions respectively, with no `Win_GlobalConfig` type. Both expose related `FLTest.GlobalConfig` types, including a separate `SimpleConfig` with five fields; that class is not evidence for the missing component's schema. Il2CppDumper reported a protection warning while completing the dump. Native IDA inspection did not produce a validated serialized layout or direct caller map; therefore no native offset was treated as a serialized field.

## Recovery implementation

- Replacement source: `Soccer-Mobile-Pro/Assets/Scripts/Assembly-CSharp/Win_GlobalConfig.cs`; global class name and `Assembly-CSharp` match the surviving MonoScript identity. Its `.meta` keeps the missing script GUID `6b28ac2d25f6486b3da95bd206b9d665`.
- Implementation: `Soccer-Mobile-Pro/Assets/Recovery/GlobalConfig/OfflineConfigWindow.cs` and `OfflineConfigStore.cs`.
- Lobby-only hookup: `GlobalConfigInstaller.cs` binds the existing `Win_GlobalConfig.prefab` in `LobbyOffline.unity`; original game scenes were not given this panel.
- The replacement's four editable values are recovery-only controls whose actual effects are implemented and tested: show/hide the profile banner, panel opacity, local profile label, and accent color. They are stored in versioned JSON below `Application.persistentDataPath/Recovery` through a temporary file and atomic replacement. Invalid/future JSON is preserved as a diagnostic backup and defaults are used. Apply, cancel, reset, filtering, and validation are supported.
- Five recovered original-looking fields are explicitly read-only and marked unsupported in the replacement. No meaning was assigned to the 76 unknown bytes, and no automatic reflection/method invocation was added.

## Verification

- Unity `2020.3.49f1` compile/asset validation succeeded with **zero missing scripts and zero asset issues**.
- GlobalConfig PlayMode tests: **7/7 passed** (`globalconfig-playmode-final.xml`). The Lobby screenshot from the Unity PlayMode test is `globalconfig-lobby.png`.
- Existing Offline UI tests: **4/4 passed** (standalone report `OfflineValidation-20260925-175956-8e9458a2/offline-validation.json`); Boot flow: **12/12 passed**; Lobby flow: **13/13 passed**. Combined report: `LobbyValidation-20260925-175036-85122e2a/lobby-validation.json`.
- The end-to-end Lobby test now waits on Unity's `sceneLoaded` event with a real-time timeout. The former frame-count wait could assert before the asynchronous editor scene load completed; the focused retest and full 13-test Lobby suite then passed.
- The APK was installed and launched in the separate LDPlayer instance `SoccerGlobalConfigFinal` (package `com.football.soccer.league`, version `0.2.16`, versionCode 216). On launch, the captured screen was black. Logcat reports Play Asset Delivery API unavailable in the emulator and a `NullReferenceException` in `ExternalDataArchives.LoadName` -> `GUITeamData.Updater` -> `MainView.Start`. Public app storage contained `commentator_vi.unity3d`; `run-as` was denied because the APK is not debuggable. This does not establish whether `Win_GlobalConfig` is loaded at runtime. The instance was shut down after capture. Offline-mode capture could not complete: after network isolation, ADB guest commands timed out again.

## Reproduction and evidence files

- `independent-assets-audit.json`, `component-5332196853466566746.bin`, `asset-comparison.json`, `same-typehash-components.json`, and `sibling-schema-candidate.json` record the parser comparison and layout limits.
- `serialized-artifact-search.json`, `artifact-inventory.json`, `assembly-comparison.json`, `Cpp2IL/`, `Il2CppDumper/`, and `Native/` preserve the search and reverse-engineering outputs.
- `runtime-online-*.txt`, `runtime-online.png`, and `runtime-online-commands.json` preserve the successful LDPlayer capture. `runtime-offline-commands.json` records offline ADB timeouts.
- Re-run independent bundle audit from `Soccer-Mobile-Pro-APK` with:

  ```powershell
  dotnet run --project .\Tools\GlobalConfigAudit\GlobalConfigAudit.csproj -c Release -- C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Recovery\Runs\GlobalConfig-Final-20260925-222110
  ```

The recovery feature is complete and tested. Original-schema recovery is concluded for the current artifact set; it should be reopened only if a matching source/DLL, development build, typed bundle, backup, or equivalent artifact becomes available.
