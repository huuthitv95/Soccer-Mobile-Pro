public class CastPlaneShadow : global::UnityEngine.MonoBehaviour
{
    internal struct ShadowInfo
    {
        public float shadowAlpha;
        public global::UnityEngine.Vector4[] lightDirs;
        public global::UnityEngine.Vector3 shadowColor;
        public float HFallOff;
        public float VFallOff;
    }

    private static CastPlaneShadow.ShadowInfo[] shadowInfos;
    private static global::UnityEngine.Material[] _shadowMaterials;
    private static global::UnityEngine.MaterialPropertyBlock _block;
    private static string _stadiumName;
    private static global::UnityEngine.Shader shadowShader;
    public static global::UnityEngine.Material[] shareMaterials => null;

    public static string StadiumName
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    private static void InitShadowMaterials(in CastPlaneShadow.ShadowInfo shadowInfo)
    {
    }

    internal static void SetShadowMaterials(in CastPlaneShadow.ShadowInfo shadowInfo)
    {
    }

    internal static void SetShadowMaterials(global::UnityEngine.Material[] materials)
    {
    }

    public static void SetShadowY(float val)
    {
    }

    private void Start()
    {
    }

    internal static CastPlaneShadow.ShadowInfo GetShadowInfoFromStadium(string activeScenePath)
    {
        return default;
    }
}