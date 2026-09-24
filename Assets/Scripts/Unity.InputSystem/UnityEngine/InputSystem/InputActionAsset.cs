namespace UnityEngine.InputSystem
{
    public class InputActionAsset : global::UnityEngine.ScriptableObject, global::UnityEngine.InputSystem.IInputActionCollection2, global::UnityEngine.InputSystem.IInputActionCollection, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputAction>, global::System.Collections.IEnumerable
    {
        [global::System.Serializable]
        internal struct WriteFileJson
        {
            public string name;
            public global::UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;
            public global::UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;
        }

        [global::System.Serializable]
        internal struct WriteFileJsonNoName
        {
            public global::UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;
            public global::UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;
        }

        [global::System.Serializable]
        internal struct ReadFileJson
        {
            public string name;
            public global::UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;
            public global::UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;
            public void ToAsset(global::UnityEngine.InputSystem.InputActionAsset asset)
            {
            }
        }

        public const string Extension = "inputactions";
        internal const string kDefaultAssetLayoutJson = "{}";
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputActionMap[] m_ActionMaps;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputControlScheme[] m_ControlSchemes;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionState m_SharedStateForAllMaps;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputBinding? m_BindingMask;
        [global::System.NonSerialized]
        internal int m_ParameterOverridesCount;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;
        [global::System.NonSerialized]
        internal global::UnityEngine.InputSystem.InputActionMap.DeviceArray m_Devices;
        public bool enabled => false;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputActionMap> actionMaps => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControlScheme> controlSchemes => default;
        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputBinding> bindings => null;

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

        public string ToJson()
        {
            return null;
        }

        public void LoadFromJson(string json)
        {
        }

        public static global::UnityEngine.InputSystem.InputActionAsset FromJson(string json)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return null;
        }

        public int FindBinding(global::UnityEngine.InputSystem.InputBinding mask, out global::UnityEngine.InputSystem.InputAction action)
        {
            action = null;
            return 0;
        }

        public global::UnityEngine.InputSystem.InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputActionMap FindActionMap(global::System.Guid id)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputAction FindAction(global::System.Guid guid)
        {
            return null;
        }

        public int FindControlSchemeIndex(string name)
        {
            return 0;
        }

        public global::UnityEngine.InputSystem.InputControlScheme? FindControlScheme(string name)
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

        public bool Contains(global::UnityEngine.InputSystem.InputAction action)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputAction> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        internal void MarkAsDirty()
        {
        }

        internal bool IsEmpty()
        {
            return false;
        }

        internal void OnWantToChangeSetup()
        {
        }

        internal void OnSetupChanged()
        {
        }

        private void ReResolveIfNecessary(bool fullResolve)
        {
        }

        internal void ResolveBindingsIfNecessary()
        {
        }

        private void OnDestroy()
        {
        }
    }
}