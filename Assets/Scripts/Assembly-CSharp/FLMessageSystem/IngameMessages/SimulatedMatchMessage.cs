namespace FLMessageSystem.IngameMessages
{
	public struct SimulatedMatchMessage
	{
		public enum StateType
		{
			StartPreMatchSimulation = 0,
			StartSimulationToEnd = 1,
			SimulationToEndDataCompleted = 2,
			SimulationToEndOver = 3
		}

		public MatchDataSimulator.SimulatedMatchData SimulatedMatch;

		public global::FLMessageSystem.IngameMessages.SimulatedMatchMessage.StateType State;
	}
}
