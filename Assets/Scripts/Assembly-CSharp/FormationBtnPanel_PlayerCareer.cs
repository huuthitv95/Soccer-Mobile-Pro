public class FormationBtnPanel_PlayerCareer : FormationBtnPanelBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnFormation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnEdit;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTacticsStyle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRole;
    [global::UnityEngine.SerializeField]
    public GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Button btnUserPlayerInfo;
    private IMatchManager matchManager;
    private Win_PlayerCareerFormation win_PlayerCareerFormation;
    public override global::UnityEngine.UI.Button BtnFormation => null;
    public override global::UnityEngine.UI.Button BtnEdit => null;
    public override global::UnityEngine.UI.Button BtnTacticsStyle => null;
    public override global::UnityEngine.UI.Button BtnRole => null;

    public void SetPlayerCareerFormation(Win_PlayerCareerFormation win)
    {
    }

    public void Init(IMatchManager matchManager)
    {
    }

    private void OnClickUserPlayerInfo()
    {
    }
}