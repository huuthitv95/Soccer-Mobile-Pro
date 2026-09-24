namespace UnityEngine.UI.Extensions
{
    public class UIPrimitiveBase : global::UnityEngine.UI.MaskableGraphic, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.ICanvasRaycastFilter
    {
        protected static global::UnityEngine.Material s_ETC1DefaultUI;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Sprite m_Sprite;
        [global::System.NonSerialized]
        private global::UnityEngine.Sprite m_OverrideSprite;
        internal float m_EventAlphaThreshold;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ResolutionMode m_improveResolution;
        [global::UnityEngine.SerializeField]
        protected float m_Resolution;
        [global::UnityEngine.SerializeField]
        private bool m_useNativeSize;
        public global::UnityEngine.Sprite sprite
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Sprite overrideSprite
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected global::UnityEngine.Sprite activeSprite => null;

        public float eventAlphaThreshold
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.ResolutionMode ImproveResolution
        {
            get
            {
                return global::UnityEngine.UI.Extensions.ResolutionMode.None;
            }

            set
            {
            }
        }

        public float Resoloution
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool UseNativeSize
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::UnityEngine.Material defaultETC1GraphicMaterial => null;
        public override global::UnityEngine.Texture mainTexture => null;
        public bool hasBorder => false;
        public float pixelsPerUnit => 0f;

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

        public virtual float minWidth => 0f;
        public virtual float preferredWidth => 0f;
        public virtual float flexibleWidth => 0f;
        public virtual float minHeight => 0f;
        public virtual float preferredHeight => 0f;
        public virtual float flexibleHeight => 0f;
        public virtual int layoutPriority => 0;

        protected UIPrimitiveBase()
        {
        }

        protected global::UnityEngine.UIVertex[] SetVbo(global::UnityEngine.Vector2[] vertices, global::UnityEngine.Vector2[] uvs)
        {
            return null;
        }

        protected global::UnityEngine.Vector2[] IncreaseResolution(global::UnityEngine.Vector2[] input)
        {
            return null;
        }

        protected virtual void GeneratedUVs()
        {
        }

        protected virtual void ResolutionToNativeSize(float distance)
        {
        }

        public virtual void CalculateLayoutInputHorizontal()
        {
        }

        public virtual void CalculateLayoutInputVertical()
        {
        }

        public virtual bool IsRaycastLocationValid(global::UnityEngine.Vector2 screenPoint, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        private global::UnityEngine.Vector2 MapCoordinate(global::UnityEngine.Vector2 local, global::UnityEngine.Rect rect)
        {
            return default;
        }

        private global::UnityEngine.Vector4 GetAdjustedBorders(global::UnityEngine.Vector4 border, global::UnityEngine.Rect rect)
        {
            return default;
        }

        protected override void OnEnable()
        {
        }
    }
}