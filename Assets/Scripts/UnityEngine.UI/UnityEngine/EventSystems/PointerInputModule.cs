namespace UnityEngine.EventSystems
{
    public abstract class PointerInputModule : global::UnityEngine.EventSystems.BaseInputModule
    {
        protected class ButtonState
        {
            private global::UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
            private global::UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;
            public global::UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData eventData
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public global::UnityEngine.EventSystems.PointerEventData.InputButton button
            {
                get
                {
                    return global::UnityEngine.EventSystems.PointerEventData.InputButton.Left;
                }

                set
                {
                }
            }
        }

        protected class MouseState
        {
            private global::System.Collections.Generic.List<global::UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;
            public bool AnyPressesThisFrame()
            {
                return false;
            }

            public bool AnyReleasesThisFrame()
            {
                return false;
            }

            public global::UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(global::UnityEngine.EventSystems.PointerEventData.InputButton button)
            {
                return null;
            }

            public void SetButtonState(global::UnityEngine.EventSystems.PointerEventData.InputButton button, global::UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, global::UnityEngine.EventSystems.PointerEventData data)
            {
            }
        }

        public class MouseButtonEventData
        {
            public global::UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
            public global::UnityEngine.EventSystems.PointerEventData buttonData;
            public bool PressedThisFrame()
            {
                return false;
            }

            public bool ReleasedThisFrame()
            {
                return false;
            }
        }

        public const int kMouseLeftId = -1;
        public const int kMouseRightId = -2;
        public const int kMouseMiddleId = -3;
        public const int kFakeTouchesId = -4;
        protected global::System.Collections.Generic.Dictionary<int, global::UnityEngine.EventSystems.PointerEventData> m_PointerData;
        private readonly global::UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;
        protected bool GetPointerData(int id, out global::UnityEngine.EventSystems.PointerEventData data, bool create)
        {
            data = null;
            return false;
        }

        protected void RemovePointerData(global::UnityEngine.EventSystems.PointerEventData data)
        {
        }

        protected global::UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(global::UnityEngine.Touch input, out bool pressed, out bool released)
        {
            pressed = default;
            released = default;
            return null;
        }

        protected void CopyFromTo(global::UnityEngine.EventSystems.PointerEventData from, global::UnityEngine.EventSystems.PointerEventData to)
        {
        }

        protected global::UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId)
        {
            return global::UnityEngine.EventSystems.PointerEventData.FramePressState.Pressed;
        }

        protected virtual global::UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData()
        {
            return null;
        }

        protected virtual global::UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id)
        {
            return null;
        }

        protected global::UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id)
        {
            return null;
        }

        private static bool ShouldStartDrag(global::UnityEngine.Vector2 pressPos, global::UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold)
        {
            return false;
        }

        protected virtual void ProcessMove(global::UnityEngine.EventSystems.PointerEventData pointerEvent)
        {
        }

        protected virtual void ProcessDrag(global::UnityEngine.EventSystems.PointerEventData pointerEvent)
        {
        }

        public override bool IsPointerOverGameObject(int pointerId)
        {
            return false;
        }

        protected void ClearSelection()
        {
        }

        public override string ToString()
        {
            return null;
        }

        protected void DeselectIfSelectionChanged(global::UnityEngine.GameObject currentOverGo, global::UnityEngine.EventSystems.BaseEventData pointerEvent)
        {
        }
    }
}