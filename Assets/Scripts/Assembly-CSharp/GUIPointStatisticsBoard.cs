public class GUIPointStatisticsBoard : global::UnityEngine.MonoBehaviour
{
    private struct LeagueDescRule
    {
        public bool enable;
        public int currentLeagueLeavel;
        public League league;
        public LeagueDescRule(bool enable, League league)
        {
            this.enable = false;
            currentLeagueLeavel = 0;
            this.league = null;
        }
    }

    public struct UIPromotionRule
    {
        public global::UnityEngine.GameObject relegationMark;
        public global::UnityEngine.GameObject promotionMark;
        public global::UnityEngine.GameObject playoffsMark;
        public UIPromotionRule(global::UnityEngine.Transform teamInfo)
        {
            relegationMark = null;
            promotionMark = null;
            playoffsMark = null;
        }
    }

    private struct CupDescRule
    {
        public bool enable;
        public FACup cup;
        public global::FL.UIController.IPromotionRelegationMark PRMarkController;
        public string defaultPromotionDesc;
        public string defaultPlayOffDescStr;
        public global::System.Collections.Generic.List<int> promotionSlotByGroupIdx;
        public CupDescRule(bool enable, FACup cup)
        {
            this.enable = false;
            this.cup = null;
            PRMarkController = null;
            defaultPromotionDesc = null;
            defaultPlayOffDescStr = null;
            promotionSlotByGroupIdx = null;
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject title;
    [global::UnityEngine.SerializeField]
    private bool fullTeamName;
    [global::UnityEngine.SerializeField]
    private GUIWheel wheel;
    private bool isWheel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector2 itemSize;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject ruleDesc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text promotionText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playoffText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text relegationText;
    public void Show(global::System.Collections.Generic.List<global::SL.PointRaceStatistics> info, int groupIdx, TeamsData userTeam, IMatchManager mgr, bool enableRuleDesc)
    {
    }

    private void InitLeaguePromotionItem(int rank, int teamsPerGroup, int idx, in GUIPointStatisticsBoard.UIPromotionRule UI, in GUIPointStatisticsBoard.LeagueDescRule league)
    {
    }

    private void InitLeaguePromotionDesc(in GUIPointStatisticsBoard.LeagueDescRule league)
    {
    }

    private void InitCupPromotionItem(int groupIdx, int rank, in GUIPointStatisticsBoard.CupDescRule rule, in GUIPointStatisticsBoard.UIPromotionRule UI, global::System.Collections.Generic.List<global::FL.UIController.GUIPromotionRelegationMark> marks, TeamsData team)
    {
    }

    private void scrollToItem(int idx)
    {
    }

    private void SetDestText((string, string, string) desc)
    {
    }

    private void CheckWheel(IMatchManager matchManager, bool enableRuleDesc)
    {
    }

    public void Show(IMatchManager matchManager, bool enableRuleDesc, bool reset = false)
    {
    }
}