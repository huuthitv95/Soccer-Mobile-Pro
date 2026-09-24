public struct PlayerPassEvent
{
    private bool enabled;
    private EventLog.Param[] parameters;
    private CupMatchBase match;
    public void LogEvent(global::EngineMessages.PassEvent passEvent, AISampleBase sample)
    {
    }

    public PlayerPassEvent(CupMatchBase match, AISampleBase sample)
    {
        enabled = false;
        parameters = null;
        this.match = null;
    }
}