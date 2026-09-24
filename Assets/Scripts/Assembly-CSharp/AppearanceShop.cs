public class AppearanceShop : global::Common.Singleton<AppearanceShop>
{
    public struct ShopItem
    {
        public int id;
        public int videosToUnlock;
        public int order;
        public int eventId;
        public bool unlocked;
        public string IAP;
        public int styleId;
        public LicensedAssetManager.LicensedAssetType licensedAssetType;
        public int currentProgress => 0;
        public bool isUnLocked => false;
        public AppearanceShop.ShopItemType ItemType => (AppearanceShop.ShopItemType)0;

        public void AddProgress(int progress)
        {
        }
    }

    public enum ShopItemType
    {
        Jersey = 10000,
        Ball = 20000,
        Points = 30000
    }

    private global::System.Collections.Generic.List<AppearanceShop.ShopItem> ballItemsProfile;
    private global::System.Collections.Generic.List<AppearanceShop.ShopItem> jerseyItemsProfile;
    public static global::UnityEngine.Events.UnityEvent<int> OnShopItemUnlocked;
    private global::Google.Protobuf.Collections.MapField<int, global::Srv.AppearanceShopArchive> Database => null;

    public static AppearanceShop.ShopItemType GetShopItemType(int id)
    {
        return (AppearanceShop.ShopItemType)0;
    }

    private void LoadConfig()
    {
    }

    public bool HasNewItem()
    {
        return false;
    }

    public void MarkNewItem()
    {
    }

    public void GetShopItems(AppearanceShop.ShopItemType shopItemType, ref global::System.Collections.Generic.List<AppearanceShop.ShopItem> items)
    {
    }

    public void AddProgress(int id, int progress)
    {
    }

    public int GetProgress(int id)
    {
        return 0;
    }

    public bool IsItemUnlockedBefore(int id, global::System.DateTime date)
    {
        return false;
    }

    public bool IsItemUnlocked(int id)
    {
        return false;
    }

    public static global::UnityEngine.Texture2D GetBallOrJerseyThumb(int shopItemId)
    {
        return null;
    }
}