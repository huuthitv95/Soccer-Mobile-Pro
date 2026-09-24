public class Win_LastDanceEvent : global::Common.WindowBase
{
    private const float MilestoneRewardFlyDuration = 0.66f;
    private const float MilestoneRewardFlyDelay = 0.12f;
    private const float MilestoneRewardImpactOffset = 0.16f;
    private const float CurrencyTextChangedScale = 1.18f;
    private const float CurrencyTextScaleUpDuration = 0.12f;
    private const float CurrencyTextScaleBackDuration = 0.18f;
    private const float CurrencyTextColorBackDuration = 0.35f;
    private static readonly global::UnityEngine.Color CurrencyTextGainColor;
    [global::UnityEngine.SerializeField]
    private MilestoneProgressBar milestoneProgressBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text countDown;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text progressText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text currencyText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchContainer;
    [global::UnityEngine.SerializeField]
    private GUILastDanceMatchDetailPanel matchDetailPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShop;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image currencyIcon;
    private global::FL.LastDanceEventManager manager;
    private global::System.Collections.Generic.List<GUILastDanceMatchItem> matchItems;
    private int selectedSlotId;
    private bool delayCurrencyTextUpdate;
    private int delayedCurrencyValue;
    private global::DG.Tweening.Tween milestoneRewardArriveTween;
    private Win_RewardAnimationEffect milestoneRewardEffectWindow;
    private global::UnityEngine.Color currencyTextDefaultColor;
    private global::UnityEngine.Vector3 currencyTextDefaultScale;
    private bool hasCurrencyTextDefault;
    private global::UnityEngine.Coroutine failTipCoroutine;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    private void RecoverFromOcclusion()
    {
    }

    private void BindButtons()
    {
    }

    private void SubscribePoints()
    {
    }

    private void UnsubscribePoints()
    {
    }

    private void CacheMatchItems()
    {
    }

    private void CacheCurrencyTextDefault()
    {
    }

    private void Refresh(global::System.Collections.Generic.IReadOnlyList<global::FL.LastDanceEventManager.SlotInfo> slotInfos = null, bool showDetail = true)
    {
    }

    private void UpdateStaticTexts()
    {
    }

    private void UpdateCurrencyText(int count)
    {
    }

    private void UpdateMilestones()
    {
    }

    private void OnMilestoneClaim(int threshold, global::UnityEngine.RectTransform rewardStart)
    {
    }

    private void UpdateMatches(global::System.Collections.Generic.IReadOnlyList<global::FL.LastDanceEventManager.SlotInfo> slotInfos = null, bool showDetail = true)
    {
    }

    private void OnMatchItemClick(global::FL.LastDanceEventManager.SlotInfo slotInfo)
    {
    }

    private void ShowDetail(global::FL.LastDanceEventManager.SlotInfo slotInfo)
    {
    }

    private void OnSlotRefreshed(int slotId)
    {
    }

    private void OnWindowReady(bool playRoundRefreshAnimation)
    {
    }

    private void ScheduleUpdateFailTip()
    {
    }

    private global::System.Collections.IEnumerator UpdateFailTipWhenMainViewReady()
    {
        return null;
    }

    private void StopFailTipCoroutine()
    {
    }

    private void PlayRoundRefreshAnimation()
    {
    }

    private void OpenShop()
    {
    }

    private void UpdateFailTip()
    {
    }

    private global::UnityEngine.UI.Button FindButton(string objectName)
    {
        return null;
    }

    private global::UnityEngine.Transform FindChildRecursive(global::UnityEngine.Transform root, string objectName)
    {
        return null;
    }

    private void PlayMilestoneRewardEffect(bool hasStart, global::UnityEngine.Vector2 startScreenPosition)
    {
    }

    private void OnMilestoneRewardArrive()
    {
    }

    private void ApplyDelayedCurrencyText(bool animate = false)
    {
    }

    private void KillMilestoneRewardEffect(bool applyCurrency)
    {
    }

    private void StopMilestoneRewardEffectVisual()
    {
    }

    private void PlayCurrencyTextGainAnimation()
    {
    }

    private void ResetCurrencyTextAnimation()
    {
    }

    private global::UnityEngine.Color WithDefaultCurrencyTextAlpha(global::UnityEngine.Color color)
    {
        return default;
    }

    private global::UnityEngine.Vector2 GetScreenPoint(global::UnityEngine.RectTransform target)
    {
        return default;
    }

    private global::UnityEngine.Camera GetUICamera()
    {
        return null;
    }
}