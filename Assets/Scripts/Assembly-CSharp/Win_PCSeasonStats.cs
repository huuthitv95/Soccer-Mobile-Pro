public class Win_PCSeasonStats : global::Common.WindowBase
{
    private static readonly global::UnityEngine.Color ChampionRankColor;
    private static readonly global::UnityEngine.Color NormalRankColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text currentSeasonText;
    [global::UnityEngine.SerializeField]
    private GUITeam team;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage leagueTrophy;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rankText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform historyList;
    [global::UnityEngine.SerializeField]
    private GUIHistorySeasonItem historyItemChild0;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform leagueOnlyGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform league_cupGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage leagueTrophy_leagueCup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueNameText_leagueCup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rankText_leagueCup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cupEventList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cupEventItem;
    private global::FL.PlayerCareer playerCareer;
    public void Fill(global::FL.PlayerCareer playerCareer)
    {
    }

    private void RefreshUI()
    {
    }

    private void FillCurrentSeason(global::Srv.PlayerCareerSeasonStats seasonStats)
    {
    }

    private void FillLeagueAndCupSeason(global::SL.LeagueProto leagueProto, int leagueProtoId, int rank, global::System.Collections.Generic.List<global::Srv.PlayerCareerCupHonor> cupChampionHonors)
    {
    }

    private global::System.Collections.Generic.List<global::Srv.PlayerCareerCupHonor> GetCupChampionHonors(global::Srv.PlayerCareerSeasonStats seasonStats)
    {
        return null;
    }

    private void FillCupChampionList(global::System.Collections.Generic.List<global::Srv.PlayerCareerCupHonor> cupChampionHonors)
    {
    }

    private void FillCurrentTeam(global::Srv.PlayerCareerSeasonStats seasonStats)
    {
    }

    private void FillLeagueTrophy(global::UnityEngine.UI.RawImage trophy, global::SL.LeagueProto leagueProto)
    {
    }

    private void FillCupTrophy(global::UnityEngine.UI.RawImage trophy, string textureName)
    {
    }

    private void FillHistoryList(global::System.Collections.Generic.List<global::Srv.PlayerCareerSeasonStats> seasonStatsList)
    {
    }

    private void FillHistoryItem(GUIHistorySeasonItem item, global::Srv.PlayerCareerSeasonStats seasonStats)
    {
    }

    private void FillHistoryTeam(GUIHistorySeasonItem item, int teamId)
    {
    }

    private void FillLeagueIcon(GUIHistorySeasonItem item, global::SL.LeagueProto leagueProto)
    {
    }

    private void FillRank(global::UnityEngine.UI.Text text, int rank)
    {
    }

    private int GetDisplayRank(global::Srv.PlayerCareerSeasonStats seasonStats)
    {
        return 0;
    }

    private string GetRankText(int rank)
    {
        return null;
    }

    private string GetSeasonText(int seasonYear)
    {
        return null;
    }

    private string ResolveLeagueName(global::SL.LeagueProto leagueProto, int leagueProtoId)
    {
        return null;
    }

    private global::SL.LeagueProto ResolveLeagueProto(int leagueProtoId)
    {
        return null;
    }

    private global::SL.FACupGroupsData ResolveCupProto(global::Srv.PlayerCareerCupHonor honor)
    {
        return null;
    }

    private string ResolveCupName(global::SL.FACupGroupsData cupProto, global::Srv.PlayerCareerCupHonor honor)
    {
        return null;
    }

    private string ResolveCupTexture(global::SL.FACupGroupsData cupProto)
    {
        return null;
    }

    private TeamsData ResolveTeam(int teamId)
    {
        return null;
    }
}