namespace UnityEngine.InputSystem
{
    public static class InputControlExtensions
    {
        [global::System.Flags]
        public enum Enumerate
        {
            IgnoreControlsInDefaultState = 1,
            IgnoreControlsInCurrentState = 2,
            IncludeSyntheticControls = 4,
            IncludeNoisyControls = 8,
            IncludeNonLeafControls = 0x10
        }

        public struct InputEventControlCollection : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControl>, global::System.Collections.IEnumerable
        {
            internal global::UnityEngine.InputSystem.InputDevice m_Device;
            internal global::UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr;
            internal global::UnityEngine.InputSystem.InputControlExtensions.Enumerate m_Flags;
            internal float m_MagnitudeThreshold;
            public global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr => default;

            public global::UnityEngine.InputSystem.InputControlExtensions.InputEventControlEnumerator GetEnumerator()
            {
                return default;
            }

            global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputControl> global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControl>.GetEnumerator()
            {
                return null;
            }

            global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        public struct InputEventControlEnumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputControl>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private global::UnityEngine.InputSystem.InputControlExtensions.Enumerate m_Flags;
            private readonly global::UnityEngine.InputSystem.InputDevice m_Device;
            private readonly uint[] m_StateOffsetToControlIndex;
            private readonly int m_StateOffsetToControlIndexLength;
            private readonly global::UnityEngine.InputSystem.InputControl[] m_AllControls;
            private unsafe byte* m_DefaultState;
            private unsafe byte* m_CurrentState;
            private unsafe byte* m_NoiseMask;
            private global::UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr;
            private global::UnityEngine.InputSystem.InputControl m_CurrentControl;
            private int m_CurrentIndexInStateOffsetToControlIndexMap;
            private uint m_CurrentControlStateBitOffset;
            private unsafe byte* m_EventState;
            private uint m_CurrentBitOffset;
            private uint m_EndBitOffset;
            private float m_MagnitudeThreshold;
            public global::UnityEngine.InputSystem.InputControl Current => null;

            object global::System.Collections.IEnumerator.Current => null;

            internal unsafe InputEventControlEnumerator(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, float magnitudeThreshold = 0f)
            {
                m_Flags = (global::UnityEngine.InputSystem.InputControlExtensions.Enumerate)0;
                m_Device = null;
                m_StateOffsetToControlIndex = null;
                m_StateOffsetToControlIndexLength = 0;
                m_AllControls = null;
                m_DefaultState = null;
                m_CurrentState = null;
                m_NoiseMask = null;
                m_EventPtr = default;
                m_CurrentControl = null;
                m_CurrentIndexInStateOffsetToControlIndexMap = 0;
                m_CurrentControlStateBitOffset = 0u;
                m_EventState = null;
                m_CurrentBitOffset = 0u;
                m_EndBitOffset = 0u;
                m_MagnitudeThreshold = 0f;
            }

            private bool CheckDefault(uint numBits)
            {
                return false;
            }

            private bool CheckCurrent(uint numBits)
            {
                return false;
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

        public struct ControlBuilder
        {
            public global::UnityEngine.InputSystem.InputControl control { get; internal set; }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder At(global::UnityEngine.InputSystem.InputDevice device, int index)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithParent(global::UnityEngine.InputSystem.InputControl parent)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithName(string name)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDisplayName(string displayName)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithShortDisplayName(string shortDisplayName)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithLayout(global::UnityEngine.InputSystem.Utilities.InternedString layout)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithUsages(int startIndex, int count)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithAliases(int startIndex, int count)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithChildren(int startIndex, int count)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithStateBlock(global::UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDefaultState(global::UnityEngine.InputSystem.Utilities.PrimitiveValue value)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithMinAndMax(global::UnityEngine.InputSystem.Utilities.PrimitiveValue min, global::UnityEngine.InputSystem.Utilities.PrimitiveValue max)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor)
                where TProcessor : global::UnityEngine.InputSystem.InputProcessor<TValue> where TValue : struct
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsNoisy(bool value)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsSynthetic(bool value)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder DontReset(bool value)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsButton(bool value)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Finish()
            {
            }
        }

        public struct DeviceBuilder
        {
            public global::UnityEngine.InputSystem.InputDevice device { get; internal set; }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithName(string name)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithDisplayName(string displayName)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithShortDisplayName(string shortDisplayName)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithLayout(global::UnityEngine.InputSystem.Utilities.InternedString layout)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithChildren(int startIndex, int count)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateBlock(global::UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder IsNoisy(bool value)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlUsage(int controlIndex, global::UnityEngine.InputSystem.Utilities.InternedString usage, global::UnityEngine.InputSystem.InputControl control)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlAlias(int controlIndex, global::UnityEngine.InputSystem.Utilities.InternedString alias)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies)
            {
                return default;
            }

            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Finish()
            {
            }
        }

        public static TControl FindInParentChain<TControl>(this global::UnityEngine.InputSystem.InputControl control)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return null;
        }

        public static bool IsPressed(this global::UnityEngine.InputSystem.InputControl control, float buttonPressPoint = 0f)
        {
            return false;
        }

        public static bool IsActuated(this global::UnityEngine.InputSystem.InputControl control, float threshold = 0f)
        {
            return false;
        }

        public static object ReadValueAsObject(this global::UnityEngine.InputSystem.InputControl control)
        {
            return null;
        }

        public unsafe static void ReadValueIntoBuffer(this global::UnityEngine.InputSystem.InputControl control, void* buffer, int bufferSize)
        {
        }

