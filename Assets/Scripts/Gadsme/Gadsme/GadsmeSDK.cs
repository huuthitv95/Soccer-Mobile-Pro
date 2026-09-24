namespace Gadsme
{
    public class GadsmeSDK
    {
        internal global::Gadsme.Tdabed9b_19 F264;
        internal global::Gadsme.Tdabed9b_6 F265;
        internal global::Gadsme.Tdabed9b_46 F266;
        internal global::Gadsme.Tdabed9b_42 F267;
        internal global::Gadsme.Tdabed9b_31 F268;
        internal global::Gadsme.Tdabed9b_18 F269;
        internal global::UnityEngine.GameObject F270;
        internal static global::Gadsme.GadsmeSDK F271;
        private static bool F272;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Action F273;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Action F274;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Action F275;
        public static string Version;
        public static string Commit;
        internal static global::UnityEngine.Camera F276;
        internal static string F277;
        internal static string F278;
        internal static string F279;
        internal static string F280;
        internal static string[] F281;
        internal static bool F282;
        internal static int F283;
        internal static string F284;
        internal static int F285;
        internal static int F286;
        internal static bool F287;
        internal static int F288;
        internal static global::Gadsme.Gender F289;
        internal static bool F290;
        internal static bool F291;
        internal static bool F292;
        internal static int F293;
        internal static bool F294;
        internal static bool F295;
        internal static int F296;
        internal static Tdabed9b_11 F297;
        internal static global::Gadsme.Tdabed9b_27 F298;
        internal static global::UnityEngine.EventSystems.EventSystem F299;
        internal static bool F300;
        internal static global::System.Threading.Thread F301;
        internal static global::System.Collections.Generic.Dictionary<string, int> F302;
        internal static bool F303;
        private static int F304;
        private static int F305;
        private static float F306;
        private static float F307;
        internal static int F308;
        internal static global::System.Collections.Generic.Dictionary<string, int> F309;
        public static bool IsInitialized { get; private set; }
        internal static global::Gadsme.GadsmeSDK P18 => get_Instance();
        internal static global::Gadsme.Tdabed9b_6 P19 => get_AdContentManager();
        internal static global::Gadsme.Tdabed9b_46 P20 => get_VisibilityManager();
        internal static global::Gadsme.Tdabed9b_42 P21 => get_TrackingManager();
        internal static global::Gadsme.Tdabed9b_19 P22 => get_CameraManager();
        internal static global::Gadsme.Tdabed9b_31 P23 => get_InteractionManager();
        internal static float P24 => get_AudioVolume();
        public static int P25 => get_MaxConcurrentRequests();
        public static int P26 => get_MaxActiveAdContents();
        public static float P27 => get_VideoAdVolume();
        public static float P28 => get_AdWatermarkOffset();

        internal static event global::System.Action StartEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal static event global::System.Action ReadyEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal static event global::System.Action StopEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal static void M332(string A260)
        {
        }

        internal static int M333(string A261)
        {
            return 0;
        }

        internal static global::Gadsme.GadsmeSDK get_Instance()
        {
            return null;
        }

        internal static global::Gadsme.Tdabed9b_6 get_AdContentManager()
        {
            return null;
        }

        internal static global::Gadsme.Tdabed9b_46 get_VisibilityManager()
        {
            return null;
        }

        internal static global::Gadsme.Tdabed9b_42 get_TrackingManager()
        {
            return null;
        }

        internal static global::Gadsme.Tdabed9b_19 get_CameraManager()
        {
            return null;
        }

        internal static global::Gadsme.Tdabed9b_31 get_InteractionManager()
        {
            return null;
        }

        internal static float get_AudioVolume()
        {
            return 0f;
        }

        public static int get_MaxConcurrentRequests()
        {
            return 0;
        }

        public static int get_MaxActiveAdContents()
        {
            return 0;
        }

        public static float get_VideoAdVolume()
        {
            return 0f;
        }

        public static float get_AdWatermarkOffset()
        {
            return 0f;
        }

        public static void Init()
        {
        }

        private static void M334(global::System.Action A262)
        {
        }

        private static void M335(global::System.Action A263)
        {
        }

        private static void M336(global::System.Action A264)
        {
        }

        [global::System.Diagnostics.DebuggerHidden]
        private static global::System.Collections.IEnumerator M337(global::System.Action A265)
        {
            return null;
        }

        private static string M338()
        {
            return null;
        }

        public static void Terminate()
        {
        }

        public static void SetMainCamera(global::UnityEngine.Camera A266)
        {
        }

        public static void SetGdprApplies(bool A267)
        {
        }

        public static void SetGdprConsent(bool A268)
        {
        }

        public static void SetGdprConsentString(string A269)
        {
        }

        public static void SetCoppa(bool A270)
        {
        }

        public static void SetUserAge(int A271)
        {
        }

        public static void SetUserGender(global::Gadsme.Gender A272)
        {
        }

        public static void SetInteractionsEnabled(bool A273)
        {
        }

        public static void SetEventSystem(global::UnityEngine.EventSystems.EventSystem A274)
        {
        }

        public static void HandlePlacementInteractions()
        {
        }

        public static bool IsPlacementResult(global::UnityEngine.EventSystems.RaycastResult A275)
        {
            return false;
        }

        public static bool CanUseVendorIdentifier()
        {
            return false;
        }

        public static void SetAllowConsentDialog(bool A276)
        {
        }

        public static void SetUseLegacyVisibilityCheck(bool A277)
        {
        }

        public static void SetUseVisibilityCheckV2(bool A278)
        {
        }

        public static void SetMaxConcurrentRequests(int A279)
        {
        }

        public static void SetMaxActiveAdContents(int A280)
        {
        }

        public static void SetVideoAdVolume(float A281)
        {
        }

        public static void SetAdWatermarkOffset(float A282)
        {
        }

        public static void RegisterAndroidInterface(global::Gadsme.Core.Native.IAndroidNativeInterface A283)
        {
        }

        public static void RegisterIOSInterface(global::Gadsme.Core.Native.IIOSNativeInterface A284)
        {
        }

        public static void RegisterMacInterface(global::Gadsme.Core.Native.IMacNativeInterface A285)
        {
        }

        public static void RefreshStaticAds()
        {
        }

        public static void PreloadAudioAd()
        {
        }

        public static void StartAudioAd()
        {
        }

        public static void PreloadAudioAd(global::UnityEngine.Vector2 A286)
        {
        }

        public static void StartAudioAd(global::UnityEngine.Vector2 A287)
        {
        }

        public static void PreloadRewardedAudioAd()
        {
        }

        public static void StartRewardedAudioAd(global::System.Action<bool> A288)
        {
        }

        public static void PreloadRewardedAudioAd(global::UnityEngine.Vector2 A289)
        {
        }

        public static void StartRewardedAudioAd(global::UnityEngine.Vector2 A290, global::System.Action<bool> A291)
        {
        }

        public static void StopAudioAd()
        {
        }

        internal static global::Gadsme.GadsmeAdFormat M339(string A292)
        {
            return null;
        }

        internal static void M340(global::UnityEngine.WWWForm A293)
        {
        }
    }
}