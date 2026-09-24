public class Win_RejectAgreementPopUp : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUINegotiationItem agreementItem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCancel;
    private global::FL.PlayerCareer playerCareer;
    private global::Srv.PlayerCareerTransferAgreement agreement;
    private global::System.Action onConfirmed;
    public override void OnOpen(object parameter)
    {
    }

    public Win_RejectAgreementPopUp Fill(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement agreement, global::System.Action onConfirmed)
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