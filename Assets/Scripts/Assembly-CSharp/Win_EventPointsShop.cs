public class Win_EventPointsShop : global::Common.WindowBase
{
    private static readonly global::FLGameData.RewardType[] TabRewardTypeOrder;
    [global::UnityEngine.SerializeField]
    private GUIPointsShopItem[] templateByTypeOrder;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle[] tabsByRewardType;
    [global::UnityEngine.SerializeField]
    private ScrollRectToggleLocator locator;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text curPointText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button backBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRedeem;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.GameObject> generatedItems;
    private global::FL.PointsStoreMananger storeManager;
    protected virtual string ConfirmWindowId => null;

    protected virtual global::FLGameData.RewardType[] RewardTypeOrder()
    {
        return null;
    }

    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::FL.PointsStoreMananger storeManager)
    {
    }

    private void BuildItems(global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> datas)
    {
    }

    private void HideTemplatesAndTabs()
    {
    }

    private int CompareShopItem(global::FLDataTable.PointsShopConfig x, global::FLDataTable.PointsShopConfig y)
    {
        return 0;
    }

    private bool IsItemUnavailable(global::FLDataTable.PointsShopConfig config)
    {
        return false;
    }

    private bool IsRewardOwned(global::FLDataTable.PointsShopConfig config)
    {
        return false;
    }

    private bool IsAppearanceItemUnlocked(int itemId)
    {
        return false;
    }

    private int GetRewardTypeIndex(global::FLGameData.RewardType rewardType)
    {
        return 0;
    }

    private int GetTabRewardTypeIndex(global::FLGameData.RewardType rewardType)
    {
        return 0;
    }

    public void OnItemClick(GUIPointsShopItem uiNode, global::FLDataTable.PointsShopConfig item)
    {
    }

    protected virtual void OnConfirmClick(global::FLDataTable.PointsShopConfig item)
    {
    }

    private void UpdatePoints(int count)
    {
    }

    private void UpdateRedeemEntry()
    {
    }

    protected virtual bool ShouldShowRedeemEntry()
    {
        return false;
    }

    protected virtual void OpenRedeem()
    {
    }

    public override void OnClose()
    {
    }

    private void ClearGeneratedItems()
    {
    }
}