namespace Facebook.Unity
{
    internal abstract class FacebookGameObject : global::UnityEngine.MonoBehaviour, global::Facebook.Unity.IFacebookCallbackHandler
    {
        public global::Facebook.Unity.IFacebookImplementation Facebook { get; set; }

        public void Awake()
        {
        }

        public void OnInitComplete(string message)
        {
        }

        public void OnLoginComplete(string message)
        {
        }

        public void OnLogoutComplete(string message)
        {
        }

        public void OnGetAppLinkComplete(string message)
        {
        }

        public void OnAppRequestsComplete(string message)
        {
        }

        public void OnShareLinkComplete(string message)
        {
        }

        protected virtual void OnAwake()
        {
        }
    }
}