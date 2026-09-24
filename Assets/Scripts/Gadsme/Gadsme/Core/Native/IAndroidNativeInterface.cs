namespace Gadsme.Core.Native
{
	public interface IAndroidNativeInterface
	{
		global::System.IntPtr PluginGetUpdateTextureCallback();

		void PluginSetMessageCallback(global::System.IntPtr nativeMessageCallback);
	}
}
