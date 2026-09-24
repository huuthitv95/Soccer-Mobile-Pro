namespace FLMessageSystem.IngameMessages
{
	public struct TeamFormationChange
	{
		public bool isHome;

		public TeamsData TeamsData;

		public TeamFormationChange(bool ishome, TeamsData teamsData)
		{
			isHome = false;
			TeamsData = null;
		}
	}
}
