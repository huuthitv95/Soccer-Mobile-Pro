public class LicensedAssetController : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct GameObjectGroup
    {
        public LicensedAssetManager.LicensedAssetType licensedAssetType;
        public global::UnityEngine.GameObject[] gameObjects;
    }

    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<LicensedAssetController.GameObjectGroup> licensedAssetGroups;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<LicensedAssetController.GameObjectGroup> permanentAssetGroups;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> fallbackAssetGroup;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> HideInfallbackGroup;
    [global::UnityEngine.SerializeField]
    private bool autoSwitch;
    [global::UnityEngine.SerializeField]
    private int offsetIndex;
    [global::UnityEngine.SerializeField]
    private static readonly string saveKey;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> cup26TempGO;
    private void ApplyLicensedAssetGroup(LicensedAssetManager.LicensedAssetType assetType)
    {
    }

    private void CheckLicenseEnable(global::System.Collections.Generic.List<LicensedAssetManager.LicensedAssetType> enabledTypes)
    {
    }

    private void Start()
    {
    }
}