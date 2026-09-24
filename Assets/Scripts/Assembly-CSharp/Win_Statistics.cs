public class Win_Statistics : global::Common.WindowBase
{
    public struct MatchStatistics
    {
        public string name;
        public float homeValue;
        public float awayValue;
        public float homeValue2;
        public float awayValue2;
        public bool hasValue2;
    }

    private enum ShowType
    {
        Pause = 0,
        MatchEnd = 1,
        HalfTime = 2
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text score;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform home;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform away;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnHome;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform homeGoalList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform awayGoalList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnGroupMatchEnd;
    [global::UnityEngine.SerializeField]
    private StringID title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnGoalMoments;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform team_playerToggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playerStatisticsToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject userPlayerStatisticsToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform contentRect;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playerStatistics;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject teamStatistics;
    [global::UnityEngine.SerializeField]
    private GUIIngameUserPlayerStatistics userPlayerStatisticsUI;
    [global::UnityEngine.SerializeField]
    private GUISeasonalGoalsBanner seasonalGoalsBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text homePenaltyScore;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text awayPenaltyScore;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform content;
    [global::UnityEngine.SerializeField]
    private GUILocalPVPDecorator localPVPDecorator;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAgain;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnLocalPVPHome;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button p1Formation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button p2Formation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFormation;
    private CupMatchBase m_match;
    private bool isHalfTime;
    private global::UnityEngine.Events.UnityAction onResumeAction;
    private global::UnityEngine.Events.UnityAction onSettingBtnClickAction;
    private global::UnityEngine.Events.UnityAction onQuitClickAction;
    private global::UnityEngine.Events.UnityAction onFormationClickAction;
    private global::System.Action CloseAction;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Statistics Fill(global::System.Collections.Generic.List<Win_Statistics.MatchStatistics> matchStatistics, CupMatchBase match, int[] scores, int[] penaltyScores, MatchStatisticsData matchStatisticsData, global::UnityEngine.Events.UnityAction onResume, global::UnityEngine.Events.UnityAction onSetting, global::UnityEngine.Events.UnityAction onQuit, global::UnityEngine.Events.UnityAction onFormation)
    {
        return null;
    }

    private void UpdateToggleGroup(Win_Statistics.ShowType showType, TestSample match)
    {
    }

    public Win_Statistics ShowWithPause(TestSample match)
    {
        return null;
    }

    private void CloseWindow()
    {
    }

    public Win_Statistics ShowWithEndMatch(CupMatchBase matchData, TestSample aiSample, CupMatchBase.MatchSettlementData settlementData)
    {
        return null;
    }

    private void TryPlaySeasonalGoalsBanner(CupMatchBase matchData, CupMatchBase.MatchSettlementData settlementData)
    {
    }

    private void UpdatePlayerStatistics(CupMatchBase.MatchSettlementData settlementData)
    {
    }

    private void UpdatePlayerStatisticsUI(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<float, InGamePlayer>> values, global::UnityEngine.Transform list, bool showMvp)
    {
    }

    public Win_Statistics ShowWithHalfTime(global::System.Action action, bool showAd, TestSample match)
    {
        return null;
    }

    private void SetResumeAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    private void SetSettingAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    private void SetQuitAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    private void SetFormationAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void SettingClick()
    {
    }

    private void OnEnable()
    {
    }

    public void QuitClick()
    {
    }

    public void OpenPlayerOneFormation()
    {
    }

    public void OpenPlayerTwoFormation()
    {
    }

    private void OpenFormation(TeamsData team)
    {
    }

    public void FormationClick()
    {
    }

    public void ShowHalftimeForamtionView(global::System.Action onClose)
    {
    }

    public void ShowInjuredForamtionView()
    {
    }

    private void UpdateGoalInfo(global::System.Collections.Generic.List<MatchStatisticsData.GoalInfo> datas, global::UnityEngine.Transform list)
    {
    }

    public Win_Statistics ShowAgainBtn(global::System.Action onAgain)
    {
        return null;
    }

    private void UpdateTeamUI(global::UnityEngine.Transform root, TeamsData data)
    {
    }

    public Win_Statistics SetCloseAction(global::System.Action action)
    {
        return null;
    }

    public override void OnClose()
    {
    }
}