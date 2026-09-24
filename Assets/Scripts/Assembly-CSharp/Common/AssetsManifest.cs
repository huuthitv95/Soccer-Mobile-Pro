namespace Common
{
	public class AssetsManifest : global::UnityEngine.ScriptableObject
	{
		public enum RemotePackType
		{
			install_time = 0,
			fast_follow = 1,
			on_demand = 2
		}

		public global::System.Collections.Generic.List<string> bundles;

		public global::Common.Dictionary_StrInt rest2Bundle;

		public global::System.Collections.Generic.List<int> external;

		public global::Common.Dictionary_IntInt remote;

		public bool IsRemote(string bundleName)
		{
			return false;
		}

		public global::Common.AssetsManifest.RemotePackType GetRemotePackType(string bundleName)
		{
			return global::Common.AssetsManifest.RemotePackType.install_time;
		}
	}
}
