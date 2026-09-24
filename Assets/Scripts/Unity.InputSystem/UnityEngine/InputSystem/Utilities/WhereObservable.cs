namespace UnityEngine.InputSystem.Utilities
{
    internal class WhereObservable<TValue> : global::System.IObservable<TValue>
    {
        private class Where : global::System.IObserver<TValue>
        {
            private global::UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable;
            private readonly global::System.IObserver<TValue> m_Observer;
            public Where(global::UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, global::System.IObserver<TValue> observer)
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

        private readonly global::System.IObservable<TValue> m_Source;
        private readonly global::System.Func<TValue, bool> m_Predicate;
        public WhereObservable(global::System.IObservable<TValue> source, global::System.Func<TValue, bool> predicate)
        {
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<TValue> observer)
        {
            return null;
        }
    }
}