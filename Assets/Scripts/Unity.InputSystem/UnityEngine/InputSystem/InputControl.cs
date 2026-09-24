namespace UnityEngine.InputSystem
{
    public abstract class InputControl
    {
        [global::System.Flags]
        internal enum ControlFlags
        {
            ConfigUpToDate = 1,
            IsNoisy = 2,
            IsSynthetic = 4,
            IsButton = 8,
            DontReset = 0x10,
            SetupFinished = 0x20,
            UsesStateFromOtherControl = 0x40
        }

        protected internal global::UnityEngine.InputSystem.LowLevel.InputStateBlock m_StateBlock;
        internal global::UnityEngine.InputSystem.Utilities.InternedString m_Name;
        internal string m_Path;
        internal string m_DisplayName;
        internal string m_DisplayNameFromLayout;
        internal string m_ShortDisplayName;
        internal string m_ShortDisplayNameFromLayout;
        internal global::UnityEngine.InputSystem.Utilities.InternedString m_Layout;
        internal global::UnityEngine.InputSystem.Utilities.InternedString m_Variants;
        internal global::UnityEngine.InputSystem.InputDevice m_Device;
        internal global::UnityEngine.InputSystem.InputControl m_Parent;
        internal int m_UsageCount;
        internal int m_UsageStartIndex;
        internal int m_AliasCount;
        internal int m_AliasStartIndex;
        internal int m_ChildCount;
        internal int m_ChildStartIndex;
        internal global::UnityEngine.InputSystem.InputControl.ControlFlags m_ControlFlags;
        internal bool m_CachedValueIsStale;
        internal bool m_UnprocessedCachedValueIsStale;
        internal global::UnityEngine.InputSystem.Utilities.PrimitiveValue m_DefaultState;
        internal global::UnityEngine.InputSystem.Utilities.PrimitiveValue m_MinValue;
        internal global::UnityEngine.InputSystem.Utilities.PrimitiveValue m_MaxValue;
        internal global::UnityEngine.InputSystem.Utilities.FourCC m_OptimizedControlDataType;
        public string name => null;

        public string displayName
        {
            get
            {
                return null;
            }

            protected set
            {
            }
        }

        public string shortDisplayName
        {
            get
            {
                return null;
            }

            protected set
            {
            }
        }

        public string path => null;
        public string layout => null;
        public string variants => null;
        public global::UnityEngine.InputSystem.InputDevice device => null;
        public global::UnityEngine.InputSystem.InputControl parent => null;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControl> children => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.InternedString> usages => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.InternedString> aliases => default;
        public global::UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock => default;

        public bool noisy
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public bool synthetic
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.InputControl this[string path]
        {
            get
            {
                return null;
            }
        }

        public abstract global::System.Type valueType { get; }
        public abstract int valueSizeInBytes { get; }
        public float magnitude => 0f;
        protected internal unsafe void* currentStatePtr => null;
        protected internal unsafe void* previousFrameStatePtr => null;
        protected internal unsafe void* defaultStatePtr => null;
        protected internal unsafe void* noiseMaskPtr => null;
        protected internal uint stateOffsetRelativeToDeviceRoot => 0u;
        public global::UnityEngine.InputSystem.Utilities.FourCC optimizedControlDataType => default;

        internal bool isSetupFinished
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool isButton
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool isConfigUpToDate
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool dontReset
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool usesStateFromOtherControl
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal bool hasDefaultState => false;

        public override string ToString()
        {
            return null;
        }

        private string DebuggerDisplay()
        {
            return null;
        }

        public float EvaluateMagnitude()
        {
            return 0f;
        }

        public unsafe virtual float EvaluateMagnitude(void* statePtr)
        {
            return 0f;
        }

        public unsafe abstract object ReadValueFromBufferAsObject(void* buffer, int bufferSize);
        public unsafe abstract object ReadValueFromStateAsObject(void* statePtr);
        public unsafe abstract void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);
        public unsafe virtual void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
        {
        }

        public unsafe virtual void WriteValueFromObjectIntoState(object value, void* statePtr)
        {
        }

        public unsafe abstract bool CompareValue(void* firstStatePtr, void* secondStatePtr);
        public global::UnityEngine.InputSystem.InputControl TryGetChildControl(string path)
        {
            return null;
        }

        public TControl TryGetChildControl<TControl>(string path)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputControl GetChildControl(string path)
        {
            return null;
        }

        public TControl GetChildControl<TControl>(string path)
            where TControl : global::UnityEngine.InputSystem.InputControl
        {
            return null;
        }

        protected virtual void FinishSetup()
        {
        }

        protected void RefreshConfigurationIfNeeded()
        {
        }

        protected virtual void RefreshConfiguration()
        {
        }

        protected virtual global::UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
        {
            return default;
        }

        public void ApplyParameterChanges()
        {
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private void SetOptimizedControlDataType()
        {
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal void SetOptimizedControlDataTypeRecursively()
        {
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal void EnsureOptimizationTypeHasNotChanged()
        {
        }

        internal void CallFinishSetupRecursive()
        {
        }

        internal string MakeChildPath(string path)
        {
            return null;
        }

        internal void BakeOffsetIntoStateBlockRecursive(uint offset)
        {
        }

        internal int GetDeviceIndex()
        {
            return 0;
        }

        internal bool IsValueConsideredPressed(float value)
        {
            return false;
        }

        internal virtual void AddProcessor(object first)
        {
        }

        internal void MarkAsStale()
        {
        }

        internal void MarkAsStaleRecursively()
        {
        }
    }

    public abstract class InputControl<TValue> : global::UnityEngine.InputSystem.InputControl where TValue : struct
    {
        internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputProcessor<TValue>> m_ProcessorStack;
        private TValue m_CachedValue;
        private TValue m_UnprocessedCachedValue;
        internal bool evaluateProcessorsEveryRead;
        public override global::System.Type valueType => null;
        public override int valueSizeInBytes => 0;

        public ref readonly TValue value
        {
            get
            {
                throw null;
            }
        }

        internal ref readonly TValue unprocessedValue
        {
            get
            {
                throw null;
            }
        }

        internal global::UnityEngine.InputSystem.InputProcessor<TValue>[] processors => null;

        public TValue ReadValue()
        {
            return default;
        }

        public TValue ReadValueFromPreviousFrame()
        {
            return default;
        }

        public TValue ReadDefaultValue()
        {
            return default;
        }

        public unsafe TValue ReadValueFromState(void* statePtr)
        {
            return default;
        }

        public unsafe TValue ReadValueFromStateWithCaching(void* statePtr)
        {
            return default;
        }

        public unsafe TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr)
        {
            return default;
        }

        public TValue ReadUnprocessedValue()
        {
            return default;
        }

        public unsafe abstract TValue ReadUnprocessedValueFromState(void* statePtr);
        public unsafe override object ReadValueFromStateAsObject(void* statePtr)
        {
            return null;
        }

        public unsafe override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
        {
        }

        public unsafe override void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
        {
        }

        public unsafe override void WriteValueFromObjectIntoState(object value, void* statePtr)
        {
        }

        public unsafe virtual void WriteValueIntoState(TValue value, void* statePtr)
        {
        }

        public unsafe override object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
        {
            return null;
        }

        private static bool CompareValue(ref TValue firstValue, ref TValue secondValue)
        {
            return false;
        }

        public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
        {
            return false;
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public TValue ProcessValue(TValue value)
        {
            return default;
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void ProcessValue(ref TValue value)
        {
        }

        internal TProcessor TryGetProcessor<TProcessor>()
            where TProcessor : global::UnityEngine.InputSystem.InputProcessor<TValue>
        {
            return null;
        }

        internal override void AddProcessor(object processor)
        {
        }

        protected override void FinishSetup()
        {
        }
    }
}