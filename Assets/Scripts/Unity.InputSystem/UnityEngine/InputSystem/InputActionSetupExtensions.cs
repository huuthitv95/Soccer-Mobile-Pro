namespace UnityEngine.InputSystem
{
    public static class InputActionSetupExtensions
    {
        public struct BindingSyntax
        {
            private readonly global::UnityEngine.InputSystem.InputActionMap m_ActionMap;
            private readonly global::UnityEngine.InputSystem.InputAction m_Action;
            internal readonly int m_BindingIndexInMap;
            public bool valid => false;
            public int bindingIndex => 0;
            public global::UnityEngine.InputSystem.InputBinding binding => default;

            internal BindingSyntax(global::UnityEngine.InputSystem.InputActionMap map, int bindingIndexInMap, global::UnityEngine.InputSystem.InputAction action = null)
            {
                m_ActionMap = null;
                m_Action = null;
                m_BindingIndexInMap = 0;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithName(string name)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithPath(string path)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroup(string group)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroups(string groups)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction(string interaction)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteractions(string interactions)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction<TInteraction>()
                where TInteraction : global::UnityEngine.InputSystem.IInputInteraction
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor(string processor)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessors(string processors)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor<TProcessor>()
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Triggering(global::UnityEngine.InputSystem.InputAction action)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax To(global::UnityEngine.InputSystem.InputBinding binding)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextBinding()
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousBinding()
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextPartBinding(string partName)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousPartBinding(string partName)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextCompositeBinding(string compositeName = null)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousCompositeBinding(string compositeName = null)
            {
                return default;
            }

            private global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Iterate(bool next)
            {
                return default;
            }

            private global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IterateCompositeBinding(bool next, string compositeName)
            {
                return default;
            }

            private global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IteratePartBinding(bool next, string partName)
            {
                return default;
            }

            public void Erase()
            {
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax InsertPartBinding(string partName, string path)
            {
                return default;
            }
        }

        public struct CompositeSyntax
        {
            private readonly global::UnityEngine.InputSystem.InputAction m_Action;
            private readonly global::UnityEngine.InputSystem.InputActionMap m_ActionMap;
            private int m_BindingIndexInMap;
            public int bindingIndex => 0;

            internal CompositeSyntax(global::UnityEngine.InputSystem.InputActionMap map, global::UnityEngine.InputSystem.InputAction action, int compositeIndex)
            {
                m_Action = null;
                m_ActionMap = null;
                m_BindingIndexInMap = 0;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax With(string name, string binding, string groups = null, string processors = null)
            {
                return default;
            }
        }

        public struct ControlSchemeSyntax
        {
            private readonly global::UnityEngine.InputSystem.InputActionAsset m_Asset;
            private readonly int m_ControlSchemeIndex;
            private global::UnityEngine.InputSystem.InputControlScheme m_ControlScheme;
            internal ControlSchemeSyntax(global::UnityEngine.InputSystem.InputActionAsset asset, int index)
            {
                m_Asset = null;
                m_ControlSchemeIndex = 0;
                m_ControlScheme = default;
            }

            internal ControlSchemeSyntax(global::UnityEngine.InputSystem.InputControlScheme controlScheme)
            {
                m_Asset = null;
                m_ControlSchemeIndex = 0;
                m_ControlScheme = default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithBindingGroup(string bindingGroup)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice<TDevice>()
                where TDevice : global::UnityEngine.InputSystem.InputDevice
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice<TDevice>()
                where TDevice : global::UnityEngine.InputSystem.InputDevice
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice<TDevice>()
                where TDevice : global::UnityEngine.InputSystem.InputDevice
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice<TDevice>()
                where TDevice : global::UnityEngine.InputSystem.InputDevice
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice(string controlPath)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice(string controlPath)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice(string controlPath)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice(string controlPath)
            {
                return default;
            }

            private string DeviceTypeToControlPath<TDevice>()
                where TDevice : global::UnityEngine.InputSystem.InputDevice
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputControlScheme Done()
            {
                return default;
            }

            private void AddDeviceEntry(string controlPath, global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags flags)
            {
            }
        }

        public static global::UnityEngine.InputSystem.InputActionMap AddActionMap(this global::UnityEngine.InputSystem.InputActionAsset asset, string name)
        {
            return null;
        }

        public static void AddActionMap(this global::UnityEngine.InputSystem.InputActionAsset asset, global::UnityEngine.InputSystem.InputActionMap map)
        {
        }

        public static void RemoveActionMap(this global::UnityEngine.InputSystem.InputActionAsset asset, global::UnityEngine.InputSystem.InputActionMap map)
        {
        }

        public static void RemoveActionMap(this global::UnityEngine.InputSystem.InputActionAsset asset, string nameOrId)
        {
        }

        public static global::UnityEngine.InputSystem.InputAction AddAction(this global::UnityEngine.InputSystem.InputActionMap map, string name, global::UnityEngine.InputSystem.InputActionType type = global::UnityEngine.InputSystem.InputActionType.Value, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null)
        {
            return null;
        }

        public static void RemoveAction(this global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public static void RemoveAction(this global::UnityEngine.InputSystem.InputActionAsset asset, string nameOrId)
        {
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputAction action, string path, string interactions = null, string processors = null, string groups = null)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputControl control)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding binding = default(global::UnityEngine.InputSystem.InputBinding))
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputActionMap actionMap, string path, global::UnityEngine.InputSystem.InputAction action, string interactions = null, string groups = null)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputActionMap actionMap, string path, global::System.Guid action, string interactions = null, string groups = null)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::UnityEngine.InputSystem.InputBinding binding)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(this global::UnityEngine.InputSystem.InputAction action, string composite, string interactions = null, string processors = null)
        {
            return default;
        }

        private static int AddBindingInternal(global::UnityEngine.InputSystem.InputActionMap map, global::UnityEngine.InputSystem.InputBinding binding, int bindingIndex = -1)
        {
            return 0;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(this global::UnityEngine.InputSystem.InputAction action, int index)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(this global::UnityEngine.InputSystem.InputAction action, string name)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(this global::UnityEngine.InputSystem.InputActionMap actionMap, int index)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(this global::UnityEngine.InputSystem.InputAction action, string id)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(this global::UnityEngine.InputSystem.InputAction action, global::System.Guid id)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(this global::UnityEngine.InputSystem.InputAction action, string group)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(this global::UnityEngine.InputSystem.InputAction action, string path)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding match)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(this global::UnityEngine.InputSystem.InputAction action, string compositeName)
        {
            return default;
        }

        public static void Rename(this global::UnityEngine.InputSystem.InputAction action, string newName)
        {
        }

        public static void AddControlScheme(this global::UnityEngine.InputSystem.InputActionAsset asset, global::UnityEngine.InputSystem.InputControlScheme controlScheme)
        {
        }

        public static global::UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(this global::UnityEngine.InputSystem.InputActionAsset asset, string name)
        {
            return default;
        }

        public static void RemoveControlScheme(this global::UnityEngine.InputSystem.InputActionAsset asset, string name)
        {
        }

        public static global::UnityEngine.InputSystem.InputControlScheme WithBindingGroup(this global::UnityEngine.InputSystem.InputControlScheme scheme, string bindingGroup)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlScheme WithDevice(this global::UnityEngine.InputSystem.InputControlScheme scheme, string controlPath, bool required)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlScheme WithRequiredDevice(this global::UnityEngine.InputSystem.InputControlScheme scheme, string controlPath)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlScheme WithOptionalDevice(this global::UnityEngine.InputSystem.InputControlScheme scheme, string controlPath)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlScheme OrWithRequiredDevice(this global::UnityEngine.InputSystem.InputControlScheme scheme, string controlPath)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlScheme OrWithOptionalDevice(this global::UnityEngine.InputSystem.InputControlScheme scheme, string controlPath)
        {
            return default;
        }
    }
}