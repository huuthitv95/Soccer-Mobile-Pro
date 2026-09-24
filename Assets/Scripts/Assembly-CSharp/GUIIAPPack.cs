public class GUIIAPPack : GUIIAPItem
{
    [global::UnityEngine.SerializeField]
    private string backupProductID;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text coinText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text PC_CoinText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject disableOverlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text originalPriceText;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> mainProductObjs;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> backupProductObjs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text discountText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage[] ballImage;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] ballNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text descText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject descGo;
    protected override void OnInit()
    {
    }

    private void UpdateMainOrBackupProductObjs(bool isMain)
    {
    }

    private void UpdateCommon()
    {
    }

    private void UpdateForNormalState()
    {
    }

    private void UpdateForPurchasedState()
    {
    }

    private void UpdateForUnavailableState()
    {
    }

    public void OnIapPlayerInfoClick()
    {
    }
}