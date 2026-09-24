public class ActionLicensedPlayerTextureSupplier : IPlayerTextureSupplier
{
    private LicensedJerseyLoader licensedJerseyLoader;
    public ActionPlayerTextureSupplierInfo Info { get; private set; }

    public void SetLicensedJerseyLoader(in LicensedJerseyLoader licensedJerseyLoader)
    {
    }

    public ActionLicensedPlayerTextureSupplier(PlayerKitPathInfo playerKitPathInfo, PlayerAppearancePathInfo playerAppearancePathInfo, bool IsFemale, bool isClub, in LicensedJerseyLoader licensedJerseyLoader)
    {
    }

    public Cloth GetClothConfig(PlayerTextureAtlasData.PartType part)
    {
        return default;
    }

    public global::UnityEngine.Color? GetColorConfig(PlayerTextureAtlasData.PartType part)
    {
        return null;
    }

    public bool DisableColorModification(PlayerTextureAtlasData.PartType part)
    {
        return false;
    }

    private global::UnityEngine.Rect ResizeRect(global::UnityEngine.Rect sourceRect, global::UnityEngine.Vector3 newSize)
    {
        return default;
    }

    public void SelfAtlasTargetRectUpdate(PlayerTextureAtlasData.PartType part, PlayerTextureAtlasData atlasData, ref global::UnityEngine.Rect targetRect)
    {
    }

    public string SupplyBaseTexture(PlayerTextureAtlasData.PartType part)
    {
        return null;
    }

    public global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect>? SupplyPartTexture(PlayerTextureAtlasData.PartType part)
    {
        return null;
    }

    public global::UnityEngine.Vector2 TexturePositionOffset(PlayerTextureAtlasData.PartType part)
    {
        return default;
    }

    public global::Common.RectRotation TextureRotation(PlayerTextureAtlasData.PartType part)
    {
        return global::Common.RectRotation.R_0;
    }

    public float TextureScale(PlayerTextureAtlasData.PartType part)
    {
        return 0f;
    }
}