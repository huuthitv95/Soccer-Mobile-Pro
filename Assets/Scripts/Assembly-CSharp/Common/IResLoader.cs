namespace Common
{
	public interface IResLoader
	{
		void Initialize(global::System.Action<bool> callBack);

		T Load<T>(string path) where T : global::UnityEngine.Object;

		global::UnityEngine.GameObject LoadPrefab(string path);

		bool IsFileExist(string filepath);

		global::System.Collections.Generic.List<string> GetAllFilesInPath(string bundleName);

		bool CheckAssetIsReady(string assetname);
	}
}
