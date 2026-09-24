namespace UnityEngine.InputSystem.Utilities
{
    internal class Observer<TValue> : global::System.IObserver<TValue>
    {
        private global::System.Action<TValue> m_OnNext;
        private global::System.Action m_OnCompleted;
        public Observer(global::System.Action<TValue> onNext, global::System.Action onCompleted = null)
        {
        }

        public void OnCompleted()
        {
        }

        public void OnError(global::System.Exception error)
        {
        }

        public void OnNext(TValue evt)
        {
        }
    }
}