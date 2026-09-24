public class HairTools : global::Common.Singleton<HairTools>
{
    public class HairAtlas
    {
        public global::UnityEngine.Texture texture;
        public global::UnityEngine.Vector2 scale;
        public global::UnityEngine.Vector2 scale_hd;
        public global::UnityEngine.Vector2 offset;
        public global::UnityEngine.Vector2 offset_hd;
    }

    private global::UnityEngine.RenderTexture _hairAtlas;
    private global::UnityEngine.RenderTexture _hairAtlas_n;
    private int _allocCount;
    private int _maxSize;
    private int _cellSize_HD;
    private int _cellSize;
    private global::UnityEngine.Material mApplyHairColor;
    public global::UnityEngine.Material BlinnPhong { get; private set; }
    public global::UnityEngine.Material BlinnPhongInGame { get; private set; }
    public global::UnityEngine.Material InGame { get; private set; }

    public void ClearCache()
    {
    }

    public HairTools.HairAtlas AllocTexture(global::UnityEngine.Color? color, global::UnityEngine.Color? color2, global::UnityEngine.Color? colorSpec, global::UnityEngine.Texture textureHD, global::UnityEngine.Texture texture, global::UnityEngine.Texture normalTexture = null, float cutoff = 0.99f, bool applyColor = true)
    {
        return null;
    }
}