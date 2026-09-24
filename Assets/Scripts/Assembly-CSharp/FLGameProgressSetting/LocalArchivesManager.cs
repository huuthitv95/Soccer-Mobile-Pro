namespace FLGameProgressSetting
{
    public static class LocalArchivesManager
    {
        private struct DebugData
        {
            public string name;
            public int round;
            public int teamId;
            public int currentYear;
            public long recordTm;
        }

        public static global::System.Collections.Generic.Dictionary<string, global::FLGameProgressSetting.SeasonDataLocalArchives> MLArchives;
        public static global::System.Collections.Generic.Dictionary<string, global::FLGameProgressSetting.SeasonDataLocalArchives> ClubArchives;
        public static global::System.Collections.Generic.Dictionary<string, global::FLGameProgressSetting.SeasonDataLocalArchives> SimpleClubArchives;
        public static global::System.Collections.Generic.Dictionary<string, PlayerCareerLocalArchives> PlayerCareerArchives;
        public static global::FLGameProgressSetting.FriendlyDataLocalArchives FriendlyArchives;
        public static global::System.Collections.Generic.Dictionary<string, global::FLGameProgressSetting.NationalLocalArchives> NationalArchives;
        public static global::FLGameProgressSetting.StaticLocalArchives StaticArchive;
        public static global::FLGameProgressSetting.CustomLeagueArchives CustomLeagueArchives;
        public static global::System.Collections.Generic.Dictionary<string, global::FLGameProgressSetting.ChampionsLeagueLocalArchives> ChampionsLeagueArchives;
        private const string MLThumbnailFile = "MLThumbnail";
        private const string SimpleClubThumbnailFile = "SimpleClubThumbnail";
        private const string CustomLeagueThumbnailFile = "CustomThumbnail";
        private const string PlayerCareerThumbnailFile = "PlayerCareerThumbnail";
        public static global::FLGameProgressSetting.SeasonDataThumbnailArchives MLThumbnailArchives;
        public static global::FLGameProgressSetting.SeasonDataThumbnailArchives SimpleClubThumbnailArchives;
        public static global::FLGameProgressSetting.SeasonDataThumbnailArchives CustomLeagueThumbnailArchives;
        public static global::FLGameProgressSetting.PlayerCareerThumbnailArchives PlayerCareerThumbnailArchives;
        private static readonly global::FLGameProgressSetting.ArchiveScopedId[] EmptyScopedIds;
        private static readonly global::FLGameProgressSetting.ArchiveMatchId[] EmptyMatchIds;
        private static string BasePath => null;
        private static string ExternalPath => null;

        private static void CombineDebugInfo(global::System.Text.StringBuilder sb, global::System.Collections.Generic.List<global::FLGameProgressSetting.LocalArchivesManager.DebugData> debugDatas)
        {
        }

        public static string DebugInfo()
        {
            return null;
        }

        public static void OnVersionChanged()
        {
        }

        public static void LoadFromFile()
        {
        }

        private static void SetupMasterLeague(string name, global::Srv.SeasonData data)
        {
        }

        private static void SetupSimpleClub(string name, global::Srv.SeasonData data)
        {
        }

        private static void SetupPlayerCareer(string name, global::Srv.PlayerCareerArchive data)
        {
        }

        private static bool Load(global::FLGameProgressSetting.LocalArchives.ArchiveType type, string name)
        {
            return false;
        }

        private static T LoadArchiveMessage<T>(global::FLGameProgressSetting.LocalArchives.ArchiveType type, string name, global::Google.Protobuf.MessageParser<T> parser)
            where T : class, global::Google.Protobuf.IMessage<T>
        {
            return null;
        }

        internal static T LoadArchiveMessage<T>(string databasePath, string path, string backupPath, global::Google.Protobuf.MessageParser<T> parser)
            where T : class, global::Google.Protobuf.IMessage<T>
        {
            return null;
        }

        internal static void MigratePlayerCareerLegacyArchives(string directoryPath)
        {
        }

        internal static void Load(string path, string externalpath, global::System.Func<string, byte[], int, int, global::Google.Protobuf.IMessage> onLoad, global::System.Action<string, global::Google.Protobuf.IMessage> afterHydrate = null)
        {
        }

        private static void TryDeleteMigratedInvalidMain(string path)
        {
        }

        public static void CheckDirtyFlag()
        {
        }

        public static string CopyAllArchivesToExternal()
        {
            return null;
        }

        internal static void ReplaceDirectoryCopy(string sourcePath, string destinationPath)
        {
        }

        private static void CopyDirectoryContents(string sourcePath, string destinationPath)
        {
        }

        public static void SaveIapCriticalImmediate()
        {
        }

        public static void MarkAllDirty()
        {
        }

        public static global::FLGameProgressSetting.SeasonDataLocalArchives GetMLArchive(string name)
        {
            return null;
        }

        public static void UnloadMLArchive(string name)
        {
        }

        public static global::FLGameProgressSetting.SeasonDataLocalArchives GetClubArchive(string name)
        {
            return null;
        }

        public static global::FLGameProgressSetting.SeasonDataLocalArchives GetSimpleClubArchive(string name)
        {
            return null;
        }

        public static void UnloadSimpleClubArchive(string name)
        {
        }

        public static PlayerCareerLocalArchives CreatePlayerCareerArchive()
        {
            return null;
        }

        public static PlayerCareerLocalArchives LoadPlayerCareerArchive(string name)
        {
            return null;
        }

        public static bool PlayerCareerArchiveExists(string name)
        {
            return false;
        }

        internal static global::System.Collections.Generic.List<string> GetAllPlayerCareerArchiveNames()
        {
            return null;
        }

        internal static global::System.Collections.Generic.List<string> CollectPlayerCareerArchiveNames(string directoryPath)
        {
            return null;
        }

        public static PlayerCareerLocalArchives DeletePlayerCareerArchive(string name)
        {
            return null;
        }

        public static void UnloadPlayerCareerArchive(PlayerCareerLocalArchives archives)
        {
        }

        public static global::FLGameProgressSetting.NationalLocalArchives CreateNationalArchive(string name, global::FLGameProgressSetting.NationalLocalArchives previous = null)
        {
            return null;
        }

        public static void DeleteNationalArchive(global::FLGameProgressSetting.NationalLocalArchives archives)
        {
        }

        public static global::System.Collections.Generic.List<global::FLGameProgressSetting.NationalLocalArchives> AllNationalLocalArchives()
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::FLGameProgressSetting.ChampionsLeagueLocalArchives> AllChampionsLeagueLocalArchives()
        {
            return null;
        }

        public static global::FLGameProgressSetting.ChampionsLeagueLocalArchives CreateChampionsLeagueArchive(string name)
        {
            return null;
        }

        public static void DeleteChampionsLeagueArchive(global::FLGameProgressSetting.ChampionsLeagueLocalArchives archives)
        {
        }

        public static void DeleteALL()
        {
        }

        private static string GeneratePlayerCareerArchiveName()
        {
            return null;
        }
    }
}