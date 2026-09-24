namespace UnityEngine.InputSystem.UI
{
    public class InputSystemUIInputModule : global::UnityEngine.EventSystems.BaseInputModule
    {
        private struct InputActionReferenceState
        {
            public int refCount;
            public bool enabledByInputModule;
        }

        public enum CursorLockBehavior
        {
            OutsideScreen = 0,
            ScreenCenter = 1
        }

        private const float kClickSpeed = 0.3f;
        [global::UnityEngine.SerializeField]
        private float m_MoveRepeatDelay;
        [global::UnityEngine.SerializeField]
        private float m_MoveRepeatRate;
        private float m_TrackedDeviceDragThresholdMultiplier;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Transform m_XRTrackingOrigin;
        private static global::UnityEngine.InputSystem.DefaultInputActions defaultActions;
        internal const float kPixelPerLine = 20f;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionAsset m_ActionsAsset;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_PointAction;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.InputSystem.InputActionReference m_MoveAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_SubmitAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_CancelAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_LeftClickAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_MiddleClickAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_RightClickAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_ScrollWheelAction;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.InputSystem.InputActionReference m_TrackedDevicePositionAction;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionReference m_TrackedDeviceOrientationAction;
        [global::UnityEngine.SerializeField]
        private bool m_DeselectOnBackgroundClick;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.UI.UIPointerBehavior m_PointerBehavior;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        internal global::UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior m_CursorLockBehavior;
        private static global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.InputAction, global::UnityEngine.InputSystem.UI.InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts;
        [global::System.NonSerialized]
        private bool m_ActionsHooked;
        [global::System.NonSerialized]
        private bool m_NeedToPurgeStalePointers;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnPointDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMoveDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnLeftClickDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnRightClickDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMiddleClickDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnScrollWheelDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate;
        private global::System.Action<object> m_OnControlsChangedDelegate;
        [global::System.NonSerialized]
        private int m_CurrentPointerId;
        [global::System.NonSerialized]
        private int m_CurrentPointerIndex;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.UI.UIPointerType m_CurrentPointerType;
        internal global::UnityEngine.InputSystem.Utilities.InlinedArray<int> m_PointerIds;
        internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputControl> m_PointerTouchControls;
        internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.UI.PointerModel> m_PointerStates;
        private global::UnityEngine.InputSystem.UI.NavigationModel m_NavigationState;
        [global::System.NonSerialized]
        private global::UnityEngine.GameObject m_LocalMultiPlayerRoot;
        public bool deselectOnBackgroundClick
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.UI.UIPointerBehavior pointerBehavior
        {
            get
            {
                return global::UnityEngine.InputSystem.UI.UIPointerBehavior.SingleMouseOrPenButMultiTouchAndTrack;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior cursorLockBehavior
        {
            get
            {
                return global::UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior.OutsideScreen;
            }

            set
            {
            }
        }

        internal global::UnityEngine.GameObject localMultiPlayerRoot
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float moveRepeatDelay
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float moveRepeatRate
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        private bool explictlyIgnoreFocus => false;
        private bool shouldIgnoreFocus => false;

        [global::System.Obsolete]
        public float repeatRate
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public float repeatDelay
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Transform xrTrackingOrigin
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float trackedDeviceDragThresholdMultiplier
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference point
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference scrollWheel
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference leftClick
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference middleClick
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference rightClick
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference move
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference submit
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference cancel
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference trackedDeviceOrientation
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionReference trackedDevicePosition
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.InputSystem.InputActionReference trackedDeviceSelect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionAsset actionsAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override void ActivateModule()
        {
        }

        public override bool IsPointerOverGameObject(int pointerOrTouchId)
        {
            return false;
        }

        public global::UnityEngine.EventSystems.RaycastResult GetLastRaycastResult(int pointerOrTouchId)
        {
            return default;
        }

        private global::UnityEngine.EventSystems.RaycastResult PerformRaycast(global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
        {
            return default;
        }

        private void ProcessPointer(ref global::UnityEngine.InputSystem.UI.PointerModel state)
        {
        }

        private bool PointerShouldIgnoreTransform(global::UnityEngine.Transform t)
        {
            return false;
        }

        private void ProcessPointerMovement(ref global::UnityEngine.InputSystem.UI.PointerModel pointer, global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
        {
        }

        private void ProcessPointerMovement(global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, global::UnityEngine.GameObject currentPointerTarget)
        {
        }

        private void ProcessPointerButton(ref global::UnityEngine.InputSystem.UI.PointerModel.ButtonState button, global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void ProcessPointerButtonDrag(ref global::UnityEngine.InputSystem.UI.PointerModel.ButtonState button, global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
        {
        }

        private static void ProcessPointerScroll(ref global::UnityEngine.InputSystem.UI.PointerModel pointer, global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        internal void ProcessNavigation(ref global::UnityEngine.InputSystem.UI.NavigationModel navigationState)
        {
        }

        private bool IsMoveAllowed(global::UnityEngine.EventSystems.AxisEventData eventData)
        {
            return false;
        }

        private void SwapAction(ref global::UnityEngine.InputSystem.InputActionReference property, global::UnityEngine.InputSystem.InputActionReference newValue, bool actionsHooked, global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback)
        {
        }

        public void AssignDefaultActions()
        {
        }

        public void UnassignActions()
        {
        }

        protected override void Awake()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void ResetPointers()
        {
        }

        private bool HasNoActions()
        {
            return false;
        }

        private void EnableAllActions()
        {
        }

        private void DisableAllActions()
        {
        }

        private void EnableInputAction(global::UnityEngine.InputSystem.InputActionReference inputActionReference)
        {
        }

        private void TryDisableInputAction(global::UnityEngine.InputSystem.InputActionReference inputActionReference, bool isComponentDisabling = false)
        {
        }

        private int GetPointerStateIndexFor(int pointerOrTouchId)
        {
            return 0;
        }

        private ref global::UnityEngine.InputSystem.UI.PointerModel GetPointerStateForIndex(int index)
        {
            throw null;
        }

        private int GetDisplayIndexFor(global::UnityEngine.InputSystem.InputControl control)
        {
            return 0;
        }

        private int GetPointerStateIndexFor(ref global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            return 0;
        }

        private int GetPointerStateIndexFor(global::UnityEngine.InputSystem.InputControl control, bool createIfNotExists = true)
        {
            return 0;
        }

        private int AllocatePointer(int pointerId, int displayIndex, int touchId, global::UnityEngine.InputSystem.UI.UIPointerType pointerType, global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputControl touchControl = null)
        {
            return 0;
        }

        private void SendPointerExitEventsAndRemovePointer(int index)
        {
        }

        private void RemovePointerAtIndex(int index)
        {
        }

        private void PurgeStalePointers()
        {
        }

        private static bool HaveControlForDevice(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputActionReference actionReference)
        {
            return false;
        }

        private void OnPointCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private bool IgnoreNextClick(ref global::UnityEngine.InputSystem.InputAction.CallbackContext context, bool wasPressed)
        {
            return false;
        }

        private void OnLeftClickCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnRightClickCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnMiddleClickCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private bool CheckForRemovedDevice(ref global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            return false;
        }

        private void OnScrollCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnMoveCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnTrackedDeviceOrientationCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnTrackedDevicePositionCallback(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnControlsChanged(object obj)
        {
        }

        private void FilterPointerStatesByType()
        {
        }

        public override void Process()
        {
        }

        private void HookActions()
        {
        }

        private void UnhookActions()
        {
        }

        private void SetActionCallbacks(bool install)
        {
        }

        private static void SetActionCallback(global::UnityEngine.InputSystem.InputActionReference actionReference, global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install)
        {
        }

        private global::UnityEngine.InputSystem.InputActionReference UpdateReferenceForNewAsset(global::UnityEngine.InputSystem.InputActionReference actionReference)
        {
            return null;
        }
    }
}