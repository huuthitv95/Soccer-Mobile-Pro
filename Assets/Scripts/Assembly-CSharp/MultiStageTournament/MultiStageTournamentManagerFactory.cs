namespace MultiStageTournament
{
	public static class MultiStageTournamentManagerFactory
	{
		public static bool SupportType(string baseType)
		{
			return false;
		}

		public static global::MultiStageTournament.IMultiStageTournamentManager CreateManager(string baseType, int id)
		{
			return null;
		}
	}
}
