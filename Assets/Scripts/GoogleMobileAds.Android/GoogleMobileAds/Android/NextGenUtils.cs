namespace GoogleMobileAds.Android
{
	internal class NextGenUtils
	{
		public const string MaxAdContentRatingClassName = "com.google.android.libraries.ads.mobile.sdk.common.RequestConfiguration$MaxAdContentRating";

		public const string PublisherPrivacyPersonalizationStateEnumName = "com.google.android.libraries.ads.mobile.sdk.common.RequestConfiguration$PublisherPrivacyPersonalizationState";

		public const string RequestConfigurationBuilderClassName = "com.google.android.libraries.ads.mobile.sdk.common.RequestConfiguration$Builder";

		public const string TagForChildDirectedTreatmentClassName = "com.google.android.libraries.ads.mobile.sdk.common.RequestConfiguration$TagForChildDirectedTreatment";

		public const string TagForUnderAgeOfConsentClassName = "com.google.android.libraries.ads.mobile.sdk.common.RequestConfiguration$TagForUnderAgeOfConsent";

		public const string InitializationConfigBuilderClassName = "com.google.android.libraries.ads.mobile.sdk.initialization.InitializationConfig$Builder";

		public const string AdapterStatusInitializationStateName = "com.google.android.libraries.ads.mobile.sdk.initialization.AdapterStatus$InitializationState";

		public const string MobileAdsClassName = "com.google.android.libraries.ads.mobile.sdk.MobileAds";

		public const string OnInitializationCompleteListenerClassName = "com.google.android.libraries.ads.mobile.sdk.initialization.OnAdapterInitializationCompleteListener";

		public const string AdRequestBuilderClassName = "com.google.android.libraries.ads.mobile.sdk.common.AdRequest$Builder";

		public const string BannerAdRequestBuilderClassName = "com.google.android.libraries.ads.mobile.sdk.banner.BannerAdRequest$Builder";

		public const string NativeAdRequestBuilderClassName = "com.google.android.libraries.ads.mobile.sdk.nativead.NativeAdRequest$Builder";

		public const string AdSizeClassName = "com.google.android.libraries.ads.mobile.sdk.banner.AdSize";

		public const string PreloadConfigurationClassName = "com.google.android.libraries.ads.mobile.sdk.common.PreloadConfiguration";

		public const string NativeAdTypeClassName = "com.google.android.libraries.ads.mobile.sdk.nativead.NativeAd$NativeAdType";

		public const string UnityMobileAdsClassName = "com.google.unity.ads.nextgen.UnityMobileAds";

		public const string UnityAdInspectorClassName = "com.google.unity.ads.nextgen.UnityAdInspector";

		public const string UnityAdInspectorListenerClassName = "com.google.unity.ads.nextgen.UnityAdInspectorListener";

		public const string UnityPreloadCallbackClassName = "com.google.unity.ads.nextgen.UnityPreloadCallback";

		public const string UnityAppOpenAdClassName = "com.google.unity.ads.nextgen.UnityAppOpenAd";

		public const string UnityAppOpenAdCallbackClassName = "com.google.unity.ads.nextgen.UnityAppOpenAdCallback";

		public const string UnityAppOpenAdPreloaderClassName = "com.google.unity.ads.nextgen.UnityAppOpenAdPreloader";

		public const string UnityBannerAdClassName = "com.google.unity.ads.nextgen.UnityBannerAd";

		public const string UnityBannerAdCallbackClassName = "com.google.unity.ads.nextgen.UnityBannerAdCallback";

		public const string UnityInterstitialAdClassName = "com.google.unity.ads.nextgen.UnityInterstitialAd";

		public const string UnityInterstitialAdCallbackClassName = "com.google.unity.ads.nextgen.UnityInterstitialAdCallback";

		public const string UnityRewardedAdClassName = "com.google.unity.ads.nextgen.UnityRewardedAd";

		public const string UnityRewardedAdCallbackClassName = "com.google.unity.ads.nextgen.UnityRewardedAdCallback";

		public const string UnityRewardedAdPreloaderClassName = "com.google.unity.ads.nextgen.UnityRewardedAdPreloader";

		public const string UnityRewardedInterstitialAdClassName = "com.google.unity.ads.nextgen.UnityRewardedInterstitialAd";

		public const string UnityRewardedInterstitialAdCallbackClassName = "com.google.unity.ads.nextgen.UnityRewardedInterstitialAdCallback";

		public const string UnityInterstitialAdPreloaderClassName = "com.google.unity.ads.nextgen.UnityInterstitialAdPreloader";

		public static global::UnityEngine.AndroidJavaObject GetAdRequestJavaObject(global::GoogleMobileAds.Api.AdRequest request, string adUnitId)
		{
			return null;
		}

		public static global::UnityEngine.AndroidJavaObject GetBannerAdRequestJavaObject(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, global::GoogleMobileAds.Api.AdSize adSize)
		{
			return null;
		}

		public static global::UnityEngine.AndroidJavaObject GetNativeAdRequestJavaObject(string adUnitId, global::GoogleMobileAds.Api.AdRequest request, string nativePluginVersion = null)
		{
			return null;
		}

		public static global::UnityEngine.AndroidJavaObject GetAdSizeJavaObject(global::GoogleMobileAds.Api.AdSize adSize)
		{
			return null;
		}

		public static global::UnityEngine.AndroidJavaObject GetPreloadConfigurationJavaObject(global::GoogleMobileAds.Api.PreloadConfiguration preloadConfiguration)
		{
			return null;
		}

		public static global::GoogleMobileAds.Api.PreloadConfiguration GetPreloadConfiguration(global::UnityEngine.AndroidJavaObject configurationJavaObject)
		{
			return null;
		}
	}
}
