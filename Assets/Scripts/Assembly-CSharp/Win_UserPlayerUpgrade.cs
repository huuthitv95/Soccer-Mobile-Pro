public class Win_UserPlayerUpgrade : global::Common.WindowBase
{
    private static readonly global::UnityEngine.Color InitialHexagramAttributeNameColor;
    private static readonly global::UnityEngine.Color UpgradedHexagramAttributeNameColor;
    private const string UpgradeTutorialSaveKey = "UserPlayerUpgradeTutorialShown";
    private const string UpgradeTutorialTipStringId = "UpgradeTutorialTip";
    private const float UpgradeTutorialExtraWidth = 40f;
    private const float DisabledButtonAlpha = 0.5f;
    private const string UpgradeSessionEventName = "user_player_upgrade_session";
    private const string UpgradeManualAdjustEventName = "user_player_upgrade_manual";
    private const string UpgradeConfirmEventName = "user_player_upgrade_confirm";
    private const int UpgradeActionNone = 0;
    private const int UpgradeActionAuto = 1;
    private const int UpgradeActionManual = 2;
    private const int UpgradeActionConfirm = 3;
    private const int UpgradeActionReset = 4;
    private const int UpgradeActionExit = 5;
    [global::UnityEngine.SerializeField]
    private GUIPlayerUpgradeOption[] upgradeOptions;
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerBaseInfo baseInfo;
    [global::UnityEngine.SerializeField]
    private UIHexRadarChart originalRadarChart;
    [global::UnityEngine.SerializeField]
    private UIHexRadarChart upgradedRadarChart;
    [global::UnityEngine.SerializeField]
    private UIABStateAnimationGroup upgradeAnimationGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text originalRatingText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text upgradedRatingText;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCareerTopBar playerCareerTopBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRest;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAuto;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text totalCostText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] hexagramAttributeNameTexts;
    [global::UnityEngine.SerializeField]
    private SlideTutorial slideTutorial;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text remaining;
    private global::FL.PlayerCareer _playerCareer;
    private ClubPlayer _player;
    private global::FL.UserPlayerType _playerType;
    private GUIPlayerUpgradeOption _tutorialOption;
    private GUIPlayerUpgradeOption _activeInputOption;
    private int _bestAttributeIndex;
    private float _openTime;
    private int _entryAbility;
    private int _abilityRange;
    private int _firstAction;
    private int _afterAutoAction;
    private int _afterResetAction;
    private bool _tutorialShownThisSession;
    private bool _sessionEventSent;
    private bool _waitingAfterAutoAction;
    private bool _waitingAfterResetAction;
    private bool _autoUsed;
    private bool _manualUsed;
    private bool _hasAdjusted;
    private bool _hasUpgrade;
    private bool _loggedFirstConfirm;
    private int _recommendedManualAdjustCount;
    private int _unrecommendedManualAdjustCount;
    private int _recommendedManualDelta;
    private int _unrecommendedManualDelta;
    private readonly int[] _baseValues;
    private readonly int[] _maxValues;
    private readonly int[] _pendingDeltas;
    private readonly bool[] _recommendedFlags;
    private readonly bool[] _inputStartRecommendedFlags;
    private readonly int[] _manualDeltaBuckets;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void ResetTrackingState()
    {
    }

    private int GetAbilityRange(int ability)
    {
        return 0;
    }

    private int GetElapsedSeconds()
    {
        return 0;
    }

    private int BoolToInt(bool value)
    {
        return 0;
    }

    private void RecordFirstAction(int action)
    {
    }

    private void BeginAfterAutoAction()
    {
    }

    private void BeginAfterResetAction()
    {
    }

    private void RecordAfterAutoAction(int action)
    {
    }

    private void RecordAfterResetAction(int action)
    {
    }

    private void RecordExitActions()
    {
    }

    private void LogSessionEvent()
    {
    }

    private void BindCurrencyChanged()
    {
    }

    private void UnbindCurrencyChanged()
    {
    }

    private void HandleCurrencyChanged(int previous, int current)
    {
    }

    private void HandleOptionInput(GUIPlayerUpgradeOption option)
    {
    }

    private void ClearOptionInputHandlers()
    {
    }

    private void HandleOptionInputFinished(GUIPlayerUpgradeOption option, int startValue, int endValue)
    {
    }

    private void LogManualAdjustEvent(global::FL.HexagramAttribute attribute, bool recommended, int delta, int bucket)
    {
    }

    private void UpdatePlayerModel(ClubPlayer player)
    {
    }

    private void ComputeMaxValues()
    {
    }

    private bool CanScrollToValue(global::FL.HexagramAttribute attr, int targetValue)
    {
        return false;
    }

    private void HandleOptionValueChanged(global::FL.HexagramAttribute attr, int oldValue, int newValue)
    {
    }

    private void ApplyOptionValue(global::FL.HexagramAttribute attr, int value)
    {
    }

    private void UpdateAllCostDisplays()
    {
    }

    private void UpdateRemainingDisplay(int totalCost, int remainingCurrency)
    {
    }

    private void GetNextPointState(int attrIndex, in global::FL.PlayerExpStruct pendingExp, int remainingCurrency, out int nextCost, out bool hasNextPoint, out bool canAffordNextPoint)
    {
        nextCost = default;
        hasNextPoint = default;
        canAffordNextPoint = default;
    }

    private int GetMaxScrollableValue(global::FL.HexagramAttribute attr)
    {
        return 0;
    }

    private void UpdateUpgradeButtonStates(bool hasPendingUpgrade, int totalCost, in global::FL.PlayerExpStruct pendingExp)
    {
    }

    private bool CanAffordAnyNextUpgrade(int availableCurrency, in global::FL.PlayerExpStruct pendingExp)
    {
        return false;
    }

    private bool HasExpGrowth(in global::FL.PlayerExpStruct expGrowth)
    {
        return false;
    }

    private void SetButtonInteractable(global::UnityEngine.UI.Button button, bool interactable)
    {
    }

    private void UpdatePreviewRadar()
    {
    }

    private void UpdateRecommendFlags()
    {
    }

    private bool ShowTutorialIfNeeded()
    {
        return false;
    }

    private bool CanAffordNextPoint(int attrIndex)
    {
        return false;
    }

    private void HandleTutorialInput(GUIPlayerUpgradeOption option)
    {
    }

    private void HideTutorial()
    {
    }

    private void UpdateHexagramAttributeNameColors()
    {
    }

    private global::System.Collections.Generic.Dictionary<global::FL.HexagramAttribute, int> BuildPendingUpgradesDict()
    {
        return null;
    }

    private void OnResetClicked()
    {
    }

    private void OnConfirmClicked()
    {
    }

    private void LogConfirmEvent(int totalCost, global::System.Collections.Generic.Dictionary<global::FL.HexagramAttribute, int> upgrades)
    {
    }

    private void PlayUpgradeEffects(bool[] upgradedAttributes)
    {
    }

    private void OnAutoClicked()
    {
    }
}