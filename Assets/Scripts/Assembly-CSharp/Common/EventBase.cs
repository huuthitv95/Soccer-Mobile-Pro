namespace Common
{
    public class EventBase
    {
        protected global::System.Collections.Generic.List<global::System.MulticastDelegate> listeners;
        protected global::System.Collections.Generic.List<global::System.MulticastDelegate> InvokeList;
        protected void AddListener(global::System.MulticastDelegate listener)
        {
        }

        protected void RemoveListener(global::System.MulticastDelegate listener)
        {
        }

        public void Clear()
        {
        }
    }
}