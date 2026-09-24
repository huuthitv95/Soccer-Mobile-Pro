namespace FLGameProgressSetting
{
	public class FriendlyDataLocalArchives : global::FLGameProgressSetting.LocalArchives
	{
		private global::Srv.FriendlyData data;

		public global::Srv.FriendlyData Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override global::Google.Protobuf.IMessage Setting => null;

		public FriendlyDataLocalArchives(string fileName)
			: base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
		{
		}
	}
}
