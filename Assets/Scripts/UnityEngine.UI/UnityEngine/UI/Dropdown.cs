namespace UnityEngine.UI
{
    public class Dropdown : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.EventSystems.ICancelHandler
    {
        protected internal class DropdownItem : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ICancelHandler
        {
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.UI.Text m_Text;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.UI.Image m_Image;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.RectTransform m_RectTransform;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.UI.Toggle m_Toggle;
            public global::UnityEngine.UI.Text text
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public global::UnityEngine.UI.Image image
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public global::UnityEngine.RectTransform rectTransform
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public global::UnityEngine.UI.Toggle toggle
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public virtual void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
            {
            }

            public virtual void OnCancel(global::UnityEngine.EventSystems.BaseEventData eventData)
            {
            }
        }

        [global::System.Serializable]
        public class OptionData
        {
            [global::UnityEngine.SerializeField]
            private string m_Text;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.Sprite m_Image;
            public string text
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public global::UnityEngine.Sprite image
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public OptionData()
            {
            }

            public OptionData(string text)
            {
            }

            public OptionData(global::UnityEngine.Sprite image)
            {
            }

            public OptionData(string text, global::UnityEngine.Sprite image)
            {
            }
        }

        [global::System.Serializable]
        public class OptionDataList
        {
            [global::UnityEngine.SerializeField]
            private global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.OptionData> m_Options;
            public global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.OptionData> options
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }
        }

        [global::System.Serializable]
        public class DropdownEvent : global::UnityEngine.Events.UnityEvent<int>
        {
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform m_Template;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text m_CaptionText;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image m_CaptionImage;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text m_ItemText;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image m_ItemImage;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.Space]
        private int m_Value;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Dropdown.OptionDataList m_Options;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.Space]
        private global::UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged;
        [global::UnityEngine.SerializeField]
        private float m_AlphaFadeSpeed;
        private global::UnityEngine.GameObject m_Dropdown;
        private global::UnityEngine.GameObject m_Blocker;
        private global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.DropdownItem> m_Items;
        private global::UnityEngine.UI.CoroutineTween.TweenRunner<global::UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner;
        private bool validTemplate;
        private const int kHighSortingLayer = 30000;
        private static global::UnityEngine.UI.Dropdown.OptionData s_NoOptionData;
        public global::UnityEngine.RectTransform template
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Text captionText
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Image captionImage
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Text itemText
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Image itemImage
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.OptionData> options
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Dropdown.DropdownEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float alphaFadeSpeed
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int value
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public void SetValueWithoutNotify(int input)
        {
        }

        private void Set(int value, bool sendCallback = true)
        {
        }

        protected Dropdown()
        {
        }

        protected override void Awake()
        {
        }

        protected override void Start()
        {
        }

        protected override void OnDisable()
        {
        }

        public void RefreshShownValue()
        {
        }

        public void AddOptions(global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.OptionData> options)
        {
        }

        public void AddOptions(global::System.Collections.Generic.List<string> options)
        {
        }

        public void AddOptions(global::System.Collections.Generic.List<global::UnityEngine.Sprite> options)
        {
        }

        public void ClearOptions()
        {
        }

        private void SetupTemplate(global::UnityEngine.Canvas rootCanvas)
        {
        }

        private static T GetOrAddComponent<T>(global::UnityEngine.GameObject go)
            where T : global::UnityEngine.Component
        {
            return null;
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnCancel(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public void Show()
        {
        }

        protected virtual global::UnityEngine.GameObject CreateBlocker(global::UnityEngine.Canvas rootCanvas)
        {
            return null;
        }

        protected virtual void DestroyBlocker(global::UnityEngine.GameObject blocker)
        {
        }

        protected virtual global::UnityEngine.GameObject CreateDropdownList(global::UnityEngine.GameObject template)
        {
            return null;
        }

        protected virtual void DestroyDropdownList(global::UnityEngine.GameObject dropdownList)
        {
        }

        protected virtual global::UnityEngine.UI.Dropdown.DropdownItem CreateItem(global::UnityEngine.UI.Dropdown.DropdownItem itemTemplate)
        {
            return null;
        }

        protected virtual void DestroyItem(global::UnityEngine.UI.Dropdown.DropdownItem item)
        {
        }

        private global::UnityEngine.UI.Dropdown.DropdownItem AddItem(global::UnityEngine.UI.Dropdown.OptionData data, bool selected, global::UnityEngine.UI.Dropdown.DropdownItem itemTemplate, global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.DropdownItem> items)
        {
            return null;
        }

        private void AlphaFadeList(float duration, float alpha)
        {
        }

        private void AlphaFadeList(float duration, float start, float end)
        {
        }

        private void SetAlpha(float alpha)
        {
        }

        public void Hide()
        {
        }

        private global::System.Collections.IEnumerator DelayedDestroyDropdownList(float delay)
        {
            return null;
        }

        private void ImmediateDestroyDropdownList()
        {
        }

        private void OnSelectItem(global::UnityEngine.UI.Toggle toggle)
        {
        }
    }
}