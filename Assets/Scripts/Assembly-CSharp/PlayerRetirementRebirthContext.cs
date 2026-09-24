public class PlayerRetirementRebirthContext
{
    private class MarketPlayers
    {
        private readonly global::System.Collections.Generic.Dictionary<int, ClubPlayer> allPlayers;
        private readonly global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::System.Collections.Generic.SortedDictionary<int, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>>>> ratingIndex;
        private readonly global::System.Collections.Generic.Dictionary<int, int> playerRatings;
        private readonly RegionalLeague regionalLeague;
        public MarketPlayers(RegionalLeague regionalLeague)
        {
        }

        private void AddPlayer(ClubPlayer player)
        {
        }

        public void Refresh(global::System.Collections.Generic.List<ClubPlayer> players)
        {
        }

        public ClubPlayer GetReplacerPlayer(ClubPlayer clubPlayer, bool needCheckNation)
        {
            return null;
        }

        private void Rebirth(ClubPlayer clubPlayer)
        {
        }

        private float CalculateRating(global::SL.Player proto, int rebirthAge, float potential, int adjustedPrimeAge)
        {
            return 0f;
        }
    }

    private readonly RegionalLeague regionalLeague;
    private readonly PlayerRetirementRebirthContext.MarketPlayers marketPlayers;
    public PlayerRetirementRebirthContext(RegionalLeague regionalLeague)
    {
    }

    public void SystemPlayer2Market()
    {
    }

    public void RefreshMarketPlayers()
    {
    }

    public void CheckPlayerRetirement(TeamsData team, ClubPlayer clubPlayer, bool needSupply, global::System.Action<TeamsData, ClubPlayer> onRetirement)
    {
    }

    public static float RetirementCeffByPos(FormationTool.UIPosition pos)
    {
        return 0f;
    }

    public void HandleRetirementCore(TeamsData team, ClubPlayer clubPlayer, global::System.Action<ClubPlayer> onUserTeamRetired)
    {
    }

    public void SupplyPlayer(TeamsData team, ClubPlayer clubPlayer)
    {
    }
}