namespace Common
{
    public class Client
    {
        private enum WritingState
        {
            Idle = 0,
            Writing = 1,
            Closing = 2
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Common.GameMessage> m_OnReceiveMessage;
        private global::System.Net.Sockets.TcpClient _client;
        private global::System.Net.Sockets.NetworkStream _stream;
        private readonly object _streamLock;
        private global::Common.Client.WritingState _writeState;
        private int _writingCount;
        private const int MAX_BUFFER_SIZE = 1048576;
        private byte[] _buffer;
        private int _totalBytesRead;
        private bool _resetReadBuffer;
        private bool _nodelay;
        private global::Common.MessagePool _messagePool;
        private long _lastRecvTime;
        private global::System.Diagnostics.Stopwatch _watch;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<string> m_OnDisconnectEvent;
        private long _connected;
        private long _connecting;
        private string _host;
        private global::Common.ByteBuffer serilizeBuffer;
        private global::Google.Protobuf.CodedOutputStream codeOupStream;
        private global::Common.GameMessage _tempMessage;
        public bool Connected
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool Connecting
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public event global::System.Action<global::Common.GameMessage> OnReceiveMessage
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

        public event global::System.Action<string> OnDisconnectEvent
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

        public Client(bool nodelay)
        {
        }

        public bool Connect(global::System.Net.IPAddress ip, int port)
        {
            return false;
        }

        public bool Connect(string addr, int port)
        {
            return false;
        }

        public void ConnectAsync(string addr, int port)
        {
        }

        private void ConnectCallback(global::System.IAsyncResult ar)
        {
        }

        public void Disconnect()
        {
        }

        private void ReadCallback(global::System.IAsyncResult ar)
        {
        }

        public void WriteMessage(ushort opCode, bool printLog = false)
        {
        }

        public void WriteMessage<TRequest>(ushort opCode, TRequest t, bool printLog = false, bool useGZip = false)
            where TRequest : global::Google.Protobuf.IMessage
        {
        }

        private void WriteCallback(global::System.IAsyncResult ar)
        {
        }

        private int DecodeMessage(int initOffset)
        {
            return 0;
        }

        public void DispatchMessage()
        {
        }

        private void OnDisconnected(string reason)
        {
        }

        public void ClearBuffer()
        {
        }

        public bool IsTcpClientAlive()
        {
            return false;
        }
    }
}