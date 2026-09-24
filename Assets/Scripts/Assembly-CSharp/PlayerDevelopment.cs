public class PlayerDevelopment : RegionalLeagueEventListener
{
    public global::System.Collections.Generic.Dictionary<int, global::SL.Player.Hexagram> tempPlayerProperty;
    private global::System.Collections.Generic.Dictionary<int, global::FL.PlayerExpStruct> tempPlayerExp;
    public global::System.Collections.Generic.Dictionary<int, global::System.Tuple<int, int, float, float>> tempPlayerDebugInfo;
    public RegionalLeague regionalLeague;
    private PlayerRetirementRebirthContext retirementRebirthContext;
    private static global::System.Collections.Generic.Dictionary<int, float> seasonExp;
    private static global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, float>>> matchExp;
    private static global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>>> growthConfig;
    private static global::System.Collections.Generic.List<int> growthIds;
    private global::System.Collections.Generic.List<ClubPlayer> tempRetiredPlayer;
    public PlayerDevelopment(RegionalLeague regionalLeague)
    {
    }

    public global::FL.PlayerExpStruct AddExp(ClubPlayer clubPlayer, bool playedInMatch, int leagueMatchCount, bool recordPlayerExp, bool hasSeasonExp)
    {
        return default;
    }

    public global::System.Collections.Generic.Dictionary<int, global::FL.PlayerExpStruct> GetTempPlayerExp()
    {
        return null;
    }

    public global::System.Collections.Generic.Dictionary<int, global::SL.Player.Hexagram> GetTempPlayerProperty()
    {
        return null;
    }

    public float GetPlayerTotalGrowthValue(ClubPlayer clubPlayer)
    {
        return 0f;
    }

    private int GetPlayerGrowthType(ClubPlayer clubPlayer, int age = -1)
    {
        return 0;
    }

    private float getMatchExp(int type, int matchCount)
    {
        return 0f;
    }

    public static int GetBaseGrowthId(int playerid)
    {
        return 0;
    }

    public static void LoadConfig()
    {
    }

    public void OnInitialize()
    {
    }

    public void OnChooseTeam()
    {
    }

    public void OnUpdateRound()
    {
    }

    public void OnUpdateSeason()
    {
    }

    public void OnFinishSeason()
    {
    }

    public void OnRest()
    {
    }

    public void OnMatchFinish(CupMatchBase.MatchSettlementData settlementData)
    {
    }

    public bool HasRetiredPlayer()
    {
        return false;
    }

    public global::System.Collections.Generic.List<ClubPlayer> GetTempRetiredPlayer()
    {
        return null;
    }

    private void HandlePlayerRetirement(TeamsData Team, ClubPlayer clubPlayer)
    {
    }

    private void CheckPlayerRetirement(TeamsData Team, ClubPlayer clubPlayer, bool needSupply)
    {
    }

    private void CheckPlayerRetirement(TeamsData team, ClubPlayer clubPlayer, bool needSupply, global::System.Action<TeamsData, ClubPlayer> onRetirement)
    {
    }

    private void SupplyPlayer(TeamsData team, ClubPlayer clubPlayer)
    {
    }

    private void HandleUserPlayerRetirement()
    {
    }

    private float CalculateRetirementScore(ClubPlayer player)
    {
        return 0f;
    }

    public void MarkUserPlayerRetirement()
    {
    }

    private void SystemPlayer2Market()
    {
    }
}