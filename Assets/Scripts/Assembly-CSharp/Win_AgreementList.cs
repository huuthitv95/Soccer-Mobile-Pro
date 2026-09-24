public class Win_AgreementList : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIAgreementItem[] agreementItems;
    [global::UnityEngine.SerializeField]
    private GUIRenewalMission renewalMissionItem;
    private global::FL.PlayerCareer playerCareer;
    public override void OnOpen(object parameter)
    {
    }

    public Win_AgreementList Fill(global::FL.PlayerCareer playerCareer)
    {
        return null;
    }

    private void Refresh()
    {
    }

    private void UpdateAgreementItems()
    {
    }

    private void OnAgreementItemChanged(global::Srv.PlayerCareerTransferAgreement changedAgreement)
    {
    }

    private void CancelOtherFavorites(global::Srv.PlayerCareerTransferAgreement favoriteAgreement)
    {
    }

    private void UpdateRenewalMission()
    {
    }
}