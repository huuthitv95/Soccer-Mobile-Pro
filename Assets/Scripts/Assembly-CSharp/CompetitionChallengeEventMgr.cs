public class CompetitionChallengeEventMgr : global::Common.Singleton<CompetitionChallengeEventMgr>
{
    public class CompetitionChallengeEvent
    {
        public int Id;
        public global::System.Collections.Generic.List<Mission> missions;
        public global::FLGameData.CompetitionType competitionType;
        public string competitionSpecificType;
        public int competitionId;
        public global::System.Collections.Generic.List<Mission> stageRewardMissions;
        public global::SL.FACupGroupsData cupProto;
        public global::FLGameData.CompetitionChallengeConfig config;
    }

    private global::System.Collections.Generic.Dictionary<int, string> configDict;
    private global::System.Collections.Generic.HashSet<int> FrozenTeams;
    private CompetitionChallengeEventMgr.CompetitionChallengeEvent _current;
    private global::System.Collections.Generic.Dictionary<int, global::FLGameData.CompetitionChallengeConfig.MissionConfig> missionDict;
    private global::Srv.CompetitionChallengeArchive archive => null;
    public int CoinReward => 0;

    public bool FirstOpen
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public int CupId => 0;
    public ChampionshipRoadConfig.ChallengeMissionConfig CurrentRoundReward => default;
    public Mission CurrentRoundRewardMission => null;
    public CompetitionChallengeEventMgr.CompetitionChallengeEvent Current => null;
    public int Round => 0;
    private int challengeId => 0;
    public global::FL.EventSwitch EventSwitch { get; private set; }
    public bool FirstRoundMark => false;
    public string TitleKey => null;
    public string DescKey => null;

    public bool HasUnclaimedReward()
    {
        return false;
    }

    public bool IsFrozenTeam(int teamId)
    {
        return false;
    }

    public void Init()
    {
    }

    private CompetitionChallengeEventMgr.CompetitionChallengeEvent LoadCompetitionChallengeEvent(string name)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> BuildRoundMissionIds(global::FLGameData.CompetitionChallengeConfig config, int completionTimes)
    {
        return null;
    }

    private void ResetMissionArchive(global::FLGameData.CompetitionChallengeConfig config, bool isInit)
    {
    }

    private void ResetArchive(global::FLGameData.CompetitionChallengeConfig config)
    {
    }

    public void UpdateRefreshRVState(bool state)
    {
    }

    public bool GetRefreshRVState()
    {
        return false;
    }

    public void RefershMission(Mission mission)
    {
    }

    private void GainCoinReward(int coin)
    {
    }

    public void ClaimProgressReward(Mission mission, global::System.Action onComplete)
    {
    }

    public void OnClaimMission(Mission mission)
    {
    }

    public global::System.Collections.Generic.IEnumerable<Mission> CheckMissions(FACup fACup, out global::System.Action<Mission> onClaimMission)
    {
        onClaimMission = null;
        return null;
    }

    public Win_ChallengeTip OpenEventTipView()
    {
        return null;
    }

    private FACup CheckCreateFACup()
    {
        return null;
    }

    public FACup GetCurrentFACup()
    {
        return null;
    }

    public bool CheckShowFirstRoundInfo(global::System.Action nextAction)
    {
        return false;
    }

    public void OpenMainView()
    {
    }

    public bool NeedShowRedPoint()
    {
        return false;
    }

    public void ApplyBtn(int id, global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark)
    {
    }
}