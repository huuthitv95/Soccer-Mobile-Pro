public class FACupManager : global::Common.Singleton<FACupManager>
{
    public enum ActivityCupType
    {
        none = 0,
        CompetitionChallenge = 1,
        IndependentSaveLimit = 2,
        womenWorldCup = 3
    }

    public global::System.Collections.Generic.List<global::SL.CupRules> AllRules;
    private global::System.Collections.Generic.List<global::SL.FACupGroupsData> proto;
    private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::SL.FACupGroupsData>> protoMap;
    private FACup lastPlayed;
    public global::System.Collections.Generic.List<FACup> singleCupMode;
    public global::System.Collections.Generic.List<FACup> singleCupMode_Women;
    public global::System.Collections.Generic.List<global::SL.CupRules> singleCupModeRules;
    public global::System.Collections.Generic.List<global::SL.CupRules> singleCupModeRules_Women;
    private global::System.Collections.Generic.Dictionary<ConfigVariantID, ConfigVariant<global::SL.CupRules>> rulesVariants;
    private global::System.Collections.Generic.Dictionary<ConfigVariantID, ConfigVariant<global::SL.CupRules>> RulesVariants => null;

    public FACup LastPlayedCup
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    private global::SL.CupRules CreateRulesVariant(string name, global::System.Collections.Generic.List<string> datas, ConfigVariantID id)
    {
        return null;
    }

    private void InitRulesVariants()
    {
    }

    private ConfigVariant<global::SL.CupRules> CreateRulesConfigVariant(ConfigVariantID id)
    {
        return null;
    }

    public global::SL.CupRules GetRulesVariant(string name, ConfigVariantID variantID)
    {
        return null;
    }

    public global::SL.FACupGroupsData GetGroupVariant(string type, int id, ConfigVariantID variantId)
    {
        return null;
    }

    public static bool IsActivityCup(FACup cup)
    {
        return false;
    }

    public static bool IsActivityCup(global::SL.CupRules cup)
    {
        return false;
    }

    public static FACupManager.ActivityCupType GetActivityCupType(FACup cup)
    {
        return FACupManager.ActivityCupType.none;
    }

    public global::SL.FACupGroupsData GetWomenWorldCup()
    {
        return null;
    }

    private FACup CreateCustomCup(global::Srv.WorldCupData archive, string protoName, PlayerManager playerManager, TeamDataManager teamDataManager, global::FLGameProgressSetting.LocalArchives storer)
    {
        return null;
    }

    private FACup LoadCustomCup(global::Srv.WorldCupData data, global::FLGameProgressSetting.CompetitionLocalArchives storer)
    {
        return null;
    }

    public FACup CreateCup(global::Srv.WorldCupData archive, string protoName, PlayerManager playerManager, TeamDataManager teamDataManager, ConfigVariantID variantID, global::FLGameProgressSetting.LocalArchives storer, global::MultiStageTournament.IMultiStageTournamentManager multiStageTournamentManager = null)
    {
        return null;
    }

    public FACup CreateWithSingleCupMode(string protoName, global::SL.FACupGroupsData baseCup = null, global::MultiStageTournament.IMultiStageTournamentManager multiStageTournamentManager = null)
    {
        return null;
    }

    public FACup CreateNextStage(string protoName, global::MultiStageTournament.IMultiStageTournamentManager multiStageTournamentManager)
    {
        return null;
    }

    public void DeleteFACup(FACup fACup)
    {
    }

    public void ResetLastPlayed()
    {
    }

    public FACup LoadFromArchive(global::Srv.WorldCupData data, global::FLGameProgressSetting.CompetitionLocalArchives storer)
    {
        return null;
    }

    public global::SL.FACupGroupsData GetCupProto(string type, int id)
    {
        return null;
    }

    public global::SL.FACupGroupsData RandomGetCupProto(string type, global::SL.FACupGroupsData exclude = null)
    {
        return null;
    }

    public global::System.Collections.Generic.List<global::SL.FACupGroupsData> GetProtoByType(string type)
    {
        return null;
    }

    public void ResetCup(FACup fACup)
    {
    }

    public void Initialize()
    {
    }

    public bool HasArchiveCup(bool isWomen, global::SL.CupRules cup)
    {
        return false;
    }

    public bool HasArchiveCup(bool isWomen, string cup)
    {
        return false;
    }

    public bool HasValidArchive(bool isWomen)
    {
        return false;
    }

    public global::SL.CupRules GetCupRules(string type)
    {
        return null;
    }

    public static void MakeCupLogo(global::UnityEngine.UI.Image flag, FACup fACup, float uiHeight)
    {
    }

    public static void MakeCupLogo(global::UnityEngine.UI.Image flag, global::SL.CupRules fACup, float uiHeight)
    {
    }

    public static void MakeCupLogo(global::UnityEngine.UI.Image flag, global::UnityEngine.Sprite icon, float uiHeight)
    {
    }

    public FACup GetFACupByGlobalId(long globalId)
    {
        return null;
    }
}