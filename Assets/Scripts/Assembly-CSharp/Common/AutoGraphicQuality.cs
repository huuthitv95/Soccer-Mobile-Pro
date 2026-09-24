namespace Common
{
    public class AutoGraphicQuality : global::UnityEngine.MonoBehaviour
    {
        private static int _curQualityIndex;
        private static global::Common.AutoGraphicQualityHelper _helper;
        [global::UnityEngine.SerializeField]
        private bool AutomaticQuality;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject levelUI;
        private global::UnityEngine.UI.Toggle fogUI;
        private global::UnityEngine.UI.Dropdown vSyncUI;
        private global::UnityEngine.UI.Dropdown graphicLevel;
        private static int _WindowWidth;
        private static int _WindowHeight;
        private const int _maxQualityLevel = 5;
        private MeasureFrameTime _frameTimer;
        private int highTrendCount;
        private int lowTrendCount;
        private int upgradeThredhold;
        public static int DeviceQualityLevel;
        private static int processorFrequency;
        public static int CurQualityIndex => 0;

        public static global::Common.AutoGraphicQualityHelper Helper
        {
            private get
            {
                return null;
            }

            set
            {
            }
        }

        public static int GetDeviceQualityLevel => 0;

        private void Start()
        {
        }

        private void DoStart()
        {
        }

        private static bool LowGraphicDevice()
        {
            return false;
        }

        public static int AndroidVersion()
        {
            return 0;
        }

        public static void SetQualityLevel(int level)
        {
        }

        private void OnGraphicLevelChanged(int level, bool applyExpensiveChanges)
        {
        }

        private void OnDestroy()
        {
        }

        private void ConfigGraphic()
        {
        }

        public static int GetProcessorFrequency()
        {
            return 0;
        }

        public static bool IsLowDevice()
        {
            return false;
        }

        public static int EstimateQualityLevel()
        {
            return 0;
        }

        private static void SetStadiumShaderLOD(int shaderLOD)
        {
        }
    }
}