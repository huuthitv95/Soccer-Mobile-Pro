namespace UnityEngine.UI.Extensions
{
    public class ResizePanel : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        public global::UnityEngine.Vector2 minSize;
        public global::UnityEngine.Vector2 maxSize;
        private global::UnityEngine.RectTransform rectTransform;
        private global::UnityEngine.Vector2 currentPointerPosition;
        private global::UnityEngine.Vector2 previousPointerPosition;
        private float ratio;
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