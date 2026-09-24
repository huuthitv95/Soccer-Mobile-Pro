namespace UnityEngine.UI.Extensions
{
    public class MonoSpacing : global::UnityEngine.UI.BaseMeshEffect
    {
        [global::UnityEngine.SerializeField]
        private float m_spacing;
        public float HalfCharWidth;
        public bool UseHalfCharWidth;
        private global::UnityEngine.RectTransform rectTransform;
        private global::UnityEngine.UI.Text text;
        public float Spacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected MonoSpacing()
        {
        }

        protected override void Awake()
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }
    }
}