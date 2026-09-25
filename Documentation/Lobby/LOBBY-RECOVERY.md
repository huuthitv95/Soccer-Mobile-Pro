# Start → Lobby offline recovery

Open **Recovery → Open Lobby Recovery**, press **BẮT ĐẦU**, then let the explicit offline profile pass through Start to Lobby. In Lobby, the five recovery menu buttons open informational panels and return to the menu.

This Editor harness targets Unity 2020.3.49f1. It reproduces the verified `UI_Load.Update` readiness boundary with synthetic gates and loads an isolated copy of the recovered `MainViewWithShop` visuals. It does not run `UI_Load`, `MainViewLoader`, `StartInit`, SceneHelper's original multi-scene behavior, gameplay, save files, or external services. Lobby action buttons are recovery overlay controls; their labels follow the IL2CPP menu names, but native PlayerCareer/legacy button prefab placement is not claimed as reconstructed.

## Binary evidence

The local ARM64 binary and metadata match the APK and earlier Il2CppDumper artifacts. [`boot-logic-evidence.json`](boot-logic-evidence.json) records relevant method RVAs, the Update gates, the Lobby scene path and both menu asset lists. Annotated ARM64 files and targeted Ghidra output are under [`Evidence`](Evidence/). The input hashes are in `Evidence/native-evidence.json`.

`UI_Load.Update` checks `resMangerInit` at offset `0x28`, `pressStart` at `0x88`, `notchInited` at `0x98`, and `WaitABTest` state at `0x9c`. `WaitABTest.CanGotoMainView` has a five-second wait/default branch. Passing those checks reaches a SceneHelper request; metadata includes `Scenes/UI/Lobby`. A separate teaching-match branch remains blocked.

`StartInit` initializes many managers, account/IAP/content integrations and platform state. It is intentionally not called by the harness. The synthetic adapter reports each prerequisite separately and remains pending without a runtime timeout, except for the verified AB-test predicate which falls back after its native five-second threshold. The test watchdog reports other pending gates.

## Asset isolation and remaining missing script

The main view prefab and 26 related lobby/button prefabs were inventoried: 52 script GUID types map to source files, with 35 serialized event methods recorded across the inventory. The recovery-only prefab copy keeps the hierarchy and UI rendering/layout, disables non-uGUI behaviours, disables original buttons and removes their persistent button callbacks. Two serialized `MainView` red-point UnityEvents remain in the copied data, but their owning `MainView` component is disabled. Original scene and prefab files are unchanged.

The missing script GUID `6b28ac2d25f6486b3da95bd206b9d665` remains unresolved. Asset mapping identifies MonoScript PathID 2212 and a similarly named string exists in dump.cs, but no managed type/assembly definition is supported by current metadata. `Win_GlobalConfig.prefab` remains untouched.

## Validation

Close the project Editor and run:

```powershell
& 'C:\Users\ZGAMESVN\Downloads\Soccer-Mobile-Pro-APK\Recover-SoccerUnity.ps1' -ValidateLobbyFlow
```

The validator runs the existing compile, four offline UI and twelve boot checks, then thirteen Lobby PlayMode tests. The expected asset baseline remains one missing script in `Assets/gamedata/ui/windows/Win_GlobalConfig.prefab`. Lobby readiness, native gate blocking, the five-second AB fallback, teaching-match rejection, transition-once behavior, both profile labels, real scene loading, EventSystem menu clicks, isolated prefab behaviours, and three fresh sessions are covered.

Lobby/play readiness does not mean the original cloud/account/IAP services or gameplay have been restored.
