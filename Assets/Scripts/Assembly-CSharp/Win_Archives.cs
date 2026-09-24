public class Win_Archives : global::Common.WindowBase
{
    public struct ArchiveInfo
    {
        public object archiveData;
        public EditableSpirit matchLogo;
        public string DisplayName;
        public string RoundName;
        public long RecordTime;
        public int teamRating;
        public TeamsData placeholderTeam;
        public string TimeString => null;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    private FACup curCup;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Archives FillSimpleLeague(bool isWomenLeague)
    {
        return null;
    }

    public Win_Archives FillMasterLeague(bool isWomenLeague = false)
    {
        return null;
    }

    public static global::System.Collections.Generic.List<RegionalLeagueWrap> CheckSimpleLeagueArchives(bool isWomenLeague)
    {
        return null;
    }

    public static global::System.Collections.Generic.List<RegionalLeagueWrap> CheckMasterLeauge(bool isWomenLeague = false)
    {
        return null;
    }

    private static global::System.Collections.Generic.List<RegionalLeagueWrap> CheckLeagueArchives(RegionalLeagueLoader loader, bool isSimple, bool isWomenLeague)
    {
        return null;
    }

    private void UpdateTeamInfo(global::UnityEngine.UI.Image icon, global::UnityEngine.UI.Text name, GUIRatingStar[] stars, TeamsData team, int rating)
    {
    }

    private void FillLeague(RegionalLeagueLoader loader, int slotCount, bool isMasterLeague, bool isSimple, bool isWomenLeague)
    {
    }

    public static global::System.Collections.Generic.List<FACup> CheckCupArchives(FACupManager.ActivityCupType activityCupType = FACupManager.ActivityCupType.IndependentSaveLimit)
    {
        return null;
    }

    public static global::System.Collections.Generic.List<FACup> CheckChampionArchives()
    {
        return null;
    }

    public static global::System.Collections.Generic.List<FACup> CheckCupArchives(global::System.Collections.Generic.List<FACup> all, FACupManager.ActivityCupType activityCupType = FACupManager.ActivityCupType.IndependentSaveLimit)
    {
        return null;
    }

    public Win_Archives FillChampions(global::System.Action createAction)
    {
        return null;
    }

    public Win_Archives FillCup(FACupManager.ActivityCupType activityCupType = FACupManager.ActivityCupType.IndependentSaveLimit, global::System.Action createAction = null)
    {
        return null;
    }

    private Win_Archives FillCup(global::System.Collections.Generic.List<FACup> cups, global::System.Action<FACup> deleteAction, global::System.Action createAction, global::System.Action resetLastPlay, bool IsActivityCup = false, bool isNationActivityCup = false)
    {
        return null;
    }

    private void UpdateList(global::System.Collections.Generic.List<Win_Archives.ArchiveInfo> archiveInfos, global::UnityEngine.Events.UnityAction<object> OnDel, global::UnityEngine.Events.UnityAction OnCreate, global::UnityEngine.Events.UnityAction<object> onSelect, int slotCount)
    {
    }

    public override void OnClose()
    {
    }
}