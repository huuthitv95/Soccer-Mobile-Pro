namespace UnityEngine.InputSystem.UI
{
    public class TrackedDeviceRaycaster : global::UnityEngine.EventSystems.BaseRaycaster
    {
        private struct RaycastHitData
        {
            public global::UnityEngine.UI.Graphic graphic { get; }
            public global::UnityEngine.Vector3 worldHitPosition { get; }
            public global::UnityEngine.Vector2 screenPosition { get; }
            public float distance { get; }

            public RaycastHitData(global::UnityEngine.UI.Graphic graphic, global::UnityEngine.Vector3 worldHitPosition, global::UnityEngine.Vector2 screenPosition, float distance)
            {
                this.graphic = null;
                this.worldHitPosition = default;
                this.screenPosition = default;
                this.distance = 0f;
            }
        }

        [global::System.NonSerialized]
        private global::System.Collections.Generic.List<global::UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> m_RaycastResultsCache;
        internal static global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> s_Instances;
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> s_SortedGraphics;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreReversedGraphics;
        [global::UnityEngine.SerializeField]
        private bool m_CheckFor2DOcclusion;
        [global::UnityEngine.SerializeField]
        private bool m_CheckFor3DOcclusion;
        [global::UnityEngine.SerializeField]
        private float m_MaxDistance;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.LayerMask m_BlockingMask;
        [global::System.NonSerialized]
        private global::UnityEngine.Canvas m_Canvas;
        public override global::UnityEngine.Camera eventCamera => null;

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

        public bool checkFor3DOcclusion
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool checkFor2DOcclusion
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

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

        public float maxDistance
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        private global::UnityEngine.Canvas canvas => null;

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public override void Raycast(global::UnityEngine.EventSystems.PointerEventData eventData, global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> resultAppendList)
        {
        }

        internal void PerformRaycast(global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> resultAppendList)
        {
        }

        private void SortedRaycastGraphics(global::UnityEngine.Canvas canvas, global::UnityEngine.Ray ray, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results)
        {
        }

        private static bool RayIntersectsRectTransform(global::UnityEngine.RectTransform transform, global::UnityEngine.Ray ray, out global::UnityEngine.Vector3 worldPosition, out float distance)
        {
            worldPosition = default;
            distance = default;
            return false;
        }
    }
}