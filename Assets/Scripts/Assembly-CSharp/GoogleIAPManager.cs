public class GoogleIAPManager : global::Common.Singleton<GoogleIAPManager>
{
    private const string payClassName = "com.androidgamegou.googleiap.GoogleBillingPay";
    public void Init(string inAppSkus, string subsSkus)
    {
    }

    public void SetIsAutoConsumeAsync(bool autoConsume)
    {
    }

    public void SetConsumables(string consumables)
    {
    }

    public void QueryInventoryInApp()
    {
    }

    public void QueryPurchasesInApp()
    {
    }

    public void QueryPurchasesInApp(string requestId)
    {
    }

    public void QuerySkuDetail(string sku, string skuType)
    {
    }

    public void Buy(string buykey)
    {
    }

    public void ConsumOrders(string token)
    {
    }

    public void ConsumOrders(string operationId, string token)
    {
    }

    public void AcknowledgeOrders(string token)
    {
    }

    public void AcknowledgeOrders(string operationId, string token)
    {
    }
}