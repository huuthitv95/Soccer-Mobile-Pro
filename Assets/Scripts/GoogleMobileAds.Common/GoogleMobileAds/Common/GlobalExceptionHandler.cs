namespace GoogleMobileAds.Common
{
    public class GlobalExceptionHandler : global::GoogleMobileAds.Common.RcsClient<global::GoogleMobileAds.Common.ExceptionReport>
    {
        private static global::GoogleMobileAds.Common.GlobalExceptionHandler _instance;
        public static global::GoogleMobileAds.Common.GlobalExceptionHandler Instance => null;

        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void ReportTrappedException(global::System.Exception e, string name = null)
        {
        }

        internal void OnLogMessageReceivedThreaded(string logString, string stackTrace, global::UnityEngine.LogType type)
        {
        }

        private string Sha256Hash(string rawData)
        {
            return null;
        }

        protected override void SendBatch(global::System.Collections.Generic.List<global::GoogleMobileAds.Common.ExceptionReport> batch)
        {
        }
    }
}