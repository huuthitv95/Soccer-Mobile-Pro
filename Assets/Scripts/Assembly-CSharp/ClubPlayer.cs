public class ClubPlayer : global::SL.Player
{
    public enum InjuryType
    {
        None = 0,
        Slight = 100,
        SlightStrain = 101,
        MinorSprain = 102,
        Injury = 200,
        TendonStrain = 201,
        GroinStrain = 202,
        Serious = 300,
        BrokenLeg = 301,
        TornLigament = 302
    }

    public global::Srv.ClubPlayerData archives;
    private static global::System.Collections.Generic.List<int> NewPlayerFlag;
    private int _apperanceID;
    private PlayerManager playerManager;
    private bool forceDisableLicensedAssets;
    private short tmpInjuryType;
    private long tmpRecoveryTime;
    public global::SL.Player.PlayerState playerState { get; private set; }

    public override int age
    {
        get
        {
            return 0;
        }

        protected set
        {
        }
    }

    public short staminaConsumption { get; private set; }
    public int TeamId => 0;
    public TeamsData Team { get; private set; }
    public FormationTool.UIRole roleInTeam { get; set; }

    public int CoatNum
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int currentStamina => 0;
    public string RealName => null;

    public int MatchCounter
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int ApperanceID => 0;
    public global::SL.Player.PlayerApperance Apperance => null;
    public int RebirthCounter => 0;
    public int StaticRating => 0;
    public EditablePlayerIcon PlayerIcon => null;
    public bool IsInjury => false;
    public long RecoveryTime => 0L;
    public int StartingSeason => 0;

    // C# has no syntax for parameterized property 'Item'.
    public short this[global::FL.PlayerAbility ability]
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int GetStaticAge()
    {
        return 0;
    }

    public static void AddNewPlayerFlag(int id)
    {
    }

    public static void RemoveNewPlayerFlag(int id)
    {
    }

    public static bool IsNewPlayer(int id)
    {
        return false;
    }

    public int Rating()
    {
        return 0;
    }

    public int OptimalPositionRating()
    {
        return 0;
    }

    public void SetApperanceID(int apperanceID)
    {
    }

    public static bool NeedSpecialCard(int playerId)
    {
        return false;
    }

    public bool NeedSpecialCard()
    {
        return false;
    }

    public void RandomPlayerState()
    {
    }

    public void BoostPlayerState(bool maxLevel = false)
    {
    }

    public float GetStateBuff(bool stamina)
    {
        return 0f;
    }

    public void OnMatchFinish()
    {
    }

    public void UpdateStamina(int increment)
    {
    }

    public override global::SL.Player.Hexagram GetHexagram(bool isGK)
    {
        return default;
    }

    public global::Srv.PlayerExp GetExp()
    {
        return null;
    }

    public void AddExp(in global::FL.PlayerExpStruct exp)
    {
    }

    public void Rebirth(in global::FL.PlayerExpStruct offset, int age, global::SL.Player proto)
    {
    }

    public bool IsReBirthPlayer()
    {
        return false;
    }

    public void RestoreStamina()
    {
    }

    public bool EnableLicensedAssets()
    {
        return false;
    }

    public void ApplyUnlicensedAppearanceInfo()
    {
    }

    public void ResetLicensedAppearanceOverride()
    {
    }

    public ClubPlayer CreateUnlicensedAppearanceCopy()
    {
        return null;
    }

    public ClubPlayer(global::SL.Player proto, global::Srv.ClubPlayerData archives, TeamsData team, PlayerManager playerManager)
    {
    }

    public override sbyte Rating(FormationTool.UIPosition role)
    {
        return 0;
    }

    public float GetBenchSortValue()
    {
        return 0f;
    }

    public void ChangeTeam(TeamsData team)
    {
    }

    public ClubPlayer(global::SL.Player proto, global::Srv.ClubPlayerData archives, PlayerManager playerManager)
    {
    }

    public void Reset()
    {
    }

    public void CheckInjuryRecover(IMatchManager matchManager)
    {
    }

    public void RecoverInjury()
    {
    }

    public void ResetTempInjury()
    {
    }

    public void SaveInjury()
    {
    }

    public void SetStartingSeason(int season)
    {
    }

    public void OnInjury(ClubPlayer.InjuryType type, IMatchManager matchManager)
    {
    }

    public ClubPlayerContract GetPlayerContract()
    {
        return null;
    }

    public bool HasValidContract()
    {
        return false;
    }

    public bool IsLoanPlayer()
    {
        return false;
    }

    public static bool IsSuspended(int pid, PlayerDisciplineDatabase playerDiscipline, AISampleBase aiMatch)
    {
        return false;
    }

    public bool IsSuspended(PlayerDisciplineDatabase playerDiscipline, AISampleBase aiMatch)
    {
        return false;
    }

    public bool IsSuspended(PlayerDisciplineDatabase playerDiscipline, IngameTacticsMgr.IngameTacticsData ingameTacticsData)
    {
        return false;
    }

    private static short LogInvalidAbility(global::FL.PlayerAbility ability)
    {
        return 0;
    }

    private static short GetAbilityFromPlayer(global::SL.Player player, global::FL.PlayerAbility ability)
    {
        return 0;
    }

    public float GetAbilityWithExp(global::FL.PlayerAbility ability)
    {
        return 0f;
    }

    public float GetAbilityWithBuff(global::FL.PlayerAbility ability)
    {
        return 0f;
    }
}