public class Win_ReplaceAgreementPopUp : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIAgreementItem oldAgreementItem;
    [global::UnityEngine.SerializeField]
    private GUINegotiationItem newAgreementItem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCancel;
    private global::FL.PlayerCareer playerCareer;
    private global::Srv.PlayerCareerTransferAgreement oldAgreement;
    private global::Srv.PlayerCareerTransferAgreement newAgreement;
    private global::System.Action onConfirmed;
    public override void OnOpen(object parameter)
    {
    }

    public Win_ReplaceAgreementPopUp Fill(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement oldAgreement, global::Srv.PlayerCareerTransferAgreement newAgreement, global::System.Action onConfirmed)
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