namespace UnityEngine.InputSystem
{
    [global::System.Serializable]
    internal class RemoteInputPlayerConnection : global::UnityEngine.ScriptableObject, global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message>, global::System.IObservable<global::UnityEngine.InputSystem.InputRemoting.Message>
    {
        private class Subscriber : global::System.IDisposable
        {
            public global::UnityEngine.InputSystem.RemoteInputPlayerConnection owner;
            public global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message> observer;
            public void Dispose()
            {
            }
        }

        public static readonly global::System.Guid kNewDeviceMsg;
        public static readonly global::System.Guid kNewLayoutMsg;
        public static readonly global::System.Guid kNewEventsMsg;
        public static readonly global::System.Guid kRemoveDeviceMsg;
        public static readonly global::System.Guid kChangeUsagesMsg;
        public static readonly global::System.Guid kStartSendingMsg;
        public static readonly global::System.Guid kStopSendingMsg;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection m_Connection;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.RemoteInputPlayerConnection.Subscriber[] m_Subscribers;
        [global::UnityEngine.SerializeField]
        private int[] m_ConnectedIds;
        public void Bind(global::UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection connection, bool isConnected)
        {
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<global::UnityEngine.InputSystem.InputRemoting.Message> observer)
        {
            return null;
        }

        private void OnConnected(int id)
        {
        }

        private void OnDisconnected(int id)
        {
        }

        private void OnNewDevice(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void OnNewLayout(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void OnNewEvents(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void OnRemoveDevice(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void OnChangeUsages(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void OnStartSending(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void OnStopSending(global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
        {
        }

        private void SendToSubscribers(global::UnityEngine.InputSystem.InputRemoting.MessageType type, global::UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
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
    }
}