namespace GoogleMobileAds.Common
{
    public abstract class RcsClient<TReport> : global::UnityEngine.MonoBehaviour where TReport : class
    {
        private class BypassCertificateHandler : global::UnityEngine.Networking.CertificateHandler
        {
            protected override bool ValidateCertificate(byte[] certificateData)
            {
                return false;
            }
        }

        private const string ProdRcsUrl = "https://pagead2.googlesyndication.com/pagead/ping?e=1";
        internal static readonly global::System.Collections.Generic.Queue<TReport> _queue;
        private static readonly object _queueLock;
        private float _timeOfNextBatch;
        protected virtual int CountThreshold
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            get
            {
                return 0;
            }
        }

        protected virtual float TimeThresholdInSeconds
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            get
            {
                return 0f;
            }
        }

        private void Start()
        {
        }

        private void Update()
        {
        }

        private void OnApplicationQuit()
        {
        }

        protected void Enqueue(TReport item)
        {
        }

        protected string GetEpochMillis()
        {
            return null;
        }

        protected void SendToRcs(string jspbPayload)
        {
        }

        internal void ProcessAndSendBatch()
        {
        }

        private void ResetBatchTimer()
        {
        }

        [global::System.Diagnostics.DebuggerHidden]
        private global::System.Collections.IEnumerator PostRequest(string url, string jspbPayload)
        {
            return null;
        }

        protected abstract void SendBatch(global::System.Collections.Generic.List<TReport> batch);
    }
}