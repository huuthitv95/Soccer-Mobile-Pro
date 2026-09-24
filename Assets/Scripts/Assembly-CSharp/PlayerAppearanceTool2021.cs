public class PlayerAppearanceTool2021
{
    private static global::UnityEngine.Material applyColor1Color2Material;
    private static global::UnityEngine.Material gradientByRColor1Color2Material;
    private static global::UnityEngine.Material alphaBlendMaterial;
    private static global::UnityEngine.Material applyAddMapMaterial;
    private static RenderTextToTexture renderTextToTexture;
    private static global::LRUCache.LRUCache<int, global::UnityEngine.Texture> TexCache;
    private static global::LRUCache.LRUCache<string, global::UnityEngine.RenderTexture> NameTexCache;
    public static bool DebugFlag;
    private static global::UnityEngine.Material ApplyColor1Color2Material => null;
    private static global::UnityEngine.Material GradientByRColor1Color2Material => null;
    private static global::UnityEngine.Material AlphaBlendMaterial => null;
    private static global::UnityEngine.Material ApplyAddMapMaterial => null;
    public static global::UnityEngine.RenderTextureFormat BestRenderTextureFormat => global::UnityEngine.RenderTextureFormat.ARGB32;

    public static void ClearCache()
    {
    }

    public static void Init()
    {
    }

    public static global::UnityEngine.Texture CombinePlayerTexture(PlayerTextureAtlasData atlasData, IPlayerTextureSupplier Supplier, global::System.Func<global::UnityEngine.RenderTextureDescriptor, global::UnityEngine.RenderTexture> createRTFunc, global::System.Func<string, global::UnityEngine.Texture2D> loadTexFunc = null)
    {
        return null;
    }

    private static void RenderColor1Color2(global::UnityEngine.Material mApplyColor1Color2, Cloth kitInfo, global::UnityEngine.Texture alphaMaskTex, string coatBasePath, global::UnityEngine.Rect rect, global::System.Func<string, global::UnityEngine.Texture2D> loadTexFunc)
    {
    }

    private static bool IsNumberTexturePart(PlayerTextureAtlasData.PartType part)
    {
        return false;
    }

    private static bool IsShortsNumberTexturePart(PlayerTextureAtlasData.PartType part)
    {
        return false;
    }

    private static void RenderNumberColorPair(global::UnityEngine.Material material, IPlayerTextureSupplier supplier, PlayerTextureAtlasData.PartType part, global::UnityEngine.Texture numberTexture, global::UnityEngine.Rect sourceRect, global::UnityEngine.Rect targetRect, bool useOriginalNumberColor)
    {
    }

    private static void DrawTextureAtCenterPoint(global::UnityEngine.Vector2 pos, global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> texture, float scale, global::UnityEngine.Material m, global::Common.RectRotation rotation)
    {
    }

    public static global::UnityEngine.RenderTexture RenderTextToTexture(string s, RenderTextToTexture.Parameter p)
    {
        return null;
    }

    public static void ApplyAllInfo(IPlayerRender playerRender, IPlayerTextureSupplier textureSupplier, PlayerTextureAtlasData atlasData, global::System.Collections.Generic.List<PlayerTextureAtlasData> lod1, global::System.Collections.Generic.List<PlayerTextureAtlasData> head, bool hairAtlas)
    {
    }

    public static void ApplyLowDefinitionInfo(IPlayerRender playerRender, IPlayerTextureSupplier textureSupplier, PlayerTextureAtlasData atlasData, global::System.Collections.Generic.List<PlayerTextureAtlasData> lod1, global::System.Collections.Generic.List<PlayerTextureAtlasData> head, bool hairAtlas)
    {
    }

    public static void ApplyCommonInfo(IPlayerRender playerRender, IPlayerTextureSupplier textureSupplier, PlayerTextureAtlasData atlasData, global::System.Collections.Generic.List<PlayerTextureAtlasData> lod1, global::System.Collections.Generic.List<PlayerTextureAtlasData> head, bool hairAtlas, bool useHDHair, bool useBlinnPhongInGame = true)
    {
    }

    private static void ApplyHDInfo(IPlayerRender playerRender, IPlayerTextureSupplier textureSupplier, PlayerTextureAtlasData atlasData, global::System.Collections.Generic.List<PlayerTextureAtlasData> lod1, global::System.Collections.Generic.List<PlayerTextureAtlasData> head, bool hairAtlas)
    {
    }

    public static void ApplyHeadInfo(IPlayerRender playerRender, IPlayerTextureSupplier textureSupplier, PlayerTextureAtlasData atlasData, global::System.Collections.Generic.List<PlayerTextureAtlasData> lod1, global::System.Collections.Generic.List<PlayerTextureAtlasData> head, bool hairAtlas)
    {
    }

    public static void ApplyAllHDInfo(IPlayerRender playerRender, IPlayerTextureSupplier textureSupplier, PlayerTextureAtlasData atlasData, global::System.Collections.Generic.List<PlayerTextureAtlasData> lod1, global::System.Collections.Generic.List<PlayerTextureAtlasData> head, bool hairAtlas)
    {
    }
}