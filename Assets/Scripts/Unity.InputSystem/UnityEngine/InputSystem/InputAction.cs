namespace UnityEngine.InputSystem
{
    [global::System.Serializable]
    public sealed class InputAction : global::System.ICloneable, global::System.IDisposable
    {
        [global::System.Flags]
        internal enum ActionFlags
        {
            WantsInitialStateCheck = 1
        }

        public struct CallbackContext
        {
            internal global::UnityEngine.InputSystem.InputActionState m_State;
            internal int m_ActionIndex;
            private int actionIndex => 0;
            private int bindingIndex => 0;
            private int controlIndex => 0;
            private int interactionIndex => 0;
            public global::UnityEngine.InputSystem.InputActionPhase phase => global::UnityEngine.InputSystem.InputActionPhase.Disabled;
            public bool started => false;
            public bool performed => false;
            public bool canceled => false;
            public global::UnityEngine.InputSystem.InputAction action => null;
            public global::UnityEngine.InputSystem.InputControl control => null;
            public global::UnityEngine.InputSystem.IInputInteraction interaction => null;
            public double time => 0.0;
            public double startTime => 0.0;
            public double duration => 0.0;
            public global::System.Type valueType => null;
            public int valueSizeInBytes => 0;

            public unsafe void ReadValue(void* buffer, int bufferSize)
            {
            }

            public TValue ReadValue<TValue>()
                where TValue : struct
            {
                return default;
            }

            public bool ReadValueAsButton()
            {
                return false;
            }

            public object ReadValueAsObject()
            {
                return null;
            }

            public override string ToString()
            {
                return null;
            }
        }

        [global::UnityEngine.SerializeField]
        internal string m_Name;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputActionType m_Type;
        [global::UnityEngine.SerializeField]
        internal string m_ExpectedControlType;
        [global::UnityEngine.SerializeField]
        internal string m_Id;
        [global::UnityEngine.SerializeField]
        internal string m_Processors;
        [global::UnityEngine.SerializeField]
        internal string m_Interactions;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputBinding[] m_SingletonActionBindings;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputAction.ActionFlags m_Flags;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputBinding? m_BindingMask;
        [global::System.NonSerialized]
        internal int m_BindingsStartIndex;
        [global::System.NonSerialized]
        internal int m_BindingsCount;
        [global::System.NonSerialized]
        internal int m_ControlStartIndex;
        [global::System.NonSerialized]
        internal int m_ControlCount;
        [global::System.NonSerialized]
        internal int m_ActionIndexInState;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionMap m_ActionMap;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnStarted;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnCanceled;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnPerformed;
        public string name => null;
        public global::UnityEngine.InputSystem.InputActionType type => global::UnityEngine.InputSystem.InputActionType.Value;
        public global::System.Guid id => default;
        internal global::System.Guid idDontGenerate => default;

        public string expectedControlType
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string processors => null;
        public string interactions => null;
        public global::UnityEngine.InputSystem.InputActionMap actionMap => null;

        public global::UnityEngine.InputSystem.InputBinding? bindingMask
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputBinding> bindings => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControl> controls => default;
        public global::UnityEngine.InputSystem.InputActionPhase phase => global::UnityEngine.InputSystem.InputActionPhase.Disabled;
        public bool inProgress => false;
        public bool enabled => false;
        public bool triggered => false;
        public global::UnityEngine.InputSystem.InputControl activeControl => null;
        public global::System.Type activeValueType => null;

        public bool wantsInitialStateCheck
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool isSingletonAction => false;
        private global::UnityEngine.InputSystem.InputActionState.TriggerState currentState => default;

        public event global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> started
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> canceled
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> performed
        {
            add
            {
            }

            remove
            {
            }
        }

        public InputAction()
        {
        }

        public InputAction(string name = null, global::UnityEngine.InputSystem.InputActionType type = global::UnityEngine.InputSystem.InputActionType.Value, string binding = null, string interactions = null, string processors = null, string expectedControlType = null)
        {
        }

        public void Dispose()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public void Enable()
        {
        }

        public void Disable()
        {
        }

        public global::UnityEngine.InputSystem.InputAction Clone()
        {
            return null;
        }

        object global::System.ICloneable.Clone()
        {
            return null;
        }

        public TValue ReadValue<TValue>()
            where TValue : struct
        {
            return default;
        }

        public object ReadValueAsObject()
        {
            return null;
        }

        public float GetControlMagnitude()
        {
            return 0f;
        }

        public void Reset()
        {
        }

        public bool IsPressed()
        {
            return false;
        }

        public bool IsInProgress()
        {
            return false;
        }

        public bool WasPressedThisFrame()
        {
            return false;
        }

        public bool WasReleasedThisFrame()
        {
            return false;
        }

        public bool WasPerformedThisFrame()
        {
            return false;
        }

        public bool WasCompletedThisFrame()
        {
            return false;
        }

        public float GetTimeoutCompletionPercentage()
        {
            return 0f;
        }

        internal string MakeSureIdIsInPlace()
        {
            return null;
        }

        internal void GenerateId()
        {
        }

        internal global::UnityEngine.InputSystem.InputActionMap GetOrCreateActionMap()
        {
            return null;
        }

        private void CreateInternalActionMapForSingletonAction()
        {
        }

        internal void RequestInitialStateCheckOnEnabledAction()
        {
        }

        internal bool ActiveControlIsValid(global::UnityEngine.InputSystem.InputControl control)
        {
            return false;
        }

        internal global::UnityEngine.InputSystem.InputBinding? FindEffectiveBindingMask()
        {
            return null;
        }

        internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction)
        {
            return 0;
        }

        internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap)
        {
            return 0;
        }
    }
}