namespace UnityEngine.UI
{
    public class Image : global::UnityEngine.UI.MaskableGraphic, global::UnityEngine.ISerializationCallbackReceiver, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.ICanvasRaycastFilter
    {
        public enum Type
        {
            Simple = 0,
            Sliced = 1,
            Tiled = 2,
            Filled = 3
        }

        public enum FillMethod
        {
            Horizontal = 0,
            Vertical = 1,
            Radial90 = 2,
            Radial180 = 3,
            Radial360 = 4
        }

        public enum OriginHorizontal
        {
            Left = 0,
            Right = 1
        }

        public enum OriginVertical
        {
            Bottom = 0,
            Top = 1
        }

        public enum Origin90
        {
            BottomLeft = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomRight = 3
        }

        public enum Origin180
        {
            Bottom = 0,
            Left = 1,
            Top = 2,
            Right = 3
        }

        public enum Origin360
        {
            Bottom = 0,
            Right = 1,
            Top = 2,
            Left = 3
        }

        protected static global::UnityEngine.Material s_ETC1DefaultUI;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Sprite m_Sprite;
        [global::System.NonSerialized]
        private global::UnityEngine.Sprite m_OverrideSprite;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image.Type m_Type;
        [global::UnityEngine.SerializeField]
        private bool m_PreserveAspect;
        [global::UnityEngine.SerializeField]
        private bool m_FillCenter;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image.FillMethod m_FillMethod;
        [global::UnityEngine.SerializeField]
        private float m_FillAmount;
        [global::UnityEngine.SerializeField]
        private bool m_FillClockwise;
        [global::UnityEngine.SerializeField]
        private int m_FillOrigin;
        private float m_AlphaHitTestMinimumThreshold;
        private bool m_Tracked;
        [global::UnityEngine.SerializeField]
        private bool m_UseSpriteMesh;
        [global::UnityEngine.SerializeField]
        private float m_PixelsPerUnitMultiplier;
        private float m_CachedReferencePixelsPerUnit;
        private static readonly global::UnityEngine.Vector2[] s_VertScratch;
        private static readonly global::UnityEngine.Vector2[] s_UVScratch;
        private static readonly global::UnityEngine.Vector3[] s_Xy;
        private static readonly global::UnityEngine.Vector3[] s_Uv;
        private static global::System.Collections.Generic.List<global::UnityEngine.UI.Image> m_TrackedTexturelessImages;
        private static bool s_Initialized;
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

        private global::UnityEngine.Sprite activeSprite => null;

        public global::UnityEngine.UI.Image.Type type
        {
            get
            {
                return global::UnityEngine.UI.Image.Type.Simple;
            }

            set
            {
            }
        }

        public bool preserveAspect
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool fillCenter
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Image.FillMethod fillMethod
        {
            get
            {
                return global::UnityEngine.UI.Image.FillMethod.Horizontal;
            }

            set
            {
            }
        }

        public float fillAmount
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool fillClockwise
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int fillOrigin
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
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

        public float alphaHitTestMinimumThreshold
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool useSpriteMesh
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

        public float pixelsPerUnitMultiplier
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float pixelsPerUnit => 0f;
        protected float multipliedPixelsPerUnit => 0f;

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

        public void DisableSpriteOptimizations()
        {
        }

        protected Image()
        {
        }

        public virtual void OnBeforeSerialize()
        {
        }

        public virtual void OnAfterDeserialize()
        {
        }

        private void PreserveSpriteAspectRatio(ref global::UnityEngine.Rect rect, global::UnityEngine.Vector2 spriteSize)
        {
        }

        private global::UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
        {
            return default;
        }

        public override void SetNativeSize()
        {
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper toFill)
        {
        }

        private void TrackSprite()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void UpdateMaterial()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        private void GenerateSimpleSprite(global::UnityEngine.UI.VertexHelper vh, bool lPreserveAspect)
        {
        }

        private void GenerateSprite(global::UnityEngine.UI.VertexHelper vh, bool lPreserveAspect)
        {
        }

        private void GenerateSlicedSprite(global::UnityEngine.UI.VertexHelper toFill)
        {
        }

        private void GenerateTiledSprite(global::UnityEngine.UI.VertexHelper toFill)
        {
        }

        private static void AddQuad(global::UnityEngine.UI.VertexHelper vertexHelper, global::UnityEngine.Vector3[] quadPositions, global::UnityEngine.Color32 color, global::UnityEngine.Vector3[] quadUVs)
        {
        }

        private static void AddQuad(global::UnityEngine.UI.VertexHelper vertexHelper, global::UnityEngine.Vector2 posMin, global::UnityEngine.Vector2 posMax, global::UnityEngine.Color32 color, global::UnityEngine.Vector2 uvMin, global::UnityEngine.Vector2 uvMax)
        {
        }

        private global::UnityEngine.Vector4 GetAdjustedBorders(global::UnityEngine.Vector4 border, global::UnityEngine.Rect adjustedRect)
        {
            return default;
        }

        private void GenerateFilledSprite(global::UnityEngine.UI.VertexHelper toFill, bool preserveAspect)
        {
        }

        private static bool RadialCut(global::UnityEngine.Vector3[] xy, global::UnityEngine.Vector3[] uv, float fill, bool invert, int corner)
        {
            return false;
        }

        private static void RadialCut(global::UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner)
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

        private static void RebuildImage(global::UnityEngine.U2D.SpriteAtlas spriteAtlas)
        {
        }

        private static void TrackImage(global::UnityEngine.UI.Image g)
        {
        }

        private static void UnTrackImage(global::UnityEngine.UI.Image g)
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }
    }
}