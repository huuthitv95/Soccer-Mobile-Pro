namespace UnityEngine.EventSystems
{
    public class PhysicsRaycaster : global::UnityEngine.EventSystems.BaseRaycaster
    {
        private class RaycastHitComparer : global::System.Collections.Generic.IComparer<global::UnityEngine.RaycastHit>
        {
            public static global::UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;
            public int Compare(global::UnityEngine.RaycastHit x, global::UnityEngine.RaycastHit y)
            {
                return 0;
            }
        }

        protected const int kNoEventMaskSet = -1;
        protected global::UnityEngine.Camera m_EventCamera;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.LayerMask m_EventMask;
        [global::UnityEngine.SerializeField]
        protected int m_MaxRayIntersections;
        protected int m_LastMaxRayIntersections;
        private global::UnityEngine.RaycastHit[] m_Hits;
        public override global::UnityEngine.Camera eventCamera => null;
        public virtual int depth => 0;
        public int finalEventMask => 0;

        public global::UnityEngine.LayerMask eventMask
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public int maxRayIntersections
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        protected PhysicsRaycaster()
        {
        }

        protected bool ComputeRayAndDistance(global::UnityEngine.EventSystems.PointerEventData eventData, ref global::UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
        {
            return false;
        }

        public override void Raycast(global::UnityEngine.EventSystems.PointerEventData eventData, global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> resultAppendList)
        {
        }
    }
}