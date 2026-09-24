namespace FLGameProgressSetting
{
    internal static class ArchiveSqliteStore
    {
        private sealed class ArchiveLayout
        {
            internal readonly global::System.Collections.Generic.Dictionary<int, global::Srv.ClubPlayerDatabase> Players;
            internal readonly global::System.Collections.Generic.Dictionary<int, global::Srv.ClubTeamDatabase> Teams;
            internal readonly global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveScopedId, global::Google.Protobuf.Collections.RepeatedField<global::Srv.MatchData>> Matches;
            internal readonly global::System.Collections.Generic.HashSet<object> ProjectionMessages;
        }

        private sealed class ReferenceEqualityComparer : global::System.Collections.Generic.IEqualityComparer<object>
        {
            internal static readonly global::FLGameProgressSetting.ArchiveSqliteStore.ReferenceEqualityComparer Instance;
            public new bool Equals(object left, object right)
            {
                return false;
            }

            public int GetHashCode(object value)
            {
                return 0;
            }
        }

        private sealed class RootRow
        {
            public int Id { get; set; }
            public byte[] Payload { get; set; }
        }

        private sealed class ScopedKeyRow
        {
            public int DataScope { get; set; }
            public int Id { get; set; }
        }

        private sealed class MatchKeyRow
        {
            public int DataScope { get; set; }
            public int CompetitionId { get; set; }
            public int MatchId { get; set; }
        }

        private sealed class PlayerBlobRow
        {
            public int DataScope { get; set; }
            public int PlayerId { get; set; }
            public byte[] Payload { get; set; }
        }

        private sealed class TeamBlobRow
        {
            public int DataScope { get; set; }
            public int TeamId { get; set; }
            public byte[] Payload { get; set; }
        }

        private sealed class MatchBlobRow
        {
            public int DataScope { get; set; }
            public int CompetitionId { get; set; }
            public int MatchId { get; set; }
            public byte[] Payload { get; set; }
        }

        private const int SchemaVersion = 1;
        private const string CreateArchiveBlobSql = "\r\nCREATE TABLE archive_blob (\r\n    id      INTEGER PRIMARY KEY CHECK (id = 1),\r\n    payload BLOB NOT NULL\r\n);";
        private const string CreatePlayerBlobSql = "\r\nCREATE TABLE player_blob (\r\n    data_scope INTEGER NOT NULL,\r\n    player_id  INTEGER NOT NULL,\r\n    payload    BLOB NOT NULL,\r\n    PRIMARY KEY (data_scope, player_id)\r\n);";
        private const string CreateTeamBlobSql = "\r\nCREATE TABLE team_blob (\r\n    data_scope INTEGER NOT NULL,\r\n    team_id    INTEGER NOT NULL,\r\n    payload    BLOB NOT NULL,\r\n    PRIMARY KEY (data_scope, team_id)\r\n);";
        private const string CreateMatchBlobSql = "\r\nCREATE TABLE match_blob (\r\n    data_scope    INTEGER NOT NULL,\r\n    competition_id INTEGER NOT NULL,\r\n    match_id      INTEGER NOT NULL,\r\n    payload       BLOB NOT NULL,\r\n    PRIMARY KEY (data_scope, competition_id, match_id)\r\n);";
        internal static byte[] ReadRootPayload(string path)
        {
            return null;
        }

        internal static void Hydrate(string path, global::Google.Protobuf.IMessage root)
        {
        }

        internal static void Save(string path, global::Google.Protobuf.IMessage root, bool rootDirty, global::FLGameProgressSetting.ArchiveEntityReconcileFlags reconcileFlags, global::System.Collections.Generic.IReadOnlyCollection<global::FLGameProgressSetting.ArchiveScopedId> dirtyPlayers, global::System.Collections.Generic.IReadOnlyCollection<global::FLGameProgressSetting.ArchiveScopedId> dirtyTeams, global::System.Collections.Generic.IReadOnlyCollection<global::FLGameProgressSetting.ArchiveMatchId> dirtyMatches)
        {
        }

        internal static void Delete(string path)
        {
        }

        private static void RequirePath(string path)
        {
        }

        private static global::SQLite.SQLiteConnection OpenForReadWithRecovery(string path)
        {
            return null;
        }

        private static void CreateSchema(global::SQLite.SQLiteConnection connection)
        {
        }

        private static void RequireSchemaVersion(global::SQLite.SQLiteConnection connection)
        {
        }

        private static byte[] ReadRequiredRoot(global::SQLite.SQLiteConnection connection)
        {
            return null;
        }

        private static global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout BuildLayout(global::Google.Protobuf.IMessage root)
        {
            return null;
        }

        private static void AddSeason(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, int scope, global::Srv.SeasonData season)
        {
        }

        private static void AddWorldCup(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, int scope, global::Srv.WorldCupData worldCup, bool includePlayerAndTeam)
        {
        }

        private static int ComposeCompetitionId(MatchManagerType type, int id)
        {
            return 0;
        }

        private static void AddPlayerContainer(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, int scope, global::Srv.ClubPlayerDatabase database)
        {
        }

        private static void AddTeamContainer(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, int scope, global::Srv.ClubTeamDatabase database)
        {
        }

        private static void AddMatchContainer(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, int scope, int competitionId, global::Google.Protobuf.IMessage container, global::Google.Protobuf.Collections.RepeatedField<global::Srv.MatchData> matches)
        {
        }

        private static byte[] SerializeRootWithoutSplitData(global::Google.Protobuf.IMessage root, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
            return null;
        }

        private static global::System.Collections.Generic.HashSet<object> CollectSplitCollections(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
            return null;
        }

        private static global::Google.Protobuf.IMessage ProjectMessage(global::Google.Protobuf.IMessage source, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.HashSet<object> splitCollections, global::System.Collections.Generic.HashSet<object> omittedCollections)
        {
            return null;
        }

        private static void CopyMap(global::Google.Protobuf.IMessage target, global::Google.Protobuf.Reflection.FieldDescriptor field, global::System.Collections.IDictionary source, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.HashSet<object> splitCollections, global::System.Collections.Generic.HashSet<object> omittedCollections)
        {
        }

        private static void CopyRepeated(global::Google.Protobuf.IMessage target, global::Google.Protobuf.Reflection.FieldDescriptor field, global::System.Collections.IList source, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.HashSet<object> splitCollections, global::System.Collections.Generic.HashSet<object> omittedCollections)
        {
        }

        private static object ProjectValue(object value, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.HashSet<object> splitCollections, global::System.Collections.Generic.HashSet<object> omittedCollections)
        {
            return null;
        }

        private static void ClearSplitData(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
        }

        private static global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveScopedId, global::Srv.ClubPlayerData> CollectPlayers(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
            return null;
        }

        private static global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveScopedId, global::Srv.ClubTeamData> CollectTeams(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
            return null;
        }

        private static global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveMatchId, global::Srv.MatchData> CollectMatches(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
            return null;
        }

        private static void ReconcilePlayers(global::SQLite.SQLiteConnection connection, global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveScopedId, global::Srv.ClubPlayerData> current)
        {
        }

        private static void ReconcileTeams(global::SQLite.SQLiteConnection connection, global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveScopedId, global::Srv.ClubTeamData> current)
        {
        }

        private static void ReconcileMatches(global::SQLite.SQLiteConnection connection, global::System.Collections.Generic.Dictionary<global::FLGameProgressSetting.ArchiveMatchId, global::Srv.MatchData> current)
        {
        }

        private static void SaveDirtyPlayers(global::SQLite.SQLiteConnection connection, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.IReadOnlyCollection<global::FLGameProgressSetting.ArchiveScopedId> dirty)
        {
        }

        private static void SaveDirtyTeams(global::SQLite.SQLiteConnection connection, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.IReadOnlyCollection<global::FLGameProgressSetting.ArchiveScopedId> dirty)
        {
        }

        private static void SaveDirtyMatches(global::SQLite.SQLiteConnection connection, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::System.Collections.Generic.IReadOnlyCollection<global::FLGameProgressSetting.ArchiveMatchId> dirty)
        {
        }

        private static bool TryGetPlayer(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::FLGameProgressSetting.ArchiveScopedId key, out global::Srv.ClubPlayerData data)
        {
            data = null;
            return false;
        }

        private static bool TryGetTeam(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::FLGameProgressSetting.ArchiveScopedId key, out global::Srv.ClubTeamData data)
        {
            data = null;
            return false;
        }

        private static bool TryGetMatch(global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout, global::FLGameProgressSetting.ArchiveMatchId key, out global::Srv.MatchData data)
        {
            data = null;
            return false;
        }

        private static void HydratePlayers(global::SQLite.SQLiteConnection connection, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
        }

        private static void HydrateTeams(global::SQLite.SQLiteConnection connection, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
        }

        private static void HydrateMatches(global::SQLite.SQLiteConnection connection, global::FLGameProgressSetting.ArchiveSqliteStore.ArchiveLayout layout)
        {
        }

        private static global::Srv.ClubPlayerData ParsePlayer(byte[] payload)
        {
            return null;
        }

        private static global::Srv.ClubTeamData ParseTeam(byte[] payload)
        {
            return null;
        }

        private static global::Srv.MatchData ParseMatch(byte[] payload)
        {
            return null;
        }
    }
}