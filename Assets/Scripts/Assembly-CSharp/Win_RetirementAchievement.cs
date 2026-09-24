public class Win_RetirementAchievement : global::Common.WindowBase
{
    [global::System.Serializable]
    private struct StatItem
    {
        public global::FLGameData.MissionType firstCheck;
        public global::FLGameData.PlayerMissionType secondCheck;
        public global::UnityEngine.UI.Text nameText;
        public global::UnityEngine.UI.Text valueText;
    }

    private class TrophyDisplayData
    {
        public string Name;
        public string TextureName;
        public int Count;
    }

    private const string ShareFileName = "pc_retirement_achievement.png";
    private const string ShareFailedTipKey = "recording_failed";
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerRaitingText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform trophyList;
    [global::UnityEngine.SerializeField]
    private Win_RetirementAchievement.StatItem[] statItems;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] top4SeasonList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShare;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    private global::FL.PlayerCareer playerCareer;
    private readonly global::System.Collections.Generic.List<global::Srv.PlayerCareerSeasonStats> seasonStatsList;
    public Win_RetirementAchievement Fill(global::FL.PlayerCareer career)
    {
        return null;
    }

    private void BuildSeasonStatsList()
    {
    }

    private void RefreshUI()
    {
    }

    private void UpdatePlayerModel(ClubPlayer player)
    {
    }

    private void RegisterButtons()
    {
    }

    private void FillStatItems()
    {
    }

    private string GetStatName(Win_RetirementAchievement.StatItem item)
    {
        return null;
    }

    private string GetStatValueText(Win_RetirementAchievement.StatItem item)
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

    private global::System.Collections.Generic.Dictionary<string, Win_RetirementAchievement.TrophyDisplayData> CollectTrophies()
    {
        return null;
    }

    private void AddTrophy(global::System.Collections.Generic.Dictionary<string, Win_RetirementAchievement.TrophyDisplayData> trophies, string key, string name, string textureName)
    {
    }

    private void FillTrophyItem(int itemIndex, Win_RetirementAchievement.TrophyDisplayData trophy)
    {
    }

    private void FillTop4SeasonList()
    {
    }

    private int CompareBestSeason(global::Srv.PlayerCareerSeasonStats a, global::Srv.PlayerCareerSeasonStats b)
    {
        return 0;
    }

    private string GetSeasonText(int seasonYear)
    {
        return null;
    }

    private void OnShareClicked()
    {
    }

    private global::System.Collections.IEnumerator CaptureAndShare()
    {
        return null;
    }

    private void TryShareImage(string imagePath)
    {
    }

    private void SetOperationButtonsActive(bool active)
    {
    }

    private void OnNextClicked()
    {
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
}