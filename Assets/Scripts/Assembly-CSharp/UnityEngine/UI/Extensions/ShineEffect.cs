namespace UnityEngine.UI.Extensions
{
    public class ShineEffect : global::UnityEngine.UI.MaskableGraphic
    {
        [global::UnityEngine.SerializeField]
        private float yoffset;
        [global::UnityEngine.SerializeField]
        private float width;
        public float Yoffset
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float Width
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        public void Triangulate(global::UnityEngine.UI.VertexHelper vh)
        {
        }
    }
}