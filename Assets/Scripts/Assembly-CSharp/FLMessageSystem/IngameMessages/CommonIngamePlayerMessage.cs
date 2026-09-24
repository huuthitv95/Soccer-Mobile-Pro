namespace FLMessageSystem.IngameMessages
{
    public class CommonIngamePlayerMessage : global::Common.IRecycleable
    {
        public InGamePlayer Player;
        public InGamePlayer Player2;
        public object Message;
        public void OnCreateFromPool()
        {
        }

        public void OnReleaseToPool()
        {
        }
    }
}