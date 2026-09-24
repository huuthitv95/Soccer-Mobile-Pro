namespace FLGameProgressSetting
{
    public class CustomLeagueSeasonData : global::FLGameProgressSetting.SeasonDataLocalArchives
    {
        private global::FLGameProgressSetting.CustomLeagueArchives agent;
        private int id;
        private bool scopedEntityDirty;
        public override int DataScope => 0;

        public CustomLeagueSeasonData(global::FLGameProgressSetting.CustomLeagueArchives agent, global::Srv.SeasonData seasonData, int id) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }

        public global::Srv.CustomLeagueTemplate GetTemplate()
        {
            return null;
        }

        public override void Delete()
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
    }
}