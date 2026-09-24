namespace UnityEngine.InputSystem
{
    internal class InputManager
    {
        internal enum DeviceDisableScope
        {
            Everywhere = 0,
            InFrontendOnly = 1,
            TemporaryWhilePlayerIsInBackground = 2
        }

        [global::System.Serializable]
        internal struct AvailableDevice
        {
            public global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description;
            public int deviceId;
            public bool isNative;
            public bool isRemoved;
        }

        private struct StateChangeMonitorTimeout
        {
            public global::UnityEngine.InputSystem.InputControl control;
            public double time;
            public global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor;
            public long monitorIndex;
            public int timerIndex;
        }

        internal struct StateChangeMonitorListener
        {
            public global::UnityEngine.InputSystem.InputControl control;
            public global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor;
            public long monitorIndex;
            public uint groupIndex;
        }

        internal struct StateChangeMonitorsForDevice
        {
            public global::UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion[] memoryRegions;
            public global::UnityEngine.InputSystem.InputManager.StateChangeMonitorListener[] listeners;
            public global::UnityEngine.InputSystem.DynamicBitfield signalled;
            public bool needToUpdateOrderingOfMonitors;
            public bool needToCompactArrays;
            public int count => 0;

            public void Add(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex)
            {
            }

            public void Remove(global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval)
            {
            }

            public void Clear()
            {
            }

            public void CompactArrays()
            {
            }

            private void RemoveAt(int i)
            {
            }

            public void SortMonitorsByIndex()
            {
            }
        }

        internal int m_LayoutRegistrationVersion;
        private float m_PollingFrequency;
        internal global::UnityEngine.InputSystem.Layouts.InputControlLayout.Collection m_Layouts;
        private global::UnityEngine.InputSystem.Utilities.TypeTable m_Processors;
        private global::UnityEngine.InputSystem.Utilities.TypeTable m_Interactions;
        private global::UnityEngine.InputSystem.Utilities.TypeTable m_Composites;
        private int m_DevicesCount;
        private global::UnityEngine.InputSystem.InputDevice[] m_Devices;
        private global::System.Collections.Generic.Dictionary<int, global::UnityEngine.InputSystem.InputDevice> m_DevicesById;
        internal int m_AvailableDeviceCount;
        internal global::UnityEngine.InputSystem.InputManager.AvailableDevice[] m_AvailableDevices;
        internal int m_DisconnectedDevicesCount;
        internal global::UnityEngine.InputSystem.InputDevice[] m_DisconnectedDevices;
        internal global::UnityEngine.InputSystem.LowLevel.InputUpdateType m_UpdateMask;
        private global::UnityEngine.InputSystem.LowLevel.InputUpdateType m_CurrentUpdate;
        internal global::UnityEngine.InputSystem.LowLevel.InputStateBuffers m_StateBuffers;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.InputDeviceChange>> m_DeviceChangeListeners;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_DeviceStateChangeListeners;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks;
        internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate> m_DeviceCommandCallbacks;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<string, global::UnityEngine.InputSystem.InputControlLayoutChange>> m_LayoutChangeListeners;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice>> m_EventListeners;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action> m_BeforeUpdateListeners;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action> m_AfterUpdateListeners;
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action> m_SettingsChangedListeners;
        private bool m_NativeBeforeUpdateHooked;
        private bool m_HaveDevicesWithStateCallbackReceivers;
        private bool m_HasFocus;
        private global::UnityEngine.InputSystem.LowLevel.InputEventStream m_InputEventStream;
        private global::UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate;
        private int m_DeviceFindExecuteCommandDeviceId;
        internal global::UnityEngine.InputSystem.LowLevel.IInputRuntime m_Runtime;
        internal global::UnityEngine.InputSystem.LowLevel.InputMetrics m_Metrics;
        internal global::UnityEngine.InputSystem.InputSettings m_Settings;
        private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent;
        internal global::UnityEngine.InputSystem.InputManager.StateChangeMonitorsForDevice[] m_StateChangeMonitors;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> devices => default;
        public global::UnityEngine.InputSystem.Utilities.TypeTable processors => default;
        public global::UnityEngine.InputSystem.Utilities.TypeTable interactions => default;
        public global::UnityEngine.InputSystem.Utilities.TypeTable composites => default;
        public global::UnityEngine.InputSystem.LowLevel.InputMetrics metrics => default;

        public global::UnityEngine.InputSystem.InputSettings settings
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask
        {
            get
            {
                return global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.LowLevel.InputUpdateType defaultUpdateType => global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None;

        public float pollingFrequency
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool isProcessingEvents => false;
        private bool gameIsPlaying => false;
        private bool gameHasFocus => false;
        private bool gameShouldGetInputRegardlessOfFocus => false;

        public event global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.InputDeviceChange> onDeviceChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.InputEventPtr> onDeviceStateChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate onDeviceCommand
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<string, global::UnityEngine.InputSystem.InputControlLayoutChange> onLayoutChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> onEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action onBeforeUpdate
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action onAfterUpdate
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action onSettingsChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public void RegisterControlLayout(string name, global::System.Type type)
        {
        }

        public void RegisterControlLayout(string json, string name = null, bool isOverride = false)
        {
        }

        public void RegisterControlLayoutBuilder(global::System.Func<global::UnityEngine.InputSystem.Layouts.InputControlLayout> method, string name, string baseLayout = null)
        {
        }

        private void PerformLayoutPostRegistration(global::UnityEngine.InputSystem.Utilities.InternedString layoutName, global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false, bool isOverride = false)
        {
        }

        public void RegisterPrecompiledLayout<TDevice>(string metadata)
            where TDevice : global::UnityEngine.InputSystem.InputDevice, new()
        {
        }

        private void RecreateDevicesUsingLayout(global::UnityEngine.InputSystem.Utilities.InternedString layout, bool isKnownToBeDeviceLayout = false)
        {
        }

        private bool IsControlOrChildUsingLayoutRecursive(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.Utilities.InternedString layout)
        {
            return false;
        }

        private bool IsControlUsingLayout(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.Utilities.InternedString layout)
        {
            return false;
        }

        public void RegisterControlLayoutMatcher(string layoutName, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
        {
        }

        public void RegisterControlLayoutMatcher(global::System.Type type, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
        {
        }

        private void RecreateDevicesUsingLayoutWithInferiorMatch(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher)
        {
        }

        private void RecreateDevice(global::UnityEngine.InputSystem.InputDevice oldDevice, global::UnityEngine.InputSystem.Utilities.InternedString newLayout)
        {
        }

        private void AddAvailableDevicesMatchingDescription(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher, global::UnityEngine.InputSystem.Utilities.InternedString layout)
        {
        }

        public void RemoveControlLayout(string name)
        {
        }

        public global::UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(global::System.Type type)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(global::UnityEngine.InputSystem.Utilities.InternedString name)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingControlLayout(ref global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, int deviceId = 0)
        {
            return default;
        }

        private global::UnityEngine.InputSystem.Utilities.InternedString FindOrRegisterDeviceLayoutForType(global::System.Type type)
        {
            return default;
        }

        private bool IsDeviceLayoutMarkedAsSupportedInSettings(global::UnityEngine.InputSystem.Utilities.InternedString layoutName)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerable<string> ListControlLayouts(string basedOn = null)
        {
            return null;
        }

        public int GetControls<TControl>(string path, ref global::UnityEngine.InputSystem.InputControlList<TControl> controls)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return 0;
        }

        public void SetDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        public void AddDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        public void RemoveDeviceUsage(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        private void NotifyUsageChanged(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public global::UnityEngine.InputSystem.InputDevice AddDevice(global::System.Type type, string name = null)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputDevice AddDevice(string layout, string name = null, global::UnityEngine.InputSystem.Utilities.InternedString variants = default(global::UnityEngine.InputSystem.Utilities.InternedString))
        {
            return null;
        }

        private global::UnityEngine.InputSystem.InputDevice AddDevice(global::UnityEngine.InputSystem.Utilities.InternedString layout, int deviceId, string deviceName = null, global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription = default(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription), global::UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags = (global::UnityEngine.InputSystem.InputDevice.DeviceFlags)0, global::UnityEngine.InputSystem.Utilities.InternedString variants = default(global::UnityEngine.InputSystem.Utilities.InternedString))
        {
            return null;
        }

        public void AddDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public global::UnityEngine.InputSystem.InputDevice AddDevice(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputDevice AddDevice(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0, global::UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags = (global::UnityEngine.InputSystem.InputDevice.DeviceFlags)0)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputDevice AddDevice(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description, global::UnityEngine.InputSystem.Utilities.InternedString layout, string deviceName = null, int deviceId = 0, global::UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags = (global::UnityEngine.InputSystem.InputDevice.DeviceFlags)0)
        {
            return null;
        }

        public void RemoveDevice(global::UnityEngine.InputSystem.InputDevice device, bool keepOnListOfAvailableDevices = false)
        {
        }

        public void FlushDisconnectedDevices()
        {
        }

        public void ResetDevice(global::UnityEngine.InputSystem.InputDevice device, bool alsoResetDontResetControls = false, bool? issueResetCommand = null)
        {
        }

        public global::UnityEngine.InputSystem.InputDevice TryGetDevice(string nameOrLayout)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputDevice GetDevice(string nameOrLayout)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputDevice TryGetDevice(global::System.Type layoutType)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputDevice TryGetDeviceById(int id)
        {
            return null;
        }

        public int GetUnsupportedDevices(global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions)
        {
            return 0;
        }

        public void EnableOrDisableDevice(global::UnityEngine.InputSystem.InputDevice device, bool enable, global::UnityEngine.InputSystem.InputManager.DeviceDisableScope scope = global::UnityEngine.InputSystem.InputManager.DeviceDisableScope.Everywhere)
        {
        }

        private unsafe void QueueEvent(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
        {
        }

        public void QueueEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
        {
        }

        public void QueueEvent<TEvent>(ref TEvent inputEvent)
            where TEvent : struct, global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
        {
        }

        public void Update()
        {
        }

        public void Update(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
        }

        internal void Initialize(global::UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, global::UnityEngine.InputSystem.InputSettings settings)
        {
        }

        internal void Destroy()
        {
        }

        internal void InitializeData()
        {
        }

        internal void InstallRuntime(global::UnityEngine.InputSystem.LowLevel.IInputRuntime runtime)
        {
        }

        internal void InstallGlobals()
        {
        }

        internal void UninstallGlobals()
        {
        }

        private void MakeDeviceNameUnique(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private static void ResetControlPathsRecursive(global::UnityEngine.InputSystem.InputControl control)
        {
        }

        private void AssignUniqueDeviceId(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private void ReallocateStateBuffers()
        {
        }

        private void InitializeDefaultState(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private void InitializeDeviceState(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor)
        {
        }

        private global::UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(string deviceDescriptor)
        {
            return null;
        }

        private void InstallBeforeUpdateHookIfNecessary()
        {
        }

        private void RestoreDevicesAfterDomainReloadIfNecessary()
        {
        }

        private void WarnAboutDevicesFailingToRecreateAfterDomainReload()
        {
        }

        private void OnBeforeUpdate(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
        }

        internal void ApplySettings()
        {
        }

        internal long ExecuteGlobalCommand<TCommand>(ref TCommand command)
            where TCommand : struct, global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
        {
            return 0L;
        }

        internal void AddAvailableDevicesThatAreNowRecognized()
        {
        }

        private bool ShouldRunDeviceInBackground(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        internal void OnFocusChanged(bool focus)
        {
        }

        internal bool ShouldRunUpdate(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
            return false;
        }

        private void OnUpdate(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, ref global::UnityEngine.InputSystem.LowLevel.InputEventBuffer eventBuffer)
        {
        }

        private void InvokeAfterUpdateCallback(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
        }

        internal void DontMakeCurrentlyUpdatingDeviceCurrent()
        {
        }

        internal unsafe bool UpdateState(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
            return false;
        }

        internal unsafe bool UpdateState(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr = default(global::UnityEngine.InputSystem.LowLevel.InputEventPtr))
        {
            return false;
        }

        private unsafe void WriteStateChange(global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref global::UnityEngine.InputSystem.LowLevel.InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers)
        {
        }

        private bool FlipBuffersForDeviceIfNecessary(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
            return false;
        }

        public void AddStateChangeMonitor(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex)
        {
        }

        private void RemoveStateChangeMonitors(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        public void RemoveStateChangeMonitor(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex)
        {
        }

        public void AddStateChangeMonitorTimeout(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex)
        {
        }

        public void RemoveStateChangeMonitorTimeout(global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex)
        {
        }

        private void SortStateChangeMonitorsIfNecessary(int deviceIndex)
        {
        }

        public void SignalStateChangeMonitor(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor)
        {
        }

        public void FireStateChangeNotifications()
        {
        }

        private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes)
        {
            return false;
        }

        internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
        {
        }

        private void ProcessStateChangeMonitorTimeouts()
        {
        }
    }
}