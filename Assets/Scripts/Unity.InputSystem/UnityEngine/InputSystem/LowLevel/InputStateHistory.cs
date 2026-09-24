namespace UnityEngine.InputSystem.LowLevel
{
    public class InputStateHistory : global::System.IDisposable, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>, global::System.Collections.IEnumerable, global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
    {
        private struct Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private readonly global::UnityEngine.InputSystem.LowLevel.InputStateHistory m_History;
            private int m_Index;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            public Enumerator(global::UnityEngine.InputSystem.LowLevel.InputStateHistory history)
            {
                m_History = null;
                m_Index = 0;
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

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2)]
        protected internal struct RecordHeader
        {
            [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            [global::System.Runtime.CompilerServices.UnsafeValueType]
            public struct _003Cm_StateWithoutControlIndex_003Ee__FixedBuffer
            {
                public byte FixedElementField;
            }

            [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
            [global::System.Runtime.CompilerServices.UnsafeValueType]
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            public struct _003Cm_StateWithControlIndex_003Ee__FixedBuffer
            {
                public byte FixedElementField;
            }

            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public double time;
            [global::System.Runtime.InteropServices.FieldOffset(8)]
            public uint version;
            [global::System.Runtime.InteropServices.FieldOffset(12)]
            public int controlIndex;
            [global::System.Runtime.InteropServices.FieldOffset(12)]
            private global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader._003Cm_StateWithoutControlIndex_003Ee__FixedBuffer m_StateWithoutControlIndex;
            [global::System.Runtime.InteropServices.FieldOffset(16)]
            private global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader._003Cm_StateWithControlIndex_003Ee__FixedBuffer m_StateWithControlIndex;
            public const int kSizeWithControlIndex = 16;
            public const int kSizeWithoutControlIndex = 12;
            public unsafe byte* statePtrWithControlIndex => null;
            public unsafe byte* statePtrWithoutControlIndex => null;
        }

        public struct Record : global::System.IEquatable<global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record>
        {
            private readonly global::UnityEngine.InputSystem.LowLevel.InputStateHistory m_Owner;
            private readonly int m_IndexPlusOne;
            private uint m_Version;
            internal unsafe global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header => null;
            internal int recordIndex => 0;
            internal uint version => 0u;
            public bool valid => false;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory owner => null;
            public int index => 0;
            public double time => 0.0;
            public global::UnityEngine.InputSystem.InputControl control => null;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record next => default;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record previous => default;

            internal unsafe Record(global::UnityEngine.InputSystem.LowLevel.InputStateHistory owner, int index, global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header)
            {
                m_Owner = null;
                m_IndexPlusOne = 0;
                m_Version = 0u;
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

            public unsafe void* GetUnsafeMemoryPtr()
            {
                return null;
            }

            internal unsafe void* GetUnsafeMemoryPtrUnchecked()
            {
                return null;
            }

            public unsafe void* GetUnsafeExtraMemoryPtr()
            {
                return null;
            }

            internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked()
            {
                return null;
            }

            public void CopyFrom(global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record)
            {
            }

            internal void CheckValid()
            {
            }

            public bool Equals(global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record other)
            {
                return false;
            }

            public override bool Equals(object obj)
            {
                return false;
            }

            public override int GetHashCode()
            {
                return 0;
            }

            public override string ToString()
            {
                return null;
            }
        }

        private const int kDefaultHistorySize = 128;
        internal global::UnityEngine.InputSystem.InputControl[] m_Controls;
        internal int m_ControlCount;
        private global::Unity.Collections.NativeArray<byte> m_RecordBuffer;
        private int m_StateSizeInBytes;
        private int m_RecordCount;
        private int m_HistoryDepth;
        private int m_ExtraMemoryPerRecord;
        internal int m_HeadIndex;
        internal uint m_CurrentVersion;
        private global::UnityEngine.InputSystem.LowLevel.InputUpdateType? m_UpdateMask;
        internal readonly bool m_AddNewControls;
        public int Count => 0;
        public uint version => 0u;

        public int historyDepth
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int extraMemoryPerRecord
        {
            get
            {
                return 0;
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

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControl> controls => default;

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record this[int index]
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> onRecordAdded { get; set; }
        public global::System.Func<global::UnityEngine.InputSystem.InputControl, double, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, bool> onShouldRecordStateChange { get; set; }
        internal int bytesPerRecord => 0;

        public InputStateHistory(int maxStateSizeInBytes)
        {
        }

        public InputStateHistory(string path)
        {
        }

        public InputStateHistory(global::UnityEngine.InputSystem.InputControl control)
        {
        }

        public InputStateHistory(global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControl> controls)
        {
        }

        ~InputStateHistory()
        {
        }

        public void Clear()
        {
        }

        public global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record AddRecord(global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record)
        {
            return default;
        }

        public void StartRecording()
        {
        }

        public void StopRecording()
        {
        }

        public global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
            return default;
        }

        public unsafe global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(global::UnityEngine.InputSystem.InputControl control, void* statePtr, double time)
        {
            return default;
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public void Dispose()
        {
        }

        protected void Destroy()
        {
        }

        private void Allocate()
        {
        }

        protected internal int RecordIndexToUserIndex(int index)
        {
            return 0;
        }

        protected internal int UserIndexToRecordIndex(int index)
        {
            return 0;
        }

        protected internal unsafe global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecord(int index)
        {
            return null;
        }

        internal unsafe global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecordUnchecked(int index)
        {
            return null;
        }

        protected internal unsafe global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* AllocateRecord(out int index)
        {
            index = default;
            return null;
        }

        protected unsafe TValue ReadValue<TValue>(global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data)
            where TValue : struct
        {
            return default;
        }

        protected unsafe object ReadValueAsObject(global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data)
        {
            return null;
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(global::UnityEngine.InputSystem.InputControl control, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long monitorIndex)
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(global::UnityEngine.InputSystem.InputControl control, double time, long monitorIndex, int timerIndex)
        {
        }
    }

    public class InputStateHistory<TValue> : global::UnityEngine.InputSystem.LowLevel.InputStateHistory, global::System.Collections.Generic.IReadOnlyList<global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record>, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyCollection<global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record> where TValue : struct
    {
        private struct Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private readonly global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History;
            private int m_Index;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            public Enumerator(global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history)
            {
                m_History = null;
                m_Index = 0;
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

        public new struct Record : global::System.IEquatable<global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record>
        {
            private readonly global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_Owner;
            private readonly int m_IndexPlusOne;
            private uint m_Version;
            internal unsafe global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header => null;
            internal int recordIndex => 0;
            public bool valid => false;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner => null;
            public int index => 0;
            public double time => 0.0;
            public global::UnityEngine.InputSystem.InputControl<TValue> control => null;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record next => default;
            public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record previous => default;

            internal unsafe Record(global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index, global::UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header)
            {
                m_Owner = null;
                m_IndexPlusOne = 0;
                m_Version = 0u;
            }

            internal Record(global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, int index)
            {
                m_Owner = null;
                m_IndexPlusOne = 0;
                m_Version = 0u;
            }

            public TValue ReadValue()
            {
                return default;
            }

            public unsafe void* GetUnsafeMemoryPtr()
            {
                return null;
            }

            internal unsafe void* GetUnsafeMemoryPtrUnchecked()
            {
                return null;
            }

            public unsafe void* GetUnsafeExtraMemoryPtr()
            {
                return null;
            }

            internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked()
            {
                return null;
            }

            public void CopyFrom(global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record record)
            {
            }

            private void CheckValid()
            {
            }

            public bool Equals(global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record other)
            {
                return false;
            }

            public override bool Equals(object obj)
            {
                return false;
            }

            public override int GetHashCode()
            {
                return 0;
            }

            public override string ToString()
            {
                return null;
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record this[int index]
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public InputStateHistory(int? maxStateSizeInBytes = null) : base(0)
        {
        }

        public InputStateHistory(global::UnityEngine.InputSystem.InputControl<TValue> control) : base(0)
        {
        }

        public InputStateHistory(string path) : base(0)
        {
        }

        ~InputStateHistory()
        {
        }

        public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record AddRecord(global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record record)
        {
            return default;
        }

        public global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record RecordStateChange(global::UnityEngine.InputSystem.InputControl<TValue> control, TValue value, double time = -1.0)
        {
            return default;
        }

        public new global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>.Record> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}