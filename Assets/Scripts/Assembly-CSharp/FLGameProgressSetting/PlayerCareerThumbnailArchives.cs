namespace FLGameProgressSetting
{
    public class PlayerCareerThumbnailArchives : global::FLGameProgressSetting.LocalArchives
    {
        public global::Srv.PlayerCareerThumbnailDatabase Data;
        protected override global::Google.Protobuf.IMessage Setting => null;

        public void SaveThumbnail(string name, PlayerCareerLocalArchives target)
        {
        }

        public void RemoveThumbnail(string name)
        {
        }

        public PlayerCareerThumbnailArchives(string fileName, global::FLGameProgressSetting.LocalArchives.ArchiveType archiveType) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
        {
        }
    }
}