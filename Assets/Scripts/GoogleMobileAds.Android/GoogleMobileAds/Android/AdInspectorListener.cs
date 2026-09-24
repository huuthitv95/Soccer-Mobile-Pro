namespace GoogleMobileAds.Android
{
    public class AdInspectorListener : global::UnityEngine.AndroidJavaProxy
    {
        private global::System.Action<global::GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction;
        public AdInspectorListener(global::System.Action<global::GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction) : base((string)null)
        {
        }

        private void onAdInspectorClosed(global::UnityEngine.AndroidJavaObject error)
        {
        }
    }
}