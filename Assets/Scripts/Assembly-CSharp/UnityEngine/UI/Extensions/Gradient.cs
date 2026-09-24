namespace UnityEngine.UI.Extensions
{
    public class Gradient : global::UnityEngine.UI.BaseMeshEffect
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.GradientMode _gradientMode;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.GradientDir _gradientDir;
        [global::UnityEngine.SerializeField]
        private bool _overwriteAllColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color _vertex1;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color _vertex2;
        private global::UnityEngine.UI.Graphic targetGraphic;
        public global::UnityEngine.UI.Extensions.GradientMode GradientMode
        {
            get
            {
                return global::UnityEngine.UI.Extensions.GradientMode.Global;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Extensions.GradientDir GradientDir
        {
            get
            {
                return global::UnityEngine.UI.Extensions.GradientDir.Vertical;
            }

            set
            {
            }
        }

        public bool OverwriteAllColor
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color Vertex1
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color Vertex2
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        protected override void Awake()
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private bool CompareCarefully(global::UnityEngine.Color col1, global::UnityEngine.Color col2)
        {
            return false;
        }
    }
}