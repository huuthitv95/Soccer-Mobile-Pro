public class TexturePool : global::Common.Singleton<TexturePool>
{
    private global::LRUCache.TextureLRUCache<string, global::UnityEngine.Texture2D> cache;
    public global::UnityEngine.Texture2D LoadTexture2D(string path)
    {
        return null;
    }

    public void ClearPool()
    {
    }
}