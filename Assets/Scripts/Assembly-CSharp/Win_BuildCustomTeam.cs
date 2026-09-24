public class Win_BuildCustomTeam : global::Common.WindowBase
{
    private enum NodeType
    {
        Formation = 0,
        ChooseCaptain = 1,
        ChooseStarter = 2,
        ChooseSubs = 3,
        ShowTeams = 4,
        Count = 5
    }

    public enum ChoosePlayerType
    {
        Captain = 0,
        Starter = 1,
        FrontSub = 2,
        MidSub = 3,
        BackSub = 4,
        GKSub = 5
    }

    [global::System.Serializable]
    private class PlayerOptions
    {
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.Transform> PlayerItems;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Button btnConfirm;
        private int currentSelectedIndex;
        private ClubPlayer currentPlayer;
        private void UpdateSelectState()
        {
        }

        public void Init(in global::FL.SmallBuffer16<int> players, global::System.Action<ClubPlayer> OnSelected, global::FL.CustomTeamChallengeManager.SpecialPlayerState specialPlayerState, bool doubleCheck)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] nodes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_confirm;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo reDraftBtn;
    [global::UnityEngine.SerializeField]
    private Win_BuildCustomTeam.PlayerOptions captainOptions;
    [global::UnityEngine.SerializeField]
    private Win_BuildCustomTeam.PlayerOptions starterOptions;
    [global::UnityEngine.SerializeField]
    private Win_BuildCustomTeam.PlayerOptions subsOptions;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject windowContent;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private GUITeam gUITeam;
    private global::FL.CustomTeamChallengeManager controller;
    private global::UnityEngine.UI.Text titleBackUp;
    public override void OnOpen(object parameter)
    {
    }

    private void ShowNode(Win_BuildCustomTeam.NodeType type)
    {
    }

    public void ChooseFormation()
    {
    }

    public void ChoosePlayer(Win_BuildCustomTeam.ChoosePlayerType choosePlayerType, FormationTool.UIRole currentRole, global::FL.SmallBuffer16<int> players)
    {
    }

    private void ChooseCaptain(global::FL.SmallBuffer16<int> players, FormationTool.UIRole currentRole)
    {
    }

    private void ChooseStarter(global::FL.SmallBuffer16<int> players, FormationTool.UIRole currentRole)
    {
    }

    private void ChooseSubs(global::FL.SmallBuffer16<int> players, Win_BuildCustomTeam.ChoosePlayerType choosePlayerType)
    {
    }

    public void ShowTeam(global::System.Action onConfirm)
    {
    }

    private void UpdateStarterView(global::UnityEngine.Transform fromationList, FormationTool.UIRole currentRole)
    {
    }

    public void UpdateSubsView(global::UnityEngine.Transform fromationList)
    {
    }

    private void UpdatePlayerList(global::UnityEngine.Transform list, global::FL.SmallBuffer16<int> players, FormationTool.UIRole currentRole, bool isCaptain)
    {
    }

    private void OnChoosePlayer(ClubPlayer player, FormationTool.UIRole currentRole, bool isCaptain)
    {
    }

    private void UpdateFormationViewItem(global::UnityEngine.Transform item, ClubPlayer player, bool current, string name)
    {
    }

    private void OnChooseFormation(global::SL.FormationTemplate data)
    {
    }
}