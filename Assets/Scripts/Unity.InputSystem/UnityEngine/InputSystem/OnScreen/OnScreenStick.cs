namespace UnityEngine.InputSystem.OnScreen
{
    public class OnScreenStick : global::UnityEngine.InputSystem.OnScreen.OnScreenControl, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IDragHandler
    {
        public enum Behaviour
        {
            RelativePositionWithStaticOrigin = 0,
            ExactPositionWithStaticOrigin = 1,
            ExactPositionWithDynamicOrigin = 2
        }

        private const string kDynamicOriginClickable = "DynamicOriginClickable";
        [global::UnityEngine.SerializeField]
        private float m_MovementRange;
        [global::UnityEngine.SerializeField]
        private float m_DynamicOriginRange;
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        [global::UnityEngine.SerializeField]
        private string m_ControlPath;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour m_Behaviour;
        [global::UnityEngine.SerializeField]
        private bool m_UseIsolatedInputActions;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputAction m_PointerDownAction;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputAction m_PointerMoveAction;
        private global::UnityEngine.Vector3 m_StartPos;
        private global::UnityEngine.Vector2 m_PointerDownPos;
        [global::System.NonSerialized]
        private global::System.Collections.Generic.List<global::UnityEngine.EventSystems.RaycastResult> m_RaycastResults;
        [global::System.NonSerialized]
        private global::UnityEngine.EventSystems.PointerEventData m_PointerEventData;
        public float movementRange
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float dynamicOriginRange
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool useIsolatedInputActions
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        protected override string controlPathInternal
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour behaviour
        {
            get
            {
                return global::UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour.RelativePositionWithStaticOrigin;
            }

            set
            {
            }
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void Start()
        {
        }

        private void BeginInteraction(global::UnityEngine.Vector2 pointerPosition, global::UnityEngine.Camera uiCamera)
        {
        }

        private void MoveStick(global::UnityEngine.Vector2 pointerPosition, global::UnityEngine.Camera uiCamera)
        {
        }

        private void EndInteraction()
        {
        }

        private void OnPointerDown(global::UnityEngine.InputSystem.InputAction.CallbackContext ctx)
        {
        }

        private void OnPointerMove(global::UnityEngine.InputSystem.InputAction.CallbackContext ctx)
        {
        }

        private void OnPointerUp(global::UnityEngine.InputSystem.InputAction.CallbackContext ctx)
        {
        }

        private global::UnityEngine.Camera GetCameraFromCanvas()
        {
            return null;
        }

        private void OnDrawGizmosSelected()
        {
        }

        private void DrawGizmoCircle(global::UnityEngine.Vector2 center, float radius)
        {
        }

        private void UpdateDynamicOriginClickableArea()
        {
        }
    }
}