public class Win_MasterLeagueChoosePlayer : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform guiPlayersNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] selectedPlayers;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPre;
    [global::UnityEngine.SerializeField]
    private GUITeam teamItem;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.List<ClubPlayer>> allPlayers;
    private global::System.Collections.Generic.List<ClubPlayer> selectedPlayersList;
    private global::System.Collections.Generic.List<ClubPlayer> otherPlayers;
    public void Fill(global::System.Collections.Generic.List<global::System.Collections.Generic.List<ClubPlayer>> allPlayers, global::System.Collections.Generic.List<ClubPlayer> others, TeamsData team, global::System.Collections.Generic.List<ClubPlayer> selectedPlayers, global::System.Action nextAction)
    {
    }

    private void UpdateSelectedPlayers()
    {
    }
}