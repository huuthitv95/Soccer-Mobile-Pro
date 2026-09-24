namespace Facebook.Unity.Canvas
{
    internal class CanvasFacebookGameObject : global::Facebook.Unity.FacebookGameObject, global::Facebook.Unity.Canvas.ICanvasFacebookCallbackHandler, global::Facebook.Unity.IFacebookCallbackHandler
    {
        protected global::Facebook.Unity.Canvas.ICanvasFacebookImplementation CanvasFacebookImpl => null;

        public void OnPayComplete(string result)
        {
        }

        public void OnFacebookAuthResponseChange(string message)
        {
        }

        public void OnUrlResponse(string message)
        {
        }

        public void OnHideUnity(bool hide)
        {
        }

        protected override void OnAwake()
        {
        }
    }
}