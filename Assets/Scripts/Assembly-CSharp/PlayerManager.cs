public class PlayerManager
{
    private class PlayerIdComparer : global::SL.Player, global::System.Collections.Generic.IComparer<global::SL.Player>
    {
        public int Id
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int Compare(global::SL.Player x, global::SL.Player y)
        {
            return 0;
        }
    }

    private struct TmpFakePlayerRecorder
    {
        private global::System.Collections.Generic.HashSet<int> tmpFakePlayers;
        public void ClearTmpFakePlayers()
        {
        }

        public void RemoveTmpFakePlayer(int id)
        {
        }

        public bool IsTmpFakePlayer(int id)
        {
            return false;
        }

        public TmpFakePlayerRecorder(global::System.Collections.Generic.HashSet<int> set)
        {
            tmpFakePlayers = null;
        }

        public void AddTmpFakePlayer(int id)
        {
        }
    }

    public const int MinFakePlayerId = 300000;
    public const int UserPlayerId = 1;
    public bool UseTransfer;
    public bool EnableRealTeam;
    private static PlayerManager.PlayerIdComparer playerSeachHelper;
    public static global::System.Collections.Generic.List<global::SL.Player> allProto;
    private static global::System.Collections.Generic.Dictionary<FormationTool.UIPosition, global::System.Collections.Generic.List<global::SL.Player>> playerTemplate;
    private PlayerManager IAPPlayerManager;
    private global::Srv.ClubPlayerDatabase archives;
    private global::System.Collections.Generic.Dictionary<int, ClubPlayer> TeamPlayers;
    private PlayerManager.TmpFakePlayerRecorder tmpFakePlayerRecorder;
    private global::SL.Player userPlayerProto;
    private global::FLGameProgressSetting.LocalArchives Storer;
    private readonly int dataScope;
    private global::System.Func<int> currnetYearGetter;
    public ExternalDataAgent EditableAchiveAgent;
    private static PlayerManager _commonNationalPlayerManager;
    private static PlayerManager _commonClubPlayerManager;
    private global::System.Collections.Generic.Dictionary<int, ClubPlayerContract> playerContract;
    public PlayerAppearanceFactory PlayerAppearanceFactory { get; }
    public global::FL.IClubPlayerRules ClubPlayerRules { get; private set; }
    public bool IsPlayerCareer => false;
    public PlayerTemporaryBoostManager PlayerTemporaryBoostManager { get; private set; }
    public TeamTacticsManager TeamTacticsManager { get; private set; }
    public static PlayerManager CommonNationalPlayerManager => null;
    public static PlayerManager CommonClubPlayerManager => null;

    public void Reset()
    {
    }

    public void MarkArchiveDirty()
    {
    }

    public void MarkTeamDirty(int teamId)
    {
    }

    public static global::System.Collections.Generic.List<global::SL.Player> getTemplateByRole(FormationTool.UIPosition role)
    {
        return null;
    }

    public static global::SL.Player getTemplateById(int id)
    {
        return null;
    }

    public void SetIAPPlayerManager(PlayerManager manager)
    {
    }

    public static void FillPlaceholder()
    {
    }

    public static void Initialize()
    {
    }

    public bool ContainsPlayer(int id)
    {
        return false;
    }

    public int GetPlayerTeam(int id)
    {
        return 0;
    }

    private global::SL.Player GetFakePlayerProto(int id)
    {
        return null;
    }

    public ClubPlayer CreateTmpFakePlayer(ClubPlayer proto, int rating, int age, out global::Srv.ClubPlayerData archive, int tmpPlayerIdOffset = -1)
    {
        archive = null;
        return null;
    }

    public global::System.Collections.Generic.List<ClubPlayer> CreateTmpFakePlayers(global::System.Collections.Generic.List<ClubPlayer> protos, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> rating_age)
    {
        return null;
    }

    public ClubPlayer CreateFakePlayer(ClubPlayer proto, int rating, int teamid, int age)
    {
        return null;
    }

    public void SetUserPlayer(global::SL.Player player)
    {
    }

    public ClubPlayer LoadPlayersById(int id, TeamsData team)
    {
        return null;
    }

    public void Save(global::Srv.ClubPlayerData clubPlayerData)
    {
    }

    public void AddPlayerCache(ClubPlayer player)
    {
    }

    public ClubPlayer GetClubPlayerById(int id)
    {
        return null;
    }

    public bool TryGetClubPlayerById(int id, out ClubPlayer player)
    {
        player = null;
        return false;
    }

    public int GetCurrentYear()
    {
        return 0;
    }

    public int GetPlayerRatingWhithoutTemporaryBoost(ClubPlayer clubPlayer)
    {
        return 0;
    }

    public PlayerManager(global::Srv.ClubPlayerDatabase archives, global::FLGameProgressSetting.LocalArchives storer, global::System.Func<int> currnetYearGetter = null, int dataScope = 0)
    {
    }

    public ClubPlayerContract GetPlayerContract(int id)
    {
        return null;
    }

    public ClubPlayerContract CreatePlayerContract(int id)
    {
        return null;
    }

    public ClubPlayerContract UpdatePlayerContract(int id, int deltaValue)
    {
        return null;
    }

    public void RemovePlayerContract(int id)
    {
    }

    public void RestPlayerContract()
    {
    }
}