namespace FL
{
    public class PlayerCareerSeasonStatsManager
    {
        private readonly global::Srv.PlayerCareerSeasonStatsArchive archive;
        private readonly PlayerCareerLocalArchives store;
        public global::System.Collections.Generic.IEnumerable<global::Srv.PlayerCareerSeasonStats> Seasons => null;

        public PlayerCareerSeasonStatsManager(global::Srv.PlayerCareerSeasonStatsArchive archive, PlayerCareerLocalArchives store)
        {
        }

        public global::Srv.PlayerCareerSeasonStats EnsureSeason(int seasonYear, ClubPlayer player, FixtureListData fixtureListData)
        {
            return null;
        }

        public void RecordMatch(int seasonYear, ClubPlayer player, FixtureListData fixtureListData, CupMatchBase.MatchSettlementData match)
        {
        }

        public void CompleteSeason(int seasonYear, ClubPlayer player, FixtureListData fixtureListData)
        {
        }

        private void RecordTopRankStats(global::Srv.PlayerCareerSeasonStats season, ClubPlayer player, FixtureListData fixtureListData)
        {
        }

        private global::Srv.PlayerCareerSeasonStats FindSeason(int seasonYear)
        {
            return null;
        }

        private void CaptureSeasonStartSnapshot(global::Srv.PlayerCareerSeasonStats season, ClubPlayer player)
        {
        }

        private void CaptureSeasonContext(global::Srv.PlayerCareerSeasonStats season, ClubPlayer player, FixtureListData fixtureListData)
        {
        }

        private InGamePlayer FindUserPlayer(CupMatchBase.MatchSettlementData match, int playerId)
        {
            return null;
        }

        private int MatchStatisticCount(global::System.Collections.Generic.IDictionary<int, int> matchStatistics, int playerId)
        {
            return 0;
        }

        private bool PlayerIsTopRank(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> rank, int playerId)
        {
            return false;
        }

        private void RecordMatchResult(global::Srv.PlayerCareerSeasonStats season, CupMatchBase match)
        {
        }

        private void RecordIngameRating(global::Srv.PlayerCareerSeasonStats season, ClubPlayer player, InGamePlayer userPlayer)
        {
        }
    }
}