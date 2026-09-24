namespace UnityEngine.InputSystem.Utilities
{
    public sealed class InputActionTrace : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr>, global::System.Collections.IEnumerable, global::System.IDisposable
    {
        public struct ActionEventPtr
        {
            internal global::UnityEngine.InputSystem.InputActionState m_State;
            internal unsafe global::UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr;
            public global::UnityEngine.InputSystem.InputAction action => null;
            public global::UnityEngine.InputSystem.InputActionPhase phase => global::UnityEngine.InputSystem.InputActionPhase.Disabled;
            public global::UnityEngine.InputSystem.InputControl control => null;
            public global::UnityEngine.InputSystem.IInputInteraction interaction => null;
            public double time => 0.0;
            public double startTime => 0.0;
            public double duration => 0.0;
            public int valueSizeInBytes => 0;

            public object ReadValueAsObject()
            {
                return null;
            }

            public unsafe void ReadValue(void* buffer, int bufferSize)
            {
            }

            public TValue ReadValue<TValue>()
                where TValue : struct
            {
                return default;
            }

            public override string ToString()
            {
                return null;
            }
        }

        private struct Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private readonly global::UnityEngine.InputSystem.Utilities.InputActionTrace m_Trace;
            private unsafe readonly global::UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer;
            private readonly int m_EventCount;
            private unsafe global::UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent;
            private int m_CurrentIndex;
            public global::UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            public unsafe Enumerator(global::UnityEngine.InputSystem.Utilities.InputActionTrace trace)
            {
                m_Trace = null;
                m_Buffer = null;
                m_EventCount = 0;
                m_CurrentEvent = null;
                m_CurrentIndex = 0;
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }
        }

        private bool m_SubscribedToAll;
        private bool m_OnActionChangeHooked;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputAction> m_SubscribedActions;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputActionMap> m_SubscribedActionMaps;
        private global::UnityEngine.InputSystem.LowLevel.InputEventBuffer m_EventBuffer;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputActionState> m_ActionMapStates;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputActionState> m_ActionMapStateClones;
        private global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> m_CallbackDelegate;
        private global::System.Action<object, global::UnityEngine.InputSystem.InputActionChange> m_ActionChangeDelegate;
        public global::UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer => default;
        public int count => 0;

        public InputActionTrace()
        {
        }

        public InputActionTrace(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public InputActionTrace(global::UnityEngine.InputSystem.InputActionMap actionMap)
        {
        }

        public void SubscribeToAll()
        {
        }

        public void UnsubscribeFromAll()
        {
        }

        public void SubscribeTo(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public void SubscribeTo(global::UnityEngine.InputSystem.InputActionMap actionMap)
        {
        }

        public void UnsubscribeFrom(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public void UnsubscribeFrom(global::UnityEngine.InputSystem.InputActionMap actionMap)
        {
        }

        public void RecordAction(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        public void Clear()
        {
        }

        ~InputActionTrace()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public void Dispose()
        {
        }

        private void DisposeInternal()
        {
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        private void HookOnActionChange()
        {
        }

        private void UnhookOnActionChange()
        {
        }

        private void OnActionChange(object actionOrMapOrAsset, global::UnityEngine.InputSystem.InputActionChange change)
        {
        }

        private void CloneActionStateBeforeBindingsChange(global::UnityEngine.InputSystem.InputActionMap actionMap)
        {
        }
    }
}