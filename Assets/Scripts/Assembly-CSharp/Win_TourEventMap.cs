public class Win_TourEventMap : global::Common.WindowBase
{
    public class OpenParameter
    {
        public global::FL.TourEvent.TourEventManager Manager;
        public int ChapterId;
    }

    private const float DetailPanelNodeGap = 220f;
    private const float ChapterCompletionRewardOffsetY = -252f;
    private const float FatigueTextChangedScale = 1.18f;
    private const float FatigueTextScaleUpDuration = 0.12f;
    private const float FatigueTextScaleBackDuration = 0.18f;
    private const float FatigueTextColorBackDuration = 0.35f;
    private static readonly global::UnityEngine.Color FatigueTextGainColor;
    private static readonly global::UnityEngine.Color FatigueTextCostColor;
    [global::UnityEngine.SerializeField]
    private GUITourMapNodeDetailInfo nodeDetailInfo;
    [global::UnityEngine.SerializeField]
    private GUITourEventMapLayout mapLayout;
    [global::UnityEngine.SerializeField]
    private GUI26CupTourEventMapLineStyle lineStyle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text chapterNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text fatigueProgressText;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo cleanFatigueRV;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button freeCleanFatigueBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private GUITourEventTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject continueLineMark;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] bgByChapter;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTeam;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem chapterCompletionRewardItem;
    [global::UnityEngine.SerializeField]
    private GUIPlayer playerRewardEffect;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Sprite fatigueIcon;
    private readonly global::System.Collections.Generic.Dictionary<int, GUI26CupTourEventMapNode> nodeViews;
    private readonly global::System.Collections.Generic.List<GUITourEventMapLine> lineViews;
    private readonly global::UnityEngine.Vector3[] panelWorldCorners;
    private readonly global::UnityEngine.Vector3[] nodeWorldCorners;
    private global::FL.TourEvent.TourEventManager manager;
    private global::FL.TourEvent.TourEventChapterConfig chapterConfig;
    private global::UnityEngine.RectTransform mapRectTransform;
    private global::UnityEngine.RectTransform playerRewardEffectRect;
    private global::UnityEngine.CanvasGroup playerRewardEffectCanvasGroup;
    private global::UnityEngine.Vector2 mapDefaultPosition;
    private global::UnityEngine.Color fatigueTextDefaultColor;
    private global::UnityEngine.Vector3 fatigueTextDefaultScale;
    private global::UnityEngine.Vector3 playerRewardEffectDefaultScale;
    private global::UnityEngine.Vector3 playerRewardEffectDefaultEulerAngles;
    private global::UnityEngine.Vector3 teamButtonDefaultScale;
    private global::DG.Tweening.Sequence playerRewardEffectSequence;
    private global::DG.Tweening.Tween fatigueGainEffectTween;
    private Win_RewardAnimationEffect fatigueGainEffectWindow;
    private global::System.Action pendingAfterFatigueTextAnimation;
    private global::UnityEngine.Vector3 pendingFatigueGainEffectStartWorldPosition;
    private int pendingFatigueGainEffectCount;
    private bool hasPendingFatigueGainEffect;
    private global::UnityEngine.Coroutine restoreToggleGroupCoroutine;
    private int selectedNodeId;
    private int lastFatigueValue;
    private void Awake()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void BindButtons()
    {
    }

    private void RemoveButtonListeners()
    {
    }

    private void BuildMap()
    {
    }

    private void BindNodeViews()
    {
    }

    private void BindLineViews()
    {
    }

    private void Refresh()
    {
    }

    private void UpdateStaticText()
    {
    }

    private void UpdateTeamButton()
    {
    }

    private void UpdateChapterCompletionReward()
    {
    }

    private void PositionChapterCompletionRewardItem()
    {
    }

    private void UpdateFatigueText()
    {
    }

    private void PlayFatigueTextChangedAnimation(bool isGain, string text, global::System.Action onComplete = null)
    {
    }

    private void ApplyFatigueTextChangedAnimationState(bool isGain, string text)
    {
    }

    private global::UnityEngine.Color WithDefaultFatigueTextAlpha(global::UnityEngine.Color color)
    {
        return default;
    }

    private void ResetFatigueTextAnimation()
    {
    }

    private void UpdateRechargeButtons()
    {
    }

    private void UpdateContinueLineMark()
    {
    }

    private bool HasContinueNode()
    {
        return false;
    }

    private void UpdateChapterBackground()
    {
    }

    private int GetChapterIndex()
    {
        return 0;
    }

    private void UpdateNodeViews()
    {
    }

    private void UpdateLineViews()
    {
    }

    private void UpdateLineViewsByState(GUI26CupTourEventMapLineStyle.LineState state)
    {
    }

    private GUI26CupTourEventMapLineStyle.LineState GetLineState(GUITourEventMapLine graphics)
    {
        return GUI26CupTourEventMapLineStyle.LineState.Passed;
    }

    private void OnNodeSelected(GUI26CupTourEventMapNode nodeView)
    {
    }

    private void OnTeamClick()
    {
    }

    private void UpdateNodeSelection()
    {
    }

    private void OnConfirmNode(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
    {
    }

    private void OnRefreshRandomEvent(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
    {
    }

    private void OnDetailClosed()
    {
    }

    private void OpenMainViewAfterPendingReward()
    {
    }

    private void OpenMainView()
    {
    }

    private void TryOpenPendingRewardOrReplacementPack()
    {
    }

    private void OpenPendingReplacementPack()
    {
    }

    private void PlayPlayerRewardEffect(ClubPlayer replacementPlayer)
    {
    }

    private void OnPlayerRewardEffectComplete()
    {
    }

    private void PrepareFatigueGainEffect(int staminaDelta)
    {
    }

    private global::DG.Tweening.Tween CreateFatigueGainEffectTween(out float textAnimationStartTime)
    {
        textAnimationStartTime = default;
        return null;
    }

    private void OnFatigueGainEffectComplete()
    {
    }

    private void KillFatigueGainEffectAnimation()
    {
    }

    private void PlayTeamButtonRewardPulse()
    {
    }

    private void KillPlayerRewardEffectAnimation()
    {
    }

    private void ResetPlayerRewardEffect()
    {
    }

    private global::UnityEngine.Vector3 GetPlayerRewardEffectLocalPosition(global::UnityEngine.Vector2 screenPoint)
    {
        return default;
    }

    private global::UnityEngine.Vector3 GetPlayerRewardEffectLocalPosition(global::UnityEngine.RectTransform target)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetScreenPoint(global::UnityEngine.Vector3 worldPosition)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetScreenPoint(global::UnityEngine.RectTransform target)
    {
        return default;
    }

    private global::UnityEngine.Vector3 BuildPlayerRewardEffectControlPoint(global::UnityEngine.Vector3 startPosition, global::UnityEngine.Vector3 endPosition)
    {
        return default;
    }

    private global::UnityEngine.Vector3 EvaluateQuadraticBezier(global::UnityEngine.Vector3 startPosition, global::UnityEngine.Vector3 controlPosition, global::UnityEngine.Vector3 endPosition, float value)
    {
        return default;
    }

    private void OnFreeCleanFatigueClick()
    {
    }

    private void OnCleanFatigueVideoSucceed()
    {
    }

    private void AdjustMapForDetail()
    {
    }

    private global::UnityEngine.Vector2 CalculateMapPositionForDetail()
    {
        return default;
    }

    private void PrepareNodeToggleGroupForInitialEmptySelection()
    {
    }

    private global::System.Collections.IEnumerator RestoreNodeToggleGroupSwitchOff()
    {
        return null;
    }

    private void StopRestoreToggleGroupCoroutine()
    {
    }

    private void SetNodeToggleGroupAllowSwitchOff(bool allow)
    {
    }

    private void SetNodeSelectionCallbackEnabled(bool enabled)
    {
    }

    private global::UnityEngine.RectTransform GetNodeTransform(int nodeId)
    {
        return null;
    }

    private global::UnityEngine.RectTransform GetFinalNodeTransform()
    {
        return null;
    }

    private void ResetMapOffset()
    {
    }

    private global::UnityEngine.Rect BuildScreenRect(global::UnityEngine.Vector3[] worldCorners)
    {
        return default;
    }

    private global::UnityEngine.Rect BuildScreenRect(global::UnityEngine.RectTransform target)
    {
        return default;
    }

    private global::UnityEngine.Vector2 ConvertScreenDeltaToMapLocalDelta(float screenDeltaX)
    {
        return default;
    }

    private global::UnityEngine.Camera GetUICamera()
    {
        return null;
    }

    private bool Overlaps(global::UnityEngine.Rect left, global::UnityEngine.Rect right)
    {
        return false;
    }

    private string BuildNodeFatigueText(global::FL.TourEvent.TourEventNodeConfig nodeConfig, global::FL.EventChallengeStateHandler.ChallengeState state)
    {
        return null;
    }

    private int GetRandomEventStaminaDelta(int nodeId)
    {
        return 0;
    }

    private string BuildRandomEventRangeText(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
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

    private global::FL.TourEvent.TourEventManager ResolveManager(object parameter)
    {
        return null;
    }

    private global::FL.TourEvent.TourEventChapterConfig ResolveChapter(object parameter)
    {
        return null;
    }
}