namespace Google.Play.Common.LoadingScreen
{
    public class LoadingScreen : global::UnityEngine.MonoBehaviour
    {
        public string AssetBundleUrl;
        public global::Google.Play.Common.LoadingScreen.LoadingBar LoadingBar;
        public global::UnityEngine.UI.Button RetryButton;
        private const int InitialAttemptCount = 3;
        private global::UnityEngine.AssetBundle _bundle;
        private int _assetBundleRetrievalAttemptCount;
        private float _maxLoadingBarProgress;
        private bool _downloading;
        private void Start()
        {
        }

        public void ButtonEventRetryDownload()
        {
        }

        private void AttemptAssetBundleDownload(int numberOfAttempts)
        {
        }

        private global::System.Collections.IEnumerator AttemptAssetBundleDownloadsCo(int numberOfAttempts)
        {
            return null;
        }

        private global::System.Collections.IEnumerator GetAssetBundle(string assetBundleUrl)
        {
            return null;
        }

        private void ShowRetryButton()
        {
        }

        private void HideRetryButton()
        {
        }

        private static bool IsNetworkError(global::UnityEngine.Networking.UnityWebRequest request)
        {
            return false;
        }

        private static global::UnityEngine.AsyncOperation StartAssetBundleDownload(string assetBundleUrl, out global::UnityEngine.Networking.UnityWebRequest webRequest)
        {
            webRequest = null;
            return null;
        }
    }
}