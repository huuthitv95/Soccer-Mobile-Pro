namespace Gadsme.Core.Native
{
    internal class AndroidNativeInterface : global::Gadsme.Core.Native.IAndroidNativeInterface
    {
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr GDSPluginGetUpdateTextureCallback();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void GDSPluginSetMessageCallback(global::System.IntPtr nativeMessageCallback);
        public global::System.IntPtr PluginGetUpdateTextureCallback()
        {
            return (global::System.IntPtr)0;
        }

        public void PluginSetMessageCallback(global::System.IntPtr nativeMessageCallback)
        {
        }
    }
}