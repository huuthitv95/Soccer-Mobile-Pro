namespace UnityEngine.UI.Extensions
{
    public class RescaleDragPanel : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        private global::UnityEngine.Vector2 pointerOffset;
        private global::UnityEngine.RectTransform canvasRectTransform;
        private global::UnityEngine.RectTransform panelRectTransform;
        private global::UnityEngine.Transform goTransform;
        private void Awake()
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData data)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData data)
        {
        }

        private global::UnityEngine.Vector2 ClampToWindow(global::UnityEngine.EventSystems.PointerEventData data)
        {
            return default;
        }
    }
}