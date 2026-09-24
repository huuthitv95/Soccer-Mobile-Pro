namespace Common
{
	public interface ExternalAssetBundleLoader
	{
		global::UnityEngine.AssetBundle Load(string name);

		bool isExist(string name);
	}
}
