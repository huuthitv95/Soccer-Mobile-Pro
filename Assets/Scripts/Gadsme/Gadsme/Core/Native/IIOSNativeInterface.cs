namespace Gadsme.Core.Native
{
	public interface IIOSNativeInterface
	{
		global::System.IntPtr PluginGetUpdateTextureCallback();

		void PluginSetMessageCallback(global::System.IntPtr nativeMessageCallback);

		global::System.IntPtr WebTexture_new(int width, int height);

		void WebTexture_setGadsmeBridgeJavascript(string gadsmeBridgeJavascript);

		void WebTexture_setGadsmeSDKVersion(string sdkVersion);

		void WebTexture_setRemoteDebugEnabled(bool enabled);

		void WebTexture_setRemoteDebugBoolConfig(string name, bool value);

		void WebTexture_setRemoteDebugStringConfig(string name, string value);

		void WebTexture_setRemoteDebugDoubleConfig(string name, double value);

		int WebTexture_getInstanceId(global::System.IntPtr webViewTexturePtr);

		void WebTexture_setUserAgent(global::System.IntPtr webViewTexturePtr, string userAgent);

		void WebTexture_loadUrl(global::System.IntPtr webViewTexturePtr, string url);

		void WebTexture_loadHtml(global::System.IntPtr webViewTexturePtr, string html);

		void WebTexture_setViewable(global::System.IntPtr webViewTexturePtr, bool viewable);

		void WebTexture_render(global::System.IntPtr webViewTexturePtr);

		void WebTexture_click(global::System.IntPtr webViewTexturePtr, int posX, int posY);

		void WebTexture_setSkAdNetworkData(global::System.IntPtr webViewTexturePtr, string skAdNetworkDataString);

		void WebTexture_destroy(global::System.IntPtr webViewTexturePtr);

		void AdPresenter_presentURL(string url, string adNetworkData);

		int AdvertisingIdentifier_request(bool allowConsentDialog);

		global::System.IntPtr VendorIdentifier_getIdentifier();

		global::System.IntPtr SKAdNetwork_getAdNetworkIds();

		int UserAgent_request();

		global::System.IntPtr TCF_getConsentString();

		float Audio_requestAudioVolume();
	}
}
