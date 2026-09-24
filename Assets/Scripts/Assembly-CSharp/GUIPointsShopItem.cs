public class GUIPointsShopItem : global::UnityEngine.MonoBehaviour
{
    private global::FLGameData.RewardType goodsType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button itemButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text priceText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject purchaseLimitFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text coinNumText;
    [global::UnityEngine.SerializeField]
    private GUICoinIcon coinIcon;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text yearText;
    [global::UnityEngine.SerializeField]
    private GUIPlayer guiPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage itemIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text itemNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent<int> OnPlayerFilled;
    private global::FLDataTable.PointsShopConfig shopConfig;
    private global::UnityEngine.Events.UnityAction<GUIPointsShopItem, global::FLDataTable.PointsShopConfig> onClickEvent;
    public void DownSize()
    {
    }

    public void DisableClick()
    {
    }

    public void Init(global::FLDataTable.PointsShopConfig shopConfig, bool unavailable, global::UnityEngine.Events.UnityAction<GUIPointsShopItem, global::FLDataTable.PointsShopConfig> onClickEvent)
    {
    }

    private void UpdateGoods()
    {
    }

    private void UpdateCoins()
    {
    }

    private void UpdateClassicTeam()
    {
    }

    private void UpdatePlayer()
    {
    }

    private void UpdateBallOrJersey()
    {
    }

    private void OnClick()
    {
    }

    public void UpdatePurchaseLimitFlag(bool unavailable)
    {
    }
}