namespace Firebase.Analytics
{
    public static class FirebaseAnalytics
    {
        public static string EventAdImpression;
        public static string EventAddPaymentInfo;
        public static string EventAddShippingInfo;
        public static string EventAddToCart;
        public static string EventAddToWishlist;
        public static string EventAppOpen;
        public static string EventBeginCheckout;
        public static string EventCampaignDetails;
        public static string EventEarnVirtualCurrency;
        public static string EventGenerateLead;
        public static string EventJoinGroup;
        public static string EventLevelEnd;
        public static string EventLevelStart;
        public static string EventLevelUp;
        public static string EventLogin;
        public static string EventPostScore;
        public static string EventPurchase;
        public static string EventRefund;
        public static string EventRemoveFromCart;
        public static string EventScreenView;
        public static string EventSearch;
        public static string EventSelectContent;
        public static string EventSelectItem;
        public static string EventSelectPromotion;
        public static string EventShare;
        public static string EventSignUp;
        public static string EventSpendVirtualCurrency;
        public static string EventTutorialBegin;
        public static string EventTutorialComplete;
        public static string EventUnlockAchievement;
        public static string EventViewCart;
        public static string EventViewItem;
        public static string EventViewItemList;
        public static string EventViewPromotion;
        public static string EventViewSearchResults;
        public static string ParameterAchievementID;
        public static string ParameterAdFormat;
        public static string ParameterAdNetworkClickID;
        public static string ParameterAdPlatform;
        public static string ParameterAdSource;
        public static string ParameterAdUnitName;
        public static string ParameterAffiliation;
        public static string ParameterCP1;
        public static string ParameterCampaign;
        public static string ParameterCampaignID;
        public static string ParameterCharacter;
        public static string ParameterContent;
        public static string ParameterContentType;
        public static string ParameterCoupon;
        public static string ParameterCreativeFormat;
        public static string ParameterCreativeName;
        public static string ParameterCreativeSlot;
        public static string ParameterCurrency;
        public static string ParameterDestination;
        public static string ParameterDiscount;
        public static string ParameterEndDate;
        public static string ParameterExtendSession;
        public static string ParameterFlightNumber;
        public static string ParameterGroupID;
        public static string ParameterIndex;
        public static string ParameterItemBrand;
        public static string ParameterItemCategory;
        public static string ParameterItemCategory2;
        public static string ParameterItemCategory3;
        public static string ParameterItemCategory4;
        public static string ParameterItemCategory5;
        public static string ParameterItemID;
        public static string ParameterItemListID;
        public static string ParameterItemListName;
        public static string ParameterItemName;
        public static string ParameterItemVariant;
        public static string ParameterItems;
        public static string ParameterLevel;
        public static string ParameterLevelName;
        public static string ParameterLocation;
        public static string ParameterLocationID;
        public static string ParameterMarketingTactic;
        public static string ParameterMedium;
        public static string ParameterMethod;
        public static string ParameterNumberOfNights;
        public static string ParameterNumberOfPassengers;
        public static string ParameterNumberOfRooms;
        public static string ParameterOrigin;
        public static string ParameterPaymentType;
        public static string ParameterPrice;
        public static string ParameterPromotionID;
        public static string ParameterPromotionName;
        public static string ParameterQuantity;
        public static string ParameterScore;
        public static string ParameterScreenClass;
        public static string ParameterScreenName;
        public static string ParameterSearchTerm;
        public static string ParameterShipping;
        public static string ParameterShippingTier;
        public static string ParameterSource;
        public static string ParameterSourcePlatform;
        public static string ParameterStartDate;
        public static string ParameterSuccess;
        public static string ParameterTax;
        public static string ParameterTerm;
        public static string ParameterTransactionID;
        public static string ParameterTravelClass;
        public static string ParameterValue;
        public static string ParameterVirtualCurrencyName;
        public static string UserPropertyAllowAdPersonalizationSignals;
        public static string UserPropertySignUpMethod;
        public static global::System.Threading.Tasks.Task<string> GetAnalyticsInstanceIdAsync()
        {
            return null;
        }

        public static void LogEvent(string name, string parameterName, string parameterValue)
        {
        }

        public static void LogEvent(string name, string parameterName, long parameterValue)
        {
        }

        public static void LogEvent(string name)
        {
        }

        public static void LogEvent(string name, params global::Firebase.Analytics.Parameter[] parameters)
        {
        }

        public static void SetConsent(global::System.Collections.Generic.IDictionary<global::Firebase.Analytics.ConsentType, global::Firebase.Analytics.ConsentStatus> consentSettings)
        {
        }

        public static void SetUserProperty(string name, string property)
        {
        }
    }
}