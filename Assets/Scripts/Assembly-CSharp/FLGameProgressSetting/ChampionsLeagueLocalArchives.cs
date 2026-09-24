namespace FLGameProgressSetting
{
    public class ChampionsLeagueLocalArchives : global::FLGameProgressSetting.CompetitionLocalArchives
    {
        public global::Srv.WorldCupData Data;
        private PlayerManager playerManager;
        private TeamDataManager teamDataManager;
        public override PlayerManager PlayerManager => null;
        public override TeamDataManager TeamDataManager => null;
        protected override global::Google.Protobuf.IMessage Setting => null;

        public ChampionsLeagueLocalArchives(string fileName) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }

        public override void Init()
        {
        }
    }
}