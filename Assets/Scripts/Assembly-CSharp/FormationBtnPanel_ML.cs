public class FormationBtnPanel_ML : FormationBtnPanelBase
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
    private global::UnityEngine.UI.Button btnPlayerManager;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlayersContract;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSalePlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlayerExp;
    public override global::UnityEngine.UI.Button BtnFormation => null;
    public override global::UnityEngine.UI.Button BtnEdit => null;
    public override global::UnityEngine.UI.Button BtnTacticsStyle => null;
    public override global::UnityEngine.UI.Button BtnRole => null;
    public global::UnityEngine.UI.Button BtnPlayerManager => null;
    public global::UnityEngine.UI.Button BtnPlayersContract => null;
    public global::UnityEngine.UI.Button BtnSalePlayer => null;
    public global::UnityEngine.UI.Button BtnPlayerExp => null;

    public void ShowPlayerManager(global::System.Action openView)
    {
    }

    public void ShowPlayerContract(global::System.Func<Win_PlayerContract> openView, global::System.Action onClose)
    {
    }

    public void ShowSalePlayer(global::System.Action openView)
    {
    }

    public void ShowPlayerExp(global::System.Action openView)
    {
    }
}