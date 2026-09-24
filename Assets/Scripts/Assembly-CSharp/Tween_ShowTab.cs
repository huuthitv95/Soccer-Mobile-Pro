public class Tween_ShowTab : WindowTweenBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color maskMidColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color maskStartColor2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color maskEndColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image mask;
    [global::UnityEngine.SerializeField]
    private bool autoRegist;
    [global::UnityEngine.SerializeField]
    private bool generateMask;
    private void Awake()
    {
    }

    public override global::DG.Tweening.Sequence CreateSequence()
    {
        return null;
    }
}