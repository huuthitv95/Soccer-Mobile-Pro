public class GeneralScoutManager : RegionalLeagueEventListener
{
    private class PlayerIndexSet
    {
        private global::Motvin.Collections.FastHashSet<ClubPlayer> AllPlayers;
        private global::System.Collections.Generic.Dictionary<int, global::Motvin.Collections.FastHashSet<ClubPlayer>> RegionIndex;
        private global::System.Collections.Generic.Dictionary<int, global::Motvin.Collections.FastHashSet<ClubPlayer>> RatingIndex;
        private global::System.Collections.Generic.Dictionary<int, global::Motvin.Collections.FastHashSet<ClubPlayer>> AgeIndex;
        private global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::Motvin.Collections.FastHashSet<ClubPlayer>> PositionIndex;
        private static global::System.Collections.Generic.Dictionary<int, int> regionSetCapacityInfo;
        private static global::System.Collections.Generic.Dictionary<int, int> ratingSetCapacityInfo;
        private static global::System.Collections.Generic.Dictionary<int, int> ageSetCapacityInfo;
        private static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, int> positionSetCapacityInfo;
        private static void CheckSetCapacity()
        {
        }

        public void Clear()
        {
        }

        private void AddToIndex<TKey>(global::System.Collections.Generic.Dictionary<TKey, global::Motvin.Collections.FastHashSet<ClubPlayer>> index, TKey key, ClubPlayer player, global::System.Collections.Generic.Dictionary<TKey, int> capacityInfo)
        {
        }

        public void AddPlayer(ClubPlayer player)
        {
        }

        public global::System.Collections.Generic.List<ClubPlayer> FindPlayers(string region, int minRating, int maxRating, int minAge, int maxAge, global::System.Collections.Generic.List<FormationTool.UIPosition> pos, global::System.Collections.Generic.List<ClubPlayer> exclude)
        {
            return null;
        }

        private global::Motvin.Collections.FastHashSet<ClubPlayer> IntersectIndex(global::Motvin.Collections.FastHashSet<ClubPlayer> currentSet, global::System.Collections.Generic.Dictionary<int, global::Motvin.Collections.FastHashSet<ClubPlayer>> index, int minValue, int maxValue)
        {
            return null;
        }

        private global::Motvin.Collections.FastHashSet<ClubPlayer> IntersectIndex(global::Motvin.Collections.FastHashSet<ClubPlayer> currentSet, global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::Motvin.Collections.FastHashSet<ClubPlayer>> index, global::System.Collections.Generic.List<FormationTool.UIPosition> values)
        {
            return null;
        }
    }

    public enum RandomResult
    {
        Normal = 0,
        Good = 1,
        Bad = 2,
        Splendid = 3
    }

    public enum Error
    {
        None = 0,
        NotEnoughMoney = 1,
        NotEnoughPlayer = 2,
        PlayerCountLimit = 3
    }

    public enum PosScout
    {
        All = 0,
        Forwards = 1,
        wingers = 2,
        centre_front = 3,
        defensive_midfielder = 4,
        centre_back = 5,
        wing_back = 6,
        GK = 7,
        None = 8
    }

    private GeneralScoutManager.PlayerIndexSet AllClubPlayer;
    private global::System.Collections.Generic.Dictionary<int, int> playerClubMap;
    private global::Srv.ScoutArchive archive;
    private global::FLGameProgressSetting.LocalArchives storer;
    public static global::System.Collections.Generic.SortedSet<string> Regions;
    public int FreeRefreshTimes => 0;
    public RegionalLeague RegionalLeague { get; private set; }

    public bool LockAutoRefresh
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool NewPlayerTip => false;

    void RegionalLeagueEventListener.OnChooseTeam()
    {
    }

    void RegionalLeagueEventListener.OnInitialize()
    {
    }

    private void RefreshPlayerClubMap(bool isInit = false)
    {
    }

    public void UpdatePlayerClubMap(int playerId, int teamId)
    {
    }

    void RegionalLeagueEventListener.OnUpdateRound()
    {
    }

    void RegionalLeagueEventListener.OnFinishSeason()
    {
    }

    void RegionalLeagueEventListener.OnUpdateSeason()
    {
    }

    void RegionalLeagueEventListener.OnRest()
    {
    }

    public void CheckFreeRefresh()
    {
    }

    public int GetBargainSessionSeed()
    {
        return 0;
    }

    private int GetFinishedMatchProgress()
    {
        return 0;
    }

    public int GetBargainCount(int playerId)
    {
        return 0;
    }

    public void SetBargainCount(int playerId, int count)
    {
    }

    public void ClearBargainCount(int playerId)
    {
    }

    public void ResetBargainCounts()
    {
    }

    public GeneralScoutManager(RegionalLeague league, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    public GeneralScoutManager.RandomResult GetRandomResult(bool CheckSplendid = false)
    {
        return GeneralScoutManager.RandomResult.Normal;
    }

    private void RefreshPlayers(global::System.Collections.Generic.List<GeneralScoutManager.RandomResult> randomResults)
    {
    }

    private void RefreshWhenChooseTeam()
    {
    }

    public void Refresh(bool isFree, GeneralScoutManager.PosScout pos = GeneralScoutManager.PosScout.None)
    {
    }

    public global::System.Collections.Generic.List<ClubPlayer> GetFavorites()
    {
        return null;
    }

    public void RemoveFromFavorites(int player)
    {
    }

    public bool AddToFavorites(int player)
    {
        return false;
    }

    public void RefreshByDetailedConditions(global::System.Collections.Generic.KeyValuePair<int, int> ageRange, string region, global::System.Collections.Generic.KeyValuePair<int, int> ratingRange, GeneralScoutManager.PosScout pos)
    {
    }

    public global::System.Collections.Generic.List<ClubPlayer> FindPlayersByDetailedConditions(global::System.Collections.Generic.KeyValuePair<int, int> ageRange, string region, global::System.Collections.Generic.KeyValuePair<int, int> ratingRange, GeneralScoutManager.PosScout pos)
    {
        return null;
    }

    private void RefreshByAnyConditions()
    {
    }

    public void Sign(global::SL.Player player, int price)
    {
    }

    public void ClearNewPlayerTip()
    {
    }

    private global::System.Collections.Generic.KeyValuePair<TeamsData, ClubPlayer> AIBuyPlayer(TeamsData team, int rating)
    {
        return default;
    }

    private global::System.Collections.Generic.List<ClubPlayer> GetPlayersByRatingRange(int min, int max)
    {
        return null;
    }

    public void GetCurrentPlayers(ref global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, int>> result)
    {
    }

    public GeneralScoutManager.Error CheckSignable(int price)
    {
        return GeneralScoutManager.Error.None;
    }

    public bool SignLegendPlayer(int player)
    {
        return false;
    }

    void RegionalLeagueEventListener.OnMatchFinish(CupMatchBase.MatchSettlementData match)
    {
    }

    private void RefreshPlayers_Low(global::System.Collections.Generic.List<GeneralScoutManager.RandomResult> randomResults, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> ageRange)
    {
    }

    public global::System.Collections.Generic.List<FormationTool.UIPosition> GetPositions(GeneralScoutManager.PosScout targetPos)
    {
        return null;
    }

    private void RefreshPlayers_Position(global::System.Collections.Generic.List<GeneralScoutManager.RandomResult> randomResults, GeneralScoutManager.PosScout targetPos, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> ageRange)
    {
    }
}