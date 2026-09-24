namespace UnityEngine.UI.Extensions
{
    public class UIWindowBase : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
    {
        private global::UnityEngine.RectTransform m_transform;
        private bool _isDragging;
        public static bool ResetCoords;
        private global::UnityEngine.Vector3 m_originalCoods;
        private global::UnityEngine.Canvas m_canvas;
        private global::UnityEngine.RectTransform m_canvasRectTransform;
        public int KeepWindowInCanvas;
        private void Start()
        {
        }

        private void Update()
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void resetCoordinatePosition()
        {
        }

        private global::UnityEngine.Vector3 ScreenToCanvas(global::UnityEngine.Vector3 screenPosition)
        {
            return default;
        }
    }
}