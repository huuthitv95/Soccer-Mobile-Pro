namespace UnityEngine.UI.Extensions
{
    public class ReorderableListElement : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
    {
        public bool IsGrabbable;
        public bool IsTransferable;
        public bool isDroppableInSpace;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> _raycastResults;
        private global::UnityEngine.UI.Extensions.ReorderableList _currentReorderableListRaycasted;
        private global::UnityEngine.RectTransform _draggingObject;
        private global::UnityEngine.UI.LayoutElement _draggingObjectLE;
        private global::UnityEngine.Vector2 _draggingObjectOriginalSize;
        private global::UnityEngine.RectTransform _fakeElement;
        private global::UnityEngine.UI.LayoutElement _fakeElementLE;
        private int _fromIndex;
        private bool _isDragging;
        private global::UnityEngine.RectTransform _rect;
        private global::UnityEngine.UI.Extensions.ReorderableList _reorderableList;
        internal bool isValid;
        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void CancelDrag()
        {
        }

        private void RefreshSizes()
        {
        }

        public void Init(global::UnityEngine.UI.Extensions.ReorderableList reorderableList)
        {
        }
    }
}