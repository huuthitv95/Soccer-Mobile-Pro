[global::System.Obsolete]
public readonly ref struct MatchMissionPointChecker
{
	private struct MatchMissionStats
	{
		public int TeamStatsArraySize;

		public bool UserIsHome;

		public int UserTeamIndex;

		public int Score;

		public int PenaltyScore;

		public int OpponentScore;

		public int OpponentPenaltyScore;

		public int CornerCount;

		public int ShotCount;

		public int PassCount;
	}

	private readonly CupMatchBase _match;

	private readonly CupMatchBase.MatchSettlementData _settlementData;

	private readonly MatchMissionPointChecker.MatchMissionStats _stats;

	private readonly global::System.Func<global::FLGameData.MissionType, int> _delegate;

	private readonly global::System.Collections.Generic.Dictionary<int, InGamePlayer> _cachedPlayersById;

	private readonly global::System.Collections.Generic.HashSet<int> _missingPlayerIds;

	public readonly IMatchManager MatchManager;

	public CupMatchBase Match => null;

	private MatchMissionPointChecker(CupMatchBase match, CupMatchBase.MatchSettlementData settlementData, MatchMissionPointChecker.MatchMissionStats stats)
	{
		_match = null;
		_settlementData = null;
		_stats = default;
		_delegate = null;
		_cachedPlayersById = null;
		_missingPlayerIds = null;
		MatchManager = null;
	}

	private MatchMissionPointChecker(IMatchManager matchManager, global::System.Func<global::FLGameData.MissionType, int> func)
	{
		_match = null;
		_settlementData = null;
		_stats = default;
		_delegate = null;
		_cachedPlayersById = null;
		_missingPlayerIds = null;
		MatchManager = null;
	}

	public static MatchMissionPointChecker Create(CupMatchBase match, CupMatchBase.MatchSettlementData settlementData)
	{
		return default;
	}

	public static MatchMissionPointChecker Create(IMatchManager matchManager, global::System.Func<global::FLGameData.MissionType, int> checkPoint)
	{
		return default;
	}

	public int CheckPoint(global::FLGameData.MissionType missionType)
	{
		return 0;
	}

	public int CheckPoint(global::FLGameData.PlayerMissionType missionType, int playerId)
	{
		return 0;
	}

	public int CheckPoint(int missionTypeId, int playerId)
	{
		return 0;
	}

	private int CheckPlayerMissionPointCore(global::FLGameData.PlayerMissionType missionType, int playerId)
	{
		return 0;
	}

	private InGamePlayer GetCachedPlayer(CupMatchBase.MatchSettlementData settlementData, int playerId)
	{
		return null;
	}

	private static int CheckPointCore(CupMatchBase match, CupMatchBase.MatchSettlementData settlementData, MatchMissionPointChecker.MatchMissionStats stats, global::FLGameData.MissionType missionType)
	{
		return 0;
	}

	private static MatchMissionPointChecker.MatchMissionStats ParseMatchMissionStats(CupMatchBase match)
	{
		return default;
	}
}
