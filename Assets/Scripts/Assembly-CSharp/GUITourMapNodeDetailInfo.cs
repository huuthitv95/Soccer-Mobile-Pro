public class GUITourMapNodeDetailInfo : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct RandomNodeInfo
    {
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.GameObject node;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.RectTransform bg;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.UI.Button btnFreeDraw;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.UI.Text fatigueReward;
        [global::UnityEngine.SerializeField]
        public RewardWithVideo refreshRV;
    }

    [global::System.Serializable]
    private struct MatchNodeInfo
    {
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.GameObject node;
        [global::UnityEngine.SerializeField]
        public GUITeam homeTeam;
        [global::UnityEngine.SerializeField]
        public GUITeam awayTeam;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.UI.Text score;
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.UI.Text target;
    }

    private const float RandomEventFlipOutDuration = 0.1f;
    private const float RandomEventFlipBackDuration = 0.18f;
    private const float RandomFatigueRewardRevealScale = 1.2f;
    private const float RandomFatigueRewardRevealDuration = 0.16f;
    private const float RandomFatigueRewardScaleBackDuration = 0.12f;
    private static readonly global::UnityEngine.Color StaminaCostColor;
    private static readonly global::UnityEngine.Color StaminaRecoveryColor;
    [global::UnityEngine.SerializeField]
    private GUI26CupTourEventMapNode nodeIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text eventTypeName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rewardNumber;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] completeMarks;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hidenWhenCompleteObjects;
    [global::UnityEngine.SerializeField]
    private GUITourMapNodeDetailInfo.MatchNodeInfo matchNodeInfo;
    [global::UnityEngine.SerializeField]
    private GUITourMapNodeDetailInfo.RandomNodeInfo randomNodeInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text fatigueLimitedDesc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject normalNodeBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject finalNodeBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text randomEventRange;
    private global::FL.TourEvent.TourEventManager manager;
    private global::FL.TourEvent.TourEventChapterConfig chapterConfig;
    private global::FL.TourEvent.TourEventNodeConfig nodeConfig;
    private global::System.Action<global::FL.TourEvent.TourEventNodeConfig> onConfirm;
    private global::System.Action<global::FL.TourEvent.TourEventNodeConfig> onRefreshRandomEvent;
    private global::System.Action onClose;
    private global::UnityEngine.RectTransform rectTransform;
    private global::UnityEngine.CanvasGroup canvasGroup;
    private global::UnityEngine.Vector2 shownPosition;
    private global::UnityEngine.Vector2 hiddenPosition;
    private global::UnityEngine.Vector3 randomNodeBgDefaultScale;
    private global::UnityEngine.Vector3 randomFatigueRewardDefaultScale;
    private float randomFatigueRewardDefaultAlpha;
    private global::DG.Tweening.Sequence randomEventRevealSequence;
    private bool suppressRandomFatigueRewardRefresh;
    private bool randomEventRevealPlaying;
    public bool IsShown { get; private set; }
    public global::UnityEngine.RectTransform PanelRectTransform => null;

    public void GetRandomFatigueRewardEffectInfo(out global::UnityEngine.Vector3 worldCenter, out string text, out global::UnityEngine.Color color)
    {
        worldCenter = default;
        text = null;
        color = default;
    }

    public void GetShownWorldCorners(global::UnityEngine.Vector3[] corners)
    {
    }

    private void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    public void Show(global::FL.TourEvent.TourEventChapterConfig chapterConfig, global::FL.TourEvent.TourEventNodeConfig nodeConfig, global::FL.TourEvent.TourEventManager manager, global::System.Action<global::FL.TourEvent.TourEventNodeConfig> onConfirm, global::System.Action<global::FL.TourEvent.TourEventNodeConfig> onRefreshRandomEvent, global::System.Action onClose = null)
    {
    }

    public void Hide(bool animate)
    {
    }

    public void RefreshContent()
    {
    }

    private string BuildRandomEventRangeText(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
    {
        return null;
    }

    private void ShowAnimated()
    {
    }

    private void UpdateHeader(global::FL.EventChallengeStateHandler.ChallengeState state, bool completed)
    {
    }

    private void UpdateRewards()
    {
    }

    private void UpdateNodeTypeContent(global::FL.EventChallengeStateHandler.ChallengeState state, bool completed)
    {
    }

    private void UpdateRandomNodeInfo(global::FL.EventChallengeStateHandler.ChallengeState state, bool completed)
    {
    }

    private void UpdateMatchNodeInfo(bool completed)
    {
    }

    private string BuildMatchScoreText(bool completed, out global::FL.MomentChallenge.ChallegeTarget target)
    {
        target = default;
        return null;
    }

    private void UpdateCompletionMarks(bool completed)
    {
    }

    private void BindButtons()
    {
    }

    private void RemoveButtonListeners()
    {
    }

    private void OnCloseClick()
    {
    }

    private void OnConfirmClick()
    {
    }

    private void OnFreeDrawClick()
    {
    }

    private void OnRefreshRandomEventVideoSucceed()
    {
    }

    private void DrawRandomEvent()
    {
    }

    private void PlayRandomEventRevealAnimation(global::Srv.TourEventNodeRuntimeData runtimeData)
    {
    }

    private void KillRandomEventRevealAnimation()
    {
    }

    private void OnRandomEventRevealAnimationComplete()
    {
    }

    private void PrepareRandomFatigueRewardRevealAnimation()
    {
    }

    private void UpdateRandomFatigueReward(global::Srv.TourEventNodeRuntimeData runtimeData)
    {
    }

    private TeamsData LoadTeam(int teamId)
    {
        return null;
    }

    private string GetNodeTypeName(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
    {
        return null;
    }

    private string BuildNodeFatigueText(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
    {
        return null;
    }

    private int GetStaminaDelta(int fatigueValue)
    {
        return 0;
    }

    private string BuildSignedNumber(int value)
    {
        return null;
    }

    private global::UnityEngine.Color GetStaminaDeltaColor(int staminaDelta)
    {
        return default;
    }

    private global::UnityEngine.Color WithRandomFatigueRewardDefaultAlpha(global::UnityEngine.Color color)
    {
        return default;
    }

    private float GetPanelWidth()
    {
        return 0f;
    }

    private void SetActive(global::UnityEngine.GameObject target, bool active)
    {
    }
}