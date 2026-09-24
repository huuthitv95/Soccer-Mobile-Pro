namespace Gadsme.Core.Native
{
    internal class Tdabed9b_84 : global::Gadsme.Core.Native.Tdabed9b_64, global::Gadsme.Core.Native.Tdabed9b_63
    {
        private static bool F430;
        private static bool F431;
        private global::UnityEngine.Texture2D texture;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F432;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F433;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F434;
        private global::System.IntPtr F435;
        private global::UnityEngine.Rendering.CommandBuffer F436;
        private float F437;
        private float F438;
        public global::UnityEngine.Texture2D P50
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

        public Tdabed9b_84(int width, int height)
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

        internal static void M458(string A444)
        {
        }

        internal static void M459()
        {
        }

        public static void M460(bool A445)
        {
        }

        public static void M461(string A446, bool A447)
        {
        }

        public static void M462(string A448, string A449)
        {
        }

        public static void M463(string A450, double A451)
        {
        }

        private static void M464()
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

        public void Update()
        {
        }

        public void Destroy()
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