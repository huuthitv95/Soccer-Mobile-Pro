public class Win_PlayerCareerStats : global::Common.WindowBase
{
    [global::System.Serializable]
    private struct StatItem
    {
        public global::FLGameData.MissionType firstCheck;
        public global::FLGameData.PlayerMissionType secondCheck;
        public global::UnityEngine.UI.Text nameText;
        public global::UnityEngine.UI.Text valueText;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle overviewToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle seasonToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject overviewPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject seasonPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRetire;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerRatingText;
    [global::UnityEngine.SerializeField]
    private GUIUserPlayerBaseInfo userPlayerBaseInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text infoText;
    [global::UnityEngine.SerializeField]
    private Win_PlayerCareerStats.StatItem[] overviewStatItems;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform trophyList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject noTrophyTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform historyList;
    [global::UnityEngine.SerializeField]
    private GUIHistorySeasonItem2 historyItemChild0;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<Win_PlayerCareerStats.StatItem> presetSeasonStatItems;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.LayoutGroup seasonStatItemsParent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnDeleteArchive;
    private global::FL.PlayerCareer playerCareer;
    private readonly global::System.Collections.Generic.List<global::Srv.PlayerCareerSeasonStats> seasonStatsList;
    private global::Srv.PlayerCareerSeasonStats selectedSeasonStats;
    private bool tabListenersInitialized;
    public override void OnOpen(object parameter)
    {
    }

    public Win_PlayerCareerStats Fill(global::FL.PlayerCareer career)
    {
        return null;
    }

    private void InitTabListeners()
    {
    }

    private void RefreshTabPanels()
    {
    }

    private void RefreshUI()
    {
    }

    private void RefreshRetireButton()
    {
    }

    private void OnRetireClicked()
    {
    }

    private void RefreshDeleteArchiveButton()
    {
    }

    public static void OnDeleteArchiveClicked()
    {
    }

    private static void DeleteArchive()
    {
    }

    private void BuildSeasonStatsList()
    {
    }

    private global::Srv.PlayerCareerSeasonStats FindSeason(int seasonYear)
    {
        return null;
    }

    private void RefreshOverview()
    {
    }

    private void UpdatePlayerModel(ClubPlayer player)
    {
    }

    private void FillStatItems(global::System.Collections.Generic.IList<Win_PlayerCareerStats.StatItem> statItems, global::Srv.PlayerCareerSeasonStats seasonStats, bool aggregateCareer)
    {
    }

    private string GetStatName(Win_PlayerCareerStats.StatItem item)
    {
        return null;
    }

    private string GetStatValueText(Win_PlayerCareerStats.StatItem item, global::Srv.PlayerCareerSeasonStats seasonStats, bool aggregateCareer)
    {
        return null;
    }

    private int GetCareerStat(global::FLGameData.MissionType missionType)
    {
        return 0;
    }

    private int GetCareerStat(global::FLGameData.PlayerMissionType missionType)
    {
        return 0;
    }

    private int GetSeasonStat(global::Srv.PlayerCareerSeasonStats seasonStats, global::FLGameData.PlayerMissionType missionType)
    {
        return 0;
    }

    private float GetCareerAverageIngameRating()
    {
        return 0f;
    }

    private void FillTrophyList()
    {
    }

    private void FillTrophyItem(int itemIndex, string name, string textureName)
    {
    }

    private void FillHistoryList()
    {
    }

    private string GetSeasonText(int seasonYear)
    {
        return null;
    }

    private void SelectSeason(global::Srv.PlayerCareerSeasonStats seasonStats)
    {
    }

    private void FillSelectedSeasonStats()
    {
    }

    private void FillSelectedSeasonCupStats()
    {
    }

    private global::UnityEngine.Transform GetSeasonDynamicStatPrototype()
    {
        return null;
    }

    private global::UnityEngine.Transform GetSeasonStatItemsParent()
    {
        return null;
    }

    private string GetSeasonStatNameTextObjectName()
    {
        return null;
    }

    private string GetSeasonStatValueTextObjectName()
    {
        return null;
    }

    private string GetCupHonorText(CupHonor honor)
    {
        return null;
    }

    private int GetDisplayRank(global::Srv.PlayerCareerSeasonStats seasonStats)
    {
        return 0;
    }

    private string GetRankText(int rank)
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

    private TeamsData ResolveTeam(int teamId)
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

    private global::UnityEngine.UI.Text FindText(global::UnityEngine.Transform root, string name)
    {
        return null;
    }
}