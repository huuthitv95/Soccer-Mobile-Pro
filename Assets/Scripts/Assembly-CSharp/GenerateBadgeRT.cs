public class GenerateBadgeRT : MonoSingleton<GenerateBadgeRT>
{
    private string gameobjectPath;
    private global::UnityEngine.GameObject renderPanel;
    private global::UnityEngine.Camera renderCamera;
    private global::UnityEngine.UI.Image badgeRoot;
    private global::UnityEngine.UI.Image background;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::UnityEngine.RenderTexture>> badgeRTs;
    private global::LRUCache.TextureLRUCache<int, global::UnityEngine.RenderTexture> uiBadgeCache;
    private void Awake()
    {
    }

    public global::UnityEngine.Texture GetBadgeRTForUI(TeamsData team)
    {
        return null;
    }

    public global::UnityEngine.Texture GetBadgeRT(global::UnityEngine.Color bgColor, TeamsData team, bool isUser)
    {
        return null;
    }

    private void CheckInit()
    {
    }

    private void Render(global::UnityEngine.Color bgColor, TeamsData team, global::UnityEngine.RenderTexture renderTexture)
    {
    }
}