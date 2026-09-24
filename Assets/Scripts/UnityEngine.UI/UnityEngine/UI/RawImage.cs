namespace UnityEngine.UI
{
    public class RawImage : global::UnityEngine.UI.MaskableGraphic
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Texture m_Texture;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Rect m_UVRect;
        public override global::UnityEngine.Texture mainTexture => null;

        public global::UnityEngine.Texture texture
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Rect uvRect
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        protected RawImage()
        {
        }

        public override void SetNativeSize()
        {
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }
    }
}