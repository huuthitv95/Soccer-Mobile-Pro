public class ActionPlayerTextureSupplier : IPlayerTextureSupplier
{
    private global::System.Collections.Generic.List<global::UnityEngine.Color> wristbandColors;
    private global::System.Collections.Generic.List<string> needScaleDownSponsorLogo;
    public ActionPlayerTextureSupplierInfo Info { get; private set; }

    public ActionPlayerTextureSupplier(PlayerKitPathInfo playerKitPathInfo, PlayerAppearancePathInfo playerAppearancePathInfo, bool IsFemale, bool isClub)
    {
    }

    private static bool TryGetNumberTexturePath(JerseyNumberConfig numberConfig, int requiredLength, int digitIndex, out string path)
    {
        path = null;
        return false;
    }

    public Cloth GetClothConfig(PlayerTextureAtlasData.PartType part)
    {
        return default;
    }

    public string SupplyBaseTexture(PlayerTextureAtlasData.PartType part)
    {
        return null;
    }

    public global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect>? SupplyPartTexture(PlayerTextureAtlasData.PartType part)
    {
        return null;
    }

    private global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> HandleSelfAtlas(PlayerTextureAtlasData.PartType part, string path)
    {
        return default;
    }

    public global::UnityEngine.Color? GetColorConfig(PlayerTextureAtlasData.PartType part)
    {
        return null;
    }

    private bool CheckScaleDownSponsorLogo(ref string path)
    {
        return false;
    }

    public float TextureScale(PlayerTextureAtlasData.PartType part)
    {
        return 0f;
    }

    public global::Common.RectRotation TextureRotation(PlayerTextureAtlasData.PartType part)
    {
        return global::Common.RectRotation.R_0;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public global::UnityEngine.Vector2 TexturePositionOffset(PlayerTextureAtlasData.PartType part)
    {
        return default;
    }

    public void SelfAtlasTargetRectUpdate(PlayerTextureAtlasData.PartType part, PlayerTextureAtlasData atlasData, ref global::UnityEngine.Rect targetRect)
    {
    }

    public bool DisableColorModification(PlayerTextureAtlasData.PartType part)
    {
        return false;
    }
}