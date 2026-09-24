public class Win_TransferTargetChooser : global::Common.WindowBase
{
    private enum SelectionType
    {
        None = 0,
        Renewal = 1,
        Agreement = 2,
        FinalOffer = 3
    }

    public class Parameter
    {
        public global::FL.PlayerCareer PlayerCareer;
        public global::UnityEngine.Events.UnityAction OnTargetSelected;
    }

    private string[] messagesId;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text message;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform agreementListRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSign;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo btn_refreshFinalOffer;
    private global::FL.PlayerCareer playerCareer;
    private global::UnityEngine.Events.UnityAction onTargetSelected;
    private Win_TransferTargetChooser.SelectionType selectedType;
    private global::Srv.PlayerCareerTransferAgreement selectedAgreement;
    private global::Srv.PlayerCareerTransferOffer selectedOffer;
    public override void OnOpen(object parameter)
    {
    }

    public Win_TransferTargetChooser Fill(global::FL.PlayerCareer playerCareer, global::UnityEngine.Events.UnityAction onTargetSelected)
    {
        return null;
    }

    private void BindButtons()
    {
    }

    private void Refresh()
    {
    }

    private void FillAgreementItems()
    {
    }

    private void FillFinalOfferItems()
    {
    }

    private global::Srv.PlayerCareerTransferAgreement CreateRenewalAgreement()
    {
        return null;
    }

    private global::Srv.PlayerCareerTransferAgreement CreateAgreementFromOffer(global::Srv.PlayerCareerTransferOffer offer)
    {
        return null;
    }

    private global::UnityEngine.Transform GetItem(int index)
    {
        return null;
    }

    private void BindToggle(global::UnityEngine.Transform item, global::UnityEngine.Events.UnityAction onSelected)
    {
    }

    private global::UnityEngine.UI.Toggle GetItemToggle(global::UnityEngine.Transform item)
    {
        return null;
    }

    private void SelectRenewal()
    {
    }

    private void SelectAgreement(global::Srv.PlayerCareerTransferAgreement agreement)
    {
    }

    private void SelectFinalOffer(global::Srv.PlayerCareerTransferOffer offer)
    {
    }

    private void SignSelectedTarget()
    {
    }

    private void RefreshFinalOffersByVideo()
    {
    }

    private void ClearSelection()
    {
    }

    private void UpdateSignButton()
    {
    }

    private bool IsFinalOfferEvent()
    {
        return false;
    }

    private void SetMessage(int index)
    {
    }
}