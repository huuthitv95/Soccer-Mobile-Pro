namespace Common
{
    public class RequestAdid
    {
        private class OnAdidCallback : global::UnityEngine.AndroidJavaProxy
        {
            public OnAdidCallback() : base((string)null)
            {
            }

            public void OnOperationFinish(bool succeed, global::UnityEngine.AndroidJavaObject adid)
            {
            }

            public void OnOperationFinish(bool succeed, string adid)
            {
            }
        }

        private static global::UnityEngine.AndroidJavaProxy _adidCB;
        private static void OnGetAdid(string id)
        {
        }

        public static void SendAdid()
        {
        }

        public static global::System.Collections.IEnumerator SendAdidRequest(string adid, global::System.Action onSuccess, global::System.Action onFailed = null)
        {
            return null;
        }

        public static int GetLATStatus()
        {
            return 0;
        }
    }
}