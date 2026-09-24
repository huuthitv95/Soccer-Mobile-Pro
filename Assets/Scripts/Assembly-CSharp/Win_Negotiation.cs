public class Win_Negotiation : global::Common.WindowBase
{
    public class Parameter
    {
        public global::FL.PlayerCareer PlayerCareer;
        public FixtureListData FixtureListData;
        public global::UnityEngine.Events.UnityAction OnNegotiationCompleted;
        public global::System.Func<global::UnityEngine.GameObject> TakePlayerModelForNegotiationAnimation;
        public global::System.Action<global::UnityEngine.GameObject> StorePlayerModelFromNegotiationAnimation;
    }

    private const int NoPendingActiveSearchTeamId = -1;
    private string[] messageIds;
    private string popupMessageId;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform negotiationListRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text messageText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNoChance;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnArgreement;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text chanceProgressText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button freeNEGBtn;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo RV_NEG;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo serachRV;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject noChanceNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject negotiationNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text currentMatchBonusText;
    private global::FL.PlayerCareer playerCareer;
    private FixtureListData fixtureListData;
    private global::UnityEngine.Events.UnityAction onNegotiationCompleted;
    private global::System.Func<global::UnityEngine.GameObject> takePlayerModelForNegotiationAnimation;
    private global::System.Action<global::UnityEngine.GameObject> storePlayerModelFromNegotiationAnimation;
    private global::Srv.PlayerCareerTransferOffer selectedOffer;
    private int pendingActiveSearchTeamId;
    private UIListItemRevealAnimation activeSearchResultAnimation;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Negotiation Fill(global::FL.PlayerCareer playerCareer, FixtureListData fixtureListData, global::UnityEngine.Events.UnityAction onNegotiationCompleted)
    {
        return null;
    }

    private void BindButtons()
    {
    }

    private void Refresh()
    {
    }

    private void RefreshOfferItems()
    {
    }

    private void ResetOfferItemRevealState(global::UnityEngine.Transform item)
    {
    }

    private UIListItemRevealAnimation GetActiveSearchResultAnimation()
    {
        return null;
    }

    private int GetFirstOfferIndex()
    {
        return 0;
    }

    private global::UnityEngine.Transform GetOfferTemplate(int firstOfferIndex)
    {
        return null;
    }

    private void OnOfferSelected(GUINegotiationItem item)
    {
    }

    private void UnselectOtherItems(GUINegotiationItem selectedItem)
    {
    }

    private void RefreshButtonState(bool refreshChanceNodes = true)
    {
    }

    private void NegotiateSelectedOffer()
    {
    }

    private void OnNegotiationVideoSucceed()
    {
    }

    private void HandleNegotiationResult(global::FL.PlayerCareerTransferNegotiationResult result)
    {
    }

    private bool TryOpenNegotiationAnimation(global::FL.PlayerCareerTransferNegotiationResult result, global::System.Action onAnimationClosed)
    {
        return false;
    }

    private void PlayNegotiationResultEffect(global::FL.PlayerCareerTransferNegotiationResult result, GUINegotiationItem resultItem)
    {
    }

    private GUINegotiationItem FindOfferItem(global::Srv.PlayerCareerTransferOffer offer)
    {
        return null;
    }

    private void ClearOfferSelection()
    {
    }

    private void SetOfferItemsSelectionInteractable(bool interactable)
    {
    }

    private void CompleteNegotiationResult(global::FL.PlayerCareerTransferNegotiationResult result, bool refreshOfferItems = false)
    {
    }

    private void OpenReplaceAgreement(global::Srv.PlayerCareerTransferAgreement pendingAgreement)
    {
    }

    private void OpenActiveSearchSelector()
    {
    }

    private void UpdateActiveSearchTeamItem(global::UnityEngine.GameObject item, TeamsData team)
    {
    }

    private TeamsData GetDefaultSearchTeam(global::System.Collections.Generic.IList<global::FL.PlayerCareerTransferSearchLeague> searchLeagues)
    {
        return null;
    }

    private void OnActiveSearchTeamSelected(Win_ChooseTeam win)
    {
    }

    private void OnActiveSearchSelectorClosed()
    {
    }

    private void OpenAgreementList()
    {
    }

    private void OnNextButtonClicked()
    {
    }

    private void OpenForfeitConfirm()
    {
    }

    private void CompleteNegotiation()
    {
    }

    private void SetMessage(int index)
    {
    }

    public override void OnClose()
    {
    }
}