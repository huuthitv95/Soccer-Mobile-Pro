[global::UnityEngine.DisallowMultipleComponent]
public class UIRectTransformSizeABAnimation : UIABStateAnimation
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform target;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 stateASize;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 stateBSize;
    [global::UnityEngine.SerializeField]
    private float stateADuration;
    [global::UnityEngine.SerializeField]
    private float stateBDuration;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease stateAEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease stateBEase;
    [global::UnityEngine.SerializeField]
    private bool useUnscaledTime;
    private global::DG.Tweening.Tween tween;
    protected override void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    private void Reset()
    {
    }

    protected override void PlayStateAnimation(ABAnimationState state, bool instant)
    {
    }

    protected override void StopAnimationInternal()
    {
    }

    private void KillTween()
    {
    }
}