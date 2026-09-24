namespace Gadsme
{
    public abstract class Tdabed9b_2
    {
        internal readonly string F0;
        internal readonly global::Gadsme.GadsmeAdFormat F1;
        internal readonly int F2;
        internal bool F3;
        internal bool F4;
        internal readonly global::System.Collections.Generic.List<global::Gadsme.GadsmePlacement> F5;
        internal global::Gadsme.Tdabed9b_48<global::Gadsme.Tdabed9b_2> F6;
        private bool hasExpiredContent;
        private bool hasContent;
        private bool hasVisiblePlacements;
        private bool isHidingPlacementRenderers;
        private global::UnityEngine.Texture placementRenderersMainTexture;
        internal float F7;
        internal bool F8;
        internal float F9;
        internal float F10;
        internal bool F11;
        internal global::Gadsme.Tdabed9b_27 F12;
        internal global::Gadsme.Tdabed9b_7 F13;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.Tdabed9b_2> F14;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.Tdabed9b_2> F15;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.Tdabed9b_2> F16;
        internal string F17;
        internal bool F18;
        internal bool F19;
        internal bool F20;
        internal bool F21;
        internal bool F22;
        internal bool F23;
        internal bool F24;
        internal bool F25;
        internal float F26;
        internal int F27;
        internal int F28;
        private static int F29;
        internal bool P3 => get_isAdChannel();

        internal bool P4
        {
            get
            {
                return get_hasExpiredContent();
            }

            private set
            {
                set_hasExpiredContent(value);
            }
        }

        internal bool P5
        {
            get
            {
                return get_hasContent();
            }

            private set
            {
                set_hasContent(value);
            }
        }

        internal bool P6
        {
            get
            {
                return get_hasVisiblePlacements();
            }

            private set
            {
                set_hasVisiblePlacements(value);
            }
        }

        internal bool P7
        {
            get
            {
                return get_isHidingPlacementRenderers();
            }

            private set
            {
                set_isHidingPlacementRenderers(value);
            }
        }

        internal global::UnityEngine.Texture P8
        {
            get
            {
                return get_placementRenderersMainTexture();
            }

            private set
            {
                set_placementRenderersMainTexture(value);
            }
        }

        internal event global::System.Action<global::Gadsme.Tdabed9b_2> ContentLoadedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.Tdabed9b_2> ContentFailedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.Tdabed9b_2> ContentExpiredEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal Tdabed9b_2(string placementId, string adFormatId, int adChannelNumber, bool isPoolAdContent = false)
        {
        }

        internal bool get_isAdChannel()
        {
            return false;
        }

        internal bool get_hasExpiredContent()
        {
            return hasExpiredContent;
        }

        private void set_hasExpiredContent(bool value)
        {
            hasExpiredContent = value;
        }

        internal bool get_hasContent()
        {
            return hasContent;
        }

        private void set_hasContent(bool value)
        {
            hasContent = value;
        }

        internal bool get_hasVisiblePlacements()
        {
            return hasVisiblePlacements;
        }

        private void set_hasVisiblePlacements(bool value)
        {
            hasVisiblePlacements = value;
        }

        internal bool get_isHidingPlacementRenderers()
        {
            return isHidingPlacementRenderers;
        }

        private void set_isHidingPlacementRenderers(bool value)
        {
            isHidingPlacementRenderers = value;
        }

        internal global::UnityEngine.Texture get_placementRenderersMainTexture()
        {
            return placementRenderersMainTexture;
        }

        private void set_placementRenderersMainTexture(global::UnityEngine.Texture value)
        {
            placementRenderersMainTexture = value;
        }

        internal bool M3()
        {
            return false;
        }

        internal bool M4()
        {
            return false;
        }

        internal global::Gadsme.GadsmeAdContentInfo M5()
        {
            return default;
        }

        internal bool M6()
        {
            return false;
        }

        internal global::Gadsme.Tdabed9b_27 M7()
        {
            return global::Gadsme.Tdabed9b_27.NONE;
        }

        internal virtual void OnStop()
        {
        }

        internal virtual void CreateVisibilityStats()
        {
        }

        public void M8(global::Gadsme.GadsmePlacement A2)
        {
        }

        public void M9(global::Gadsme.GadsmePlacement A3)
        {
        }

        public void M10()
        {
        }

        public bool M11()
        {
            return false;
        }

        public bool M12()
        {
            return false;
        }

        public bool M13()
        {
            return false;
        }

        public bool M14()
        {
            return false;
        }

        public float M15(global::UnityEngine.Vector3 A4)
        {
            return 0f;
        }

        public global::Gadsme.GadsmePlacement M16(global::UnityEngine.Vector3 A5, float A6 = float.MaxValue)
        {
            return null;
        }

        public bool M17()
        {
            return false;
        }

        public bool M18()
        {
            return false;
        }

        internal void M19()
        {
        }

        internal int M20()
        {
            return 0;
        }

        internal void M21(global::UnityEngine.Texture A7)
        {
        }

        private void M22()
        {
        }

        private void M23()
        {
        }

        internal virtual void timeout()
        {
        }

        internal virtual void SetContentLoaded(bool showPlacements = true)
        {
        }

        internal virtual void SetContentFailed()
        {
        }

        internal void M24(float A8 = 0f, bool A9 = false)
        {
        }

        internal virtual void UpdateExpiredStatus()
        {
        }

        internal virtual void LoadContent()
        {
        }

        internal void M25()
        {
        }

        internal virtual void OnStartLoad()
        {
        }

        internal virtual void OnViewable()
        {
        }

        internal virtual bool CanLoad()
        {
            return false;
        }

        internal bool M26()
        {
            return false;
        }

        internal virtual bool CanFireTrackingClickedUrlsOnClick()
        {
            return false;
        }

        internal void M27(global::Gadsme.GadsmePlacement A10)
        {
        }

        internal void M28(global::Gadsme.GadsmePlacement A11)
        {
        }

        internal virtual void OnBecameVisible()
        {
        }

        internal virtual void OnBecameInvisible()
        {
        }

        internal virtual void Interact(global::Gadsme.GadsmePlacement placement, global::UnityEngine.Vector2 hitPoint)
        {
        }

        internal virtual void Update()
        {
        }

        internal virtual void LateUpdate()
        {
        }

        internal virtual bool IsAffectedByMaxActiveAdContents()
        {
            return false;
        }

        internal virtual void Unload()
        {
        }

        internal virtual void Dispose()
        {
        }
    }
}