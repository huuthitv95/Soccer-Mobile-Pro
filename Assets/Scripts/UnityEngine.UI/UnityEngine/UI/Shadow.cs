namespace UnityEngine.UI
{
    public class Shadow : global::UnityEngine.UI.BaseMeshEffect
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_EffectColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_EffectDistance;
        [global::UnityEngine.SerializeField]
        private bool m_UseGraphicAlpha;
        private const float kMaxEffectDistance = 600f;
        public global::UnityEngine.Color effectColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 effectDistance
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool useGraphicAlpha
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        protected Shadow()
        {
        }

        protected void ApplyShadowZeroAlloc(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts, global::UnityEngine.Color32 color, int start, int end, float x, float y)
        {
        }

        protected void ApplyShadow(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts, global::UnityEngine.Color32 color, int start, int end, float x, float y)
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }
    }
}