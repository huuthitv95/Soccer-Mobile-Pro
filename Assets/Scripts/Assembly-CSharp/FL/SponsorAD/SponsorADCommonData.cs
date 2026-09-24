namespace FL.SponsorAD
{
    [global::System.Serializable]
    public struct SponsorADCommonData
    {
        [global::UnityEngine.SerializeField]
        private LanguageSetting.eLanguage[] language;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject[] elementByLanguage;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject defaultElement;
        [global::UnityEngine.SerializeField]
        public string url;
        [global::UnityEngine.SerializeField]
        public global::FL.SponsorAD.SponsorType sponsorType;
        [global::UnityEngine.SerializeField]
        public int groupId;
        private bool isInited;
        public void Init()
        {
        }
    }
}