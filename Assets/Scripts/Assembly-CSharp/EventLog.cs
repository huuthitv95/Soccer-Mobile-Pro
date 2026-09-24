public class EventLog : global::UnityEngine.MonoBehaviour
{
    public class Param
    {
        private enum Type
        {
            String = 0,
            Long = 1,
            Double = 2,
            Bool = 3
        }

        public string paramname;
        private string value;
        private long longvalue;
        private double doublevalue;
        private bool boolvalue;
        private EventLog.Param.Type _type;
        public Param(string parameterName, string parameterValue)
        {
        }

        public Param(string parameterName, long parameterValue)
        {
        }

        public Param(string parameterName, double parameterValue)
        {
        }

        public Param(string parameterName, bool parameterValue)
        {
        }

        public void UpdateLongvalue(long v)
        {
        }

        public void UpdateDoublevalue(double v)
        {
        }

        public void UpdateStringValue(string v)
        {
        }

        public bool IsMiddleParameter()
        {
            return false;
        }

        public global::Firebase.Analytics.Parameter ToFirebaseParameter()
        {
            return null;
        }

        public string ToGeneralLog()
        {
            return null;
        }
    }

    public static bool FirebaseIsReady;
    private static FirebaseAnalyticsEventLogger _analyticsEventLogger;
    public static string EventAddPaymentInfo;
    public static string EventAddToCart;
    public static string EventAddToWishlist;
    public static string EventAppOpen;
    public static string EventBeginCheckout;
    public static string EventCampaignDetails;
    public static string EventCheckoutProgress;
    public static string EventEarnVirtualCurrency;
    public static string EventEcommercePurchase;
    public static string EventGenerateLead;
    public static string EventJoinGroup;
    public static string EventLevelEnd;
    public static string EventLevelStart;
    public static string EventLevelUp;
    public static string EventLogin;
    public static string EventPostScore;
    public static string EventPresentOffer;
    public static string EventPurchaseRefund;
    public static string EventRemoveFromCart;
    public static string EventSearch;
    public static string EventSelectContent;
    public static string EventSetCheckoutOption;
    public static string EventShare;
    public static string EventSignUp;
    public static string EventSpendVirtualCurrency;
    public static string EventTutorialBegin;
    public static string EventTutorialComplete;
    public static string EventUnlockAchievement;
    public static string EventViewItem;
    public static string EventViewItemList;
    public static string EventViewSearchResults;
    public const string ParameterValue = "value";
    public const string ParameterCurrency = "currency";
    public static string ParameterLevel;
    public static string ParameterLevelName;
    private bool useDisposableEvent;
    public static string PropertyEnergy;
    public static string PropertyMedal;
    private static global::System.Collections.Generic.Dictionary<string, string> _propsBeforeInitial;
    private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, EventLog.Param[]>> _eventBeforeInitial;
    private static global::System.Collections.Generic.Dictionary<string, string> _propsArchive;
    private static bool _loadingID;
    private static int _matchid;
    private static int _levelid;
    private static byte[] _replayBuff;
    private static int _bufLength;
    private static int _frameCount;
    public static FirebaseAnalyticsEventLogger AnalyticsLogger
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public static string FirebaseID { get; private set; }

    public static void LogEventOnce(string name, string parameterName, int parameterValue)
    {
    }

    public static void LogEventOnce(string name, string parameterName, string parameterValue)
    {
    }

    public static bool LogEventOnce(string name, params EventLog.Param[] param)
    {
        return false;
    }

    public static void LogEvent(string name, string parameterName, int parameterValue)
    {
    }

    public static void LogEvent(string name)
    {
    }

    public static void LogEvent(string name, string parameterName, string parameterValue)
    {
    }

    public static void AddEvent(string name, int value)
    {
    }

    public static void SetEvent(global::System.Collections.Generic.Dictionary<string, object> properties)
    {
    }

    public static void SetPublicEvent()
    {
    }

    public static void LogEvent(string name, params EventLog.Param[] param)
    {
    }

    public static void SetPlayerInfo(string key, string value)
    {
    }

    public static void SetPlayerInfo(string key, int value)
    {
    }

    public static string GetPlayerInfo(string key)
    {
        return null;
    }

    public static void FlushProperty()
    {
    }

    private static void CheckParamValid(params string[] names)
    {
    }

    private static void CheckParamValid(string names)
    {
    }

    public static void LoadID(bool is_installreferrer = false)
    {
    }

    public static void StartMatchLog(int playercount0, int playercount1)
    {
    }

    public static void LogReplay(ref byte[] buf, int length)
    {
    }

    public static void FlushBuff()
    {
    }
}