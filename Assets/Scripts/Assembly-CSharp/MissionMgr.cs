public class MissionMgr : global::Common.Singleton<MissionMgr>
{
    public delegate void MatchMissionPointCheckerDelegate(in MatchMissionPointChecker checker, bool afterMatch);
    public enum MissionState
    {
        Allocated = 0,
        Completed = 1,
        Claimed = 2
    }

    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private MissionMgr.MatchMissionPointCheckerDelegate m_OnCheckMatchMission;
    private global::System.Collections.Generic.Dictionary<int, Mission> missions;
    public event MissionMgr.MatchMissionPointCheckerDelegate OnCheckMatchMission
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public void OnAchieveMilestone(global::FLGameData.MissionType type, IMatchManager cup)
    {
    }

    private static bool CheckCumulativeMission(global::FLGameData.MissionType type)
    {
        return false;
    }

    public void OnMatchFinish(CupMatchBase match, CupMatchBase.MatchSettlementData settlementData)
    {
    }

    public static void CheckMatchMission(Mission mission, in MatchMissionPointChecker checkPoint, global::System.Action<Mission> OnClaimMission)
    {
    }

    private void CheckChallenge(IMatchManager matchManager, in MatchMissionPointChecker checkPoint, bool afterMatch)
    {
    }

    public void Load()
    {
    }

    public void AddMission(Mission mission)
    {
    }

    public void UpdateMission(Mission mission, int progress, global::System.Action OnCompleted)
    {
    }

    public void ResetMission(Mission mission)
    {
    }

    public void ClaimMission(Mission mission)
    {
    }

    public bool tryGetMission(int id, out Mission mission)
    {
        mission = null;
        return false;
    }

    public bool hasMission(int id)
    {
        return false;
    }
}