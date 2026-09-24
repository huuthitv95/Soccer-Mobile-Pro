namespace Common
{
	public interface RemoteAssetBundleLoader
	{
		global::UnityEngine.AssetBundle Load(string name, global::Common.AssetsManifest.RemotePackType remotePackType);

		bool isExist(string name);
	}
}
