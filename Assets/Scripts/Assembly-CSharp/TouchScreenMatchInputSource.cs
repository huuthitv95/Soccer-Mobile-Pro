public sealed class TouchScreenMatchInputSource : IMatchScreenInputSource
{
    private readonly TouchInputSystem touchInput;
    public TouchScreenMatchInputSource(TouchInputSystem touchInput)
    {
    }

    public bool Matches(TouchInputSystem input)
    {
        return false;
    }

    public void Configure(int deviceId, int teamId, int playerId)
    {
    }

    public void SetMatchState(bool offensive, int possessionPlayerId)
    {
    }

    public void CollectEvents(ref global::EngineMessages.InputData eventList)
    {
    }

    public void ResetInput(bool resetAll)
    {
    }
}