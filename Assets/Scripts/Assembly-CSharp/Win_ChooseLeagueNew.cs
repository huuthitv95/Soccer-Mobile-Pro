public class Win_ChooseLeagueNew : global::Common.WindowBase
{
    [global::System.Serializable]
    private class SingleLeagueInfoNode
    {
        public global::UnityEngine.UI.Text Name;
        public global::UnityEngine.UI.Text Capacity;
        public global::UnityEngine.Transform cupTransform;
        public global::UnityEngine.UI.RawImage cupIcon;
        public global::UnityEngine.GameObject gameObject;
    }

    private enum LeagueType
    {
        Master = 0,
        SimpleMen = 1,
        SimpleWomen = 2
    }

    [global::UnityEngine.SerializeField]
    private GUILeagueLevelInfo[] leagueLevelsNodes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject multipleLevelsNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform leagueList;
    [global::UnityEngine.SerializeField]
    private Win_ChooseLeagueNew.SingleLeagueInfoNode singleLeagueInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button CreateCustomLeague;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button CreateCustomLeague_bottomBanner;
    private RegionalLeagueWrap selected;
    private Win_ChooseLeagueNew.LeagueType leagueType;
    public override void OnOpen(object parameter)
    {
    }

    private void UpdateLeagueLevels(RegionalLeagueWrap league)
    {
    }

    private void UpdateLeagueInfoToggle(global::UnityEngine.Transform item, RegionalLeagueWrap league)
    {
    }

    private void UpdateLeagueList(global::System.Collections.Generic.List<RegionalLeagueWrap> leagues)
    {
    }

    public void FillMasterLeague()
    {
    }

    public void FillSimpleLeague(bool isWomen)
    {
    }

    public void Refresh()
    {
    }

    private void RefreshSimpleLeague()
    {
    }

    private void RefreshMasterLeague()
    {
    }

    private void InitCreateCustomLeague()
    {
    }
}