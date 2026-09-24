namespace GooglePlayGames.BasicApi.Events
{
	internal class Event : global::GooglePlayGames.BasicApi.Events.IEvent
	{
		private string mId;

		private string mName;

		private string mDescription;

		private string mImageUrl;

		private ulong mCurrentCount;

		private global::GooglePlayGames.BasicApi.Events.EventVisibility mVisibility;

		public string Id => null;

		public string Name => null;

		public string Description => null;

		public string ImageUrl => null;

		public ulong CurrentCount => 0uL;

		public global::GooglePlayGames.BasicApi.Events.EventVisibility Visibility => (global::GooglePlayGames.BasicApi.Events.EventVisibility)0;

		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, global::GooglePlayGames.BasicApi.Events.EventVisibility visibility)
		{
		}
	}
}
