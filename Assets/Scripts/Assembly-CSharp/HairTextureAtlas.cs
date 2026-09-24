public class HairTextureAtlas : global::Common.Singleton<HairTextureAtlas>
{
    public class HairAtlas
    {
        public global::UnityEngine.Texture texture;
        public global::UnityEngine.Vector2 scale;
        public global::UnityEngine.Vector2 offset;
    }

    private global::UnityEngine.RenderTexture _hairAtlas;
    private int _allocCount;
    private int _maxSize;
    private int _cellSize;
    private global::System.Collections.Generic.Dictionary<int, HairTextureAtlas.HairAtlas> _appearanceCache;
    private global::UnityEngine.Material mApplyHairColor;
    public global::UnityEngine.Material HairMaterial { get; private set; }

    public void ClearCache()
    {
    }

    public HairTextureAtlas.HairAtlas AllocTexture(global::UnityEngine.Color? color, global::UnityEngine.Color? color2, global::UnityEngine.Color? colorSpec, float cutoff, global::UnityEngine.Texture texture, global::UnityEngine.Texture texture1 = null)
    {
        return null;
    }

    private static int GetAppearanceKey(global::UnityEngine.Color? color, global::UnityEngine.Color? color2, global::UnityEngine.Color? colorSpec, float cutoff, global::UnityEngine.Texture texture, global::UnityEngine.Texture texture1)
    {
        return 0;
    }
}