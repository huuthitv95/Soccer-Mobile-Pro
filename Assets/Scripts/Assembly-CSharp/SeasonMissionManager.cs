public class SeasonMissionManager
{
    private const int BonusMissionCount = 3;
    private global::Srv.SeasonMissionGroup seasonMissionGroup;
    private global::FLGameProgressSetting.LocalArchives store;
    public SeasonMissionManager(global::Srv.SeasonMissionGroup seasonMissionGroup, global::FLGameProgressSetting.LocalArchives store)
    {
    }

    public global::System.Collections.Generic.List<global::Srv.SeasonMission> GetSeasonMissions()
    {
        return null;
    }

    private global::System.Collections.Generic.IEnumerable<global::Srv.SeasonMission> GetAllMissions()
    {
        return null;
    }

    private void ResetMission(global::Srv.SeasonMission mission)
    {
    }

    private void EnsureMissionStorage()
    {
    }

    private void ResetMissions()
    {
    }

    public void AllocateSeasonMissions(global::FL.PlayerCareer playerCareer)
    {
    }

    private void InitMission(global::Srv.SeasonMission mission, global::System.Collections.Generic.List<global::FLDataTable.UserPlayerSeasonGoal> configs, global::FLGameData.PlayerMissionType playerMissionType, int teamTeir, int playerTier, bool isRenewalMission)
    {
    }

    private void InitTeamMission(RegionalLeague league, global::Srv.SeasonMission mission, global::System.Collections.Generic.List<global::FLDataTable.TeamSeasonGoal> configs, int teamTeir, CoachTrustTier coachTrust)
    {
    }

    private global::System.Collections.Generic.List<global::FLDataTable.UserPlayerSeasonGoal> LoadPlayerMissionConfigs(FormationTool.UIPosition pos)
    {
        return null;
    }

    private void ChecUpdateHistoryMark(global::Srv.SeasonMission mission)
    {
    }

    private bool IsConsecutiveCondition(int id)
    {
        return false;
    }

    public global::System.Collections.Generic.List<SeasonMissionProgressUpdate> CheckMissionProgress(global::FL.PlayerCareer playerCareer, in MatchMissionPointChecker checker, bool afterMatch)
    {
        return null;
    }

    private void UpdateMissionProgress(global::Srv.SeasonMission mission, int point, bool isConsecutive)
    {
    }

    private int CaculateMissionReward(int teamtier)
    {
        return 0;
    }

    public bool RenewalConditionIsComplete()
    {
        return false;
    }

    public int ClaimUnclaimedCompletedMissionRewards(global::FL.PlayerCareer playerCareer)
    {
        return 0;
    }

    public bool ClaimMission(global::FL.PlayerCareer playerCareer, global::Srv.SeasonMission mission)
    {
        return false;
    }
}