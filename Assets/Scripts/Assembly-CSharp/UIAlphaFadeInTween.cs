[global::UnityEngine.DisallowMultipleComponent]
public class UIAlphaFadeInTween : global::UnityEngine.MonoBehaviour, global::Game.UI.Tween.ISequentialTweenItem
{
    public global::UnityEngine.UI.Graphic target;
    public global::UnityEngine.CanvasGroup canvasGroupTarget;
    public float duration;
    public bool playOnEnable;
    public bool fromCurrentAlpha;
    public bool loop;
    public global::DG.Tweening.LoopType loopType;
    public float startDelay;
    public global::DG.Tweening.Ease ease;
    private global::UnityEngine.RectTransform _rect;
    private global::DG.Tweening.Tween _tween;
    public global::UnityEngine.RectTransform RootRect => null;

    public float StartDelay
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public global::Game.UI.Tween.SequentialTweenItemType ItemType => global::Game.UI.Tween.SequentialTweenItemType.Unknown;
    public bool IsActiveAndEnabled => false;

    private void Reset()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void Play()
    {
    }

    private void PlayGraphicAnimation()
    {
    }

    private void PlayCanvasGroupAnimation()
    {
    }

    public void Stop()
    {
    }
}