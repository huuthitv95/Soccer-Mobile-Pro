namespace UnityEngine.EventSystems
{
    public abstract class BaseRaycaster : global::UnityEngine.EventSystems.UIBehaviour
    {
        private global::UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;
        public abstract global::UnityEngine.Camera eventCamera { get; }

        [global::System.Obsolete]
        public virtual int priority => 0;
        public virtual int sortOrderPriority => 0;
        public virtual int renderOrderPriority => 0;
        public global::UnityEngine.EventSystems.BaseRaycaster rootRaycaster => null;

        public abstract void Raycast(global::UnityEngine.EventSystems.PointerEventData eventData, global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> resultAppendList);
        public override string ToString()
        {
            return null;
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }
    }
}