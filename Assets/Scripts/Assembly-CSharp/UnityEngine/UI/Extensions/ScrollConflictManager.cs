namespace UnityEngine.UI.Extensions
{
    public class ScrollConflictManager : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        public global::UnityEngine.UI.ScrollRect ParentScrollRect;
        private global::UnityEngine.UI.ScrollRect _myScrollRect;
        private bool scrollOther;
        private bool scrollOtherHorizontally;
        private void Awake()
        {
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}