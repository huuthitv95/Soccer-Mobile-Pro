namespace FLGameProgressSetting
{
    public class SeasonDataThumbnailArchives : global::FLGameProgressSetting.LocalArchives
    {
        public global::Srv.SeasonDataThumbnailDatabase Data;
        protected override global::Google.Protobuf.IMessage Setting => null;

        public void SaveThumbnail(string name, global::Srv.SeasonData target)
        {
        }

        public void RemoveThumbnail(string name)
        {
        }

        public SeasonDataThumbnailArchives(string fileName, global::FLGameProgressSetting.LocalArchives.ArchiveType archiveType) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }
    }
}