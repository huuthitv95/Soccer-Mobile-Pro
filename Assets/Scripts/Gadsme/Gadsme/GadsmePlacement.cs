namespace Gadsme
{
    public class GadsmePlacement : global::UnityEngine.MonoBehaviour
    {
        internal int F202;
        private static int F203;
        internal static global::System.Collections.Generic.List<global::System.Action<global::Gadsme.GadsmePlacement>> F204;
        internal static global::UnityEngine.Texture2D F205;
        internal static global::UnityEngine.Texture2D F206;
        internal static global::UnityEngine.Texture2D F207;
        internal static global::UnityEngine.Texture2D F208;
        internal static global::UnityEngine.Texture2D F209;
        public global::Gadsme.GadsmeAdFormat adFormat;
        public string placementId;
        public int adChannelNumber;
        public string adChannelId;
        public bool clickInteraction;
        public bool use2DSpriteShader;
        public bool useUnlitShader;
        public global::UnityEngine.Texture2D fallbackTexture;
        public bool fallbackTextureVisibleWhenLoading;
        public global::UnityEngine.MeshRenderer meshRenderer;
        public int meshSegments;
        public float meshBendAmount;
        public global::Gadsme.Tdabed9b_23 meshBendAxis;
        public global::Gadsme.Tdabed9b_24 meshBendDirection;
        public global::Gadsme.GadsmeRawImage rawImage;
        public global::UnityEngine.Material customMaterial;
        public global::Gadsme.Tdabed9b_2 F210;
        private bool F211;
        internal bool F212;
        private bool isRendered;
        private bool isVisible;
        private bool hasFallbackContent;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement, bool> F213;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement, bool> F214;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F215;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F216;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F217;
        internal global::UnityEngine.Vector3[] F218;
        internal float[][] F219;
        internal int F220;
        internal bool F221;
        internal global::UnityEngine.Texture F222;
        internal static global::System.Collections.Generic.List<global::Gadsme.GadsmePlacement> F223;
        public bool UseAdContentPool;
        internal global::Gadsme.Tdabed9b_2 F224;
        internal global::Gadsme.Tdabed9b_2 F225;
        internal static bool F226;
        private global::UnityEngine.GameObject F227;
        private global::UnityEngine.MeshRenderer F228;
        private global::Gadsme.Tdabed9b_27 F229;
        public int ShouldRegister;
        internal bool P12
        {
            get
            {
                return get_isRendered();
            }

            private set
            {
                set_isRendered(value);
            }
        }

        internal bool P13
        {
            get
            {
                return get_isVisible();
            }

            private set
            {
                set_isVisible(value);
            }
        }

        internal bool P14
        {
            get
            {
                return get_hasFallbackContent();
            }

            private set
            {
                set_hasFallbackContent(value);
            }
        }

        internal bool P15 => get_isValid();

        public event global::System.Action<global::Gadsme.GadsmePlacement, bool> EnableChangeEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::Gadsme.GadsmePlacement, bool> RenderChangeEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::Gadsme.GadsmePlacement> InteractEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::Gadsme.GadsmePlacement> ContentLoadedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::Gadsme.GadsmePlacement> ContentFailedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal bool get_isRendered()
        {
            return isRendered;
        }

        private void set_isRendered(bool value)
        {
            isRendered = value;
        }

        internal bool get_isVisible()
        {
            return isVisible;
        }

        private void set_isVisible(bool value)
        {
            isVisible = value;
        }

        internal bool get_hasFallbackContent()
        {
            return hasFallbackContent;
        }

        private void set_hasFallbackContent(bool value)
        {
            hasFallbackContent = value;
        }

        private void Awake()
        {
        }

        public bool M253()
        {
            return false;
        }

        public bool M254()
        {
            return false;
        }

        public bool M255()
        {
            return false;
        }

        public virtual bool IsPoolCompatible()
        {
            return false;
        }

        public virtual void Start()
        {
        }

        private void LateUpdate()
        {
        }

        private void M256()
        {
        }

        public void ApplyMeshBend()
        {
        }

        public global::UnityEngine.GameObject M257()
        {
            return null;
        }

        public void M258()
        {
        }

        public bool M259()
        {
            return false;
        }

        internal void M260()
        {
        }

        internal void M261()
        {
        }

        internal void M262()
        {
        }

        private string M263()
        {
            return null;
        }

        public void M264()
        {
        }

        public virtual void ReconfigureMaterialIfNeeded()
        {
        }

        private void M265()
        {
        }

        private void M266()
        {
        }

        public string M267()
        {
            return null;
        }

        public bool M268()
        {
            return false;
        }

        public void M269()
        {
        }

        public void M270()
        {
        }

        public void M271(global::UnityEngine.Texture A203)
        {
        }

        private bool M272()
        {
            return false;
        }

        private void OnWillRenderObject()
        {
        }

        internal float M273(global::UnityEngine.Vector3 A204)
        {
            return 0f;
        }

        public void OnBecameVisible()
        {
        }

        public void OnBecameInvisible()
        {
        }

        protected void Update()
        {
        }

        protected void M274()
        {
        }

        protected void OnEnable()
        {
        }

        protected void OnDisable()
        {
        }

        private void M275()
        {
        }

        private void M276()
        {
        }

        private void M277()
        {
        }

        private void M278()
        {
        }

        private void M279()
        {
        }

        private void M280()
        {
        }

        internal bool get_isValid()
        {
            return false;
        }

        internal void M281()
        {
        }

        internal void M282()
        {
        }

        internal bool M283()
        {
            return false;
        }

        internal void M284()
        {
        }

        internal void M285()
        {
        }

        internal bool M286()
        {
            return false;
        }

        internal void M287()
        {
        }

        internal void M288()
        {
        }

        internal void M289()
        {
        }

        internal void M290()
        {
        }

        internal global::UnityEngine.Vector2 M291(global::UnityEngine.Vector3 A205)
        {
            return default;
        }

        public virtual void Interact()
        {
        }

        public virtual void Interact(global::UnityEngine.Vector2 hitPoint)
        {
        }

        protected void OnDestroy()
        {
        }

        public global::UnityEngine.Vector3[] M292(global::UnityEngine.Camera A206, int A207, int A208)
        {
            return null;
        }

        internal void M293(float A209)
        {
        }

        internal void M294(global::UnityEngine.Texture A210)
        {
        }

        internal virtual void SetGaugeProgressInCanvas(float progress)
        {
        }

        public static void M295(global::System.Action<global::Gadsme.GadsmePlacement> A211)
        {
        }

        internal void M296()
        {
        }

        internal float M297(int A212)
        {
            return 0f;
        }
    }
}