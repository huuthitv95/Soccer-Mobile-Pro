namespace Gadsme.Core.Native
{
    internal class Tdabed9b_65
    {
        private static global::Gadsme.Core.Native.IAndroidNativeInterface Android;
        private static global::Gadsme.Core.Native.IIOSNativeInterface IOS;
        private static global::Gadsme.Core.Native.IMacNativeInterface Mac;
        internal static global::Gadsme.Core.Native.IAndroidNativeInterface P46
        {
            get
            {
                return get_Android();
            }

            private set
            {
                set_Android(value);
            }
        }

        internal static global::Gadsme.Core.Native.IIOSNativeInterface P47
        {
            get
            {
                return get_IOS();
            }

            private set
            {
                set_IOS(value);
            }
        }

        internal static global::Gadsme.Core.Native.IMacNativeInterface P48
        {
            get
            {
                return get_Mac();
            }

            private set
            {
                set_Mac(value);
            }
        }

        internal static global::Gadsme.Core.Native.IAndroidNativeInterface get_Android()
        {
            return Android;
        }

        private static void set_Android(global::Gadsme.Core.Native.IAndroidNativeInterface value)
        {
            Android = value;
        }

        internal static global::Gadsme.Core.Native.IIOSNativeInterface get_IOS()
        {
            return IOS;
        }

        private static void set_IOS(global::Gadsme.Core.Native.IIOSNativeInterface value)
        {
            IOS = value;
        }

        internal static global::Gadsme.Core.Native.IMacNativeInterface get_Mac()
        {
            return Mac;
        }

        private static void set_Mac(global::Gadsme.Core.Native.IMacNativeInterface value)
        {
            Mac = value;
        }

        public static void M425(global::Gadsme.Core.Native.IAndroidNativeInterface A409)
        {
        }

        public static void M426(global::Gadsme.Core.Native.IIOSNativeInterface A410)
        {
        }

        public static void M427(global::Gadsme.Core.Native.IMacNativeInterface A411)
        {
        }

        public static bool M428()
        {
            return false;
        }

        public static bool M429()
        {
            return false;
        }
    }
}