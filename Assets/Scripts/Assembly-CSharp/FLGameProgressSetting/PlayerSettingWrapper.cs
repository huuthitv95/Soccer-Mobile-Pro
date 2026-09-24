namespace FLGameProgressSetting
{
    public class PlayerSettingWrapper : global::FLGameProgressSetting.LocalArchives
    {
        protected override global::Google.Protobuf.IMessage Setting => null;

        public PlayerSettingWrapper(string path) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
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
    }
}