public class PlayAssetDeliverLoader : global::Common.Singleton<PlayAssetDeliverLoader>, global::Common.RemoteAssetBundleLoader
{
    public class LoadTask
    {
        public enum State
        {
            none = 0,
            downloading = 1,
            downloaded = 2,
            failed = 3,
            loading = 4,
            loaded = 5
        }

        private const int FailuresBeforeCooldown = 3;
        private const float RetryCooldownSeconds = 30f;
        private const float StallTimeoutSeconds = 300f;
        private const float ConfirmationResumeTimeoutSeconds = 30f;
        private const float ProgressChangeThreshold = 0.0001f;
        public global::UnityEngine.AssetBundle bundle;
        public PlayAssetDeliverLoader.LoadTask.State state;
        private int failedCount;
        private float nextRetryTime;
        private global::UnityEngine.Coroutine co;
        private global::Google.Play.AssetDelivery.PlayAssetPackRequest request;
        private global::UnityEngine.AssetBundleCreateRequest assetBundleCreateRequest;
        private bool enableProLog;
        public string Name;
        public void Cancel()
        {
        }

        public float Progress()
        {
            return 0f;
        }

        public void Load(string bundleName)
        {
        }

        private global::System.Collections.IEnumerator Download()
        {
            return null;
        }

        private global::System.Collections.IEnumerator HandleConfirmation()
        {
            return null;
        }

        private global::System.Collections.IEnumerator LoadAssetBundle()
        {
            return null;
        }

        private T TryCreate<T>(global::System.Func<T> factory, string operation, bool cancelRequest = false, bool logFailureEvent = false)
            where T : class
        {
            return null;
        }

        private static bool HasStalled(float progress, ref float lastProgress, ref float lastActivityTime)
        {
            return false;
        }

        private static bool IsWaitingForConfirmation(global::Google.Play.AssetDelivery.AssetDeliveryStatus status)
        {
            return false;
        }

        private void Fail(string reason, bool cancelRequest = false, bool logFailureEvent = false)
        {
        }

        private void TryCancelRequest()
        {
        }

        private void LogDownloadEvent(int step)
        {
        }
    }

    private readonly global::System.Collections.Generic.Dictionary<string, PlayAssetDeliverLoader.LoadTask> _tasks;
    private static string NormalizeBundleName(string name)
    {
        return null;
    }

    public bool isExist(string name)
    {
        return false;
    }

    private static bool TryGetDownloadedState(string name, out bool isDownloaded)
    {
        isDownloaded = default;
        return false;
    }

    private static void SyncLegacyDownloadedState(string name, bool isDownloaded)
    {
    }

    public bool IsExistTask(string name, out PlayAssetDeliverLoader.LoadTask task)
    {
        task = null;
        return false;
    }

    public global::UnityEngine.AssetBundle Load(string name, global::Common.AssetsManifest.RemotePackType remotePackType)
    {
        return null;
    }
}