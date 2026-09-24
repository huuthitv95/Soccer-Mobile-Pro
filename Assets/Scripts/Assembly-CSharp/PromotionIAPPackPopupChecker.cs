internal static class PromotionIAPPackPopupChecker
{
    private const int DailyLimit = 2;
    private const int IntervalSeconds = 600;
    private const string DateKey = "promotion_iap_pack_popup_date";
    private const string CountKey = "promotion_iap_pack_popup_count";
    private const string LastShowTimeKey = "promotion_iap_pack_popup_last_show_time";
    private const string OpenStoreDateKey = "promotion_iap_pack_popup_open_store_date";
    public static bool TryShow()
    {
        return false;
    }

    private static bool CanShow()
    {
        return false;
    }

    private static bool CanPurchase()
    {
        return false;
    }

    private static int GetShowCount(int today)
    {
        return 0;
    }

    private static void MarkShown()
    {
    }

    private static void OnPopupShown(Win_IAPPackPopup popup)
    {
    }

    private static void MarkOpenStore()
    {
    }
}