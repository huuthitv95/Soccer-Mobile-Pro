public class ClickExtension : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
    public enum ClickEffectType
    {
        None = 0,
        Scale = 1,
        CanvasGroupAlpha = 2
    }

    public bool hasSFX;
    public ClickExtension.ClickEffectType clickEffectType;
    [global::UnityEngine.SerializeField]
    private SoundID soundId;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform target;
    [global::UnityEngine.SerializeField]
    private float scaleRatio;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup canvasGroup;
    [global::UnityEngine.SerializeField]
    private float pressedAlpha;
    [global::UnityEngine.SerializeField]
    private float alphaDuration;
    private global::UnityEngine.Vector3 localScale;
    private float localAlpha;
    private global::DG.Tweening.Tween clickEffectTween;
    private global::UnityEngine.UI.Selectable selectable;
    private global::UnityEngine.UI.Button button;
    private global::UnityEngine.RectTransform rectTransform;
    private bool press;
    private bool clickEffectApplied;
    public global::System.Action uninteractiveAction;
    private void Start()
    {
    }

    private void OnDisable()
    {
    }

    public void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private bool PlayClickEffect()
    {
        return false;
    }

    private void ResetClickEffect(bool immediate = false)
    {
    }

    private void FadeCanvasGroup(global::UnityEngine.CanvasGroup group, float alpha)
    {
    }

    private void SetCanvasGroupAlpha(global::UnityEngine.CanvasGroup group, float alpha)
    {
    }

    private void KillClickEffectTween()
    {
    }

    private global::UnityEngine.CanvasGroup GetCanvasGroup()
    {
        return null;
    }

    private void EnsureTarget()
    {
    }

    private bool CheckHit(global::UnityEngine.RectTransform rect, global::UnityEngine.EventSystems.PointerEventData eventData)
    {
        return false;
    }
}