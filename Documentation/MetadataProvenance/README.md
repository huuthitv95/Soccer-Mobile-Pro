# GlobalConfig identity and metadata provenance

**Historical investigation.** The unchanged-artifact statements and missing-script baseline below describe this provenance audit before the functional replacement was added. See [the current GlobalConfig milestone](../GlobalConfig/README.md): the original prefab remains byte-identical and its GUID resolves to an explicit offline replacement. Zero missing scripts does not establish recovery of the original 76-byte layout or class behavior. Evidence files in this directory retain their original audit meaning.

## Result

`Win_GlobalConfig` is a global-namespace type named by two byte-identical MonoScripts in the original APK, both naming `Assembly-CSharp.dll`. Identity is resolved; the component implementation is not recovered. No Assets, script GUIDs, original scenes or Build Settings were changed by this investigation.

The original `ui.unity3d` component (PathID 5332196853466566746) refers locally to MonoScript 4126250031869780553. That MonoScript matches globalgamemanagers.assets MonoScript 2212. Both have raw SHA-256 `26cc72653d7f7a47dde108de4282baf9e54a53a32513a5b144b62b2a1e6e9196`.

The component is 108 bytes, but its available type information only explains a 32-byte header. The remaining 76 bytes are retained as raw hex in the evidence. The exported YAML has no corresponding recovered field layout. A blank replacement class would conceal this loss, not restore the component. The prefab remains unchanged with its known missing script.

A direct parse of all 10,669 version-27 metadata type definitions finds no `Win_GlobalConfig`. Both recovered Assembly-CSharp DLLs independently have zero matching definitions/references across 4,161 types including nested types. The field `Common.WindowID.Win_GlobalConfig` is a string identifier, not the missing class. The original binary/metadata hashes match the APK and previous recovery inputs. Stripping and stale bundle metadata remain possible explanations; neither is proven. There is no validated class/method RVA from which to reconstruct its inheritance or body, so no arbitrary native function was relabeled as this type.

## Baseline audit

All 18,089 baseline metadata hashes match. No missing files, duplicate GUIDs or malformed GUIDs were found. There are 23 newer Lobby recovery metadata files outside this baseline.

| Classification | Count | Meaning |
| --- | ---: | --- |
| APK container path | 8,066 | Export path matches an original bundle container entry; does not prove the GUID existed before build |
| Metadata type path candidate | 3,778 | Assembly/namespace/type maps to an exported script path; source declaration equivalence is not asserted |
| Export name candidate | 2,352 | One or more serialized objects match the export name; ambiguity retained |
| Directory | 681 | Export/project directory metadata |
| Recovery-created | 29 | Files under Assets/Recovery already present in the baseline |
| Unresolved | 3,183 | No candidate from these indexes |

No GUID is labeled an original developer GUID without direct evidence. Properties hashes, CAB names and PathIDs are not treated as script GUIDs. APK container mappings are path provenance, not content-equivalence proofs. `provenanceComplete` is deliberately false even though `integrityPassed` is true.

## Evidence and reproduction

- `apk-serialized-evidence.json`: both MonoScripts, raw component, bundle containers, external-file tables and parsed metadata types.
- `metadata-provenance.json` / `.csv`: one row for every baseline metadata file; JSON retains all candidate identities.
- `summary.json`: integrity, classification counts and scan coverage. Final scan has no entry-level parser errors.
- `assembly-type-evidence.json` and `input-comparison.json`: independent assembly inspection and hash agreement.

Run from Downloads/Soccer-Mobile-Pro-APK:

```powershell
python Tools/Audit-MetadataProvenance.py --project ../Soccer-Mobile-Pro --apk Soccer-Mobile-Pro.apk --baseline ../Soccer-Unity-Recovery/Runs/LobbyFlow-20260925-075150/meta-before.json --output ../Soccer-Unity-Recovery/Runs/MetadataProvenance-Repeat
python -B Tools/Test-MetadataProvenance.py
```

The audit requires Python with UnityPy and writes only to an output directory outside the Unity project. Metadata parsing is restricted to the validated version 27 schema and checks table bounds and TypeDef tokens. Schema reference: [Il2CppDumper MetadataClass.cs](https://github.com/Perfare/Il2CppDumper/blob/master/Il2CppDumper/Il2Cpp/MetadataClass.cs).

No runtime code changed, so this investigation does not claim a new Unity runtime validation result. The prior compiler/UI/boot/Lobby results remain historical. A future component fix requires verified field layout and inheritance plus fresh Unity and regression validation.
