namespace Google.Play.Core.Internal
{
    public class PlayServicesTask<TAndroidJava> : global::System.IDisposable
    {
        private readonly global::UnityEngine.AndroidJavaObject _javaTask;
        public PlayServicesTask(global::UnityEngine.AndroidJavaObject javaTask)
        {
        }

        public void RegisterOnSuccessCallback(global::System.Action<TAndroidJava> onSuccess)
        {
        }

        public void RegisterOnFailureCallback(global::System.Action<string, int> onFailure)
        {
        }

        private void AddOnSuccessListener(global::UnityEngine.AndroidJavaProxy listenerProxy)
        {
        }

        private void AddOnFailureListener(global::UnityEngine.AndroidJavaProxy listenerProxy)
        {
        }

        public void Dispose()
        {
        }
    }
}