public class MatchDurationSettingManager
{
    public struct MatchLegthConfig
    {
        public int[] display;
        public float[] option;
        public int defaultIdx;
    }

    private string saveKey;
    public static global::System.Collections.Generic.Dictionary<int, MatchDurationSettingManager.MatchLegthConfig> matchLenghtPlan;
    public MatchDurationSettingManager(string saveKey)
    {
    }

    private static int GetMatchLenghtPlant()
    {
        return 0;
    }

    private static int DefaultMatchLenght()
    {
        return 0;
    }

    public float GetMatchDuration()
    {
        return 0f;
    }

    public int GetMatchDurationDisplay()
    {
        return 0;
    }

    public MatchDurationSettingManager.MatchLegthConfig GetCurrentMatchLengthConfig()
    {
        return default;
    }

    public int GetCurrentMatchLengthIndex()
    {
        return 0;
    }

    public void SetMatchLengthIndex(int idx)
    {
    }
}