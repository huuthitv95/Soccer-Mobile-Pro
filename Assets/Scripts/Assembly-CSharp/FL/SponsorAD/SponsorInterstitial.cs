namespace FL.SponsorAD
{
    public class SponsorInterstitial : global::UnityEngine.MonoBehaviour, global::FL.SponsorAD.ISponsorAD
    {
        [global::UnityEngine.SerializeField]
        private global::FL.SponsorAD.SponsorADCommonData commonData;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Button closeButton;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image cutdownProgressImage;
        private global::System.Action onCloseCallback;
        private void LogImpression()
        {
        }

        public void OpenURL()
        {
        }

        private global::System.Collections.IEnumerator DelayEnableCloseButton()
        {
            return null;
        }

        public bool Show(string pos, global::System.Action onClose)
        {
            return false;
        }

        public void Hide()
        {
        }
    }
}