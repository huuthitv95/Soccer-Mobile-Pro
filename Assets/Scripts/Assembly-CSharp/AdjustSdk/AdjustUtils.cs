namespace AdjustSdk
{
    public class AdjustUtils
    {
        public static string KeyAdid;
        public static string KeyMessage;
        public static string KeyNetwork;
        public static string KeyAdgroup;
        public static string KeyCampaign;
        public static string KeyCreative;
        public static string KeyWillRetry;
        public static string KeyTimestamp;
        public static string KeyCallbackId;
        public static string KeyEventToken;
        public static string KeyClickLabel;
        public static string KeyTrackerName;
        public static string KeyTrackerToken;
        public static string KeyJsonResponse;
        public static string KeyCostType;
        public static string KeyCostAmount;
        public static string KeyCostCurrency;
        public static string KeyFbInstallReferrer;
        public static string KeySkanConversionValue;
        public static string KeySkanCoarseValue;
        public static string KeySkanLockWindow;
        public static string KeyCode;
        public static string KeyVerificationStatus;
        public static string KeyTestOptionsBaseUrl;
        public static string KeyTestOptionsGdprUrl;
        public static string KeyTestOptionsSubscriptionUrl;
        public static string KeyTestOptionsPurchaseVerificationUrl;
        public static string KeyTestOptionsOverwriteUrl;
        public static string KeyTestOptionsExtraPath;
        public static string KeyTestOptionsBasePath;
        public static string KeyTestOptionsGdprPath;
        public static string KeyTestOptionsDeleteState;
        public static string KeyTestOptionsUseTestConnectionOptions;
        public static string KeyTestOptionsTimerIntervalInMilliseconds;
        public static string KeyTestOptionsTimerStartInMilliseconds;
        public static string KeyTestOptionsSessionIntervalInMilliseconds;
        public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
        public static string KeyTestOptionsTeardown;
        public static string KeyTestOptionsNoBackoffWait;
        public static string KeyTestOptionsAdServicesFrameworkEnabled;
        public static string KeyTestOptionsAttStatus;
        public static string KeyTestOptionsIdfa;
        public static string KeyTestOptionsIgnoreSystemLifecycleBootstrap;
        public static int ConvertLogLevel(global::AdjustSdk.AdjustLogLevel? logLevel)
        {
            return 0;
        }

        public static int ConvertBool(bool? value)
        {
            return 0;
        }

        public static double ConvertDouble(double? value)
        {
            return 0.0;
        }

        public static int ConvertInt(int? value)
        {
            return 0;
        }

        public static long ConvertLong(long? value)
        {
            return 0L;
        }

        public static string ConvertReadOnlyCollectionToJson(global::System.Collections.ObjectModel.ReadOnlyCollection<string> list)
        {
            return null;
        }

        public static string ConvertReadOnlyCollectionOfPairsToJson(global::System.Collections.ObjectModel.ReadOnlyCollection<string> list)
        {
            return null;
        }

        public static string ConvertReadOnlyCollectionOfTripletsToJson(global::System.Collections.ObjectModel.ReadOnlyCollection<string> list)
        {
            return null;
        }

        public static string GetJsonResponseCompact(global::System.Collections.Generic.Dictionary<string, object> dictionary)
        {
            return null;
        }

        public static string GetJsonString(global::AdjustSdk.JSONNode node, string key)
        {
            return null;
        }

        public static void WriteJsonResponseDictionary(global::AdjustSdk.JSONClass jsonObject, global::System.Collections.Generic.Dictionary<string, object> output)
        {
        }

        public static string TryGetValue(global::System.Collections.Generic.Dictionary<string, string> dictionary, string key)
        {
            return null;
        }

        public static global::System.Collections.Generic.Dictionary<string, string> GetSkanUpdateDataDictionary(string skanUpdateData)
        {
            return null;
        }

        public static global::System.Collections.Generic.Dictionary<string, object> GetAttributionJsonResponse(string attributionJsonResponse)
        {
            return null;
        }

        public static string GetValueOrEmptyToNull(string value)
        {
            return null;
        }

        public static global::UnityEngine.AndroidJavaObject TestOptionsMap2AndroidJavaObject(global::System.Collections.Generic.Dictionary<string, string> testOptionsMap, global::UnityEngine.AndroidJavaObject ajoCurrentActivity)
        {
            return null;
        }
    }
}