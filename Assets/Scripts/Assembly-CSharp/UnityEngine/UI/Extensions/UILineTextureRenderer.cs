namespace UnityEngine.UI.Extensions
{
    public class UILineTextureRenderer : global::UnityEngine.UI.Extensions.UIPrimitiveBase
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Rect m_UVRect;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2[] m_points;
        public float LineThickness;
        public bool UseMargins;
        public global::UnityEngine.Vector2 Margin;
        public bool relativeSize;
        public global::UnityEngine.Rect uvRect
        {
            get
            {
                return default;
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

        public global::UnityEngine.Vector3 RotatePointAroundPivot(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 pivot, global::UnityEngine.Vector3 angles)
        {
            return default;
        }
    }
}