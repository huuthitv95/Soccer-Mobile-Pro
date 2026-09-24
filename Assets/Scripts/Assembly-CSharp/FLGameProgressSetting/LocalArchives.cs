namespace FLGameProgressSetting
{
    public abstract class LocalArchives
    {
        public enum ArchiveType
        {
            Friendly = 0,
            Club = 1,
            ML = 2,
            National = 3,
            Static = 4,
            SimpleClub = 5,
            CustomLeague = 6,
            ChampionsLeague = 7,
            PlayerCareer = 8,
            Common = 9
        }

        protected global::FLGameProgressSetting.LocalArchives.ArchiveType archiveType;
        private string fileName;
        protected bool dirty;
        private global::FLGameProgressSetting.ArchiveEntityReconcileFlags entityReconcileFlags;
        private readonly global::System.Collections.Generic.HashSet<global::FLGameProgressSetting.ArchiveScopedId> dirtyPlayers;
        private readonly global::System.Collections.Generic.HashSet<global::FLGameProgressSetting.ArchiveScopedId> dirtyTeams;
        private readonly global::System.Collections.Generic.HashSet<global::FLGameProgressSetting.ArchiveMatchId> dirtyMatches;
        public static string basePath => null;
        public string relativePath => null;
        private string path => null;
        private string databasePath => null;
        private string externalpath => null;
        private string backupPath => null;
        public virtual int DataScope => 0;
        public string FileName => null;
        protected abstract global::Google.Protobuf.IMessage Setting { get; }
        protected bool HasPendingChanges => false;

        public global::FLGameProgressSetting.LocalArchives.ArchiveType GetArchiveType()
        {
            return global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly;
        }

        public virtual void MarkDirty()
        {
        }

        public virtual void MarkPlayerStructureDirty()
        {
        }

        public virtual void MarkTeamStructureDirty()
        {
        }

        public virtual void MarkMatchStructureDirty()
        {
        }

        public virtual void MarkAllEntityStructuresDirty()
        {
        }

        private void MarkEntityStructureDirty(global::FLGameProgressSetting.ArchiveEntityReconcileFlags flags)
        {
        }

        public virtual void MarkPlayerDirty(int playerId)
        {
        }

        public virtual void MarkPlayerDirty(int dataScope, int playerId)
        {
        }

        public virtual void MarkTeamDirty(int teamId)
        {
        }

        public virtual void MarkTeamDirty(int dataScope, int teamId)
        {
        }

        public virtual void MarkMatchDirty(int competitionId, int matchId)
        {
        }

        public virtual void MarkMatchDirty(int dataScope, int competitionId, int matchId)
        {
        }

        public byte[] GetBytes(out int size)
        {
            size = default;
            return null;
        }

        public static void DeleteALL()
        {
        }

        private void SavePendingChanges(bool forceFullSave)
        {
        }

        private void ClearPendingChanges()
        {
        }

        public void SaveToFile()
        {
        }

        public void SaveIapCriticalImmediate()
        {
        }

        public bool TrySaveIapCriticalImmediate(out string error)
        {
            error = null;
            return false;
        }

        public virtual void Delete()
        {
        }

        public virtual void CheckDirtyFlag()
        {
        }

        public virtual void Init()
        {
        }

        public LocalArchives(string fileName, global::FLGameProgressSetting.LocalArchives.ArchiveType archiveType)
        {
        }
    }
}