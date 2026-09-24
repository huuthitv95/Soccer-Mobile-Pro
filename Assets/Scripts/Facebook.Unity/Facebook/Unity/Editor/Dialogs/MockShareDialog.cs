namespace Facebook.Unity.Editor.Dialogs
{
    internal class MockShareDialog : global::Facebook.Unity.Editor.EditorFacebookMockDialog
    {
        public string SubTitle { private get; set; }
        protected override string DialogTitle => null;

        protected override void DoGui()
        {
        }

        protected override void SendSuccessResult()
        {
        }

        protected override void SendCancelResult()
        {
        }

        private string GenerateFakePostID()
        {
            return null;
        }
    }
}