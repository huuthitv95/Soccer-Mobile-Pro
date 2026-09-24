public static class WeatherConfigs
{
    public enum Weather
    {
        None = 0,
        cloudless = 1,
        cloudy = 2,
        rain = 3,
        snow = 4
    }

    public enum Season
    {
        spring = 0,
        summer = 1,
        autumn = 2,
        winter = 3,
        NONE = 4
    }

    public class WeatherByMonth
    {
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<WeatherConfigs.Weather, int>>> weathers;
        public WeatherConfigs.Season[] seasons;
    }

    private static global::System.Collections.Generic.Dictionary<string, WeatherConfigs.WeatherByMonth> configs;
    public static void Load()
    {
    }

    public static WeatherConfigs.Weather RandomGet(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<WeatherConfigs.Weather, int>> src, int randomSeed)
    {
        return WeatherConfigs.Weather.None;
    }

    public static WeatherConfigs.Weather RandomGet(string nation, int month, int seed)
    {
        return WeatherConfigs.Weather.None;
    }

    public static WeatherConfigs.Season GetSeason(string nation, int month)
    {
        return WeatherConfigs.Season.spring;
    }
}