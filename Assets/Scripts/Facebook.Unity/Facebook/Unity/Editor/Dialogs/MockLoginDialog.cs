namespace Facebook.Unity.Editor.Dialogs
{
    internal class MockLoginDialog : global::Facebook.Unity.Editor.EditorFacebookMockDialog
    {
        private string accessToken;
        protected override string DialogTitle => null;

        protected override void DoGui()
        {
        }

        protected override void SendSuccessResult()
        {
        }
    }
}