namespace GooglePlayGames.OurUtils
{
    public class NearbyHelperObject : global::UnityEngine.MonoBehaviour
    {
        private static global::GooglePlayGames.OurUtils.NearbyHelperObject instance;
        private static double mAdvertisingRemaining;
        private static double mDiscoveryRemaining;
        private static global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient mClient;
        public static void CreateObject(global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client)
        {
        }

        private static double ToSeconds(global::System.TimeSpan? span)
        {
            return 0.0;
        }

        public static void StartAdvertisingTimer(global::System.TimeSpan? span)
        {
        }

        public static void StartDiscoveryTimer(global::System.TimeSpan? span)
        {
        }

        public void Awake()
        {
        }

        public void OnDisable()
        {
        }

        public void Update()
        {
        }
    }
}