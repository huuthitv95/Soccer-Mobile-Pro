namespace Google.Play.AssetDelivery.Internal
{
    internal class AssetPackManager : global::System.IDisposable
    {
        private global::UnityEngine.AndroidJavaObject _javaAssetPackManager;
        public void RegisterListener(global::UnityEngine.AndroidJavaProxy listener)
        {
        }

        public void UnregisterListener(global::UnityEngine.AndroidJavaProxy listener)
        {
        }

        public global::Google.Play.Core.Internal.PlayServicesTask<global::UnityEngine.AndroidJavaObject> Fetch(params string[] assetPackNames)
        {
            return null;
        }

        public global::Google.Play.Core.Internal.PlayServicesTask<global::UnityEngine.AndroidJavaObject> GetPackStates(params string[] assetPackNames)
        {
            return null;
        }

        public global::Google.Play.AssetDelivery.Internal.AssetPackLocation GetPackLocation(string assetPackName)
        {
            return null;
        }

        public global::Google.Play.AssetDelivery.AssetLocation GetAssetLocation(string assetPackName, string assetPath)
        {
            return null;
        }

        public global::UnityEngine.AndroidJavaObject Cancel(params string[] assetPackNames)
        {
            return null;
        }

        public global::Google.Play.Core.Internal.PlayServicesTask<global::UnityEngine.AndroidJavaObject> RemovePack(string assetPackName)
        {
            return null;
        }

        public global::Google.Play.Core.Internal.PlayServicesTask<int> ShowCellularDataConfirmation()
        {
            return null;
        }

        public global::Google.Play.Core.Internal.PlayServicesTask<int> ShowConfirmationDialog()
        {
            return null;
        }

        private static global::UnityEngine.AndroidJavaObject BuildAssetPackList(params string[] assetPackNames)
        {
            return null;
        }

        public void Dispose()
        {
        }
    }
}