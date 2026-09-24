namespace Coffee.UIEffects
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIFlip : global::Coffee.UIEffects.BaseMeshEffect
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

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.UI.Graphic graphic)
        {
        }
    }
}