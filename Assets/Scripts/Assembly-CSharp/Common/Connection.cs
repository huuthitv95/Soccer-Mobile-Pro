namespace Common
{
    public class Connection : global::Common.Singleton<global::Common.Connection>, global::Common.IUpdate
    {
        private global::Common.Client _client;
        private float retryConnectRemainTime;
        private global::System.Collections.Generic.List<global::System.Action<global::Common.GameMessage>> listeners;
        private global::Common.MessagePool _messagePool;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<string> m_OnServerDisconnect;
        public global::Common.MessagePool messagePool => null;
        public bool Connected => false;

        public event global::System.Action<string> OnServerDisconnect
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public void AddListener(global::System.Action<global::Common.GameMessage> listener)
        {
        }

        public void RemoveListener(global::System.Action<global::Common.GameMessage> listener)
        {
        }

        public void Connect()
        {
        }

        private void ReceiveMessage(global::Common.GameMessage msg)
        {
        }

        public void Disconnect()
        {
        }

        public void WriteMessage(OpCode opCode)
        {
        }

        public void WriteMessage(OpCode code, global::Google.Protobuf.IMessage message)
        {
        }

        public void OnUpdate(float deltaTime)
        {
        }

        private void ServerDisconnected(string obj)
        {
        }
    }
}