# Soccer-Mobile-Pro

Offline UI milestone: see [opening instructions, controls and validation](Documentation/OFFLINE-UI.md). The isolated scene uses functional uGUI restored from the installed Unity 2020.3.49f1 source; original gameplay remains stubbed.

Recovered Unity asset/type project for **Unity 2020.3.49f1**. Gameplay method bodies remain stubs; compilation does not mean functional gameplay recovery. Original export provenance is Unity 2022.3, so asset compatibility requires separate validation.

Clone with Git LFS installed, run `git lfs pull`, and open this repository with Unity 2020.3.49f1. Keep the local directory named `Soccer-Mobile-Pro`. In Unity Preferences > External Tools, choose Visual Studio and regenerate project files to create `Soccer-Mobile-Pro.sln`. Solution and C# project files are generated locally and are not tracked.

`Assets` includes recovered assets, source and GUID metadata; `Packages` and `ProjectSettings` define the editor project. `AuxiliaryFiles` retains original assembly and asset mapping evidence outside Unity's imported directories.

Recovered UI, TextMeshPro and Timeline assemblies already live under `Assets/Scripts`. Do not also install `com.unity.ugui`, `com.unity.textmeshpro` or `com.unity.timeline`: they introduce duplicate assembly definitions and block compilation.

Decompiled Android source, the APK, recovery automation and tests are maintained at https://github.com/huuthitv95/Soccer-Mobile-Pro-APK.

Local layout:
- Unity: `C:\Users\ZGAMESVN\Downloads\Soccer-Mobile-Pro`
- APK/tools: `C:\Users\ZGAMESVN\Downloads\Soccer-Mobile-Pro-APK`
- Backups and reports: `C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Recovery`

Close this project's Editor before validation:

```powershell
& 'C:\Users\ZGAMESVN\Downloads\Soccer-Mobile-Pro-APK\Recover-SoccerUnity.ps1' -ValidateOnly
```

Historical APK source commits remain in this repository's history. Current Android source development belongs in the APK repository above. Recovery logs and machine-specific caches are kept locally.

Validation after relocation (2026-09-24): Unity 2020.3.49f1 compiled successfully with no editor errors; all 18,054 original GUIDs were preserved and 35,429 asset/source/metadata files retained their hashes. `Soccer-Mobile-Pro.sln` contains 65 generated project entries. The remaining pre-existing missing script is in `Assets/gamedata/ui/windows/Win_GlobalConfig.prefab`; gameplay remains stubbed. Local detailed report: `Soccer-Unity-Recovery/Runs/20260924-141607-d84a8791/Reports/recovery.json`.
