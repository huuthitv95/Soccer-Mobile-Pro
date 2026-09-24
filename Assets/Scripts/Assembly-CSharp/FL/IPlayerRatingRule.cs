namespace FL
{
	public interface IPlayerRatingRule
	{
		sbyte Rating(global::SL.Player player, FormationTool.UIPosition role);

		global::SL.Player.Hexagram Hexagram(global::SL.Player player, bool isGK);
	}
}
