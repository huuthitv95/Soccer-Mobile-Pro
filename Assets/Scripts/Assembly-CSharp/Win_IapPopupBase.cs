public abstract class Win_IapPopupBase : global::Common.WindowBase
{
    protected global::FL.IAP.IapStoreEntryPoint entryPoint;
    protected bool purchased;
    [global::UnityEngine.SerializeField]
    protected global::System.Collections.Generic.List<GUIIAPItem> datas;
    [global::UnityEngine.SerializeField]
    private Win_IAPStore.IapPageType targetPage;
    public global::System.Action OnOpenStore;
    public override void OnOpen(object parameter)
    {
    }

    protected void InitItems()
    {
    }

    public override void OnClose()
    {
    }

    protected virtual void OnPurchaseSuccess(BaseIAPItemInfo data, GUIIAPItem gui)
    {
    }

    protected virtual void OnBuyButtonClicked(BaseIAPItemInfo data, GUIIAPItem gui)
    {
    }

    public void OpenStore()
    {
    }
}