public class Win_LastDancePointsShop : Win_EventPointsShop
{
    protected override string ConfirmWindowId => null;

    protected override bool ShouldShowRedeemEntry()
    {
        return false;
    }

    protected override global::FLGameData.RewardType[] RewardTypeOrder()
    {
        return null;
    }

    protected override void OnConfirmClick(global::FLDataTable.PointsShopConfig item)
    {
    }
}