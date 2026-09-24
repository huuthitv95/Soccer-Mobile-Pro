public class Tween_ImageFader : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic targetGraphic;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup canvasGroup;
    [global::UnityEngine.SerializeField]
    private float fadeInDuration;
    [global::UnityEngine.SerializeField]
    private float displayDuration;
    [global::UnityEngine.SerializeField]
    private float fadeOutDuration;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease fadeInEase;
    [global::UnityEngine.SerializeField]
    private global::DG.Tweening.Ease fadeOutEase;
    private global::DG.Tweening.Tween _currentTween;
    private void Reset()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void PlayFadeAnimation()
    {
    }

    private void PlayGraphicAnimation()
    {
    }

    private void PlayCanvasGroupAnimation()
    {
    }

    public void StopAnimation()
    {
    }
}