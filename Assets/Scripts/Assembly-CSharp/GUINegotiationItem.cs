public class GUINegotiationItem : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text valueText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image leagueIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text oddsText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject inprogressNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject completeNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle selectedToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic[] leagueLevelGraphics;
    [global::UnityEngine.SerializeField]
    private GUINegotiationResultEffect optionalResultEffect;
    private global::FL.PlayerCareer playerCareer;
    private global::Srv.PlayerCareerTransferOffer offer;
    private global::System.Action<GUINegotiationItem> onSelected;
    public global::Srv.PlayerCareerTransferOffer Offer => null;

    public void Fill(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferOffer offer, global::System.Action<GUINegotiationItem> onSelected)
    {
    }

    public void FillDisplay(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferOffer offer)
    {
    }

    public void FillDisplay(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement agreement)
    {
    }

    public void SetSelected(bool selected)
    {
    }

    public void SetSelectionInteractable(bool interactable)
    {
    }

    private void UpdateOfferInfo(global::Srv.PlayerCareerTransferOffer offer)
    {
    }

    private void UpdateInfo(int teamId, int successOdds, int leagueProtoId, string regionalLeague, int leagueLevel, bool completed)
    {
    }

    private global::SL.LeagueProto ResolveLeagueProto(int leagueProtoId)
    {
        return null;
    }

    private void BindSelection(bool enabled)
    {
    }

    public bool IsForOffer(global::Srv.PlayerCareerTransferOffer targetOffer)
    {
        return false;
    }

    public void RefreshOfferState()
    {
    }

    public bool PlayNegotiationResultEffect(bool succeeded, global::System.Action onStateSwitch, global::System.Action onComplete, float durationScale = 1f)
    {
        return false;
    }

    private void OnDisable()
    {
    }

    private void HideNegotiationResultEffect()
    {
    }

    private void OnSelectedChanged(bool isOn)
    {
    }
}