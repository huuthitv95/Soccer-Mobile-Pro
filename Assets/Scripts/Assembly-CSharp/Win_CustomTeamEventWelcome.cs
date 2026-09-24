public class Win_CustomTeamEventWelcome : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text challengeName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text desc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerList;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFree;
    [global::UnityEngine.SerializeField]
    private GUITeam[] rewardTeams;
    [global::UnityEngine.SerializeField]
    private GUIPlayer[] rewardPlayers;
    private global::FL.CustomTeamChallengeManager controller;
    public global::System.Action OnStartEvent;
    public override void OnOpen(object parameter)
    {
    }

    public void HideStartButton()
    {
    }

    private void StartEvent()
    {
    }

    private void UpdatePlayerList()
    {
    }
}