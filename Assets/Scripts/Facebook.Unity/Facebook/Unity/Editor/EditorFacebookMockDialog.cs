namespace Facebook.Unity.Editor
{
    internal abstract class EditorFacebookMockDialog : global::UnityEngine.MonoBehaviour
    {
        private global::UnityEngine.Rect modalRect;
        private global::UnityEngine.GUIStyle modalStyle;
        public global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> Callback { protected get; set; }
        public string CallbackID { protected get; set; }
        protected abstract string DialogTitle { get; }

        public void Start()
        {
        }

        public void OnGUI()
        {
        }

        protected abstract void DoGui();
        protected abstract void SendSuccessResult();
        protected virtual void SendCancelResult()
        {
        }

        protected virtual void SendErrorResult(string errorMessage)
        {
        }

        private void OnGUIDialog(int windowId)
        {
        }
    }
}