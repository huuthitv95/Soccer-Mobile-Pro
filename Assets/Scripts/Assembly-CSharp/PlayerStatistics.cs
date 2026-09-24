public class PlayerStatistics
{
    private global::System.Collections.Generic.LinkedList<global::System.Collections.Generic.KeyValuePair<FormationTool.PlayerCategory, int>> categoryStatistics;
    private short[] EventStatistics;
    private short[] EventStatisticsOffset;
    private global::System.Collections.Generic.List<global::FLMessageSystem.FullPlayerStatisticsType> _params;
    public global::System.Action<global::System.Collections.Generic.IEnumerable<global::FLMessageSystem.FullPlayerStatisticsType>> EventChangedNotifier;
    public global::System.Action<global::FLMessageSystem.FullPlayerStatisticsType> OnEventAddedNotifier;
    private global::System.Collections.Generic.List<global::FLMessageSystem.FullPlayerStatisticsType> _params2;
    private int goalsConceded;
    private float[] goalRating;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> goalCoefficient;
    private float[] assistRating;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> assistCoefficient;
    private float[] goalsConcededRating;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> goalsConcededCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> savesCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> successfulTacklesCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> interceptionsCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> clearancesCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> keyPassesCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> passingAccuracyCoefficient;
    private global::System.Collections.Generic.Dictionary<FormationTool.PlayerCategory, float> shotsOnTargetCoefficient;
    public void OnCategoryChanged(FormationTool.UIRole role, int time)
    {
    }

    public void SetEventCountOffset(global::FLMessageSystem.FullPlayerStatisticsType eventType, short offset)
    {
    }

    public short GetEventCount(global::FLMessageSystem.FullPlayerStatisticsType eventType)
    {
        return 0;
    }

    private bool UpdateAndCheckChanged(global::FLMessageSystem.FullPlayerStatisticsType eventType, short newValue)
    {
        return false;
    }

    public global::System.Collections.Generic.IEnumerable<global::FLMessageSystem.FullPlayerStatisticsType> UpdateFromAIData(global::EngineMessages.PlayerStatistics data)
    {
        return null;
    }

    public void AddEvent(global::FLMessageSystem.FullPlayerStatisticsType eventType)
    {
    }

    public void ResetEvent(global::FLMessageSystem.FullPlayerStatisticsType eventType)
    {
    }

    public void OnFakeMatchFinish()
    {
    }

    public float CalculateRating(int playingTime, int teamRatingGap, int matchResult, int goalsConcededRegularTime)
    {
        return 0f;
    }

    private FormationTool.PlayerCategory CalculateLongestHeldCategory()
    {
        return FormationTool.PlayerCategory.Forward;
    }

    private float CalculatePlayingTimeCoefficient(int playingTime)
    {
        return 0f;
    }

    private float CalculateMatchResultRating(int teamRatingGap, int matchResult)
    {
        return 0f;
    }

    private float CalculateRatingWithCoefficient(float[] rating, int count, float coefficient)
    {
        return 0f;
    }

    private float CalculateSaveRating(float coefficient)
    {
        return 0f;
    }

    private float CalculateSuccessfulTacklesRating(float coefficient)
    {
        return 0f;
    }

    private float CalculateInterceptionsRating(float coefficient)
    {
        return 0f;
    }

    private float CalculateClearancesRating(FormationTool.PlayerCategory playerCategory)
    {
        return 0f;
    }

    private float CalculateKeyPassesRating(FormationTool.PlayerCategory playerCategory)
    {
        return 0f;
    }

    private float CalculatePassingAccuracyRating(float coefficient)
    {
        return 0f;
    }

    private float CalculateShotsOnTargetRating(FormationTool.PlayerCategory playerCategory)
    {
        return 0f;
    }
}