public class MatchScheduleInfo
{
    private WeatherConfigs.Weather weather;
    private WeatherConfigs.Season season;
    private global::System.DateTime defaultDate;
    private global::System.DateTime date;
    private CupMatchBase match;
    public WeatherConfigs.Weather Weather => WeatherConfigs.Weather.None;
    public WeatherConfigs.Season Season => WeatherConfigs.Season.spring;
    public global::System.DateTime Date => default;

    public void SetWeather(WeatherConfigs.Weather weather)
    {
    }

    public void SetDate(global::System.DateTime date)
    {
    }

    public MatchScheduleInfo(CupMatchBase match)
    {
    }
}