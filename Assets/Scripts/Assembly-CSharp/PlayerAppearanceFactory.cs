public class PlayerAppearanceFactory
{
    private static global::LRUCache.LRUCache<int, global::SL.Player.PlayerApperance> playerAppearanceTableCache;
    public void ClearCache()
    {
    }

    public global::SL.Player.PlayerApperance GetPlayerApperance(int apperanceID, int templateId, int height, int weight, bool isFemale)
    {
        return null;
    }

    private void RandomApperanceNew(int seed, global::SL.Player.PlayerApperance _apperance, bool isFemale, bool needReset, int height, int weight)
    {
    }
}