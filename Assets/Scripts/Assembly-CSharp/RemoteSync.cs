public class RemoteSync : global::UnityEngine.MonoBehaviour
{
    public global::Common.Client client;
    private global::System.Collections.Generic.Dictionary<ushort, global::System.Action<global::Common.GameMessage>> handlers;
    private bool loggedin;
    private void Start()
    {
    }

    private void Update()
    {
    }

    private void OnDestroy()
    {
    }

    private global::System.Collections.IEnumerator DelayConnect()
    {
        return null;
    }

    private void OnMessage(global::Common.GameMessage msg)
    {
    }

    public void WriteMessage(global::Srv.OpCode opCode, global::Google.Protobuf.IMessage message)
    {
    }

    private void RegisterHandler(ushort opcode, global::System.Action<global::Common.GameMessage> handler)
    {
    }

    private void ExecuteWriteAsync(global::System.Action writer)
    {
    }

    private global::System.Collections.IEnumerator DoWriteAsync(global::System.Action writer)
    {
        return null;
    }
}