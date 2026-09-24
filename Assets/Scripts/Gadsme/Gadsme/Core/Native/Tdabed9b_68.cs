namespace Gadsme.Core.Native
{
    internal class Tdabed9b_68 : global::Gadsme.Core.Native.Tdabed9b_64
    {
        private readonly global::UnityEngine.Texture2D texture;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F422;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F423;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action F424;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<int, string> F425;
        public global::UnityEngine.Texture2D P49 => get_texture();

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

        public event global::System.Action<int, string> RemoteDebugEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public Tdabed9b_68(int width, int height)
        {
        }

        public global::UnityEngine.Texture2D get_texture()
        {
            return texture;
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

        global::UnityEngine.Texture2D global::Gadsme.Core.Native.Tdabed9b_64.P45
        {
            get
            {
                return get_texture();
            }
        }
    }
}