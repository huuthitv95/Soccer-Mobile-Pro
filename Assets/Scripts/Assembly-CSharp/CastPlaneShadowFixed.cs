public class CastPlaneShadowFixed : CastPlaneShadow
{
    private static global::UnityEngine.Material[] _shadowMaterials;
    private static global::UnityEngine.MaterialPropertyBlock _block;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.SkinnedMeshRenderer targetRenderer;
    [global::UnityEngine.SerializeField]
    private string shadowLayer;
    [global::UnityEngine.HideInInspector]
    public global::UnityEngine.SkinnedMeshRenderer shadow;
    private global::UnityEngine.Vector4[] lightDirs;
    private void Start()
    {
    }

    public void SetupShadowRootBoneForTimeline()
    {
    }

    public void SetupShadowRootBoneForMatch()
    {
    }

    public void SetupShadowDirectionForCelebration()
    {
    }

    public void SetupShadowDirectionForMatch()
    {
    }
}