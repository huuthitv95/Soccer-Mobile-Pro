namespace FLGameProgressSetting
{
    public class CustomLeagueArchives : global::FLGameProgressSetting.LocalArchives
    {
        public global::Srv.CustomLeagueArchive Data;
        private global::System.Collections.Generic.Dictionary<int, global::FLGameProgressSetting.CustomLeagueSeasonData> Archives;
        protected override global::Google.Protobuf.IMessage Setting => null;

        public CustomLeagueArchives(string fileName) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }

        public global::FLGameProgressSetting.CustomLeagueSeasonData GetLeagueArchive(global::Srv.CustomLeagueTemplate template)
        {
            return null;
        }

        public void DeleteTemplates(global::Srv.CustomLeagueTemplate template)
        {
        }

        public int GetNextTemplateID()
        {
            return 0;
        }

        public string CheckDuplicationName(string name, int exclude = -1)
        {
            return null;
        }

        public override void CheckDirtyFlag()
        {
        }
    }
}