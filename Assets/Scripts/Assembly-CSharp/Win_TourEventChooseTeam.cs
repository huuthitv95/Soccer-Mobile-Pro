public class Win_TourEventChooseTeam : global::Common.WindowBase
{
    private struct GUITeamData
    {
        private global::UnityEngine.UI.Image teamIcon;
        private global::UnityEngine.UI.Text nameText;
        private global::UnityEngine.UI.Toggle toggle;
        public global::UnityEngine.UI.Toggle Toggle => null;

        public GUITeamData(global::UnityEngine.Transform node)
        {
            teamIcon = null;
            nameText = null;
            toggle = null;
        }

        public void Updater(TeamsData team, string teamName)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform teamList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject teamChild0;
    [global::UnityEngine.SerializeField]
    private GUIPlayer[] starter;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb formationThumb;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform substituteList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject substituteItemChild0;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo refreshRV;
    private const int StarterCount = 11;
    private global::FL.TourEvent.TourEventManager manager;
    private global::System.Collections.Generic.List<global::FL.TourEvent.SelectableTeamTemplateConfig> teamTemplates;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Toggle> teamToggles;
    private int selectedTemplateId;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action m_OnTeamConfirmed;
    public event global::System.Action OnTeamConfirmed
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void BindButtons()
    {
    }

    private void BuildTeamList()
    {
    }

    private void SelectDefaultTeam()
    {
    }

    private void SelectTeam(int templateTeamId)
    {
    }

    private void UpdateTeamToggles()
    {
    }

    private void RefreshPreview(TeamsData previewTeam)
    {
    }

    private void UpdateStarterPlayers(TeamsData previewTeam)
    {
    }

    private void UpdateSubstitutePlayers(TeamsData previewTeam)
    {
    }

    private GUIPlayer GetSubstituteGUIPlayer(global::UnityEngine.Transform item)
    {
        return null;
    }

    private void HidePlayerViews()
    {
    }

    private void OnRefreshVideoSucceed()
    {
    }

    private void OnConfirmClick()
    {
    }

    private TeamsData LoadTeam(int teamId)
    {
        return null;
    }
}