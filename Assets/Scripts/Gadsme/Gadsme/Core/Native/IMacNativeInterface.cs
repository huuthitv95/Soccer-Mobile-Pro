namespace Gadsme.Core.Native
{
	public interface IMacNativeInterface
	{
		global::System.IntPtr PluginGetUpdateTextureCallback();

		void PluginSetMessageCallback(global::System.IntPtr nativeMessageCallback);

		global::System.IntPtr WebTexture_new(int width, int height);

		int WebTexture_getInstanceId(global::System.IntPtr webViewTexturePtr);

		void WebTexture_setUserAgent(global::System.IntPtr webViewTexturePtr, string userAgent);

		void WebTexture_loadUrl(global::System.IntPtr webViewTexturePtr, string url);

		void WebTexture_loadHtml(global::System.IntPtr webViewTexturePtr, string html);

		void WebTexture_render(global::System.IntPtr webViewTexturePtr);

		void WebTexture_click(global::System.IntPtr webViewTexturePtr, int posX, int posY);

		void WebTexture_destroy(global::System.IntPtr webViewTexturePtr);

		int AdvertisingIdentifier_request();

		int UserAgent_request();
	}
}
