public interface IPlayerTextureSupplier
{
	ActionPlayerTextureSupplierInfo Info { get; }

	global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect>? SupplyPartTexture(PlayerTextureAtlasData.PartType part);

	string SupplyBaseTexture(PlayerTextureAtlasData.PartType part);

	Cloth GetClothConfig(PlayerTextureAtlasData.PartType part);

	global::UnityEngine.Color? GetColorConfig(PlayerTextureAtlasData.PartType part);

	bool DisableColorModification(PlayerTextureAtlasData.PartType part);

	float TextureScale(PlayerTextureAtlasData.PartType part);

	global::Common.RectRotation TextureRotation(PlayerTextureAtlasData.PartType part);

	global::UnityEngine.Vector2 TexturePositionOffset(PlayerTextureAtlasData.PartType part);

	void SelfAtlasTargetRectUpdate(PlayerTextureAtlasData.PartType part, PlayerTextureAtlasData atlasData, ref global::UnityEngine.Rect targetRect);
}
