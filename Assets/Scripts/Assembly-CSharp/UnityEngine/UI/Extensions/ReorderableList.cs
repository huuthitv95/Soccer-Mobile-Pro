namespace UnityEngine.UI.Extensions
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class ReorderableList : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public struct ReorderableListEventStruct
        {
            public global::UnityEngine.GameObject DroppedObject;
            public int FromIndex;
            public global::UnityEngine.UI.Extensions.ReorderableList FromList;
            public bool IsAClone;
            public global::UnityEngine.GameObject SourceObject;
            public int ToIndex;
            public global::UnityEngine.UI.Extensions.ReorderableList ToList;
            public void Cancel()
            {
            }
        }

        [global::System.Serializable]
        public class ReorderableListHandler : global::UnityEngine.Events.UnityEvent<global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListEventStruct>
        {
        }

        public global::UnityEngine.UI.LayoutGroup ContentLayout;
        public global::UnityEngine.RectTransform DraggableArea;
        public bool IsDraggable;
        public bool CloneDraggedObject;
        public bool IsDropable;
        public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementDropped;
        public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementGrabbed;
        public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementRemoved;
        public global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementAdded;
        private global::UnityEngine.RectTransform _content;
        private global::UnityEngine.UI.Extensions.ReorderableListContent _listContent;
        public global::UnityEngine.RectTransform Content => null;

        private global::UnityEngine.Canvas GetCanvas()
        {
            return null;
        }

        private void Awake()
        {
        }

        public void TestReOrderableListTarget(global::UnityEngine.UI.Extensions.ReorderableList.ReorderableListEventStruct item)
        {
        }
    }
}