namespace UnityEngine.UI
{
    public class ExtensionsToggle : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.UI.ICanvasElement
    {
        public enum ToggleTransition
        {
            None = 0,
            Fade = 1
        }

        [global::System.Serializable]
        public class ToggleEvent : global::UnityEngine.Events.UnityEvent<bool>
        {
        }

        [global::System.Serializable]
        public class ToggleEventObject : global::UnityEngine.Events.UnityEvent<global::UnityEngine.UI.ExtensionsToggle>
        {
        }

        public string UniqueID;
        public global::UnityEngine.UI.ExtensionsToggle.ToggleTransition toggleTransition;
        public global::UnityEngine.UI.Graphic graphic;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.ExtensionsToggleGroup m_Group;
        public global::UnityEngine.UI.ExtensionsToggle.ToggleEvent onValueChanged;
        public global::UnityEngine.UI.ExtensionsToggle.ToggleEventObject onToggleChanged;
        [global::UnityEngine.SerializeField]
        private bool m_IsOn;
        public global::UnityEngine.UI.ExtensionsToggleGroup Group
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool IsOn
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        protected ExtensionsToggle()
        {
        }

        public virtual void Rebuild(global::UnityEngine.UI.CanvasUpdate executing)
        {
        }

        public virtual void LayoutComplete()
        {
        }

        public virtual void GraphicUpdateComplete()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        private void SetToggleGroup(global::UnityEngine.UI.ExtensionsToggleGroup newGroup, bool setMemberValue)
        {
        }

        private void Set(bool value)
        {
        }

        private void Set(bool value, bool sendCallback)
        {
        }

        private void PlayEffect(bool instant)
        {
        }

        protected override void Start()
        {
        }

        private void InternalToggle()
        {
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }
    }
}