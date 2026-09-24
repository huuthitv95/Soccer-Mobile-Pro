namespace UnityEngine.UI.Extensions
{
    public class RescalePanel : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        public global::UnityEngine.Vector2 minSize;
        public global::UnityEngine.Vector2 maxSize;
        private global::UnityEngine.RectTransform rectTransform;
        private global::UnityEngine.Transform goTransform;
        private global::UnityEngine.Vector2 currentPointerPosition;
        private global::UnityEngine.Vector2 previousPointerPosition;
        private global::UnityEngine.RectTransform thisRectTransform;
        private global::UnityEngine.Vector2 sizeDelta;
        private void Awake()
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData data)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData data)
        {
        }
    }
}