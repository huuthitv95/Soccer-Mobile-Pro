public class EventThemeManager : global::Common.Singleton<EventThemeManager>
{
    private global::LRUCache.LRUCache<string, global::UnityEngine.GameObject> eventThemeCache;
    public void ClearCache()
    {
    }

    private global::UnityEngine.GameObject LoadFACupThemePrefab(FACup fACup)
    {
        return null;
    }

    public global::FLDataTable.CupModeThemeConfig GetCupModeThemeConfig(FACup fACup)
    {
        return null;
    }

    public static string GetAtlasPath(global::FLDataTable.CupModeThemeConfig config)
    {
        return null;
    }

    public global::UnityEngine.GameObject ApplyMatchInfoTheme(global::UnityEngine.Transform parent, IMatchManager matchManager)
    {
        return null;
    }
}