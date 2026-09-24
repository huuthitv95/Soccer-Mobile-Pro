public class Win_PlayerCareer : global::Common.WindowBase
{
    private const string TransferWindowOpenTitleStringId = "transfer_win_open_title";
    private const string TransferWindowOpenDescStringId = "transfer_win_open_desc";
    private const string TransferContactTitleStringId = "contact_win_open_title";
    private const string TransferContactDescStringId = "contact_win_open_desc";
    [global::UnityEngine.SerializeField]
    private GUICoachTrust uiCoachTrust;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCareerTopBar topBar;
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerBaseInfo userPlayerBaseInfo;
    [global::UnityEngine.SerializeField]
    private GUITeam uiHomeTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam uiAwayTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchInfoText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchScoreText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text seasonInfoText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerRatingText;
    [global::UnityEngine.SerializeField]
    private UIHexRadarChart playerRatingChart;
    [global::UnityEngine.SerializeField]
    private GUIPlayerCareerNextBtn uiPlayerCareerNextBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFixtures;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRank;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnStats;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCalendar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text basicMatchBonusText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnUpgrade;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject upgradeTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSeasonMission;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform bonusMissionPreviewParent;
    [global::UnityEngine.SerializeField]
    private PageView bonusMissionPreviewPageView;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject missionRedDot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnStartSchedule;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnEventReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform scheduleList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button scheduleListBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCoachTrustDetail;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAgreementList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSeasonStats;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nextTransferWindow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text contractNum;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnDelete;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnChangeSlideWindow;
    [global::UnityEngine.SerializeField]
    private UIABStateAnimationGroup slideWindowAnimationGroup;
    private bool scheduleListAnimating;
    private bool showingRetirementPrompt;
    private bool uiInitialized;
    private float timer;
    public Win_PlayerCareer Fill(global::FL.PlayerCareer playerCareer)
    {
        return null;
    }

    private void TryShowRetirementPrompt(global::FL.PlayerCareer playerCareer)
    {
    }

    private void OpenRetirementAchievement(global::FL.PlayerCareer playerCareer)
    {
    }

    public void UpdateUI(global::FL.PlayerCareer playerCareer)
    {
    }

    private void UpdateScheduleUI(global::FL.PlayerCareer playerCareer, bool refreshScheduleList)
    {
    }

    private GUIPlayerCareerNextBtn.NextBtnType GetNextBtnType(Schedule schedule, CupMatchBase match, bool suspension)
    {
        return GUIPlayerCareerNextBtn.NextBtnType.NextMatch;
    }

    private bool IsTransferNegotiationCompleted(Schedule schedule, global::FL.PlayerCareer playerCareer)
    {
        return false;
    }

    private void UpdateNextButtonAction(CupMatchBase match, Schedule schedule, GUIPlayerCareerNextBtn.NextBtnType btnType, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData, bool isTransferNegotiationCompleted)
    {
    }

    private void UpdateStartScheduleButtonAction(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer, bool isMatchFinished, bool isTransferNegotiationCompleted)
    {
    }

    private void ContinueCompletedTransferNegotiationSchedule(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer)
    {
    }

    private void ToPrematch(CupMatchBase match)
    {
    }

    private void SkipCurrentMatch(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer)
    {
    }

    private void ToNextSchedule(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer, global::UnityEngine.Events.UnityAction onScheduleAdvanced = null)
    {
    }

    private global::System.Collections.IEnumerator ToNextScheduleAnim(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer, Schedule currentDay, Schedule nextDay, global::UnityEngine.Events.UnityAction onScheduleAdvanced)
    {
        return null;
    }

    private global::System.Collections.IEnumerator PlayScheduleListScrollAnim(FixtureListData fixtureListData, Schedule currentDay, Schedule nextDay)
    {
        return null;
    }

    private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> GetScheduleListItems(global::UnityEngine.RectTransform root)
    {
        return null;
    }

    private float GetScheduleListScrollDistance(global::UnityEngine.RectTransform root)
    {
        return 0f;
    }

    private void HandleTransferSchedule(Schedule schedule, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private void OnTransferContactSchedule(Schedule schedule, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private global::UnityEngine.GameObject TakePlayerModelForNegotiationAnimation()
    {
        return null;
    }

    private void StorePlayerModelFromNegotiationAnimation(global::UnityEngine.GameObject playerModel)
    {
    }

    private void OnTransferWindowOpenSchedule(Schedule schedule, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private void OnTransferDeadlineSchedule(Schedule schedule, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private void TryOpenTransferSchedulePrompt(Schedule schedule, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private void TryOpenTransferContactPrompt(Schedule schedule, global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private void TryOpenTransferWindowOpenPrompt(global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData)
    {
    }

    private void OpenTransferPrompt(string titleStringId, string descStringId, global::UnityEngine.Events.UnityAction onConfirmed)
    {
    }

    private void ContinueTransferWindowOpenToNegotiation(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer)
    {
    }

    private void ContinueTransferSchedule(FixtureListData fixtureListData, global::FL.PlayerCareer playerCareer)
    {
    }

    private void PlayContractRenewalTimeline(global::FL.PlayerCareer playerCareer, global::UnityEngine.Events.UnityAction onComplete)
    {
    }

    public void Back()
    {
    }

    private void UpdateMatchInfo(CupMatchBase match, RegionalLeague league)
    {
    }

    private void UpdateTransferScheduleInfo(Schedule schedule, CupMatchBase nextMatch, RegionalLeague league)
    {
    }

    private void UpdateRoundText(Schedule schedule, CupMatchBase match)
    {
    }

    private void UpdatePlayerRating(ClubPlayer player)
    {
    }

    private void UpdateNextMatchBtn(GUIPlayerCareerNextBtn.NextBtnType btnType, UserPlayerData userPlayer)
    {
    }

    private void UpdateBasicMatchBonus(global::FL.PlayerCareer playerCareer)
    {
    }

    private void UpdateTransferSummary(FixtureListData fixtureListData, Schedule currentSchedule, global::FL.PlayerCareer playerCareer)
    {
    }

    private void UpdateNextTransferWindowText(FixtureListData fixtureListData, Schedule currentSchedule)
    {
    }

    private void UpdateContractNum(global::FL.PlayerCareer playerCareer)
    {
    }

    private int CountMatchesToNextTransferWindow(FixtureListData fixtureListData, Schedule currentSchedule)
    {
        return 0;
    }

    private string GetNextTransferWindowText(int matchCount)
    {
        return null;
    }

    private void UpdateUpgradeTip(global::FL.PlayerCareer playerCareer)
    {
    }

    private void InitButtons(FixtureListData fixtureListData, CupMatchBase currentMatch, global::FL.PlayerCareer playerCareer)
    {
    }

    private void UpdateEventRewardButton(global::FL.PlayerCareer playerCareer)
    {
    }

    private global::System.Collections.Generic.List<Schedule> GetSchedulePreview(FixtureListData fixtureListData, Schedule current, int count)
    {
        return null;
    }

    private void UpdateScheduleList(global::System.Collections.Generic.List<Schedule> datas, Schedule current, FixtureListData fixtureListData)
    {
    }

    public void UpdatePlayerModel(ClubPlayer player)
    {
    }

    private void UpdateMissionPreviewItem(global::UnityEngine.Transform item, global::Srv.SeasonMission mission)
    {
    }

    private void UpdateMissionPreview(global::System.Collections.Generic.List<global::Srv.SeasonMission> bonusMissions)
    {
    }

    private void Update()
    {
    }
}