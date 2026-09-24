namespace UnityEngine.UI.Extensions
{
    public class Gradient2 : global::UnityEngine.UI.BaseMeshEffect
    {
        public enum Type
        {
            Horizontal = 0,
            Vertical = 1,
            Radial = 2,
            Diamond = 3
        }

        public enum Blend
        {
            Override = 0,
            Add = 1,
            Multiply = 2
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.Gradient2.Type _gradientType;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.Gradient2.Blend _blendMode;
        [global::UnityEngine.SerializeField]
        private bool _modifyVertices;
        [global::UnityEngine.SerializeField]
        private float _offset;
        [global::UnityEngine.SerializeField]
        private float _zoom;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Gradient _effectGradient;
        [global::UnityEngine.SerializeField]
        private bool _useRotatedBounds;
        private bool _useScreenBounds;
        private global::UnityEngine.Rect _screenBounds;
        private float _screenMinProjection;
        private float _screenMaxProjection;
        public global::UnityEngine.UI.Extensions.Gradient2.Blend BlendMode
        {
            get
            {
                return global::UnityEngine.UI.Extensions.Gradient2.Blend.Override;
            }

            set
            {
            }
        }

        public global::UnityEngine.Gradient EffectGradient
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.Gradient2.Type GradientType
        {
            get
            {
                return global::UnityEngine.UI.Extensions.Gradient2.Type.Horizontal;
            }

            set
            {
            }
        }

        public bool ModifyVertices
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float Offset
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float Zoom
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool UseRotatedBounds
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal void SetScreenBounds(global::UnityEngine.Rect bounds, float minProjection, float maxProjection)
        {
        }

        internal void ClearScreenBounds()
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper helper)
        {
        }

        private global::UnityEngine.Rect GetBounds(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> vertices)
        {
            return default;
        }

        private static bool RectApproximately(global::UnityEngine.Rect left, global::UnityEngine.Rect right)
        {
            return false;
        }

        private void SplitTrianglesAtGradientStops(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> _vertexList, global::UnityEngine.Rect gradientBounds, global::UnityEngine.Rect meshBounds, float zoomOffset, bool includeGradientStops, global::UnityEngine.UI.VertexHelper helper)
        {
        }

        private float[] GetPositions(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> _vertexList, int index)
        {
            return null;
        }

        private global::System.Collections.Generic.List<float> FindStops(float zoomOffset, global::UnityEngine.Rect gradientBounds, global::UnityEngine.Rect meshBounds, bool includeGradientStops)
        {
            return null;
        }

        private global::UnityEngine.UIVertex CreateSplitVertex(global::UnityEngine.UIVertex vertex1, global::UnityEngine.UIVertex vertex2, float stop)
        {
            return default;
        }

        private void GetMinMaxProjection(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> vertices, global::UnityEngine.Vector2 dir, out float min, out float max)
        {
            min = default;
            max = default;
        }

        private float[] GetProjectedPositions(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> vertexList, int index, global::UnityEngine.Vector2 dir)
        {
            return null;
        }

        private global::UnityEngine.UIVertex CreateSplitVertexProjected(global::UnityEngine.UIVertex v1, global::UnityEngine.UIVertex v2, float stop, global::UnityEngine.Vector2 dir)
        {
            return default;
        }

        private global::System.Collections.Generic.List<float> FindStopsProjected(float zoomOffset, float minProj, float size, float meshMinProj, float meshMaxProj, bool includeGradientStops)
        {
            return null;
        }

        private void SplitTrianglesAtGradientStopsProjected(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> vertexList, global::UnityEngine.Vector2 dir, float minProj, float size, float meshMinProj, float meshMaxProj, float zoomOffset, bool includeGradientStops, global::UnityEngine.UI.VertexHelper helper)
        {
        }

        private global::UnityEngine.Color BlendColor(global::UnityEngine.Color colorA, global::UnityEngine.Color colorB)
        {
            return default;
        }
    }
}