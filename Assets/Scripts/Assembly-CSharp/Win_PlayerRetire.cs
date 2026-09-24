public class Win_PlayerRetire : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    private global::System.Collections.Generic.List<ClubPlayer> players;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(RegionalLeague regionalLeague, TeamsData team, global::System.Action nextAction)
    {
    }
}