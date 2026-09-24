namespace GooglePlayGames.Android
{
    internal class AndroidTaskUtils
    {
        private class TaskOnCompleteProxy<T> : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<T> mCallback;
            public TaskOnCompleteProxy(global::System.Action<T> callback) : base((string)null)
            {
            }

            public void onComplete(T result)
            {
            }
        }

        private class TaskOnSuccessProxy<T> : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<T> mCallback;
            private bool mDisposeResult;
            public TaskOnSuccessProxy(global::System.Action<T> callback, bool disposeResult) : base((string)null)
            {
            }

            public void onSuccess(T result)
            {
            }
        }

        private class TaskOnFailedProxy : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::UnityEngine.AndroidJavaObject> mCallback;
            public TaskOnFailedProxy(global::System.Action<global::UnityEngine.AndroidJavaObject> callback) : base((string)null)
            {
            }

            public void onFailure(global::UnityEngine.AndroidJavaObject exception)
            {
            }
        }

        private AndroidTaskUtils()
        {
        }

        public static void AddOnSuccessListener<T>(global::UnityEngine.AndroidJavaObject task, global::System.Action<T> callback)
        {
        }

        public static void AddOnSuccessListener<T>(global::UnityEngine.AndroidJavaObject task, bool disposeResult, global::System.Action<T> callback)
        {
        }

        public static void AddOnFailureListener(global::UnityEngine.AndroidJavaObject task, global::System.Action<global::UnityEngine.AndroidJavaObject> callback)
        {
        }

        public static void AddOnCompleteListener<T>(global::UnityEngine.AndroidJavaObject task, global::System.Action<T> callback)
        {
        }
    }
}