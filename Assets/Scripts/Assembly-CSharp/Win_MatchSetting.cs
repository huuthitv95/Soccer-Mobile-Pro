public class Win_MatchSetting : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIMatchDuration matchDuration;
    [global::UnityEngine.SerializeField]
    private NormalDifficultyOption difficulty;
    [global::UnityEngine.SerializeField]
    private SwitchToggles ExtraTime;
    [global::UnityEngine.SerializeField]
    private SwitchToggles penalty;
    [global::UnityEngine.SerializeField]
    private GUIWheel weather;
    [global::UnityEngine.SerializeField]
    private GUIWheel time;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] weatherIcons;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] timeIcons;
    private const string matchDurationKey = "friendly_match_duration";
    private const string matchDifficultyKey = "friendlyDifficulty";
    private const string extraTimeKey = "friendlyExtraTime";
    private const string penaltyKey = "friendlyPenalty";
    private const string weatherKey = "friendly_weather";
    private const string timeKey = "friendly_time";
    private CupMatchBase match;
    private global::System.Collections.Generic.List<int> timelist;
    public override void OnOpen(object parameter)
    {
    }

    public void UpdateWeather(WeatherConfigs.Weather current)
    {
    }

    public void UpdateTime(int current)
    {
    }

    public override void OnClose()
    {
    }
}