namespace UnityEngine.UI.Extensions
{
    public class TileSizeFitter : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ILayoutSelfController, global::UnityEngine.UI.ILayoutController
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_Border;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_TileSize;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_Rect;
        private global::UnityEngine.DrivenRectTransformTracker m_Tracker;
        public global::UnityEngine.Vector2 Border
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 TileSize
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        private global::UnityEngine.RectTransform rectTransform => null;

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void UpdateRect()
        {
        }

        private global::UnityEngine.Vector2 GetParentSize()
        {
            return default;
        }

        public virtual void SetLayoutHorizontal()
        {
        }

        public virtual void SetLayoutVertical()
        {
        }

        protected void SetDirty()
        {
        }
    }
}