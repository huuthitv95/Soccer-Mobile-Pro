public class Tween_ShowTopBtn : WindowTweenBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color maskStartColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color maskEndColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image mask;
    [global::UnityEngine.SerializeField]
    private bool autoRegist;
    [global::UnityEngine.SerializeField]
    private bool generateMask;
    private static global::UnityEngine.Material MaskMaterial;
    private void Awake()
    {
    }

    public override global::DG.Tweening.Sequence CreateSequence()
    {
        return null;
    }
}