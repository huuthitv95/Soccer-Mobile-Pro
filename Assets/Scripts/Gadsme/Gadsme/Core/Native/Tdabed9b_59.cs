namespace Gadsme.Core.Native
{
    internal class Tdabed9b_59 : global::Gadsme.Core.Native.Tdabed9b_64, global::Gadsme.Core.Native.Tdabed9b_63
    {
        private static bool F399;
        private static bool F400;
        private static global::UnityEngine.AndroidJavaClass F401;
        private global::UnityEngine.Texture2D texture;
        private global::UnityEngine.AndroidJavaObject F402;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F403;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F404;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F405;
        private global::UnityEngine.Rendering.CommandBuffer F406;
        private float F407;
        private float F408;
        public global::UnityEngine.Texture2D P43
        {
            get
            {
                return get_texture();
            }

            private set
            {
                set_texture(value);
            }
        }

        public event global::System.Action PageLoadedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action PageErrorEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action PageClickVisitedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public Tdabed9b_59(int width, int height, int explicitDrawInterval)
        {
        }

        public global::UnityEngine.Texture2D get_texture()
        {
            return texture;
        }

        private void set_texture(global::UnityEngine.Texture2D value)
        {
            texture = value;
        }

        private static void M413()
        {
        }

        internal static void M414(string A397)
        {
        }

        public static void M415(bool A398)
        {
        }

        public static void M416(string A399, bool A400)
        {
        }

        public static void M417(string A401, string A402)
        {
        }

        public static void M418(string A403, double A404)
        {
        }

        internal static void M419()
        {
        }

        private static void M420()
        {
        }

        public void Update()
        {
        }

        public void Destroy()
        {
        }

        public void SetUserAgent(string userAgent)
        {
        }

        public void LoadUrl(string url)
        {
        }

        public void LoadHtml(string html)
        {
        }

        public void SetViewable(bool viewable)
        {
        }

        public void Click(global::UnityEngine.Vector2 point)
        {
        }

        public void SetSkAdNetworkData(string skAdNetworkDataString)
        {
        }

        public void HandleNativeMessage(string message)
        {
        }

        global::UnityEngine.Texture2D global::Gadsme.Core.Native.Tdabed9b_64.P45
        {
            get
            {
                return get_texture();
            }
        }
    }
}