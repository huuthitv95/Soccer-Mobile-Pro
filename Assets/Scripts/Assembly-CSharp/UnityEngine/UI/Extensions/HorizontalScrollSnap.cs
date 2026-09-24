namespace UnityEngine.UI.Extensions
{
    public class HorizontalScrollSnap : global::UnityEngine.UI.Extensions.ScrollSnapBase, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler
    {
        private void Start()
        {
        }

        private void Update()
        {
        }

        private bool IsRectMovingSlowerThanThreshold(float startingSpeed)
        {
            return false;
        }

        private void DistributePages()
        {
        }

        public void AddChild(global::UnityEngine.GameObject GO)
        {
        }

        public void AddChild(global::UnityEngine.GameObject GO, bool WorldPositionStays)
        {
        }

        public void RemoveChild(int index, out global::UnityEngine.GameObject ChildRemoved)
        {
            ChildRemoved = null;
        }

        public void RemoveChild(int index, bool WorldPositionStays, out global::UnityEngine.GameObject ChildRemoved)
        {
            ChildRemoved = null;
        }

        public void RemoveAllChildren(out global::UnityEngine.GameObject[] ChildrenRemoved)
        {
            ChildrenRemoved = null;
        }

        public void RemoveAllChildren(bool WorldPositionStays, out global::UnityEngine.GameObject[] ChildrenRemoved)
        {
            ChildrenRemoved = null;
        }

        private void SetScrollContainerPosition()
        {
        }

        public void UpdateLayout()
        {
        }

        private void OnRectTransformDimensionsChange()
        {
        }

        private void OnEnable()
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}