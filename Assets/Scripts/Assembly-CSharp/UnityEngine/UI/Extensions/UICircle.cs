namespace UnityEngine.UI.Extensions
{
    public class UICircle : global::UnityEngine.UI.Extensions.UIPrimitiveBase
    {
        [global::UnityEngine.SerializeField]
        private int m_fillPercent;
        public bool FixedToSegments;
        [global::UnityEngine.SerializeField]
        private bool m_fill;
        [global::UnityEngine.SerializeField]
        private float m_thickness;
        [global::UnityEngine.SerializeField]
        private int m_segments;
        public int FillPercent
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public bool Fill
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float Thickness
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int Segments
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        private void Update()
        {
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private void StepThroughPointsAndFill(float outer, float inner, ref global::UnityEngine.Vector2 prevX, ref global::UnityEngine.Vector2 prevY, out global::UnityEngine.Vector2 pos0, out global::UnityEngine.Vector2 pos1, out global::UnityEngine.Vector2 pos2, out global::UnityEngine.Vector2 pos3, float c, float s)
        {
            pos0 = default;
            pos1 = default;
            pos2 = default;
            pos3 = default;
        }
    }
}