namespace FLMessageSystem
{
    public class MessageSystem
    {
        private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::System.Delegate>> _subscribers;
        private readonly global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Action<object>>> _stringSubscribers;
        public void Subscribe<T>(global::System.Action<T> action)
        {
        }

        public void Unsubscribe<T>(global::System.Action<T> action)
        {
        }

        public void Subscribe<T>(global::FLMessageSystem.ReadOnlyAction<T> action)
        {
        }

        public void Unsubscribe<T>(global::FLMessageSystem.ReadOnlyAction<T> action)
        {
        }

        public void Publish<T>(T message)
        {
        }

        public void Subscribe(string messageKey, global::System.Action<object> action)
        {
        }

        public void Unsubscribe(string messageKey, global::System.Action<object> action)
        {
        }

        public void Publish(string messageKey, object payload = null)
        {
        }
    }
}