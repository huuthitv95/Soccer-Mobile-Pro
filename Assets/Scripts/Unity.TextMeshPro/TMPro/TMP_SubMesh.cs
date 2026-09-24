namespace TMPro
{
    public class TMP_SubMesh : global::UnityEngine.MonoBehaviour
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
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Renderer m_renderer;
        private global::UnityEngine.MeshFilter m_meshFilter;
        private global::UnityEngine.Mesh m_mesh;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TextMeshPro m_TextComponent;
        [global::System.NonSerialized]
        private bool m_isRegisteredForEvents;
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

        public global::UnityEngine.Material material
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

        public global::UnityEngine.Renderer renderer => null;
        public global::UnityEngine.MeshFilter meshFilter => null;

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

        public static global::TMPro.TMP_SubMesh AddSubTextObject(global::TMPro.TextMeshPro textComponent, global::TMPro.MaterialReference materialReference)
        {
            return null;
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        public void DestroySelf()
        {
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

        public float GetPaddingForMaterial()
        {
            return 0f;
        }

        public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
        {
        }

        public void SetVerticesDirty()
        {
        }

        public void SetMaterialDirty()
        {
        }

        protected void UpdateMaterial()
        {
        }
    }
}