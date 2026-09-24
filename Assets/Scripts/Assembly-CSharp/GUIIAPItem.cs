public abstract class GUIIAPItem : global::UnityEngine.MonoBehaviour
{
    protected enum ProductState
    {
        Normal = 0,
        Purchased = 1,
        Unavailable = 2
    }

    [global::UnityEngine.SerializeField]
    private string productID;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text priceText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBuy;
    [global::UnityEngine.SerializeField]
    private IGUIIAPComponents[] components;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] purchasableEffectObjects;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Behaviour[] purchasableEffectBehaviours;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Animator[] purchasableEffectAnimators;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.ParticleSystem[] purchasableEffectParticles;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Canvas[] purchasableEffectCanvases;
    protected BaseIAPItemInfo data;
    protected GUIIAPItem.ProductState state;
    private global::System.Action<BaseIAPItemInfo, GUIIAPItem> onBuySuccess;
    private global::System.Action<BaseIAPItemInfo, GUIIAPItem> onBuyButtonClicked;
    public bool AlwaysNeedRefresh { get; protected set; }
    public bool IsPurchasable => false;

    public void Init(global::System.Action<BaseIAPItemInfo, GUIIAPItem> onBuySuccess, global::System.Action<BaseIAPItemInfo, GUIIAPItem> onBuyButtonClicked)
    {
    }

    public bool HasBallOrJerseyID(int id)
    {
        return false;
    }

    public bool HasStadiumRewardType(global::FLGameData.RewardType rewardType)
    {
        return false;
    }

    public virtual void Refresh()
    {
    }

    private void LoadData()
    {
    }

    protected void LoadData(string id)
    {
    }

    private void RefreshPurchasableEffects()
    {
    }

    protected abstract void OnInit();
    protected virtual void Buy()
    {
    }

    protected virtual void OnBuySuccess()
    {
    }

    protected internal virtual void OnBuyFailed(global::FL.IAP.PurchaseError error)
    {
    }
}