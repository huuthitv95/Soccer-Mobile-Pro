namespace UnityEngine.UI.Extensions
{
    public class BoundTooltipTrigger : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.ISelectHandler, global::UnityEngine.EventSystems.IDeselectHandler
    {
        [global::UnityEngine.TextArea]
        public string text;
        public bool useMousePosition;
        public global::UnityEngine.Vector3 offset;
        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private void StartHover(global::UnityEngine.Vector3 position)
        {
        }

        private void StopHover()
        {
        }
    }
}