        public static object ReadDefaultValueAsObject(this global::UnityEngine.InputSystem.InputControl control)
        {
            return null;
        }

        public static TValue ReadValueFromEvent<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent)
            where TValue : struct
        {
            return default;
        }

        public static bool ReadValueFromEvent<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, out TValue value)
            where TValue : struct
        {
            value = default;
            return false;
        }

        public static object ReadValueFromEventAsObject(this global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent)
        {
            return null;
        }

        public static TValue ReadUnprocessedValueFromEvent<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
            where TValue : struct
        {
            return default;
        }

        public static bool ReadUnprocessedValueFromEvent<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, out TValue value)
            where TValue : struct
        {
            value = default;
            return false;
        }

        public static void WriteValueFromObjectIntoEvent(this global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, object value)
        {
        }

        public unsafe static void WriteValueIntoState(this global::UnityEngine.InputSystem.InputControl control, void* statePtr)
        {
        }

        public unsafe static void WriteValueIntoState<TValue>(this global::UnityEngine.InputSystem.InputControl control, TValue value, void* statePtr)
            where TValue : struct
        {
        }

        public unsafe static void WriteValueIntoState<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, TValue value, void* statePtr)
            where TValue : struct
        {
        }

        public unsafe static void WriteValueIntoState<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, void* statePtr)
            where TValue : struct
        {
        }

        public static void WriteValueIntoState<TValue, TState>(this global::UnityEngine.InputSystem.InputControl<TValue> control, TValue value, ref TState state)
            where TValue : struct where TState : struct, global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
        {
        }

        public static void WriteValueIntoEvent<TValue>(this global::UnityEngine.InputSystem.InputControl control, TValue value, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
            where TValue : struct
        {
        }

        public static void WriteValueIntoEvent<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, TValue value, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
            where TValue : struct
        {
        }

        public unsafe static void CopyState(this global::UnityEngine.InputSystem.InputDevice device, void* buffer, int bufferSizeInBytes)
        {
        }

        public static void CopyState<TState>(this global::UnityEngine.InputSystem.InputDevice device, out TState state)
            where TState : struct, global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
        {
            state = default;
        }

        public static bool CheckStateIsAtDefault(this global::UnityEngine.InputSystem.InputControl control)
        {
            return false;
        }

        public unsafe static bool CheckStateIsAtDefault(this global::UnityEngine.InputSystem.InputControl control, void* statePtr, void* maskPtr = null)
        {
            return false;
        }

        public static bool CheckStateIsAtDefaultIgnoringNoise(this global::UnityEngine.InputSystem.InputControl control)
        {
            return false;
        }

        public unsafe static bool CheckStateIsAtDefaultIgnoringNoise(this global::UnityEngine.InputSystem.InputControl control, void* statePtr)
        {
            return false;
        }

        public unsafe static bool CompareStateIgnoringNoise(this global::UnityEngine.InputSystem.InputControl control, void* statePtr)
        {
            return false;
        }

        public unsafe static bool CompareState(this global::UnityEngine.InputSystem.InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null)
        {
            return false;
        }

        public unsafe static bool CompareState(this global::UnityEngine.InputSystem.InputControl control, void* statePtr, void* maskPtr = null)
        {
            return false;
        }

        public unsafe static bool HasValueChangeInState(this global::UnityEngine.InputSystem.InputControl control, void* statePtr)
        {
            return false;
        }

        public static bool HasValueChangeInEvent(this global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return false;
        }

        public unsafe static void* GetStatePtrFromStateEvent(this global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return null;
        }

        internal unsafe static void* GetStatePtrFromStateEventUnchecked(this global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.Utilities.FourCC eventType)
        {
            return null;
        }

        public static bool ResetToDefaultStateInEvent(this global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return false;
        }

        public static void QueueValueChange<TValue>(this global::UnityEngine.InputSystem.InputControl<TValue> control, TValue value, double time = -1.0)
            where TValue : struct
        {
        }

        public unsafe static void AccumulateValueInEvent(this global::UnityEngine.InputSystem.InputControl<float> control, void* currentStatePtr, global::UnityEngine.InputSystem.LowLevel.InputEventPtr newState)
        {
        }

        internal unsafe static void AccumulateValueInEvent(this global::UnityEngine.InputSystem.InputControl<global::UnityEngine.Vector2> control, void* currentStatePtr, global::UnityEngine.InputSystem.LowLevel.InputEventPtr newState)
        {
        }

        public static void FindControlsRecursive<TControl>(this global::UnityEngine.InputSystem.InputControl parent, global::System.Collections.Generic.IList<TControl> controls, global::System.Func<TControl, bool> predicate)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
        }

        internal static string BuildPath(this global::UnityEngine.InputSystem.InputControl control, string deviceLayout, global::System.Text.StringBuilder builder = null)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateControls(this global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, global::UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateChangedControls(this global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputDevice device = null, float magnitudeThreshold = 0f)
        {
            return default;
        }

        public static bool HasButtonPress(this global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
        {
            return false;
        }

        public static global::UnityEngine.InputSystem.InputControl GetFirstButtonPressOrNull(this global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
        {
            return null;
        }

        public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControl> GetAllButtonPresses(this global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputControlExtensions.ControlBuilder Setup(this global::UnityEngine.InputSystem.InputControl control)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder Setup(this global::UnityEngine.InputSystem.InputDevice device, int controlCount, int usageCount, int aliasCount)
        {
            return default;
        }
    }
}