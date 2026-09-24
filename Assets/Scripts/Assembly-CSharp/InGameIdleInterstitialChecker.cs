public class InGameIdleInterstitialChecker : global::Common.Singleton<InGameIdleInterstitialChecker>
{
    private const int limit = 8;
    private global::System.DateTime startTm;
    private global::System.DateTime pauseTm;
    private bool isEnabled;
    private global::System.DateTime pauseStartTime;
    private string position;
    public const string formation = "formation_idle";
    public const string setting = "setting_idle";
    public void Enable()
    {
    }

    public void Disable()
    {
    }

    public void Start(string pos)
    {
    }

    public void Pause()
    {
    }

    public void Resume()
    {
    }

    public void Check()
    {
    }
}