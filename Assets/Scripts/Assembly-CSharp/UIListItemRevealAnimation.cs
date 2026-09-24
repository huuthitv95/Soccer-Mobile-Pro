[global::UnityEngine.DisallowMultipleComponent]
public class UIListItemRevealAnimation : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    public struct Settings
    {
        public float StartScale;
        public float PeakScale;
        public float FadeDuration;
        public float PopDuration;
        public float SettleDuration;
        public global::DG.Tweening.Ease FadeEase;
        public global::DG.Tweening.Ease PopEase;
        public global::DG.Tweening.Ease SettleEase;
        public bool ScrollToStart;
        public static UIListItemRevealAnimation.Settings Default => default;
    }

    [global::UnityEngine.SerializeField]
    private float startScale;
    [global::UnityEngine.SerializeField]
    private float peakScale;
    [global::UnityEngine.SerializeField]
    private float fadeDuration;
    [global::UnityEngine.SerializeField]
    private float popDuration;
    [global::UnityEngine.SerializeField]
    private float settleDuration;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease fadeEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease popEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease settleEase;
    [global::UnityEngine.SerializeField]
    private bool scrollToStart;
    private global::UnityEngine.Coroutine coroutine;
    private global::DG.Tweening.Sequence sequence;
    private global::UnityEngine.RectTransform rectTransform;
    private global::UnityEngine.CanvasGroup canvasGroup;
    private global::UnityEngine.Vector3 defaultScale;
    private float defaultAlpha;
    public void ApplySettings(UIListItemRevealAnimation.Settings settings)
    {
    }

    private void OnDisable()
    {
    }

    public bool Prepare(global::UnityEngine.Transform item)
    {
        return false;
    }

    public void Play(global::UnityEngine.Transform item, global::UnityEngine.Transform listRoot = null)
    {
    }

    public void Stop(bool reset)
    {
    }

    private global::System.Collections.IEnumerator PlayAfterLayout(global::UnityEngine.Transform item, global::UnityEngine.Transform listRoot)
    {
        return null;
    }

    private void ScrollToStart(global::UnityEngine.Transform listRoot)
    {
    }

    private void ResetState()
    {
    }
}