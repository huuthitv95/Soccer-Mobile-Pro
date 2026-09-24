namespace UnityEngine.InputSystem
{
    public sealed class InputRemoting : global::System.IObservable<global::UnityEngine.InputSystem.InputRemoting.Message>, global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message>
    {
        public enum MessageType
        {
            Connect = 0,
            Disconnect = 1,
            NewLayout = 2,
            NewDevice = 3,
            NewEvents = 4,
            RemoveDevice = 5,
            RemoveLayout = 6,
            ChangeUsages = 7,
            StartSending = 8,
            StopSending = 9
        }

        public struct Message
        {
            public int participantId;
            public global::UnityEngine.InputSystem.InputRemoting.MessageType type;
            public byte[] data;
        }

        [global::System.Flags]
        private enum Flags
        {
            Sending = 1,
            StartSendingOnConnect = 2
        }

        [global::System.Serializable]
        internal struct RemoteSender
        {
            public int senderId;
            public global::UnityEngine.InputSystem.Utilities.InternedString[] layouts;
            public global::UnityEngine.InputSystem.InputRemoting.RemoteInputDevice[] devices;
        }

        [global::System.Serializable]
        internal struct RemoteInputDevice
        {
            public int remoteId;
            public int localId;
            public global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description;
        }

        internal class Subscriber : global::System.IDisposable
        {
            public global::UnityEngine.InputSystem.InputRemoting owner;
            public global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message> observer;
            public void Dispose()
            {
            }
        }

        private static class ConnectMsg
        {
            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver)
            {
            }
        }

        private static class StartSendingMsg
        {
            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver)
            {
            }
        }

        private static class StopSendingMsg
        {
            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver)
            {
            }
        }

        private static class DisconnectMsg
        {
            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver, global::UnityEngine.InputSystem.InputRemoting.Message msg)
            {
            }
        }

        private static class NewLayoutMsg
        {
            [global::System.Serializable]
            public struct Data
            {
                public string name;
                public string layoutJson;
                public bool isOverride;
            }

            public static global::UnityEngine.InputSystem.InputRemoting.Message? Create(global::UnityEngine.InputSystem.InputRemoting sender, string layoutName)
            {
                return null;
            }

            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver, global::UnityEngine.InputSystem.InputRemoting.Message msg)
            {
            }
        }

        private static class NewDeviceMsg
        {
            [global::System.Serializable]
            public struct Data
            {
                public string name;
                public string layout;
                public int deviceId;
                public string[] usages;
                public global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description;
            }

            public static global::UnityEngine.InputSystem.InputRemoting.Message Create(global::UnityEngine.InputSystem.InputDevice device)
            {
                return default;
            }

            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver, global::UnityEngine.InputSystem.InputRemoting.Message msg)
            {
            }
        }

        private static class NewEventsMsg
        {
            public static global::UnityEngine.InputSystem.InputRemoting.Message CreateResetEvent(global::UnityEngine.InputSystem.InputDevice device, bool isHardReset)
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputRemoting.Message CreateStateEvent(global::UnityEngine.InputSystem.InputDevice device)
            {
                return default;
            }

            public unsafe static global::UnityEngine.InputSystem.InputRemoting.Message Create(global::UnityEngine.InputSystem.LowLevel.InputEvent* events, int eventCount)
            {
                return default;
            }

            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver, global::UnityEngine.InputSystem.InputRemoting.Message msg)
            {
            }
        }

        private static class ChangeUsageMsg
        {
            [global::System.Serializable]
            public struct Data
            {
                public int deviceId;
                public string[] usages;
            }

            public static global::UnityEngine.InputSystem.InputRemoting.Message Create(global::UnityEngine.InputSystem.InputDevice device)
            {
                return default;
            }

            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver, global::UnityEngine.InputSystem.InputRemoting.Message msg)
            {
            }
        }

        private static class RemoveDeviceMsg
        {
            public static global::UnityEngine.InputSystem.InputRemoting.Message Create(global::UnityEngine.InputSystem.InputDevice device)
            {
                return default;
            }

            public static void Process(global::UnityEngine.InputSystem.InputRemoting receiver, global::UnityEngine.InputSystem.InputRemoting.Message msg)
            {
            }
        }

        private global::UnityEngine.InputSystem.InputRemoting.Flags m_Flags;
        private global::UnityEngine.InputSystem.InputManager m_LocalManager;
        private global::UnityEngine.InputSystem.InputRemoting.Subscriber[] m_Subscribers;
        private global::UnityEngine.InputSystem.InputRemoting.RemoteSender[] m_Senders;
        public bool sending
        {
            get
            {
                return false;
            }

            private set
            {
            }
        }

        internal global::UnityEngine.InputSystem.InputManager manager => null;

        internal InputRemoting(global::UnityEngine.InputSystem.InputManager manager, bool startSendingOnConnect = false)
        {
        }

        public void StartSending()
        {
        }

        public void StopSending()
        {
        }

        void global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message>.OnNext(global::UnityEngine.InputSystem.InputRemoting.Message msg)
        {
        }

        void global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message>.OnError(global::System.Exception error)
        {
        }

        void global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted()
        {
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message> observer)
        {
            return null;
        }

        private void SendInitialMessages()
        {
        }

        private void SendAllGeneratedLayouts()
        {
        }

        private void SendLayout(string layoutName)
        {
        }

        private void SendAllDevices()
        {
        }

        private void SendDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private void SendEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private void SendDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
        {
        }

        private void SendLayoutChange(string layout, global::UnityEngine.InputSystem.InputControlLayoutChange change)
        {
        }

        private void Send(global::UnityEngine.InputSystem.InputRemoting.Message msg)
        {
        }

        private int FindOrCreateSenderRecord(int senderId)
        {
            return 0;
        }

        private static global::UnityEngine.InputSystem.Utilities.InternedString BuildLayoutNamespace(int senderId)
        {
            return default;
        }

        private int FindLocalDeviceId(int remoteDeviceId, int senderIndex)
        {
            return 0;
        }

        private global::UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex)
        {
            return null;
        }

        public void RemoveRemoteDevices(int participantId)
        {
        }

        private static byte[] SerializeData<TData>(TData data)
        {
            return null;
        }

        private static TData DeserializeData<TData>(byte[] data)
        {
            return default;
        }
    }
}