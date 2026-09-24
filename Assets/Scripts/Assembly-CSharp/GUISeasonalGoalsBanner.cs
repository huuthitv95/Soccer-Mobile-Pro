public class GUISeasonalGoalsBanner : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform root;
    [global::UnityEngine.SerializeField]
    private ColorParamsHolder2 colorParamsHolder;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text goalDesc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text goalProgress;
    private const float SlideInDuration = 0.3f;
    private const float StayDuration = 1.2f;
    private const float SlideOutDuration = 0.25f;
    private const float HiddenRightPadding = 40f;
    private const float HiddenUpOffset = 120f;
    private global::UnityEngine.CanvasGroup canvasGroup;
    private global::DG.Tweening.Sequence sequence;
    private global::UnityEngine.Vector2 shownPosition;
    private bool shownPositionInitialized;
    public bool Play(global::System.Collections.Generic.IList<SeasonMissionProgressUpdate> updates, global::System.Action onComplete)
    {
        return false;
    }

    public void Stop()
    {
    }

    public void HideImmediately()
    {
    }

    private void OnDisable()
    {
    }

    private void Fill(SeasonMissionProgressUpdate update)
    {
    }

    private void ResetToHiddenRight()
    {
    }

    private void EnsureCanvasGroup()
    {
    }

    private void InitShownPosition()
    {
    }
}