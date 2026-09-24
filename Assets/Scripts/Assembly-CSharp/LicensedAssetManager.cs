public class LicensedAssetManager : global::Common.Singleton<LicensedAssetManager>
{
    public enum LicensedAssetType
    {
        ManCityResourcePack = 0,
        MonacoResourcePack = 1,
        None = 2
    }

    public struct TeamLicensedAssetInfo
    {
        public string AtlasName;
        public int TeamId;
        public int HomeJersey;
        public int AwayJersey;
        public int HomeGKJersey;
        public int AwayGKJersey;
        public string NameKey;
        public string NameAbbr;
        public TeamLicensedAssetInfo(string atlasName, int teamId, int homeJersey, int awayJersey, int homeGKJersey, int awayGKJersey, string nameKey, string nameAbbr)
        {
            AtlasName = null;
            TeamId = 0;
            HomeJersey = 0;
            AwayJersey = 0;
            HomeGKJersey = 0;
            AwayGKJersey = 0;
            NameKey = null;
            NameAbbr = null;
        }
    }

    private class LicensedAssetRemoteConfig
    {
        public global::System.Func<string> GetConfigString;
        public global::System.Collections.Generic.SortedSet<int> players;
        public bool Enabled;
        public bool inited;
        public LicensedAssetManager.TeamLicensedAssetInfo teamInfo;
        public void Init(bool force = false)
        {
        }

        public LicensedAssetRemoteConfig(global::System.Func<string> getConfigString, string atlasName, int teamId, int homeJersey, int awayJersey, int homeGKJersey, int awayGKJersey, string strKey, string strAbbr)
        {
        }
    }

    private LicensedAssetManager.LicensedAssetRemoteConfig[] licensedAssetConfigs;
    public bool IsLicensedAssetEnabled(LicensedAssetManager.LicensedAssetType type)
    {
        return false;
    }

    public bool IsPlayerInLicensedAsset(int playerId)
    {
        return false;
    }

    public bool isTeamInLicensedAsset(int teamId)
    {
        return false;
    }

    public bool TryGetTeamLicensedAssetInfo(int teamId, out LicensedAssetManager.TeamLicensedAssetInfo teamInfo)
    {
        teamInfo = default;
        return false;
    }

    public bool TryGetTeamLicensedAssetInfo(LicensedAssetManager.LicensedAssetType licensedAssetType, out LicensedAssetManager.TeamLicensedAssetInfo teamInfo)
    {
        teamInfo = default;
        return false;
    }

    public void InitConfigs(bool force = true)
    {
    }

    private static void SaveState(int typeIndex, bool enabled)
    {
    }

    public static global::System.Collections.Generic.List<LicensedAssetManager.LicensedAssetType> GetEnabledLicensedAssetTypes()
    {
        return null;
    }
}