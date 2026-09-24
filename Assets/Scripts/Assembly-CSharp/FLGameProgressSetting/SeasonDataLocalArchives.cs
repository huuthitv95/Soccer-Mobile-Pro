namespace FLGameProgressSetting
{
    public class SeasonDataLocalArchives : global::FLGameProgressSetting.CompetitionLocalArchives
    {
        public global::Srv.SeasonData Data;
        private global::FLGameProgressSetting.CompetitionLocalArchives agent;
        private string editeableKey;
        private ExternalDataAgent _EditableAchiveAgent;
        private PlayerManager playerManager;
        private TeamDataManager teamDataManager;
        public ExternalDataAgent EditableAchiveAgent => null;
        public override PlayerManager PlayerManager => null;
        public override TeamDataManager TeamDataManager => null;
        protected override global::Google.Protobuf.IMessage Setting => null;

        public void SetEditeableKey(string key)
        {
        }

        public global::Srv.LeagueData GetLeagueDataByName(string name)
        {
            return null;
        }

        public global::Srv.LeagueData GetLeagueDataById(int id)
        {
            return null;
        }

        public global::Srv.WorldCupData GetCupDataById(int id)
        {
            return null;
        }

        public void AddCupData(int id, global::Srv.WorldCupData data)
        {
        }

        public override void MarkDirty()
        {
        }

        public override void MarkPlayerStructureDirty()
        {
        }

        public override void MarkTeamStructureDirty()
        {
        }

        public override void MarkMatchStructureDirty()
        {
        }

        public override void MarkAllEntityStructuresDirty()
        {
        }

        public override void MarkPlayerDirty(int dataScope, int playerId)
        {
        }

        public override void MarkTeamDirty(int dataScope, int teamId)
        {
        }

        public override void MarkMatchDirty(int dataScope, int competitionId, int matchId)
        {
        }

        public override void CheckDirtyFlag()
        {
        }

        public override void Delete()
        {
        }

        public SeasonDataLocalArchives(string fileName, global::FLGameProgressSetting.LocalArchives.ArchiveType archiveType, global::FLGameProgressSetting.CompetitionLocalArchives agent = null) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }

        public override void Init()
        {
        }
    }
}