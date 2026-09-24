public class Win_IAPStore : global::Common.WindowBase
{
    public enum IapPageType
    {
        Package = 0,
        Resources = 1,
        Others = 2
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle[] tabs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject noAdNormal;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject noAdPromotion;
    private static readonly global::UnityEngine.Vector3[] corners;
    private Win_IAPStore.IapPageType targetPageType;
    private bool init;
    private global::System.Collections.Generic.List<GUIIAPItem> datas;
    private global::FL.IAP.IapStoreEntryPoint point;
    private bool purchased;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRestorePurchases;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    public void SwitchToPage(Win_IAPStore.IapPageType pageType)
    {
    }

    public void SwitchToPageForJersey(int ballOrJerseyId)
    {
    }

    public void SwitchToStadiumItem(global::FLGameData.RewardType rewardType)
    {
    }

    private void SetPageToggleState(Win_IAPStore.IapPageType pageType, bool notify)
    {
    }

    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    private void RecoverFromOcclusion()
    {
    }

    private void OnEnable()
    {
    }

    private global::System.Collections.IEnumerator InitCoroutine()
    {
        return null;
    }

    public override void OnOpen(object parameter)
    {
    }

    private void CollectItems()
    {
    }

    private void InitItems()
    {
    }

    private global::System.Collections.IEnumerator SwitchToBallOrJerseyCoroutine(int ballOrJerseyId)
    {
        return null;
    }

    private global::System.Collections.IEnumerator SwitchToStadiumItemCoroutine(global::FLGameData.RewardType rewardType)
    {
        return null;
    }

    private GUIIAPItem FindItemByBallOrJerseyID(int ballOrJerseyId)
    {
        return null;
    }

    private GUIIAPItem FindItemByStadiumRewardType(global::FLGameData.RewardType rewardType)
    {
        return null;
    }

    private void ScrollToCenter(global::UnityEngine.RectTransform target)
    {
    }

    private void StopPageLocatorScroll()
    {
    }

    private float CalculateCenteredNormalizedPosition(global::UnityEngine.UI.ScrollRect scrollRect, global::UnityEngine.RectTransform viewport, global::UnityEngine.RectTransform content, global::UnityEngine.RectTransform target, int axis)
    {
        return 0f;
    }

    private static global::UnityEngine.Bounds GetBoundsInView(global::UnityEngine.RectTransform rect, ref global::UnityEngine.Matrix4x4 viewWorldToLocal)
    {
        return default;
    }

    private void OnBuyButtonClicked(BaseIAPItemInfo data, GUIIAPItem gui)
    {
    }

    public override void OnClose()
    {
    }

    private void OnPurchaseSuccess(BaseIAPItemInfo data, GUIIAPItem gui)
    {
    }

    private void RefreshAll()
    {
    }

    private void SetRestorePurchasesLoading(bool isLoading)
    {
    }

    public void Resore()
    {
    }
}