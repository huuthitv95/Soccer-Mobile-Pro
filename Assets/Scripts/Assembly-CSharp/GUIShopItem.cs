public class GUIShopItem : global::UnityEngine.MonoBehaviour
{
    private const int DebeyChallengeEventId = 666;
    [global::UnityEngine.HideInInspector]
    public AppearanceShop.ShopItem shopItem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform icon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text desc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text progress;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle btnPreview;
    [global::UnityEngine.SerializeField]
    private ADButtonStateBase adButtonStateBase;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject lockedFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Animator unlockAnimator;
    private TeamsData modelTeam;
    public void PlayUnlockAnimation()
    {
    }

    public void Select()
    {
    }

    public void UnSelect()
    {
    }

    private void Start()
    {
    }

    private void OnDestroy()
    {
    }

    private void OnShopItemUnlocked(int id)
    {
    }

    public void Init(AppearanceShop.ShopItem shopItem, TeamsData modelTeam, global::System.Action<GUIShopItem> onPreview, global::System.Action<GUIShopItem> onVideo, global::System.Action<ADButtonStateBase> registVideoBtn)
    {
    }

    public void Updater()
    {
    }

    private bool CheckLicenseEvent()
    {
        return false;
    }

    private bool IsTourEventRewardItem()
    {
        return false;
    }

    private bool IsDebeyChallengeEventRewardItem()
    {
        return false;
    }

    private void IconUpdater()
    {
    }
}