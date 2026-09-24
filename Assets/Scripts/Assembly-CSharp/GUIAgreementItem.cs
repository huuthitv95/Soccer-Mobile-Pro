public class GUIAgreementItem : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image leagueIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leagueNameText;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text valueText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnDelete;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle favorToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject argreementNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject emptyNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic[] leagueLevelGraphics;
    private global::Srv.PlayerCareerTransferAgreement agreement;
    private global::FL.PlayerCareer playerCareer;
    private global::System.Action onChanged;
    public void Fill(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement agreement, global::System.Action onChanged)
    {
    }

    public void FillDisplay(global::FL.PlayerCareer playerCareer, global::Srv.PlayerCareerTransferAgreement agreement)
    {
    }

    private void UpdateAgreementInfo()
    {
    }

    private global::SL.LeagueProto ResolveLeagueProto()
    {
        return null;
    }

    private void BindEvents()
    {
    }

    private void ResetEvents()
    {
    }

    private void SetInteractionVisible(bool visible)
    {
    }

    private void OnDeleteClick()
    {
    }

    private void OnFavoriteChanged(bool favorite)
    {
    }
}