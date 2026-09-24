namespace FL
{
	public struct PlayerCareerRebirthSetupConstraints
	{
		public FormationTool.UIPosition LockedPosition { get; private set; }

		public int RetiredSeasonYear { get; private set; }

		public int RetiredRawAbility { get; private set; }

		public int TargetRawAbility { get; private set; }

		public int RebirthAge { get; private set; }

		public PlayerCareerRebirthSetupConstraints(global::Srv.PlayerCareerPendingRebirth pendingRebirth)
		{
			LockedPosition = FormationTool.UIPosition.GK;
			RetiredSeasonYear = 0;
			RetiredRawAbility = 0;
			TargetRawAbility = 0;
			RebirthAge = 0;
		}
	}
}
