# Repository workflow

- Work, commit and push directly on `main`. Do not create feature/recovery branches unless the user explicitly requests one.
- Preserve existing user changes. Never force-push `main` or rewrite published history.
- Unity version is 2020.3.49f1. Preserve asset `.meta` GUIDs, original scenes and the current package set.
- This is an offline Editor recovery harness. Do not describe replacement behavior or compiling stubs as recovered original gameplay/services.
- Validate runtime changes through the sibling Soccer-Mobile-Pro-APK repository's `Test-MilestonePipeline.ps1` and `Recover-SoccerUnity.ps1 -ValidateLobbyFlow`; close the project Editor first without forcibly stopping a user's session.
- Keep full logs, binary analysis databases and backups in the sibling Soccer-Unity-Recovery directory. Retain small, intentional evidence under Documentation.
- Clean only explicitly identified generated paths. Preserve Library, IDE settings, original artifacts and recovery evidence unless the user requests their removal.
