public class Win_ReplaceAgreement : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIAgreementItem[] agreementItems;
    [global::UnityEngine.SerializeField]
    private GUINegotiationItem newAgreementItem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle[] agreementIteamsToggles;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button replaceBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button rejectBtn;
    private global::FL.PlayerCareer playerCareer;
    private global::Srv.PlayerCareerTransferAgreement pendingAgreement;
    private global::Srv.PlayerCareerTransferAgreement selectedAgreement;
    private global::System.Action onResolved;
    public Win_ReplaceAgreement Fill(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement pendingAgreement, global::System.Action onResolved)
    {
        return null;
    }

    private void Refresh()
    {
    }

    private void BindButtons()
    {
    }

    private void OnAgreementToggleChanged(int index, bool isOn)
    {
    }

    private void UpdateReplaceButton()
    {
    }

    private void OpenReplaceConfirm()
    {
    }

    private void OpenRejectConfirm()
    {
    }
}