public class Win_DeleteAgreementPopUp : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private GUIAgreementItem agreementItem;
    private global::FL.PlayerCareer playerCareer;
    private global::Srv.PlayerCareerTransferAgreement agreement;
    private global::System.Action onConfirmed;
    public Win_DeleteAgreementPopUp Fill(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement agreement, global::System.Action onConfirmed)
    {
        return null;
    }

    private void BindButtons()
    {
    }

    private void OnConfirm()
    {
    }
}