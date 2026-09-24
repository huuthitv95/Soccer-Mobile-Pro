namespace UnityEngine.InputSystem.Utilities
{
    internal class TakeNObservable<TValue> : global::System.IObservable<TValue>
    {
        private class Take : global::System.IObserver<TValue>
        {
            private global::System.IObserver<TValue> m_Observer;
            private int m_Remaining;
            public Take(global::UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, global::System.IObserver<TValue> observer)
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

        private global::System.IObservable<TValue> m_Source;
        private int m_Count;
        public TakeNObservable(global::System.IObservable<TValue> source, int count)
        {
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<TValue> observer)
        {
            return null;
        }
    }
}