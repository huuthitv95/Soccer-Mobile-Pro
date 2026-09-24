[global::UnityEngine.DisallowMultipleComponent]
public class GUINegotiationResultEffect : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup canvasGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image background;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image successIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image failedIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform iconRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color succeededColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color failedColor;
    [global::UnityEngine.SerializeField]
    private float fadeInDuration;
    [global::UnityEngine.SerializeField]
    private float holdDuration;
    [global::UnityEngine.SerializeField]
    private float fadeOutDuration;
    [global::UnityEngine.SerializeField]
    private float stateSwitchTime;
    [global::UnityEngine.SerializeField]
    private float startScale;
    [global::UnityEngine.SerializeField]
    private float peakScale;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease fadeInEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease iconPopEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease fadeOutEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease iconRecoverEase;
    private global::UnityEngine.Vector3 iconDefaultScale;
    private bool iconDefaultScaleCached;
    private global::DG.Tweening.Sequence sequence;
    public bool Play(bool succeeded, global::UnityEngine.GameObject linkTarget, global::System.Action onStateSwitch, global::System.Action onComplete, float durationScale = 1f)
    {
        return false;
    }

    public void Hide()
    {
    }

    private void OnDestroy()
    {
    }

    private void Awake()
    {
    }

    private void CacheDefaultScale()
    {
    }

    private void Prepare(bool succeeded)
    {
    }

    private void ResetState()
    {
    }

    private void Kill()
    {
    }
}