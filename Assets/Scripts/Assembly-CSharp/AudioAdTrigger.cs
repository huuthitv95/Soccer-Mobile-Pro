public class AudioAdTrigger : global::Common.Singleton<AudioAdTrigger>
{
    public struct OnceOnlyTrigger
    {
        private string pos;
        private bool triggered;
        public bool Trigger()
        {
            return false;
        }

        public OnceOnlyTrigger(string pos)
        {
            this.pos = null;
            triggered = false;
        }
    }

    private (int, int) minInterval;
    private global::System.DateTime minIntervalLastUpdateTime;
    private bool showingAd;
    private global::System.DateTime lastShowTime;
    private (int, int) MinInterval => default;

    public void CheckInitSdk(bool isPreloadInterstitial)
    {
    }

    public void CheckLoadAD()
    {
    }

    public void OnApplicationPause(bool pause)
    {
    }

    public bool ShowAD(string pos)
    {
        return false;
    }

    public bool Showing()
    {
        return false;
    }

    public void StopAD()
    {
    }
}