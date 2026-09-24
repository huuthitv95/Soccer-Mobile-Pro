namespace UnityEngine.InputSystem
{
    public static class InputSystem
    {
        private struct StateEventBuffer
        {
            [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 511)]
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            [global::System.Runtime.CompilerServices.UnsafeValueType]
            public struct _003Cdata_003Ee__FixedBuffer
            {
                public byte FixedElementField;
            }

            public global::UnityEngine.InputSystem.LowLevel.StateEvent stateEvent;
            public const int kMaxSize = 512;
            public global::UnityEngine.InputSystem.InputSystem.StateEventBuffer._003Cdata_003Ee__FixedBuffer data;
        }

        private struct DeltaStateEventBuffer
        {
            [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 511)]
            [global::System.Runtime.CompilerServices.UnsafeValueType]
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            public struct _003Cdata_003Ee__FixedBuffer
            {
                public byte FixedElementField;
            }

            public global::UnityEngine.InputSystem.LowLevel.DeltaStateEvent stateEvent;
            public const int kMaxSize = 512;
            public global::UnityEngine.InputSystem.InputSystem.DeltaStateEventBuffer._003Cdata_003Ee__FixedBuffer data;
        }

        internal const string kAssemblyVersion = "1.8.2";
        internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8";
        internal static global::UnityEngine.InputSystem.InputManager s_Manager;
        internal static global::UnityEngine.InputSystem.InputRemoting s_Remote;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> devices => default;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> disconnectedDevices => default;

        public static float pollingFrequency
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        internal static bool isProcessingEvents => false;

        public static global::UnityEngine.InputSystem.LowLevel.InputEventListener onEvent
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public static global::System.IObservable<global::UnityEngine.InputSystem.InputControl> onAnyButtonPress => null;

        public static global::UnityEngine.InputSystem.InputSettings settings
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public static global::UnityEngine.InputSystem.InputRemoting remoting => null;
        public static global::System.Version version => null;

        public static bool runInBackground
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputMetrics metrics => default;

        public static event global::System.Action<string, global::UnityEngine.InputSystem.InputControlLayoutChange> onLayoutChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.InputDeviceChange> onDeviceChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate onDeviceCommand
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate onFindLayoutForDevice
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action onBeforeUpdate
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action onAfterUpdate
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action onSettingsChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action<object, global::UnityEngine.InputSystem.InputActionChange> onActionChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public static void RegisterLayout(global::System.Type type, string name = null, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher? matches = null)
        {
        }

        public static void RegisterLayout<T>(string name = null, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher? matches = null)
            where T : global::UnityEngine.InputSystem.InputControl
        {
        }

        public static void RegisterLayout(string json, string name = null, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher? matches = null)
        {
        }

        public static void RegisterLayoutOverride(string json, string name = null)
        {
        }

        public static void RegisterLayoutMatcher(string layoutName, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
        {
        }

        public static void RegisterLayoutMatcher<TDevice>(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
        }

        public static void RegisterLayoutBuilder(global::System.Func<global::UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, string name, string baseLayout = null, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher? matches = null)
        {
        }

        public static void RegisterPrecompiledLayout<TDevice>(string metadata)
            where TDevice : global::UnityEngine.InputSystem.InputDevice, new()
        {
        }

        public static void RemoveLayout(string name)
        {
        }

        public static string TryFindMatchingLayout(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
        {
            return null;
        }

        public static global::System.Collections.Generic.IEnumerable<string> ListLayouts()
        {
            return null;
        }

        public static global::System.Collections.Generic.IEnumerable<string> ListLayoutsBasedOn(string baseLayout)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout(string name)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout<TControl>()
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return null;
        }

        public static string GetNameOfBaseLayout(string layoutName)
        {
            return null;
        }

        public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName)
        {
            return false;
        }

        public static void RegisterProcessor(global::System.Type type, string name = null)
        {
        }

        public static void RegisterProcessor<T>(string name = null)
        {
        }

        public static global::System.Type TryGetProcessor(string name)
        {
            return null;
        }

        public static global::System.Collections.Generic.IEnumerable<string> ListProcessors()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, string variants = null)
        {
            return null;
        }

        public static TDevice AddDevice<TDevice>(string name = null)
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputDevice AddDevice(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description)
        {
            return null;
        }

        public static void AddDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public static void RemoveDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public static void FlushDisconnectedDevices()
        {
        }

        public static global::UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout)
        {
            return null;
        }

        public static TDevice GetDevice<TDevice>()
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputDevice GetDevice(global::System.Type type)
        {
            return null;
        }

        public static TDevice GetDevice<TDevice>(global::UnityEngine.InputSystem.Utilities.InternedString usage)
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
            return null;
        }

        public static TDevice GetDevice<TDevice>(string usage)
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputDevice GetDeviceById(int deviceId)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices()
        {
            return null;
        }

        public static int GetUnsupportedDevices(global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions)
        {
            return 0;
        }

        public static void EnableDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public static void DisableDevice(global::UnityEngine.InputSystem.InputDevice device, bool keepSendingEvents = false)
        {
        }

        public static bool TrySyncDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        public static void ResetDevice(global::UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false)
        {
        }

        [global::System.Obsolete]
        public static bool TryResetDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        public static void PauseHaptics()
        {
        }

        public static void ResumeHaptics()
        {
        }

        public static void ResetHaptics()
        {
        }

        public static void SetDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, string usage)
        {
        }

        public static void SetDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        public static void AddDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, string usage)
        {
        }

        public static void AddDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        public static void RemoveDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, string usage)
        {
        }

        public static void RemoveDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        public static global::UnityEngine.InputSystem.InputControl FindControl(string path)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> FindControls(string path)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlList<TControl> FindControls<TControl>(string path)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return default;
        }

        public static int FindControls<TControl>(string path, ref global::UnityEngine.InputSystem.InputControlList<TControl> controls)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return 0;
        }

        public static void QueueEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }

        public static void QueueEvent<TEvent>(ref TEvent inputEvent)
            where TEvent : struct, global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
        {
        }

        public static void QueueStateEvent<TState>(global::UnityEngine.InputSystem.InputDevice device, TState state, double time = -1.0)
            where TState : struct, global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
        {
        }

        public static void QueueDeltaStateEvent<TDelta>(global::UnityEngine.InputSystem.InputControl control, TDelta delta, double time = -1.0)
            where TDelta : struct
        {
        }

        public static void QueueConfigChangeEvent(global::UnityEngine.InputSystem.InputDevice device, double time = -1.0)
        {
        }

        public static void QueueTextEvent(global::UnityEngine.InputSystem.InputDevice device, char character, double time = -1.0)
        {
        }

        public static void Update()
        {
        }

        internal static void Update(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
        }

        public static void RegisterInteraction(global::System.Type type, string name = null)
        {
        }

        public static void RegisterInteraction<T>(string name = null)
        {
        }

        public static global::System.Type TryGetInteraction(string name)
        {
            return null;
        }

        public static global::System.Collections.Generic.IEnumerable<string> ListInteractions()
        {
            return null;
        }

        public static void RegisterBindingComposite(global::System.Type type, string name)
        {
        }

        public static void RegisterBindingComposite<T>(string name = null)
        {
        }

        public static global::System.Type TryGetBindingComposite(string name)
        {
            return null;
        }

        public static void DisableAllEnabledActions()
        {
        }

        public static global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputAction> ListEnabledActions()
        {
            return null;
        }

        public static int ListEnabledActions(global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputAction> actions)
        {
            return 0;
        }

        static InputSystem()
        {
        }

        private static void RunInitializeInPlayer()
        {
        }

        internal static void EnsureInitialized()
        {
        }

        private static void InitializeInPlayer(global::UnityEngine.InputSystem.LowLevel.IInputRuntime runtime = null, global::UnityEngine.InputSystem.InputSettings settings = null)
        {
        }

        private static void RunInitialUpdate()
        {
        }

        private static void PerformDefaultPluginInitialization()
        {
        }
    }
}