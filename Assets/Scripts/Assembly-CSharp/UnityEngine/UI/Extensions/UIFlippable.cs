namespace UnityEngine.UI.Extensions
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIFlippable : global::UnityEngine.UI.BaseMeshEffect
    {
        [global::UnityEngine.SerializeField]
        private bool m_Horizontal;
        [global::UnityEngine.SerializeField]
        private bool m_Veritical;
        public bool horizontal
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool vertical
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper verts)
        {
        }
    }
}