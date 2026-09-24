namespace UnityEngine.UI.Extensions
{
    public class CurvedText : global::UnityEngine.UI.BaseMeshEffect
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationCurve _curveForText;
        [global::UnityEngine.SerializeField]
        private float _curveMultiplier;
        private global::UnityEngine.RectTransform rectTrans;
        public global::UnityEngine.AnimationCurve CurveForText
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float CurveMultiplier
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }
    }
}