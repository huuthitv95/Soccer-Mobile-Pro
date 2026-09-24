namespace UnityEngine.InputSystem
{
    public class InputDevice : global::UnityEngine.InputSystem.InputControl
    {
        [global::System.Serializable]
        [global::System.Flags]
        internal enum DeviceFlags
        {
            UpdateBeforeRender = 1,
            HasStateCallbacks = 2,
            HasControlsWithDefaultState = 4,
            HasDontResetControls = 0x400,
            HasEventMerger = 0x2000,
            HasEventPreProcessor = 0x4000,
            Remote = 8,
            Native = 0x10,
            DisabledInFrontend = 0x20,
            DisabledInRuntime = 0x80,
            DisabledWhileInBackground = 0x100,
            DisabledStateHasBeenQueriedFromRuntime = 0x40,
            CanRunInBackground = 0x800,
            CanRunInBackgroundHasBeenQueried = 0x1000
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Pack = 1, Size = 7)]
        internal struct ControlBitRangeNode
        {
            public ushort endBitOffset;
            public short leftChildIndex;
            public ushort controlStartIndex;
            public byte controlCount;
            public ControlBitRangeNode(ushort endOffset)
            {
                endBitOffset = 0;
                leftChildIndex = 0;
                controlStartIndex = 0;
                controlCount = 0;
            }
        }

        public const int InvalidDeviceId = 0;
        internal const int kLocalParticipantId = 0;
        internal const int kInvalidDeviceIndex = -1;
        internal global::UnityEngine.InputSystem.InputDevice.DeviceFlags m_DeviceFlags;
        internal int m_DeviceId;
        internal int m_ParticipantId;
        internal int m_DeviceIndex;
        internal global::UnityEngine.InputSystem.Layouts.InputDeviceDescription m_Description;
        internal double m_LastUpdateTimeInternal;
        internal uint m_CurrentUpdateStepCount;
        internal global::UnityEngine.InputSystem.Utilities.InternedString[] m_AliasesForEachControl;
        internal global::UnityEngine.InputSystem.Utilities.InternedString[] m_UsagesForEachControl;
        internal global::UnityEngine.InputSystem.InputControl[] m_UsageToControl;
        internal global::UnityEngine.InputSystem.InputControl[] m_ChildrenForEachControl;
        internal uint[] m_StateOffsetToControlMap;
        internal global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode[] m_ControlTreeNodes;
        internal ushort[] m_ControlTreeIndices;
        internal const int kControlIndexBits = 10;
        internal const int kStateOffsetBits = 13;
        internal const int kStateSizeBits = 9;
        public global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description => default;
        public bool enabled => false;
        public bool canRunInBackground => false;
        public bool added => false;
        public bool remote => false;
        public bool native => false;
        public bool updateBeforeRender => false;
        public int deviceId => 0;
        public double lastUpdateTime => 0.0;
        public bool wasUpdatedThisFrame => false;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControl> allControls => default;
        public override global::System.Type valueType => null;
        public override int valueSizeInBytes => 0;

        [global::System.Obsolete]
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputDevice> all => default;

        internal bool disabledInFrontend
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool disabledInRuntime
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool disabledWhileInBackground
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool hasControlsWithDefaultState
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool hasDontResetControls
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool hasStateCallbacks
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool hasEventMerger
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool hasEventPreProcessor
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public unsafe override object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
        {
            return null;
        }

        public unsafe override object ReadValueFromStateAsObject(void* statePtr)
        {
            return null;
        }

        public unsafe override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
        {
        }

        public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
        {
            return false;
        }

        internal void NotifyConfigurationChanged()
        {
        }

        public virtual void MakeCurrent()
        {
        }

        protected virtual void OnAdded()
        {
        }

        protected virtual void OnRemoved()
        {
        }

        protected virtual void OnConfigurationChanged()
        {
        }

        public long ExecuteCommand<TCommand>(ref TCommand command)
            where TCommand : struct, global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
        {
            return 0L;
        }

        protected unsafe virtual long ExecuteCommand(global::UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr)
        {
            return 0L;
        }

        internal bool QueryEnabledStateFromRuntime()
        {
            return false;
        }

        internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits)
        {
            return 0u;
        }

        internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize)
        {
            controlIndex = default;
            stateOffset = default;
            stateSize = default;
        }

        internal void AddDeviceUsage(global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        internal void RemoveDeviceUsage(global::UnityEngine.InputSystem.Utilities.InternedString usage)
        {
        }

        internal void ClearDeviceUsages()
        {
        }

        internal bool RequestSync()
        {
            return false;
        }

        internal bool RequestReset()
        {
            return false;
        }

        internal bool ExecuteEnableCommand()
        {
            return false;
        }

        internal bool ExecuteDisableCommand()
        {
            return false;
        }

        internal void NotifyAdded()
        {
        }

        internal void NotifyRemoved()
        {
        }

        internal static TDevice Build<TDevice>(string layoutName = null, string layoutVariants = null, global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription = default(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription), bool noPrecompiledLayouts = false)
            where TDevice : global::UnityEngine.InputSystem.InputDevice
        {
            return null;
        }

        internal unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice)
        {
        }

        private unsafe void WritePartialChangedControlStatesInternal(void* statePtr, uint stateSizeInBits, uint stateOffsetInDeviceInBits, byte* deviceStatePtr, global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset)
        {
        }

        private void DumpControlBitRangeNode(int nodeIndex, global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode node, uint startOffset, uint sizeInBits, global::System.Collections.Generic.List<string> output)
        {
        }

        private void DumpControlTree(global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset, global::System.Collections.Generic.List<string> output)
        {
        }

        internal string DumpControlTree()
        {
            return null;
        }

        private unsafe void WriteChangedControlStatesInternal(void* statePtr, uint stateSizeInBits, byte* deviceStatePtr, global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, uint startOffset)
        {
        }

        private unsafe static bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits)
        {
            return false;
        }
    }
}