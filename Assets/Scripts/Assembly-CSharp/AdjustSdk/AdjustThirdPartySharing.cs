namespace AdjustSdk
{
    public class AdjustThirdPartySharing
    {
        private global::System.Collections.Generic.List<string> innerGranularOptions;
        private global::System.Collections.Generic.List<string> innerPartnerSharingSettings;
        public bool? IsEnabled { get; private set; }
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> GranularOptions => null;
        public global::System.Collections.ObjectModel.ReadOnlyCollection<string> PartnerSharingSettings => null;

        public AdjustThirdPartySharing(bool? isEnabled)
        {
        }

        public void AddGranularOption(string partnerName, string key, string value)
        {
        }

        public void AddPartnerSharingSetting(string partnerName, string key, bool value)
        {
        }
    }
}