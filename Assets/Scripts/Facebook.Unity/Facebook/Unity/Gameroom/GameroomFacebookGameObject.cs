namespace Facebook.Unity.Gameroom
{
    internal class GameroomFacebookGameObject : global::Facebook.Unity.FacebookGameObject, global::Facebook.Unity.IFacebookCallbackHandler
    {
        protected global::Facebook.Unity.Gameroom.IGameroomFacebookImplementation GameroomFacebookImpl => null;

        public void WaitForResponse(global::Facebook.Unity.Gameroom.GameroomFacebook.OnComplete onCompleteDelegate, string callbackId)
        {
        }

        protected override void OnAwake()
        {
        }

        private global::System.Collections.IEnumerator WaitForPipeResponse(global::Facebook.Unity.Gameroom.GameroomFacebook.OnComplete onCompleteDelegate, string callbackId)
        {
            return null;
        }
    }
}