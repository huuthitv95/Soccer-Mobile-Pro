public class TeamsData : global::SL.TeamsProto
{
    public global::Srv.ClubTeamData Archives;
    public global::System.Collections.Generic.List<int> PlayerOrder;
    public global::System.Collections.Generic.List<ClubPlayer> Players;
    private global::UnityEngine.Events.UnityEvent<int> OnAbilityChange;
    private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ClubPlayer, FormationTool.UIRole>> tmpFormationHelper;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> _formationInUse;
    private static global::System.Collections.Generic.Dictionary<int, int> TmpSequence;
    public PlayerManager playerManager;
    private global::System.Collections.Generic.Dictionary<int, global::SL.PointRaceStatistics> pointRaceStatistics;
    public global::System.Collections.Generic.List<ClubPlayer> inactivePlayers;
    private int preMatchInjuredTip;
    private int FormationInjuredTip;
    private int FormationMatchContractTip;
    public override int PlayerCount => 0;
    public int LoanPlayerCount => 0;
    public global::System.Collections.Generic.List<string> CupQualification => null;
    public global::System.Collections.Generic.List<string> LeagueQualification => null;
    public override int Ability => 0;
    public int AbilityWithoutStayers => 0;
    public int ProtoAbility => 0;

    public override string RealName
    {
        get
        {
            return null;
        }

        protected set
        {
        }
    }

    public virtual global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> formationInUse
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public global::Common.Formation Formation => null;
    public float SeriousInjuryValue => 0f;
    public float InjuryValue => 0f;
    public float SlightInjuryValue => 0f;
    public float InjuryValueThreshold => 0f;
    public bool NeedShowPreMatchInjuredTip => false;
    public bool NeedShowFormationInjuredTip => false;
    public bool NeedShowFormationMatchContractTip => false;

    public int HomeJersey
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int AwayJersey
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public global::System.Collections.Generic.List<ClubPlayer> GetStarterAndBench()
    {
        return null;
    }

    public bool CheckCupQualification(string cup)
    {
        return false;
    }

    public bool CheckLeagueQualification(string league)
    {
        return false;
    }

    public void AddCupQualification(string cup)
    {
    }

    public void RemoveCupQualification(string cup)
    {
    }

    public void AddLeagueQualification(string league)
    {
    }

    public void RemoveQualification(string league)
    {
    }

    public void UpdateAbility()
    {
    }

    public void AddAbilityListener(global::UnityEngine.Events.UnityAction<int> action)
    {
    }

    public void RemoveAbilityListener(global::UnityEngine.Events.UnityAction<int> action)
    {
    }

    public void ReplacePlayers(global::System.Collections.Generic.List<ClubPlayer> newList)
    {
    }

    public bool EnableLicensedAssets()
    {
        return false;
    }

    public void CheckExpiredContractPlayers()
    {
    }

    public void CheckSuspendPlayers(PlayerDisciplineDatabase playerDisciplineDatabase)
    {
    }

    public static int GetLoanContractCount(int playerID, int playerRating)
    {
        return 0;
    }

    public void SystemTeamGainPlayer(ClubPlayer player, RegionalLeague mlManager)
    {
    }

    public void GainPlayer(ClubPlayer player, RegionalLeague mlManager, bool checkStarting, bool isLoan = false)
    {
    }

    private int CheckCoatNumValid(ClubPlayer player, int num)
    {
        return 0;
    }

    public bool CheckLoanPlayer(ClubPlayer player)
    {
        return false;
    }

    public int GetLoanPlayerContract(ClubPlayer player)
    {
        return 0;
    }

    public global::System.Collections.Generic.List<ClubPlayer> UpdateLoanContraca(global::System.Collections.Generic.List<ClubPlayer> needUpdate, TeamsData legend, RegionalLeague mlManager)
    {
        return null;
    }

    public void SystemTeamRemovePlayer(ClubPlayer player)
    {
    }

    public void RemovePlayer(ClubPlayer player)
    {
    }

    public ClubPlayer GetBestPlayerForPosition(FormationTool.UIRole pos, bool onlySubs, global::System.Func<ClubPlayer, bool> excludeCheck = null, bool checkContract = true)
    {
        return null;
    }

    public void MakeFirstString(ClubPlayer player, global::System.Collections.Generic.List<ClubPlayer> skipCheck = null)
    {
    }

    public ClubPlayer GetPlayerById(int id)
    {
        return null;
    }

    public void OverrideTeamName(string nameStringId)
    {
    }

    public void BoostPlayerState(bool maxLevel = false)
    {
    }

    public void RestoreStamina()
    {
    }

    public void OnMatchFinish()
    {
    }

    public void SwitchPlayer(int src, int target)
    {
    }

    public bool PromotePlayerToStarter(int playerId, out int replacedPlayerId)
    {
        replacedPlayerId = default;
        return false;
    }

    public bool DemoteStarterToSubstitute(int playerId)
    {
        return false;
    }

    private int GetSubsPlayer(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> formation)
    {
        return 0;
    }

    public global::SL.PointRaceStatistics MatchStatistics(int globalId)
    {
        return null;
    }

    public void SetRankState(IMatchManager mgr, int state)
    {
    }

    public int GetRankState(IMatchManager mgr)
    {
        return 0;
    }

    public void OnCompetitionStart()
    {
    }

    public void Accumulation(CupMatchBase match)
    {
    }

    public TeamsData(global::SL.TeamsProto proto, global::Srv.ClubTeamData clubTeamData, PlayerManager playerManager)
    {
    }

    public void SetFormationFromArchive(global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> formationData)
    {
    }

    public void ResetFormation()
    {
    }

    public void Reset(bool ResetPlayers)
    {
    }

    public bool NeedBoostMorale()
    {
        return false;
    }

    public bool NeedShowMoraleTip()
    {
        return false;
    }

    public void AddInjuryValueFromFatigue(float value)
    {
    }

    public void SetInjuryValue(float serious, float injury, float slight)
    {
    }

    public void CheckPlayerInjury(IMatchManager matchManager)
    {
    }

    public bool HasInjuredPlayer(bool starter = false)
    {
        return false;
    }

    public void ResetInjuredTip()
    {
    }

    public bool HasExpiredContractPlayer(bool starter = false)
    {
        return false;
    }

    public bool HasInvaildStarter(PlayerDisciplineDatabase playerDisciplineDatabase)
    {
        return false;
    }
}