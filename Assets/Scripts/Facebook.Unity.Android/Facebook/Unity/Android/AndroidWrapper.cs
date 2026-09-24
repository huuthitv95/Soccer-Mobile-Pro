namespace Facebook.Unity.Android
{
    internal class AndroidWrapper
    {
        private const string FacebookJavaClassName = "com.facebook.unity.FB";
        private global::UnityEngine.AndroidJavaClass facebookJavaClass;
        public T CallStatic<T>(string methodName)
        {
            return default;
        }

        public void CallStatic(string methodName, params object[] args)
        {
        }
    }
}