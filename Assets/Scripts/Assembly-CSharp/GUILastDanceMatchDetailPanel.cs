public class GUILastDanceMatchDetailPanel : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchTitle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchRound;
    [global::UnityEngine.SerializeField]
    private GUITeam userTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam opponentTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text scoreText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchTime;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button closeButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text target;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text reward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playNode;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo refreshRV;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject finishNode;
    private global::FL.LastDanceEventManager manager;
    private global::FL.LastDanceEventManager.SlotInfo slotInfo;
    private global::System.Action<int> onChanged;
    private global::System.Action onStartSuccess;
    private global::UnityEngine.RectTransform rectTransform;
    private global::UnityEngine.CanvasGroup canvasGroup;
    private global::UnityEngine.Vector2 shownPosition;
    private global::UnityEngine.Vector2 hiddenPosition;
    public bool IsShown { get; private set; }

    private void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    public void Hide()
    {
    }

    public void Hide(bool animate)
    {
    }

    public void Bind(global::FL.LastDanceEventManager manager, global::FL.LastDanceEventManager.SlotInfo slotInfo, global::System.Action<int> onChanged, global::System.Action onStartSuccess, bool animate = true)
    {
    }

    private void UpdateTexts()
    {
    }

    private void UpdateTeams()
    {
    }

    private void UpdateButtons()
    {
    }

    private void OnPlayClick()
    {
    }

    private void OnRefreshVideoSuccess()
    {
    }

    private string Localized(string key)
    {
        return null;
    }

    private void ShowAnimated()
    {
    }

    private void ShowImmediate()
    {
    }

    private void EnsureAnimationState()
    {
    }

    private float GetPanelWidth()
    {
        return 0f;
    }
}