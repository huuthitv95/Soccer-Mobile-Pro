namespace FL
{
	public interface IClubPlayerRules
	{
		sbyte Rating(ClubPlayer player, FormationTool.UIPosition role);

		global::SL.Player.Hexagram Hexagram(ClubPlayer player, bool isGK);
	}
}
