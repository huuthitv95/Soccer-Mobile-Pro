namespace UnityEngine.UI
{
    public class GraphicRaycaster : global::UnityEngine.EventSystems.BaseRaycaster
    {
        public enum BlockingObjects
        {
            None = 0,
            TwoD = 1,
            ThreeD = 2,
            All = 3
        }

        protected const int kNoEventMaskSet = -1;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreReversedGraphics;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.LayerMask m_BlockingMask;
        private global::UnityEngine.Canvas m_Canvas;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.List<global::UnityEngine.UI.Graphic> m_RaycastResults;
        [global::System.NonSerialized]
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Graphic> s_SortedGraphics;
        public override int sortOrderPriority => 0;
        public override int renderOrderPriority => 0;

        public bool ignoreReversedGraphics
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.GraphicRaycaster.BlockingObjects blockingObjects
        {
            get
            {
                return global::UnityEngine.UI.GraphicRaycaster.BlockingObjects.None;
            }

            set
            {
            }
        }

        public global::UnityEngine.LayerMask blockingMask
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        private global::UnityEngine.Canvas canvas => null;
        public override global::UnityEngine.Camera eventCamera => null;

        protected GraphicRaycaster()
        {
        }

        public override void Raycast(global::UnityEngine.EventSystems.PointerEventData eventData, global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> resultAppendList)
        {
        }

        private static void Raycast(global::UnityEngine.Canvas canvas, global::UnityEngine.Camera eventCamera, global::UnityEngine.Vector2 pointerPosition, global::System.Collections.Generic.IList<global::UnityEngine.UI.Graphic> foundGraphics, global::System.Collections.Generic.List<global::UnityEngine.UI.Graphic> results)
        {
        }
    }
}