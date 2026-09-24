namespace UnityEngine.EventSystems
{
    public abstract class BaseInputModule : global::UnityEngine.EventSystems.UIBehaviour
    {
        [global::System.NonSerialized]
        protected global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;
        private global::UnityEngine.EventSystems.AxisEventData m_AxisEventData;
        private global::UnityEngine.EventSystems.EventSystem m_EventSystem;
        private global::UnityEngine.EventSystems.BaseEventData m_BaseEventData;
        protected global::UnityEngine.EventSystems.BaseInput m_InputOverride;
        private global::UnityEngine.EventSystems.BaseInput m_DefaultInput;
        public global::UnityEngine.EventSystems.BaseInput input => null;

        public global::UnityEngine.EventSystems.BaseInput inputOverride
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected global::UnityEngine.EventSystems.EventSystem eventSystem => null;

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public abstract void Process();
        protected static global::UnityEngine.EventSystems.RaycastResult FindFirstRaycast(global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> candidates)
        {
            return default;
        }

        protected static global::UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y)
        {
            return global::UnityEngine.EventSystems.MoveDirection.Left;
        }

        protected static global::UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
        {
            return global::UnityEngine.EventSystems.MoveDirection.Left;
        }

        protected static global::UnityEngine.GameObject FindCommonRoot(global::UnityEngine.GameObject g1, global::UnityEngine.GameObject g2)
        {
            return null;
        }

        protected void HandlePointerExitAndEnter(global::UnityEngine.EventSystems.PointerEventData currentPointerData, global::UnityEngine.GameObject newEnterTarget)
        {
        }

        protected virtual global::UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
        {
            return null;
        }

        protected virtual global::UnityEngine.EventSystems.BaseEventData GetBaseEventData()
        {
            return null;
        }

        public virtual bool IsPointerOverGameObject(int pointerId)
        {
            return false;
        }

        public virtual bool ShouldActivateModule()
        {
            return false;
        }

        public virtual void DeactivateModule()
        {
        }

        public virtual void ActivateModule()
        {
        }

        public virtual void UpdateModule()
        {
        }

        public virtual bool IsModuleSupported()
        {
            return false;
        }
    }
}