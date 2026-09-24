namespace LeTai.TrueShadow.PluginInterfaces
{
	public interface ITrueShadowRendererMaterialProvider
	{
		event global::System.Action materialReplaced;

		event global::System.Action materialModified;

		global::UnityEngine.Material GetTrueShadowRendererMaterial();
	}
}
