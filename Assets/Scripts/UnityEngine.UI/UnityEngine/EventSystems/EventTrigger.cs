namespace UnityEngine.EventSystems
{
    public class EventTrigger : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDropHandler, global::UnityEngine.EventSystems.IScrollHandler, global::UnityEngine.EventSystems.IUpdateSelectedHandler, global::UnityEngine.EventSystems.ISelectHandler, global::UnityEngine.EventSystems.IDeselectHandler, global::UnityEngine.EventSystems.IMoveHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.EventSystems.ICancelHandler
    {
        [global::System.Serializable]
        public class TriggerEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.EventSystems.BaseEventData>
        {
        }

        [global::System.Serializable]
        public class Entry
        {
            public global::UnityEngine.EventSystems.EventTriggerType eventID;
            public global::UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;
        }

        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;
        [global::System.Obsolete]
        public global::System.Collections.Generic.List<global::UnityEngine.EventSystems.EventTrigger.Entry> delegates
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Collections.Generic.List<global::UnityEngine.EventSystems.EventTrigger.Entry> triggers
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected EventTrigger()
        {
        }

        private void Execute(global::UnityEngine.EventSystems.EventTriggerType id, global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrop(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnScroll(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnMove(global::UnityEngine.EventSystems.AxisEventData eventData)
        {
        }

        public virtual void OnUpdateSelected(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnInitializePotentialDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnCancel(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }
    }
}