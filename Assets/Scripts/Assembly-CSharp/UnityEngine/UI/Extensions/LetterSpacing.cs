namespace UnityEngine.UI.Extensions
{
    public class LetterSpacing : global::UnityEngine.UI.BaseMeshEffect
    {
        [global::UnityEngine.SerializeField]
        private float m_spacing;
        public float spacing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected LetterSpacing()
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }
    }
}