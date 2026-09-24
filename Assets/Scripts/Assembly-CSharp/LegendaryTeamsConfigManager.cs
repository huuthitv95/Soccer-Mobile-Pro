public class LegendaryTeamsConfigManager : global::Common.Singleton<LegendaryTeamsConfigManager>
{
    public enum CompetitionType : sbyte
    {
        None = 0,
        NineGrid = 1,
        RTC = 2,
        CustomTeamRTC = 3,
        MomentChallenge = 4,
        TourEvent = 5
    }

    private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LegendaryTeamsConfig> ClubLegendaryTeamsConfig;
    private global::System.Collections.Generic.Dictionary<int, global::FLDataTable.LegendaryTeamsConfig> NationalLegendaryTeamsConfig;
    private global::System.Collections.Generic.List<int> eventTeams;
    private global::System.Collections.Generic.HashSet<int> eventTeamsSet;
    public const int MaxLegendaryNationalTeamProgress = 3;
    public global::System.Collections.Generic.List<int> GetEventTeams()
    {
        return null;
    }

    public global::System.Collections.Generic.List<int> GetNonUnlockableEventTeams()
    {
        return null;
    }

    public bool CheckEventIsOpen(int teamId)
    {
        return false;
    }

    public bool CheckEventTeamUnlockable(int teamId)
    {
        return false;
    }

    private bool CheckEventIsOpen(LegendaryTeamsConfigManager.CompetitionType competitionType, int id)
    {
        return false;
    }

    public void ApplyEventBtn(int id, global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark)
    {
    }

    public void OpenEventMainView(int id)
    {
    }

    public bool IsEventTeam(int teamId)
    {
        return false;
    }

    public global::System.Collections.Generic.IEnumerable<int> GetClubLegendaryTeams()
    {
        return null;
    }

    public global::System.Collections.Generic.IEnumerable<int> GetNationalLegendaryTeams()
    {
        return null;
    }

    public bool CheckLegendaryClubTeam(int teamId)
    {
        return false;
    }

    public bool CheckLegendaryNationalTeam(int teamId)
    {
        return false;
    }

    public global::System.Collections.Generic.List<int> GetLegendaryTeams()
    {
        return null;
    }

    public int GetLegendaryTeamsYear(int id)
    {
        return 0;
    }

    public bool LegendaryTeamIsUnlocked(int id)
    {
        return false;
    }

    public void UnlockLegendaryTeam(int id, int addProgress = 1)
    {
    }

    public int GetLegendaryTeamProgress(int id)
    {
        return 0;
    }

    public bool NationalTeamIsUnlocked(int id)
    {
        return false;
    }

    public bool ClubTeamIsUnlocked(int id)
    {
        return false;
    }
}