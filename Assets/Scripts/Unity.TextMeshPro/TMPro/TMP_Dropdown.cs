namespace TMPro
{
    public class TMP_Dropdown : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.EventSystems.ICancelHandler
    {
        protected internal class DropdownItem : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ICancelHandler
        {
            [global::UnityEngine.SerializeField]
            private global::TMPro.TMP_Text m_Text;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.UI.Image m_Image;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.RectTransform m_RectTransform;
            [global::UnityEngine.SerializeField]
            private global::UnityEngine.UI.Toggle m_Toggle;
            public global::TMPro.TMP_Text text
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
            private global::System.Collections.Generic.List<global::TMPro.TMP_Dropdown.OptionData> m_Options;
            public global::System.Collections.Generic.List<global::TMPro.TMP_Dropdown.OptionData> options
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
        private global::TMPro.TMP_Text m_CaptionText;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image m_CaptionImage;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic m_Placeholder;
        [global::UnityEngine.Space]
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_Text m_ItemText;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image m_ItemImage;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.Space]
        private int m_Value;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.Space]
        private global::TMPro.TMP_Dropdown.OptionDataList m_Options;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.Space]
        private global::TMPro.TMP_Dropdown.DropdownEvent m_OnValueChanged;
        [global::UnityEngine.SerializeField]
        private float m_AlphaFadeSpeed;
        private global::UnityEngine.GameObject m_Dropdown;
        private global::UnityEngine.GameObject m_Blocker;
        private global::System.Collections.Generic.List<global::TMPro.TMP_Dropdown.DropdownItem> m_Items;
        private global::TMPro.TweenRunner<global::TMPro.FloatTween> m_AlphaTweenRunner;
        private bool validTemplate;
        private global::UnityEngine.Coroutine m_Coroutine;
        private static global::TMPro.TMP_Dropdown.OptionData s_NoOptionData;
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

        public global::TMPro.TMP_Text captionText
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

        public global::UnityEngine.UI.Graphic placeholder
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_Text itemText
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

        public global::System.Collections.Generic.List<global::TMPro.TMP_Dropdown.OptionData> options
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_Dropdown.DropdownEvent onValueChanged
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

        public bool IsExpanded => false;

        public void SetValueWithoutNotify(int input)
        {
        }

        private void SetValue(int value, bool sendCallback = true)
        {
        }

        protected TMP_Dropdown()
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

        public void AddOptions(global::System.Collections.Generic.List<global::TMPro.TMP_Dropdown.OptionData> options)
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

        private void SetupTemplate()
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

        protected virtual global::TMPro.TMP_Dropdown.DropdownItem CreateItem(global::TMPro.TMP_Dropdown.DropdownItem itemTemplate)
        {
            return null;
        }

        protected virtual void DestroyItem(global::TMPro.TMP_Dropdown.DropdownItem item)
        {
        }

        private global::TMPro.TMP_Dropdown.DropdownItem AddItem(global::TMPro.TMP_Dropdown.OptionData data, bool selected, global::TMPro.TMP_Dropdown.DropdownItem itemTemplate, global::System.Collections.Generic.List<global::TMPro.TMP_Dropdown.DropdownItem> items)
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