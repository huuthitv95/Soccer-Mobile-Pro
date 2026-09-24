namespace UnityEngine.InputSystem.UI
{
    internal struct PointerModel
    {
        public struct ButtonState
        {
            private bool m_IsPressed;
            private global::UnityEngine.EventSystems.PointerEventData.FramePressState m_FramePressState;
            private float m_PressTime;
            private global::UnityEngine.EventSystems.RaycastResult m_PressRaycast;
            private global::UnityEngine.GameObject m_PressObject;
            private global::UnityEngine.GameObject m_RawPressObject;
            private global::UnityEngine.GameObject m_LastPressObject;
            private global::UnityEngine.GameObject m_DragObject;
            private global::UnityEngine.Vector2 m_PressPosition;
            private float m_ClickTime;
            private int m_ClickCount;
            private bool m_Dragging;
            private bool m_ClickedOnSameGameObject;
            private bool m_IgnoreNextClick;
            public bool isPressed
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool ignoreNextClick
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public float pressTime
            {
                get
                {
                    return 0f;
                }

                set
                {
                }
            }

            public bool clickedOnSameGameObject
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool wasPressedThisFrame => false;
            public bool wasReleasedThisFrame => false;

            public void CopyPressStateTo(global::UnityEngine.EventSystems.PointerEventData eventData)
            {
            }

            public void CopyPressStateFrom(global::UnityEngine.EventSystems.PointerEventData eventData)
            {
            }

            public void OnEndFrame()
            {
            }
        }

        public bool changedThisFrame;
        public global::UnityEngine.InputSystem.UI.PointerModel.ButtonState leftButton;
        public global::UnityEngine.InputSystem.UI.PointerModel.ButtonState rightButton;
        public global::UnityEngine.InputSystem.UI.PointerModel.ButtonState middleButton;
        public global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData;
        private global::UnityEngine.Vector2 m_ScreenPosition;
        private global::UnityEngine.Vector2 m_ScrollDelta;
        private global::UnityEngine.Vector3 m_WorldPosition;
        private global::UnityEngine.Quaternion m_WorldOrientation;
        private float m_Pressure;
        private float m_AzimuthAngle;
        private float m_AltitudeAngle;
        private float m_Twist;
        private global::UnityEngine.Vector2 m_Radius;
        public global::UnityEngine.InputSystem.UI.UIPointerType pointerType => global::UnityEngine.InputSystem.UI.UIPointerType.None;

        public global::UnityEngine.Vector2 screenPosition
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector3 worldPosition
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Quaternion worldOrientation
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 scrollDelta
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float pressure
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float azimuthAngle
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float altitudeAngle
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float twist
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 radius
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public PointerModel(global::UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
        {
            changedThisFrame = false;
            leftButton = default;
            rightButton = default;
            middleButton = default;
            this.eventData = null;
            m_ScreenPosition = default;
            m_ScrollDelta = default;
            m_WorldPosition = default;
            m_WorldOrientation = default;
            m_Pressure = 0f;
            m_AzimuthAngle = 0f;
            m_AltitudeAngle = 0f;
            m_Twist = 0f;
            m_Radius = default;
        }

        public void OnFrameFinished()
        {
        }

        public void CopyTouchOrPenStateFrom(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}