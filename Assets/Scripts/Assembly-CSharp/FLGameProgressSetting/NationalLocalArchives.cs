namespace FLGameProgressSetting
{
    public class NationalLocalArchives : global::FLGameProgressSetting.CompetitionLocalArchives
    {
        public global::Srv.WorldCupData data;
        private PlayerManager playerManager;
        private TeamDataManager teamDataManager;
        public override PlayerManager PlayerManager => null;
        public override TeamDataManager TeamDataManager => null;
        protected override global::Google.Protobuf.IMessage Setting => null;

        public NationalLocalArchives(string fileName) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }

        public override void Init()
        {
        }

        public void StartNewStage(global::FLGameProgressSetting.NationalLocalArchives previous)
        {
        }
    }
}