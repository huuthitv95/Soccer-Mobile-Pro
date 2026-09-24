namespace FL
{
	public class NormalPlayerRules : global::FL.IPlayerRatingRule, global::FL.IClubPlayerRules
	{
		public global::SL.Player.Hexagram Hexagram(global::SL.Player player, bool isGK)
		{
			return default;
		}

		public sbyte Rating(global::SL.Player player, FormationTool.UIPosition role)
		{
			return 0;
		}

		public global::SL.Player.Hexagram Hexagram(ClubPlayer player, bool isGK)
		{
			return default;
		}

		public sbyte Rating(ClubPlayer player, FormationTool.UIPosition role)
		{
			return 0;
		}
	}
}
