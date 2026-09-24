namespace GoogleMobileAds.Android
{
    public class NextGenAdInspectorCallback : global::UnityEngine.AndroidJavaProxy
    {
        private global::System.Action<global::GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction;
        public NextGenAdInspectorCallback(global::System.Action<global::GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction) : base((string)null)
        {
        }

        private void onAdInspectorClosed(global::UnityEngine.AndroidJavaObject error)
        {
        }
    }
}