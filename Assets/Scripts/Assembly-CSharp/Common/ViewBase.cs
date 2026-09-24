namespace Common
{
    public class ViewBase : global::UnityEngine.MonoBehaviour, global::Common.IMessageReceiver, global::Common.IUpdate
    {
        public virtual void OnOpen(object paramter)
        {
        }

        public virtual void ReceiveMessage(global::Common.GameMessage message)
        {
        }

        public virtual void OnUpdate(float deltaTime)
        {
        }

        public virtual void OnClose()
        {
        }
    }
}