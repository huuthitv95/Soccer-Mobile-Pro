namespace Facebook.Unity
{
    internal class CallbackManager
    {
        private global::System.Collections.Generic.IDictionary<string, object> facebookDelegates;
        private int nextAsyncId;
        public string AddFacebookDelegate<T>(global::Facebook.Unity.FacebookDelegate<T> callback)
            where T : global::Facebook.Unity.IResult
        {
            return null;
        }

        public void OnFacebookResponse(global::Facebook.Unity.IInternalResult result)
        {
        }

        private static void CallCallback(object callback, global::Facebook.Unity.IResult result)
        {
        }

        private static bool TryCallCallback<T>(object callback, global::Facebook.Unity.IResult result)
            where T : global::Facebook.Unity.IResult
        {
            return false;
        }
    }
}