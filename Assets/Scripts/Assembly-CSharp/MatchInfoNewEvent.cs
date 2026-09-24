internal struct MatchInfoNewEvent
{
    private bool enabled;
    private CupMatchBase match;
    private TestSample aiSample;
    public void LogEvent(global::EngineMessages.MatchStatistics stats, InGamePlayer[] userPlayers, InGamePlayer[] cpuPlayers)
    {
    }

    public MatchInfoNewEvent(TestSample sample, CupMatchBase match)
    {
        enabled = false;
        this.match = null;
        aiSample = null;
    }
}