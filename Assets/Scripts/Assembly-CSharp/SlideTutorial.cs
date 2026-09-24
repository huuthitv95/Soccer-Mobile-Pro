public class SlideTutorial : global::UnityEngine.MonoBehaviour
{
    public enum SlideDirection
    {
        Left = 0,
        Right = 1,
        Up = 2,
        Down = 3
    }

    private const float PressDuration = 0.15f;
    private const float SlideDuration = 0.65f;
    private const float LoopInterval = 0.35f;
    private const float SlideDistanceRatio = 0.55f;
    private const float TipSpacing = 20f;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform highlight;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text tip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform rectTransform;
    private readonly global::UnityEngine.Vector3[] _worldCorners;
    private global::DG.Tweening.Sequence _slideSequence;
    public void Show(global::UnityEngine.RectTransform target, SlideTutorial.SlideDirection direction, float extraWidth, string tipStringId)
    {
    }

    public void Hide()
    {
    }

    private void OnDisable()
    {
    }

    private void FitHighlight(global::UnityEngine.RectTransform target, float extraWidth)
    {
    }

    private void PositionTip(SlideTutorial.SlideDirection direction)
    {
    }

    private void PlaySlideAnimation(SlideTutorial.SlideDirection direction)
    {
    }

    private void KillSlideAnimation()
    {
    }

    private global::UnityEngine.Vector2 GetDirection(SlideTutorial.SlideDirection direction)
    {
        return default;
    }
}