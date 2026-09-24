namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class RectMask2D : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.IClipper, global::UnityEngine.ICanvasRaycastFilter
    {
        [global::System.NonSerialized]
        private readonly global::UnityEngine.UI.RectangularVertexClipper m_VertexClipper;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_RectTransform;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.HashSet<global::UnityEngine.UI.MaskableGraphic> m_MaskableTargets;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.HashSet<global::UnityEngine.UI.IClippable> m_ClipTargets;
        [global::System.NonSerialized]
        private bool m_ShouldRecalculateClipRects;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.List<global::UnityEngine.UI.RectMask2D> m_Clippers;
        [global::System.NonSerialized]
        private global::UnityEngine.Rect m_LastClipRectCanvasSpace;
        [global::System.NonSerialized]
        private bool m_ForceClip;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector4 m_Padding;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2Int m_Softness;
        [global::System.NonSerialized]
        private global::UnityEngine.Canvas m_Canvas;
        private global::UnityEngine.Vector3[] m_Corners;
        public global::UnityEngine.Vector4 padding
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2Int softness
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        internal global::UnityEngine.Canvas Canvas => null;
        public global::UnityEngine.Rect canvasRect => default;
        public global::UnityEngine.RectTransform rectTransform => null;
        private global::UnityEngine.Rect rootCanvasRect => default;

        protected RectMask2D()
        {
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

        public virtual bool IsRaycastLocationValid(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        public virtual void PerformClipping()
        {
        }

        public virtual void UpdateClipSoftness()
        {
        }

        public void AddClippable(global::UnityEngine.UI.IClippable clippable)
        {
        }

        public void RemoveClippable(global::UnityEngine.UI.IClippable clippable)
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }
    }
}