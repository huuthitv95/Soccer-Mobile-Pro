namespace Common
{
    public static class Native
    {
        public static T Invoke<T, T2>(global::System.IntPtr library, params object[] pars)
        {
            return default;
        }

        public static void Invoke<T>(global::System.IntPtr library, params object[] pars)
        {
        }

        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool FreeLibrary(global::System.IntPtr hModule);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr LoadLibrary(string lpFileName);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr GetProcAddress(global::System.IntPtr hModule, string procedureName);
    }
}