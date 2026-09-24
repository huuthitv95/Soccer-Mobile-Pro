public class Win_RTCChallengeWelcome : global::Common.WindowBase
{
    public enum ButtonType
    {
        Next = 0,
        Close = 1,
        NextAndClose = 2
    }

    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb formation;
    [global::UnityEngine.SerializeField]
    private GUIPlayer[] players;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text desc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private GUIPlayer[] playerInFormation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOk;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    public override void OnOpen(object parameter)
    {
    }

    private void UpdateForCompetitionChallenge(CompetitionChallengeEventMgr competitionChallenge)
    {
    }

    private void UpdateForRTC(global::FL.IChampionshipRoadEventController controller)
    {
    }

    public void ShowCloseButton(Win_RTCChallengeWelcome.ButtonType buttonType = Win_RTCChallengeWelcome.ButtonType.Next)
    {
    }

    public void SetNextButtonAction(global::System.Action action)
    {
    }
}