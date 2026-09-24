namespace UnityEngine.UI.Extensions
{
    public class UIHighlightable : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler
    {
        [global::System.Serializable]
        public class InteractableChangedEvent : global::UnityEngine.Events.UnityEvent<bool>
        {
        }

        private global::UnityEngine.UI.Graphic m_Graphic;
        private bool m_Highlighted;
        private bool m_Pressed;
        [global::UnityEngine.SerializeField]
        private bool m_Interactable;
        [global::UnityEngine.SerializeField]
        private bool m_ClickToHold;
        public global::UnityEngine.Color NormalColor;
        public global::UnityEngine.Color HighlightedColor;
        public global::UnityEngine.Color PressedColor;
        public global::UnityEngine.Color DisabledColor;
        public global::UnityEngine.UI.Extensions.UIHighlightable.InteractableChangedEvent OnInteractableChanged;
        public bool Interactable
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool ClickToHold
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private void Awake()
        {
        }

        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void HighlightInteractable(global::UnityEngine.UI.Graphic graphic)
        {
        }
    }
}