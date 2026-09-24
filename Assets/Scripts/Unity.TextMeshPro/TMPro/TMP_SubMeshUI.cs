namespace TMPro
{
    public class TMP_SubMeshUI : global::UnityEngine.UI.MaskableGraphic
    {
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_FontAsset m_fontAsset;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_SpriteAsset m_spriteAsset;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Material m_material;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Material m_sharedMaterial;
        private global::UnityEngine.Material m_fallbackMaterial;
        private global::UnityEngine.Material m_fallbackSourceMaterial;
        [global::UnityEngine.SerializeField]
        private bool m_isDefaultMaterial;
        [global::UnityEngine.SerializeField]
        private float m_padding;
        private global::UnityEngine.Mesh m_mesh;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TextMeshProUGUI m_TextComponent;
        [global::System.NonSerialized]
        private bool m_isRegisteredForEvents;
        private bool m_materialDirty;
        [global::UnityEngine.SerializeField]
        private int m_materialReferenceIndex;
        private global::UnityEngine.Transform m_RootCanvasTransform;
        public global::TMPro.TMP_FontAsset fontAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_SpriteAsset spriteAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override global::UnityEngine.Texture mainTexture => null;

        public override global::UnityEngine.Material material
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Material sharedMaterial
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Material fallbackMaterial
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Material fallbackSourceMaterial
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override global::UnityEngine.Material materialForRendering => null;

        public bool isDefaultMaterial
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float padding
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Mesh mesh
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_Text textComponent => null;

        public static global::TMPro.TMP_SubMeshUI AddSubTextObject(global::TMPro.TextMeshProUGUI textComponent, global::TMPro.MaterialReference materialReference)
        {
            return null;
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        public override global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        public float GetPaddingForMaterial()
        {
            return 0f;
        }

        public float GetPaddingForMaterial(global::UnityEngine.Material mat)
        {
            return 0f;
        }

        public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
        {
        }

        public override void SetAllDirty()
        {
        }

        public override void SetVerticesDirty()
        {
        }

        public override void SetLayoutDirty()
        {
        }

        public override void SetMaterialDirty()
        {
        }

        public void SetPivotDirty()
        {
        }

        private global::UnityEngine.Transform GetRootCanvasTransform()
        {
            return null;
        }

        public override void Cull(global::UnityEngine.Rect clipRect, bool validRect)
        {
        }

        protected override void UpdateGeometry()
        {
        }

        public override void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
        }

        public void RefreshMaterial()
        {
        }

        protected override void UpdateMaterial()
        {
        }

        public override void RecalculateClipping()
        {
        }

        private global::UnityEngine.Material GetMaterial()
        {
            return null;
        }

        private global::UnityEngine.Material GetMaterial(global::UnityEngine.Material mat)
        {
            return null;
        }

        private global::UnityEngine.Material CreateMaterialInstance(global::UnityEngine.Material source)
        {
            return null;
        }

        private global::UnityEngine.Material GetSharedMaterial()
        {
            return null;
        }

        private void SetSharedMaterial(global::UnityEngine.Material mat)
        {
        }
    }
}