namespace Common
{
    public class MessagePool
    {
        private global::System.Collections.Generic.List<global::Common.ByteBuffer>[] _messages;
        private int _currentBuffer;
        private global::Common.GameMessage _tempMessage;
        public void Append(global::Common.ByteBuffer buffer)
        {
        }

        public void Clear()
        {
        }

        public void Dispatch(global::System.Action<global::Common.GameMessage> handler)
        {
        }
    }
}