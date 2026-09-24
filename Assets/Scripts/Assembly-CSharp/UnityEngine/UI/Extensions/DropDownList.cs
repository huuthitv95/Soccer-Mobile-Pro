namespace UnityEngine.UI.Extensions
{
    public class DropDownList : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class SelectionChangedEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        public global::UnityEngine.Color disabledTextColor;
        public global::System.Collections.Generic.List<global::UnityEngine.UI.Extensions.DropDownListItem> Items;
        public bool OverrideHighlighted;
        private bool _isPanelActive;
        private bool _hasDrawnOnce;
        private global::UnityEngine.UI.Extensions.DropDownListButton _mainButton;
        private global::UnityEngine.RectTransform _rectTransform;
        private global::UnityEngine.RectTransform _overlayRT;
        private global::UnityEngine.RectTransform _scrollPanelRT;
        private global::UnityEngine.RectTransform _scrollBarRT;
        private global::UnityEngine.RectTransform _slidingAreaRT;
        private global::UnityEngine.RectTransform _itemsPanelRT;
        private global::UnityEngine.Canvas _canvas;
        private global::UnityEngine.RectTransform _canvasRT;
        private global::UnityEngine.UI.ScrollRect _scrollRect;
        private global::System.Collections.Generic.List<global::UnityEngine.UI.Extensions.DropDownListButton> _panelItems;
        private global::UnityEngine.GameObject _itemTemplate;
        [global::UnityEngine.SerializeField]
        private float _scrollBarWidth;
        private int _selectedIndex;
        [global::UnityEngine.SerializeField]
        private int _itemsToDisplay;
        public bool SelectFirstItemOnStart;
        public global::UnityEngine.UI.Extensions.DropDownList.SelectionChangedEvent OnSelectionChanged;
        public global::UnityEngine.UI.Extensions.DropDownListItem SelectedItem { get; private set; }

        public float ScrollBarWidth
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int ItemsToDisplay
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public void Start()
        {
        }

        private bool Initialize()
        {
            return false;
        }

        private void RebuildPanel()
        {
        }

        private void OnItemClicked(int indx)
        {
        }

        private void UpdateSelected()
        {
        }

        private void RedrawPanel()
        {
        }

        public void ToggleDropdownPanel(bool directClick)
        {
        }
    }
}