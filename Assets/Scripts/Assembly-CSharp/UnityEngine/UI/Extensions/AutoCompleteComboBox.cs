namespace UnityEngine.UI.Extensions
{
    public class AutoCompleteComboBox : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class SelectionChangedEvent : global::UnityEngine.Events.UnityEvent<string, bool>
        {
        }

        [global::System.Serializable]
        public class SelectionTextChangedEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        [global::System.Serializable]
        public class SelectionValidityChangedEvent : global::UnityEngine.Events.UnityEvent<bool>
        {
        }

        public global::UnityEngine.Color disabledTextColor;
        public global::System.Collections.Generic.List<string> AvailableOptions;
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
        private global::System.Collections.Generic.List<string> _prunedPanelItems;
        private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.GameObject> panelObjects;
        private global::UnityEngine.GameObject itemTemplate;
        [global::UnityEngine.SerializeField]
        private float _scrollBarWidth;
        [global::UnityEngine.SerializeField]
        private int _itemsToDisplay;
        public bool SelectFirstItemOnStart;
        [global::UnityEngine.SerializeField]
        private bool _ChangeInputTextColorBasedOnMatchingItems;
        public global::UnityEngine.Color ValidSelectionTextColor;
        public global::UnityEngine.Color MatchingItemsRemainingTextColor;
        public global::UnityEngine.Color NoItemsRemainingTextColor;
        public global::UnityEngine.UI.Extensions.AutoCompleteSearchType autocompleteSearchType;
        private bool _selectionIsValid;
        public global::UnityEngine.UI.Extensions.AutoCompleteComboBox.SelectionTextChangedEvent OnSelectionTextChanged;
        public global::UnityEngine.UI.Extensions.AutoCompleteComboBox.SelectionValidityChangedEvent OnSelectionValidityChanged;
        public global::UnityEngine.UI.Extensions.AutoCompleteComboBox.SelectionChangedEvent OnSelectionChanged;
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

        public bool InputColorMatching
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public void Awake()
        {
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

        private void OnItemClicked(string item)
        {
        }

        private void RedrawPanel()
        {
        }

        public void OnValueChanged(string currText)
        {
        }

        private void SetInputTextColor()
        {
        }

        public void ToggleDropdownPanel(bool directClick)
        {
        }

        private void PruneItems(string currText)
        {
        }

        private void PruneItemsLinq(string currText)
        {
        }

        private void PruneItemsArray(string currText)
        {
        }
    }
}