namespace UnityEngine.InputSystem.LowLevel
{
    internal class SelectObservable<TSource, TResult> : global::System.IObservable<TResult>
    {
        private class Select : global::System.IObserver<TSource>
        {
            private global::UnityEngine.InputSystem.LowLevel.SelectObservable<TSource, TResult> m_Observable;
            private readonly global::System.IObserver<TResult> m_Observer;
            public Select(global::UnityEngine.InputSystem.LowLevel.SelectObservable<TSource, TResult> observable, global::System.IObserver<TResult> observer)
            {
            }

            public void OnCompleted()
            {
            }

            public void OnError(global::System.Exception error)
            {
            }

            public void OnNext(TSource evt)
            {
            }
        }

        private readonly global::System.IObservable<TSource> m_Source;
        private readonly global::System.Func<TSource, TResult> m_Filter;
        public SelectObservable(global::System.IObservable<TSource> source, global::System.Func<TSource, TResult> filter)
        {
        }

        public global::System.IDisposable Subscribe(global::System.IObserver<TResult> observer)
        {
            return null;
        }
    }
}