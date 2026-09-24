public sealed class FirebaseAnalyticsEventLogger
{
    public global::System.Func<string, bool> IsEventBlackList;
    private bool IsInBlackList(string eventName)
    {
        return false;
    }

    public void LogEvent(string name)
    {
    }

    public void LogEvent(string name, string parameterName, long parameterValue)
    {
    }

    public void LogEvent(string name, string parameterName, string parameterValue)
    {
    }

    public void LogEvent(string name, params EventLog.Param[] parameters)
    {
    }
}