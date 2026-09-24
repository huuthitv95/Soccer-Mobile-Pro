public class LeagueManager : global::Common.Singleton<LeagueManager>
{
    private global::System.Collections.Generic.List<global::SL.LeagueProto> protos;
    private global::System.Collections.Generic.Dictionary<string, global::SL.LeagueProto> protoMap;
    private global::System.Collections.Generic.Dictionary<ConfigVariantID, ConfigVariant<global::SL.LeagueProto>> variants;
    public global::System.Collections.Generic.List<global::SL.LeagueProto> AllProtos => null;
    private global::System.Collections.Generic.Dictionary<ConfigVariantID, ConfigVariant<global::SL.LeagueProto>> Variants => null;
    public global::SL.LeagueProto EPL => null;

    private global::SL.LeagueProto CreateVariants(string name, global::FLDataTable.LeagueVariant datas, ConfigVariantID id)
    {
        return null;
    }

    private void InitVariants()
    {
    }

    private ConfigVariant<global::SL.LeagueProto> CreateConfigVariant(ConfigVariantID id)
    {
        return null;
    }

    public global::SL.LeagueProto GetVariants(string name, ConfigVariantID id, bool useCopy = false)
    {
        return null;
    }

    public League CreateCustomLeague(global::Srv.LeagueData archive, global::FLGameProgressSetting.SeasonDataLocalArchives storer, string protoName, PlayerManager playerManager, TeamDataManager teamDataManager)
    {
        return null;
    }

    public League CreateLeague(global::Srv.LeagueData archive, global::FLGameProgressSetting.SeasonDataLocalArchives storer, string protoName, PlayerManager playerManager, TeamDataManager teamDataManager, ConfigVariantID variantID)
    {
        return null;
    }

    public League GetLeagueById(int id, global::FLGameProgressSetting.SeasonDataLocalArchives storer, global::Srv.LeagueData archive)
    {
        return null;
    }

    public global::SL.LeagueProto GetLeagueProtoByName(string name)
    {
        return null;
    }

    public global::SL.LeagueProto GetLeagueProtoById(int id)
    {
        return null;
    }

    public void Initialize()
    {
    }
}