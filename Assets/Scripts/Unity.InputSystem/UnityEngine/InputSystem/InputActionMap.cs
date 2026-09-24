namespace UnityEngine.InputSystem
{
    [global::System.Serializable]
    public sealed class InputActionMap : global::System.ICloneable, global::UnityEngine.ISerializationCallbackReceiver, global::UnityEngine.InputSystem.IInputActionCollection2, global::UnityEngine.InputSystem.IInputActionCollection, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputAction>, global::System.Collections.IEnumerable, global::System.IDisposable
    {
        [global::System.Flags]
        private enum Flags
        {
            NeedToResolveBindings = 1,
            BindingResolutionNeedsFullReResolve = 2,
            ControlsForEachActionInitialized = 4,
            BindingsForEachActionInitialized = 8
        }

        internal struct DeviceArray
        {
            private bool m_HaveValue;
            private int m_DeviceCount;
            private global::UnityEngine.InputSystem.InputDevice[] m_DeviceArray;
            public int IndexOf(global::UnityEngine.InputSystem.InputDevice device)
            {
                return 0;
            }

            public bool Remove(global::UnityEngine.InputSystem.InputDevice device)
            {
                return false;
            }

            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice>? Get()
            {
                return null;
            }

            public bool Set(global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice>? devices)
            {
                return false;
            }
        }

        [global::System.Serializable]
        internal struct BindingOverrideListJson
        {
            public global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> bindings;
        }

        [global::System.Serializable]
        internal struct BindingOverrideJson
        {
            public string action;
            public string id;
            public string path;
            public string interactions;
            public string processors;
            public static global::UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(global::UnityEngine.InputSystem.InputBinding binding, string actionName)
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(global::UnityEngine.InputSystem.InputBinding binding)
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputBinding ToBinding(global::UnityEngine.InputSystem.InputActionMap.BindingOverrideJson bindingOverride)
            {
                return default;
            }
        }

        [global::System.Serializable]
        internal struct BindingJson
        {
            public string name;
            public string id;
            public string path;
            public string interactions;
            public string processors;
            public string groups;
            public string action;
            public bool isComposite;
            public bool isPartOfComposite;
            public global::UnityEngine.InputSystem.InputBinding ToBinding()
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputActionMap.BindingJson FromBinding(ref global::UnityEngine.InputSystem.InputBinding binding)
            {
                return default;
            }
        }

        [global::System.Serializable]
        internal struct ReadActionJson
        {
            public string name;
            public string type;
            public string id;
            public string expectedControlType;
            public string expectedControlLayout;
            public string processors;
            public string interactions;
            public bool passThrough;
            public bool initialStateCheck;
            public global::UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;
            public global::UnityEngine.InputSystem.InputAction ToAction(string actionName = null)
            {
                return null;
            }
        }

        [global::System.Serializable]
        internal struct WriteActionJson
        {
            public string name;
            public string type;
            public string id;
            public string expectedControlType;
            public string processors;
            public string interactions;
            public bool initialStateCheck;
            public static global::UnityEngine.InputSystem.InputActionMap.WriteActionJson FromAction(global::UnityEngine.InputSystem.InputAction action)
            {
                return default;
            }
        }

        [global::System.Serializable]
        internal struct ReadMapJson
        {
            public string name;
            public string id;
            public global::UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;
            public global::UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;
        }

        [global::System.Serializable]
        internal struct WriteMapJson
        {
            public string name;
            public string id;
            public global::UnityEngine.InputSystem.InputActionMap.WriteActionJson[] actions;
            public global::UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;
            public static global::UnityEngine.InputSystem.InputActionMap.WriteMapJson FromMap(global::UnityEngine.InputSystem.InputActionMap map)
            {
                return default;
            }
        }

        [global::System.Serializable]
        internal struct WriteFileJson
        {
            public global::UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;
            public static global::UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMap(global::UnityEngine.InputSystem.InputActionMap map)
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMaps(global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputActionMap> maps)
            {
                return default;
            }
        }

        [global::System.Serializable]
        internal struct ReadFileJson
        {
            public global::UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;
            public global::UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;
            public global::UnityEngine.InputSystem.InputActionMap[] ToMaps()
            {
                return null;
            }
        }

        [global::UnityEngine.SerializeField]
        internal string m_Name;
        [global::UnityEngine.SerializeField]
        internal string m_Id;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputActionAsset m_Asset;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputAction[] m_Actions;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputBinding[] m_Bindings;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.InputBinding[] m_BindingsForEachAction;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.InputControl[] m_ControlsForEachAction;
        [global::System.NonSerialized]
        internal int m_EnabledActionsCount;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputAction m_SingletonAction;
        [global::System.NonSerialized]
        internal int m_MapIndexInState;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionState m_State;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputBinding? m_BindingMask;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.InputActionMap.Flags m_Flags;
        [global::System.NonSerialized]
        internal int m_ParameterOverridesCount;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionMap.DeviceArray m_Devices;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionCallbacks;
        [global::System.NonSerialized]
        internal global::System.Collections.Generic.Dictionary<string, int> m_ActionIndexByNameOrId;
        internal static int s_DeferBindingResolution;
        public string name => null;
        public global::UnityEngine.InputSystem.InputActionAsset asset => null;
        public global::System.Guid id => default;
        internal global::System.Guid idDontGenerate => default;
        public bool enabled => false;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputAction> actions => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputBinding> bindings => default;

        global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputBinding> global::UnityEngine.InputSystem.IInputActionCollection2.bindings => null;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControlScheme> controlSchemes => default;

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

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice>? devices
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.InputAction this[string actionNameOrId]
        {
            get
            {
                return null;
            }
        }

        private bool needToResolveBindings
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private bool bindingResolutionNeedsFullReResolve
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private bool controlsForEachActionInitialized
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private bool bindingsForEachActionInitialized
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext> actionTriggered
        {
            add
            {
            }

            remove
            {
            }
        }

        public InputActionMap()
        {
        }

        public InputActionMap(string name)
        {
        }

        public void Dispose()
        {
        }

        internal int FindActionIndex(string nameOrId)
        {
            return 0;
        }

        private void SetUpActionLookupTable()
        {
        }

        internal void ClearActionLookupTable()
        {
        }

        private int FindActionIndex(global::System.Guid id)
        {
            return 0;
        }

        public global::UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputAction FindAction(global::System.Guid id)
        {
            return null;
        }

        public bool IsUsableWithDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        public void Enable()
        {
        }

        public void Disable()
        {
        }

        public global::UnityEngine.InputSystem.InputActionMap Clone()
        {
            return null;
        }

        object global::System.ICloneable.Clone()
        {
            return null;
        }

        public bool Contains(global::UnityEngine.InputSystem.InputAction action)
        {
            return false;
        }

        public override string ToString()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputAction> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        internal global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(global::UnityEngine.InputSystem.InputAction action)
        {
            return default;
        }

        internal global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(global::UnityEngine.InputSystem.InputAction action)
        {
            return default;
        }

        private void SetUpPerActionControlAndBindingArrays()
        {
        }

        internal void OnWantToChangeSetup()
        {
        }

        internal void OnSetupChanged()
        {
        }

        internal void OnBindingModified()
        {
        }

        internal void ClearCachedActionData(bool onlyControls = false)
        {
        }

        internal void GenerateId()
        {
        }

        internal bool LazyResolveBindings(bool fullResolve)
        {
            return false;
        }

        internal bool ResolveBindingsIfNecessary()
        {
            return false;
        }

        internal void ResolveBindings()
        {
        }

        public int FindBinding(global::UnityEngine.InputSystem.InputBinding mask, out global::UnityEngine.InputSystem.InputAction action)
        {
            action = null;
            return 0;
        }

        internal int FindBindingRelativeToMap(global::UnityEngine.InputSystem.InputBinding mask)
        {
            return 0;
        }

        public static global::UnityEngine.InputSystem.InputActionMap[] FromJson(string json)
        {
            return null;
        }

        public static string ToJson(global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputActionMap> maps)
        {
            return null;
        }

        public string ToJson()
        {
            return null;
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }
    }
}