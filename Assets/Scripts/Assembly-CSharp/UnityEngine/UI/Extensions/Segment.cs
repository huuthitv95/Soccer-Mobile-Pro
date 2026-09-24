namespace UnityEngine.UI.Extensions
{
    public class Segment : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.ISelectHandler, global::UnityEngine.EventSystems.IDeselectHandler
    {
        internal int index;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color textColor;
        internal bool leftmost => false;
        internal bool rightmost => false;

        public bool selected
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal global::UnityEngine.UI.Extensions.SegmentedControl segmentControl => null;
        internal global::UnityEngine.UI.Selectable button => null;

        protected Segment()
        {
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private void SetSelected(bool value)
        {
        }

        private void Deselect()
        {
        }

        private void MaintainSelection()
        {
        }

        internal void TransitionButton()
        {
        }

        internal void TransitionButton(bool instant)
        {
        }

        private void StartColorTween(global::UnityEngine.Color targetColor, bool instant)
        {
        }

        internal void StoreTextColor()
        {
        }

        private void ChangeTextColor(global::UnityEngine.Color targetColor)
        {
        }

        private void DoSpriteSwap(global::UnityEngine.Sprite newSprite)
        {
        }

        private void TriggerAnimation(string triggername)
        {
        }
    }
}