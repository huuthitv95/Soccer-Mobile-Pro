namespace UnityEngine.UI
{
    public class Toggle : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.UI.ICanvasElement
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

        public global::UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
        public global::UnityEngine.UI.Graphic graphic;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.ToggleGroup m_Group;
        public global::UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
        [global::UnityEngine.SerializeField]
        private bool m_IsOn;
        public global::UnityEngine.UI.ToggleGroup group
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isOn
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

        protected Toggle()
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

        protected override void OnDestroy()
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

        private void SetToggleGroup(global::UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue)
        {
        }

        public void SetIsOnWithoutNotify(bool value)
        {
        }

        private void Set(bool value, bool sendCallback = true)
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