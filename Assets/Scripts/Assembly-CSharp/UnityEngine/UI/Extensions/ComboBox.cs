namespace UnityEngine.UI.Extensions
{
    public class ComboBox : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class SelectionChangedEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        public global::UnityEngine.Color disabledTextColor;
        public global::System.Collections.Generic.List<string> AvailableOptions;
        [global::UnityEngine.SerializeField]
        private float _scrollBarWidth;
        [global::UnityEngine.SerializeField]
        private int _itemsToDisplay;
        public global::UnityEngine.UI.Extensions.ComboBox.SelectionChangedEvent OnSelectionChanged;
        private bool _isPanelActive;
        private bool _hasDrawnOnce;
        private global::UnityEngine.UI.InputField _mainInput;
        private global::UnityEngine.RectTransform _inputRT;
        private global::UnityEngine.RectTransform _rectTransform;
        private global::UnityEngine.RectTransform _overlayRT;
        private global::UnityEngine.RectTransform _scrollPanelRT;
        private global::UnityEngine.RectTransform _scrollBarRT;
        private global::UnityEngine.RectTransform _slidingAreaRT;
        private global::UnityEngine.RectTransform _itemsPanelRT;
        private global::UnityEngine.Canvas _canvas;
        private global::UnityEngine.RectTransform _canvasRT;
        private global::UnityEngine.UI.ScrollRect _scrollRect;
        private global::System.Collections.Generic.List<string> _panelItems;
        private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.GameObject> panelObjects;
        private global::UnityEngine.GameObject itemTemplate;
        public global::UnityEngine.UI.Extensions.DropDownListItem SelectedItem { get; private set; }
        public string Text { get; private set; }

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

        public void Awake()
        {
        }

        private bool Initialize()
        {
            return false;
        }

        private void RebuildPanel()
        {
        }

        private void OnItemClicked(string item)
        {
        }

        private void RedrawPanel()
        {
        }

        public void OnValueChanged(string currText)
        {
        }

        public void ToggleDropdownPanel(bool directClick)
        {
        }
    }
}