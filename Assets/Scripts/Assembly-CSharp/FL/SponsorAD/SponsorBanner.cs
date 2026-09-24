namespace FL.SponsorAD
{
    public class SponsorBanner : global::UnityEngine.MonoBehaviour, global::FL.SponsorAD.ISponsorAD
    {
        [global::UnityEngine.SerializeField]
        private global::FL.SponsorAD.SponsorADCommonData commonData;
        private const float ImpressionInterval = 30f;
        private float accumulatedDisplayTime;
        private bool isApplicationPaused;
        private bool active;
        public void MarkActive()
        {
        }

        private void OnEnable()
        {
        }

        private void OnApplicationPause(bool paused)
        {
        }

        public void Show()
        {
        }

        public void Hide()
        {
        }

        public void OpenURL()
        {
        }

        private void LogImpression()
        {
        }
    }
}