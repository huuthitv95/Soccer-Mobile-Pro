public class FormationBtnPanel_LocalPVP : FormationBtnPanelBase, Win_Formation.IFormationDecorator
{
    private const string PlayerOneBackgroundPath = "Assets/GameData/UI/Windows/PVP/p1BG.prefab";
    private const string PlayerTwoBackgroundPath = "Assets/GameData/UI/Windows/PVP/p2BG.prefab";
    private const string PlayerOneFieldImagePath = "Assets/GameData/UI/Windows/PVP/GUIField_P1.prefab";
    private const string PlayerTwoFieldImagePath = "Assets/GameData/UI/Windows/PVP/GUIField_P2.prefab";
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFormation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnEdit;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTacticsStyle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRole;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p1Marker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p2Marker;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb p1FormationThumb;
    [global::UnityEngine.SerializeField]
    private GUIFormationThumb p2FormationThumb;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSwitch;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p1SelectedMarker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p2SelectedMarker;
    private TeamsData playerOneTeam;
    private TeamsData playerTwoTeam;
    private TeamsData selectedTeam;
    private global::System.Action<TeamsData> onTeamSelected;
    private global::UnityEngine.GameObject playerOneBackground;
    private global::UnityEngine.GameObject playerTwoBackground;
    private global::UnityEngine.GameObject playerOneFieldImage;
    private global::UnityEngine.GameObject playerTwoFieldImage;
    public override global::UnityEngine.UI.Button BtnFormation => null;
    public override global::UnityEngine.UI.Button BtnEdit => null;
    public override global::UnityEngine.UI.Button BtnTacticsStyle => null;
    public override global::UnityEngine.UI.Button BtnRole => null;
    public GUITeam GuiTeam => null;

    public void Initialize(TeamsData p1Team, TeamsData p2Team, TeamsData initialTeam, global::System.Action<TeamsData> teamSelectedAction)
    {
    }

    public void Refresh(TeamsData activeTeam)
    {
    }

    public void RefreshFormation(TeamsData team)
    {
    }

    private void SwitchTeam()
    {
    }

    private void UpdateSelection(TeamsData activeTeam)
    {
    }

    private static void SetFormationDark(GUIFormationThumb formationThumb, bool visible)
    {
    }

    public void ChangeFieldImage(global::UnityEngine.Transform parent)
    {
    }

    public void ChangeBg(global::UnityEngine.Transform parent)
    {
    }
}