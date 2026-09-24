namespace LeTai.TrueShadow.PluginInterfaces
{
	public interface ITrueShadowCasterMaterialProvider
	{
		event global::System.Action materialReplaced;

		event global::System.Action materialModified;

		global::UnityEngine.Material GetTrueShadowCasterMaterial();
	}
}
