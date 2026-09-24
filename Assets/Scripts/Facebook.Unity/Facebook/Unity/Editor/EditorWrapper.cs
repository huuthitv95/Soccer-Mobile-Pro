namespace Facebook.Unity.Editor
{
    internal class EditorWrapper : global::Facebook.Unity.Editor.IEditorWrapper
    {
        private global::Facebook.Unity.IFacebookCallbackHandler callbackHandler;
        public EditorWrapper(global::Facebook.Unity.IFacebookCallbackHandler callbackHandler)
        {
        }

        public void Init()
        {
        }

        public void ShowLoginMockDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions)
        {
        }

        public void ShowAppRequestMockDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string callbackId)
        {
        }

        public void ShowMockShareDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId)
        {
        }

        public void ShowMockFriendFinderDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId)
        {
        }

        private void ShowEmptyMockDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string callbackId, string title)
        {
        }
    }
}