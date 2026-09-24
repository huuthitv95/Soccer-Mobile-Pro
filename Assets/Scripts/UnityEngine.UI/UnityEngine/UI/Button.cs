namespace UnityEngine.UI
{
    public class Button : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler
    {
        [global::System.Serializable]
        public class ButtonClickedEvent : global::UnityEngine.Events.UnityEvent
        {
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;
        public global::UnityEngine.UI.Button.ButtonClickedEvent onClick
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected Button()
        {
        }

        private void Press()
        {
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private global::System.Collections.IEnumerator OnFinishSubmit()
        {
            return null;
        }
    }
}