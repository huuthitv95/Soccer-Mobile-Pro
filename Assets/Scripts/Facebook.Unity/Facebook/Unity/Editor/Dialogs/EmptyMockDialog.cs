namespace Facebook.Unity.Editor.Dialogs
{
    internal class EmptyMockDialog : global::Facebook.Unity.Editor.EditorFacebookMockDialog
    {
        public string EmptyDialogTitle { get; set; }
        protected override string DialogTitle => null;

        protected override void DoGui()
        {
        }

        protected override void SendSuccessResult()
        {
        }
    }
}