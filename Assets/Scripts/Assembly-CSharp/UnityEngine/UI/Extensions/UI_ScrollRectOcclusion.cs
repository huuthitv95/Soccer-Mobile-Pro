namespace UnityEngine.UI.Extensions
{
    public class UI_ScrollRectOcclusion : global::UnityEngine.MonoBehaviour
    {
        public bool InitByUser;
        private global::UnityEngine.UI.ScrollRect _scrollRect;
        private global::UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
        private global::UnityEngine.UI.VerticalLayoutGroup _verticalLayoutGroup;
        private global::UnityEngine.UI.HorizontalLayoutGroup _horizontalLayoutGroup;
        private global::UnityEngine.UI.GridLayoutGroup _gridLayoutGroup;
        private bool _isVertical;
        private bool _isHorizontal;
        private float _disableMarginX;
        private float _disableMarginY;
        private bool hasDisabledGridComponents;
        private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> items;
        private void Awake()
        {
        }

        public void Init()
        {
        }

        private void DisableGridComponents()
        {
        }

        public void OnScroll(global::UnityEngine.Vector2 pos)
        {
        }
    }
}