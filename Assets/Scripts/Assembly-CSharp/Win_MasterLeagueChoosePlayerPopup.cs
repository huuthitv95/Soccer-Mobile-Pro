public class Win_MasterLeagueChoosePlayerPopup : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform forwardList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform midfieldList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform defenceList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text progressText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnNext;
    [global::UnityEngine.SerializeField]
    private GUITeam teamItem;
    public void Fill(global::System.Collections.Generic.List<global::System.Collections.Generic.List<ClubPlayer>> allPlayers, global::System.Collections.Generic.List<ClubPlayer> selectedPlayers, TeamsData team, global::System.Collections.Generic.List<ClubPlayer> others, global::System.Action nextAction)
    {
    }

    private void UpdateProgressText(global::System.Collections.Generic.List<ClubPlayer> selectedPlayers)
    {
    }

    private void InitList(global::UnityEngine.Transform targetList, global::System.Collections.Generic.List<ClubPlayer> players, global::System.Collections.Generic.List<ClubPlayer> selectedPlayers)
    {
    }
}