namespace Google.Play.Common.LoadingScreen
{
    public class LoadingBar : global::UnityEngine.MonoBehaviour
    {
        public float OutlineWidth;
        public float InnerBorderWidth;
        public bool ResizeAutomatically;
        public float Progress;
        public global::UnityEngine.RectTransform Background;
        public global::UnityEngine.RectTransform Outline;
        public global::UnityEngine.RectTransform ProgressHolder;
        public global::UnityEngine.RectTransform ProgressFill;
        public float AssetBundleDownloadToInstallRatio;
        private void Update()
        {
        }

        public void ApplyBorderWidth()
        {
        }

        public void SetProgress(float proportionOfLoadingBar)
        {
        }

        public global::System.Collections.IEnumerator FillUntilDone(global::UnityEngine.AsyncOperation operation, float startingFillProportion, float endingFillProportion, bool skipFinalUpdate)
        {
            return null;
        }
    }
}