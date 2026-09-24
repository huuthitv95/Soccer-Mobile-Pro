namespace FLTest.GlobalConfig
{
    public static class SimpleGlobalConfig
    {
        [global::FLTest.GlobalConfig.GlobalConfig]
        public class SimpleConfig
        {
            public float NativeOverlayAdWidth;
            public float NativeOverlayAdHeight;
            public bool EnableStarPlayerAppearance;
            public bool EnableScreenTimeTrackerTester;
            public bool BlockRV;
            public static void SaveScreenTimeTrackerData()
            {
            }
        }

        private static global::FLTest.GlobalConfig.SimpleGlobalConfig.SimpleConfig simpleConfig;
        public static global::FLTest.GlobalConfig.SimpleGlobalConfig.SimpleConfig Config => null;

        public static void OnReloaded()
        {
        }
    }
}