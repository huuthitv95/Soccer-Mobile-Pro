namespace Assets.Scripts.Ads
{
    internal class AdmobEarnedLog
    {
        private class EvaluateNewuser
        {
            private bool newuser;
            public bool Isnew()
            {
                return false;
            }

            private bool IsNewUser()
            {
                return false;
            }
        }

        private static global::System.Collections.Generic.List<int> _troas;
        private long _earnedValue;
        private long _fbEarnedValue;
        private global::System.Collections.Generic.List<long> _troasLTV;
        private static readonly string _earnedCurrency;
        private long _firstDayEarn;
        private long _lastCommitTime;
        private bool _initialed;
        private long[] _earnedByFormat;
        private int _currentDailyEarned;
        private int _lastDailyEarnDate;
        private global::Assets.Scripts.Ads.AdmobEarnedLog.EvaluateNewuser evaluateNewuser;
        public void OnEarned(global::Assets.Scripts.Ads.AdFormat eventname, object sender, global::GoogleMobileAds.Api.AdValue e, string tunnel)
        {
        }

        private void LogDailyEarn(long value)
        {
        }

        private void LoadEarned()
        {
        }

        private bool CheckEarnedEvent()
        {
            return false;
        }

        private void SendAdmob(long earnedValue, string currency)
        {
        }

        private void SendEarnedByToken(long earnedValue, string currency)
        {
        }

        private void LogNewUserLTV(long addvalue)
        {
        }

        private bool IsNewUser()
        {
            return false;
        }
    }
}