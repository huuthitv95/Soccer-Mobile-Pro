# uGUI runtime restoration

The implementation is restored from `com.unity.ugui@1.0.0` bundled with Unity **2020.3.49f1**, installed at `Editor/Data/Resources/PackageManager/BuiltInPackages/com.unity.ugui/Runtime`.

Roslyn parsed the source using C# 8 and matched fully qualified top-level type names and generic arity. **113 recovered types** received their upstream implementations in their existing files. One additional upstream editor helper, `UnityEngine.UI.GraphicRebuildTracker`, lives in `RecoverySupport`. No recovered type was left unmapped. Existing script `.meta` files and GUIDs were retained.

Upstream source files containing several top-level types were split into the existing per-type recovery layout, preserving namespace, imports, nested types and conditional compilation. Serialized field names were compared before writing; no recovered serialized field was absent upstream. Whole-project Unity compilation checks consumer compatibility, including recovered TMP and SoftMask.

`RecoveryTypeMap.json` records upstream paths, destination paths, original stub hashes, restored hashes and metadata hashes. These are the upstream implementations, not IL2CPP gameplay reconstruction. New editor-only helper code is conditional on `UNITY_EDITOR`.

The assembly remains `UnityEngine.UI`; its existing asmdef and GUID are retained. Package version defines for physics, physics2d, animation and tilemap are copied from the bundled runtime asmdef. No package tests or editor inspector assembly are imported. Do not install `com.unity.ugui` alongside this assembly.

The upstream copyright notices remain in the source and `LICENSE.md` accompanies the distribution. The source maps and license apply to this runtime restoration; game assets retain their original provenance.
