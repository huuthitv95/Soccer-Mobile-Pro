public class Win_UserPlayerSeasonStats : global::Common.WindowBase
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
    private GUIUserPlayerBaseInfo playerBaseInfo;
    [global::UnityEngine.SerializeField]
    private UIHexRadarChart originalRadarChart;
    [global::UnityEngine.SerializeField]
    private UIHexRadarChart upgradedRadarChart;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text seasonStartAbilityText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text seasonEndAbilityText;
    [global::UnityEngine.SerializeField]
    private Win_UserPlayerSeasonStats.StatItem[] statItems;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI seasonNumberText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform seasonStatsRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] hexAttrNames;
    private global::FL.PlayerCareer playerCareer;
    private global::Srv.PlayerCareerSeasonStats seasonStats;
    private SelectRoleSceneManager selectRoleSceneManager;
    private bool hasRequestedSelectRoleScene;
    private bool isClosed;
    public override void OnOpen(object parameter)
    {
    }

    public Win_UserPlayerSeasonStats Fill(global::FL.PlayerCareer career)
    {
        return null;
    }

    public void HidePlayer()
    {
    }

    private Win_UserPlayerSeasonStats Fill(global::FL.PlayerCareer career, global::Srv.PlayerCareerSeasonStats stats)
    {
        return null;
    }

    private global::Srv.PlayerCareerSeasonStats ResolveCurrentSeasonStats(global::FL.PlayerCareer career)
    {
        return null;
    }

    private void RefreshUI()
    {
    }

    private global::System.Collections.Generic.IEnumerable<int> GetSeasonStartAttributes()
    {
        return null;
    }

    private void FillStatItems()
    {
    }

    private string GetStatName(Win_UserPlayerSeasonStats.StatItem item)
    {
        return null;
    }

    private string GetStatValueText(Win_UserPlayerSeasonStats.StatItem item)
    {
        return null;
    }

    private bool IsPlayerMission(Win_UserPlayerSeasonStats.StatItem item)
    {
        return false;
    }

    private void LoadSelectRoleScene()
    {
    }

    private void OnSelectRoleSceneLoaded(SelectRoleSceneManager manager)
    {
    }

    private void RefreshScenePlayer()
    {
    }

    private void ApplyPlayerModel(PlayerModelLoader playerModelLoader, ClubPlayer player)
    {
    }

    private bool IsGoalkeeper(ClubPlayer player)
    {
        return false;
    }

    public override void OnClose()
    {
    }
}