namespace UnityEngine.UI.Extensions
{
    public class UICornerCut : global::UnityEngine.UI.Extensions.UIPrimitiveBase
    {
        public global::UnityEngine.Vector2 cornerSize;
        [global::UnityEngine.SerializeField]
        private bool m_cutUL;
        [global::UnityEngine.SerializeField]
        private bool m_cutUR;
        [global::UnityEngine.SerializeField]
        private bool m_cutLL;
        [global::UnityEngine.SerializeField]
        private bool m_cutLR;
        [global::UnityEngine.SerializeField]
        private bool m_makeColumns;
        [global::UnityEngine.SerializeField]
        private bool m_useColorUp;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color32 m_colorUp;
        [global::UnityEngine.SerializeField]
        private bool m_useColorDown;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color32 m_colorDown;
        public bool CutUL
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool CutUR
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool CutLL
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool CutLR
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool MakeColumns
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool UseColorUp
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color32 ColorUp
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool UseColorDown
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color32 ColorDown
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private static void AddSquare(global::UnityEngine.Rect rect, global::UnityEngine.Rect rectUV, global::UnityEngine.Color32 color32, global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private static void AddSquare(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, global::UnityEngine.Vector2 c, global::UnityEngine.Vector2 d, global::UnityEngine.Rect rectUV, global::UnityEngine.Color32 color32, global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private static int AddVert(float x, float y, global::UnityEngine.Rect area, global::UnityEngine.Color32 color32, global::UnityEngine.UI.VertexHelper vh)
        {
            return 0;
        }
    }
}