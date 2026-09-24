namespace Facebook.Unity
{
    internal class AsyncRequestString : global::UnityEngine.MonoBehaviour
    {
        private global::System.Uri url;
        private global::Facebook.Unity.HttpMethod method;
        private global::System.Collections.Generic.IDictionary<string, string> formData;
        private global::UnityEngine.WWWForm query;
        private global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback;
        internal static void Post(global::System.Uri url, global::System.Collections.Generic.Dictionary<string, string> formData = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null)
        {
        }

        internal static void Get(global::System.Uri url, global::System.Collections.Generic.Dictionary<string, string> formData = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null)
        {
        }

        internal static void Request(global::System.Uri url, global::Facebook.Unity.HttpMethod method, global::UnityEngine.WWWForm query = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null)
        {
        }

        internal static void Request(global::System.Uri url, global::Facebook.Unity.HttpMethod method, global::System.Collections.Generic.IDictionary<string, string> formData = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null)
        {
        }

        internal global::System.Collections.IEnumerator Start()
        {
            return null;
        }

        internal global::Facebook.Unity.AsyncRequestString SetUrl(global::System.Uri url)
        {
            return null;
        }

        internal global::Facebook.Unity.AsyncRequestString SetMethod(global::Facebook.Unity.HttpMethod method)
        {
            return null;
        }

        internal global::Facebook.Unity.AsyncRequestString SetFormData(global::System.Collections.Generic.IDictionary<string, string> formData)
        {
            return null;
        }

        internal global::Facebook.Unity.AsyncRequestString SetQuery(global::UnityEngine.WWWForm query)
        {
            return null;
        }

        internal global::Facebook.Unity.AsyncRequestString SetCallback(global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback)
        {
            return null;
        }
    }
}