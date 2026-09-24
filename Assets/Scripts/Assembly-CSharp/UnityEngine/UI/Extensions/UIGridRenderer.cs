namespace UnityEngine.UI.Extensions
{
    public class UIGridRenderer : global::UnityEngine.UI.Extensions.UILineRenderer
    {
        [global::UnityEngine.SerializeField]
        private int m_GridColumns;
        [global::UnityEngine.SerializeField]
        private int m_GridRows;
        public int GridColumns
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int GridRows
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }
    }
}