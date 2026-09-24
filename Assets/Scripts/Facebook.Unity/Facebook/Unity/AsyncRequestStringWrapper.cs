namespace Facebook.Unity
{
    internal class AsyncRequestStringWrapper : global::Facebook.Unity.IAsyncRequestStringWrapper
    {
        public void Request(global::System.Uri url, global::Facebook.Unity.HttpMethod method, global::UnityEngine.WWWForm query = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null)
        {
        }

        public void Request(global::System.Uri url, global::Facebook.Unity.HttpMethod method, global::System.Collections.Generic.IDictionary<string, string> formData = null, global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null)
        {
        }
    }
}