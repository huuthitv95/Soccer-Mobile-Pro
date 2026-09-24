namespace Firebase.Unity
{
    [global::UnityEngine.Scripting.Preserve]
    internal class UnitySynchronizationContext : global::System.Threading.SynchronizationContext
    {
        private class SynchronizationContextBehavoir : global::UnityEngine.MonoBehaviour
        {
            private global::System.Collections.Generic.Queue<global::System.Tuple<global::System.Threading.SendOrPostCallback, object>> callbackQueue;
            public global::System.Collections.Generic.Queue<global::System.Tuple<global::System.Threading.SendOrPostCallback, object>> CallbackQueue => null;

            [global::UnityEngine.Scripting.Preserve]
            private global::System.Collections.IEnumerator Start()
            {
                return null;
            }
        }

        private static global::Firebase.Unity.UnitySynchronizationContext _instance;
        private global::System.Collections.Generic.Queue<global::System.Tuple<global::System.Threading.SendOrPostCallback, object>> queue;
        private global::Firebase.Unity.UnitySynchronizationContext.SynchronizationContextBehavoir behavior;
        private int mainThreadId;
        private static global::System.Collections.Generic.Dictionary<int, global::System.Threading.ManualResetEvent> signalDictionary;
        private UnitySynchronizationContext(global::UnityEngine.GameObject gameObject)
        {
        }

        public static void Create(global::UnityEngine.GameObject gameObject)
        {
        }

        public static void Destroy()
        {
        }

        private global::System.Threading.ManualResetEvent GetThreadEvent()
        {
            return null;
        }

        public override void Post(global::System.Threading.SendOrPostCallback d, object state)
        {
        }

        public override void Send(global::System.Threading.SendOrPostCallback d, object state)
        {
        }
    }
}