public class IngameGraphicsOptions
{
	public bool IsLowDevice { get; private set; }

	public WeatherConfigs.Weather weather { get; private set; }

	public bool EnableRainSFX { get; private set; }

	public bool EnableSnowSFX { get; private set; }

	public IngameGraphicsOptions(WeatherConfigs.Weather weather)
	{
	}
}
