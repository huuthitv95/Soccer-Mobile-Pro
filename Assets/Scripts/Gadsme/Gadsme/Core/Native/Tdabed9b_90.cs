namespace Gadsme.Core.Native
{
    internal class Tdabed9b_90 : global::Gadsme.Core.Native.Tdabed9b_64, global::Gadsme.Core.Native.Tdabed9b_63
    {
        private global::UnityEngine.Texture2D texture;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F441;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F442;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F443;
        private global::System.IntPtr F444;
        private global::UnityEngine.Rendering.CommandBuffer F445;
        private float F446;
        private float F447;
        public global::UnityEngine.Texture2D P51
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

        public Tdabed9b_90(int width, int height)
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