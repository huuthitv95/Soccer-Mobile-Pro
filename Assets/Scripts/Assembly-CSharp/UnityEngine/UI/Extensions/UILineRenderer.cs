namespace UnityEngine.UI.Extensions
{
    public class UILineRenderer : global::UnityEngine.UI.Extensions.UIPrimitiveBase
    {
        private enum SegmentType
        {
            Start = 0,
            Middle = 1,
            End = 2,
            Full = 3
        }

        public enum JoinType
        {
            Bevel = 0,
            Miter = 1
        }

        public enum BezierType
        {
            None = 0,
            Quick = 1,
            Basic = 2,
            Improved = 3,
            Catenary = 4
        }

        private const float MIN_MITER_JOIN = (float)global::System.Math.PI / 12f;
        private const float MIN_BEVEL_NICE_JOIN = (float)global::System.Math.PI / 6f;
        private static global::UnityEngine.Vector2 UV_TOP_LEFT;
        private static global::UnityEngine.Vector2 UV_BOTTOM_LEFT;
        private static global::UnityEngine.Vector2 UV_TOP_CENTER_LEFT;
        private static global::UnityEngine.Vector2 UV_TOP_CENTER_RIGHT;
        private static global::UnityEngine.Vector2 UV_BOTTOM_CENTER_LEFT;
        private static global::UnityEngine.Vector2 UV_BOTTOM_CENTER_RIGHT;
        private static global::UnityEngine.Vector2 UV_TOP_RIGHT;
        private static global::UnityEngine.Vector2 UV_BOTTOM_RIGHT;
        private static global::UnityEngine.Vector2[] startUvs;
        private static global::UnityEngine.Vector2[] middleUvs;
        private static global::UnityEngine.Vector2[] endUvs;
        private static global::UnityEngine.Vector2[] fullUvs;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.Vector2[] m_points;
        [global::UnityEngine.SerializeField]
        internal float lineThickness;
        [global::UnityEngine.SerializeField]
        internal bool relativeSize;
        [global::UnityEngine.SerializeField]
        internal bool lineList;
        [global::UnityEngine.SerializeField]
        internal bool lineCaps;
        [global::UnityEngine.SerializeField]
        internal int bezierSegmentsPerCurve;
        public global::UnityEngine.UI.Extensions.UILineRenderer.JoinType LineJoins;
        public global::UnityEngine.UI.Extensions.UILineRenderer.BezierType BezierMode;
        [global::UnityEngine.HideInInspector]
        public bool drivenExternally;
        public float LineThickness
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool RelativeSize
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool LineList
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool LineCaps
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int BezierSegmentsPerCurve
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2[] Points
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private global::UnityEngine.UIVertex[] CreateLineCap(global::UnityEngine.Vector2 start, global::UnityEngine.Vector2 end, global::UnityEngine.UI.Extensions.UILineRenderer.SegmentType type)
        {
            return null;
        }

        private global::UnityEngine.UIVertex[] CreateLineSegment(global::UnityEngine.Vector2 start, global::UnityEngine.Vector2 end, global::UnityEngine.UI.Extensions.UILineRenderer.SegmentType type)
        {
            return null;
        }

        protected override void GeneratedUVs()
        {
        }

        protected override void ResolutionToNativeSize(float distance)
        {
        }
    }
}