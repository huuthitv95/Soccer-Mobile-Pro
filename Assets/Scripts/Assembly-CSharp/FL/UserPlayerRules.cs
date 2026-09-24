namespace FL
{
	public class UserPlayerRules : global::FL.IClubPlayerRules
	{
		public static readonly global::FL.PlayerAbility[][] HexagramGroups;

		public static global::SL.Player.Hexagram ComputeHexagram(global::System.Func<global::FL.PlayerAbility, float> getValue, float boost = 0f)
		{
			return default;
		}

		private static float Avg(global::FL.PlayerAbility[] abilities, global::System.Func<global::FL.PlayerAbility, float> getter)
		{
			return 0f;
		}

		public global::SL.Player.Hexagram Hexagram(ClubPlayer player, bool isGK)
		{
			return default;
		}

		public static global::SL.Player.Hexagram HexagramWhitoutTemporaryBoost(ClubPlayer player, bool isGK)
		{
			return default;
		}

		public sbyte Rating(ClubPlayer player, FormationTool.UIPosition role)
		{
			return 0;
		}

		public static sbyte Rating(global::FLDataTable.UserPlayerTypeConfig playerTypeConfig, FormationTool.UIPosition role, global::FL.UserPlayerType playerType)
		{
			return 0;
		}

		public static sbyte RatingWithTemporaryEXP(in global::FL.PlayerExpStruct playerExp, ClubPlayer player)
		{
			return 0;
		}

		private static sbyte CalculateRating(ClubPlayer player, FormationTool.UIPosition role, in global::FL.PlayerExpStruct additionalExp, int temporaryBoost)
		{
			return 0;
		}
	}
}
