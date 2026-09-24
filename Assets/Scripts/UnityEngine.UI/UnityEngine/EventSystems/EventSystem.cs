namespace UnityEngine.EventSystems
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class EventSystem : global::UnityEngine.EventSystems.UIBehaviour
    {
        private global::System.Collections.Generic.List<global::UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;
        private global::UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;
        private static global::System.Collections.Generic.List<global::UnityEngine.EventSystems.EventSystem> m_EventSystems;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject m_FirstSelected;
        [global::UnityEngine.SerializeField]
        private bool m_sendNavigationEvents;
        [global::UnityEngine.SerializeField]
        private int m_DragThreshold;
        private global::UnityEngine.GameObject m_CurrentSelected;
        private bool m_HasFocus;
        private bool m_SelectionGuard;
        private global::UnityEngine.EventSystems.BaseEventData m_DummyData;
        private static readonly global::System.Comparison<global::UnityEngine.EventSystems.RaycastResult> s_RaycastComparer;
        public static global::UnityEngine.EventSystems.EventSystem current
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool sendNavigationEvents
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int pixelDragThreshold
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.EventSystems.BaseInputModule currentInputModule => null;

        public global::UnityEngine.GameObject firstSelectedGameObject
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.GameObject currentSelectedGameObject => null;

        [global::System.Obsolete]
        public global::UnityEngine.GameObject lastSelectedGameObject => null;
        public bool isFocused => false;
        public bool alreadySelecting => false;
        private global::UnityEngine.EventSystems.BaseEventData baseEventDataCache => null;

        protected EventSystem()
        {
        }

        public void UpdateModules()
        {
        }

        public void SetSelectedGameObject(global::UnityEngine.GameObject selected, global::UnityEngine.EventSystems.BaseEventData pointer)
        {
        }

        public void SetSelectedGameObject(global::UnityEngine.GameObject selected)
        {
        }

        private static int RaycastComparer(global::UnityEngine.EventSystems.RaycastResult lhs, global::UnityEngine.EventSystems.RaycastResult rhs)
        {
            return 0;
        }

        public void RaycastAll(global::UnityEngine.EventSystems.PointerEventData eventData, global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> raycastResults)
        {
        }

        public bool IsPointerOverGameObject()
        {
            return false;
        }

        public bool IsPointerOverGameObject(int pointerId)
        {
            return false;
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void TickModules()
        {
        }

        protected virtual void OnApplicationFocus(bool hasFocus)
        {
        }

        protected virtual void Update()
        {
        }

        private void ChangeEventModule(global::UnityEngine.EventSystems.BaseInputModule module)
        {
        }

        public override string ToString()
        {
            return null;
        }
    }
}