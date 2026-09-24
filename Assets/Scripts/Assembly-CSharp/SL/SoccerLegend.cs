namespace SL
{
    public class SoccerLegend : MonoSingleton<global::SL.SoccerLegend>
    {
        public ActionPeripherals peripherals;
        private static bool NeedUnLoadUnusedAssets;
        private static float LastUnLoadUnusedAssetsTime;
        private int _leaveTime;
        public int _adTime;
        public int _backStageTime;
        private float _invertFrameRate;
        public bool GameReady { get; set; }
        public int JustWatchedVideo { private get; set; }
        public bool ShowingAd { get; set; }
        public static bool IsSquareScreen => false;

        private void Awake()
        {
        }

        private void OnLowMemory()
        {
        }

        public static void ReleaseCacheAssets()
        {
        }

        public static void CheckReleaseCacheAssets()
        {
        }

        public static bool IsLowMemoryDevice()
        {
            return false;
        }

        public static bool IsPoorMemoryDevice()
        {
            return false;
        }

        public static bool NeedDecreaseRTSize()
        {
            return false;
        }

        public static void MarkNeedUnLoadUnusedAssets()
        {
        }

        public static void UnloadUnusedAssets()
        {
        }

        public void Init()
        {
        }

        public void CheckExcelDir()
        {
        }

        private void Update()
        {
        }

        private new void OnApplicationQuit()
        {
        }

        private void OnApplicationPause(bool pause)
        {
        }

        private global::System.Collections.IEnumerator DelayAppResume()
        {
            return null;
        }

        public float GetInvertFrameRate()
        {
            return 0f;
        }

        public void SetTargetFrameRate(int frame)
        {
        }

        public static bool IsHighEndDevice()
        {
            return false;
        }
    }
}