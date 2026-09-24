public interface IMatchScreenInputSource
{
	void Configure(int deviceId, int teamId, int playerId);

	void SetMatchState(bool offensive, int possessionPlayerId);

	void CollectEvents(ref global::EngineMessages.InputData eventList);

	void ResetInput(bool resetAll);
}
