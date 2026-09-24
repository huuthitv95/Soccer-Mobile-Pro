namespace UnityEngine.InputSystem.LowLevel
{
    [global::System.Serializable]
    public sealed class InputEventTrace : global::System.IDisposable, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>, global::System.Collections.IEnumerable
    {
        private class Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private global::UnityEngine.InputSystem.LowLevel.InputEventTrace m_Trace;
            private int m_ChangeCounter;
            internal global::UnityEngine.InputSystem.LowLevel.InputEventPtr m_Current;
            public global::UnityEngine.InputSystem.LowLevel.InputEventPtr Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            public Enumerator(global::UnityEngine.InputSystem.LowLevel.InputEventTrace trace)
            {
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }
        }

        [global::System.Flags]
        private enum FileFlags
        {
            FixedUpdate = 1
        }

        public class ReplayController : global::System.IDisposable
        {
            private global::UnityEngine.InputSystem.LowLevel.InputEventTrace m_EventTrace;
            private global::UnityEngine.InputSystem.LowLevel.InputEventTrace.Enumerator m_Enumerator;
            private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::System.Collections.Generic.KeyValuePair<int, int>> m_DeviceIDMappings;
            private bool m_CreateNewDevices;
            private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.InputDevice> m_CreatedDevices;
            private global::System.Action m_OnFinished;
            private global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> m_OnEvent;
            private double m_StartTimeAsPerFirstEvent;
            private double m_StartTimeAsPerRuntime;
            private int m_AllEventsByTimeIndex;
            private global::System.Collections.Generic.List<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> m_AllEventsByTime;
            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace trace => null;
            public bool finished { get; private set; }
            public bool paused { get; set; }
            public int position { get; private set; }
            public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputDevice> createdDevices => null;

            internal ReplayController(global::UnityEngine.InputSystem.LowLevel.InputEventTrace trace)
            {
            }

            public void Dispose()
            {
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(global::UnityEngine.InputSystem.InputDevice recordedDevice, global::UnityEngine.InputSystem.InputDevice playbackDevice)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(int recordedDeviceId, int playbackDeviceId)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithAllDevicesMappedToNewInstances()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnFinished(global::System.Action action)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnEvent(global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> action)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayOneEvent()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Rewind()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllFramesOneByOne()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEvents()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEventsAccordingToTimestamps()
            {
                return null;
            }

            private void OnBeginFrame()
            {
            }

            private void Finished()
            {
            }

            private void QueueEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
            {
            }

            private bool MoveNext(bool skipFrameEvents, out global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
            {
                eventPtr = default;
                return false;
            }

            private int ApplyDeviceMapping(int originalDeviceId)
            {
                return 0;
            }
        }

        [global::System.Serializable]
        public struct DeviceInfo
        {
            [global::UnityEngine.SerializeField]
            internal int m_DeviceId;
            [global::UnityEngine.SerializeField]
            internal string m_Layout;
            [global::UnityEngine.SerializeField]
            internal global::UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;
            [global::UnityEngine.SerializeField]
            internal int m_StateSizeInBytes;
            [global::UnityEngine.SerializeField]
            internal string m_FullLayoutJson;
            public int deviceId
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public string layout
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public global::UnityEngine.InputSystem.Utilities.FourCC stateFormat
            {
                get
                {
                    return default;
                }

                set
                {
                }
            }

            public int stateSizeInBytes
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }
        }

        private const int kDefaultBufferSize = 1048576;
        [global::System.NonSerialized]
        private int m_ChangeCounter;
        [global::System.NonSerialized]
        private bool m_Enabled;
        [global::System.NonSerialized]
        private global::System.Func<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice, bool> m_OnFilterEvent;
        [global::UnityEngine.SerializeField]
        private int m_DeviceId;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_EventListeners;
        [global::UnityEngine.SerializeField]
        private long m_EventBufferSize;
        [global::UnityEngine.SerializeField]
        private long m_MaxEventBufferSize;
        [global::UnityEngine.SerializeField]
        private long m_GrowIncrementSize;
        [global::UnityEngine.SerializeField]
        private long m_EventCount;
        [global::UnityEngine.SerializeField]
        private long m_EventSizeInBytes;
        [global::UnityEngine.SerializeField]
        private ulong m_EventBufferStorage;
        [global::UnityEngine.SerializeField]
        private ulong m_EventBufferHeadStorage;
        [global::UnityEngine.SerializeField]
        private ulong m_EventBufferTailStorage;
        [global::UnityEngine.SerializeField]
        private bool m_HasWrapped;
        [global::UnityEngine.SerializeField]
        private bool m_RecordFrameMarkers;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo[] m_DeviceInfos;
        private static int kFileVersion;
        public static global::UnityEngine.InputSystem.Utilities.FourCC FrameMarkerEvent => default;

        public int deviceId
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public bool enabled => false;

        public bool recordFrameMarkers
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public long eventCount => 0L;
        public long totalEventSizeInBytes => 0L;
        public long allocatedSizeInBytes => 0L;
        public long maxSizeInBytes => 0L;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> deviceInfos => default;

        public global::System.Func<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice, bool> onFilterEvent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private unsafe byte* m_EventBuffer
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private unsafe byte* m_EventBufferHead
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private unsafe byte* m_EventBufferTail
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private static global::UnityEngine.InputSystem.Utilities.FourCC kFileFormat => default;

        public event global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> onEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public InputEventTrace(global::UnityEngine.InputSystem.InputDevice device, long bufferSizeInBytes = 1048576L, bool growBuffer = false, long maxBufferSizeInBytes = -1L, long growIncrementSizeInBytes = -1L)
        {
        }

        public InputEventTrace(long bufferSizeInBytes = 1048576L, bool growBuffer = false, long maxBufferSizeInBytes = -1L, long growIncrementSizeInBytes = -1L)
        {
        }

        public void WriteTo(string filePath)
        {
        }

        public void WriteTo(global::System.IO.Stream stream)
        {
        }

        public void ReadFrom(string filePath)
        {
        }

        public void ReadFrom(global::System.IO.Stream stream)
        {
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(string filePath)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(global::System.IO.Stream stream)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Replay()
        {
            return null;
        }

        public bool Resize(long newBufferSize, long newMaxBufferSize = -1L)
        {
            return false;
        }

        public void Clear()
        {
        }

        public void Enable()
        {
        }

        public void Disable()
        {
        }

        public bool GetNextEvent(ref global::UnityEngine.InputSystem.LowLevel.InputEventPtr current)
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator()
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

        private void Allocate()
        {
        }

        private void Release()
        {
        }

        private void OnBeforeUpdate()
        {
        }

        private void OnInputEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, global::UnityEngine.InputSystem.InputDevice device)
        {
        }
    }
}