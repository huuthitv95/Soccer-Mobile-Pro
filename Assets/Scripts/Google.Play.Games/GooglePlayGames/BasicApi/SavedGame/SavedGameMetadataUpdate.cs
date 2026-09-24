namespace GooglePlayGames.BasicApi.SavedGame
{
	public struct SavedGameMetadataUpdate
	{
		public struct Builder
		{
			internal bool mDescriptionUpdated;

			internal string mNewDescription;

			internal bool mCoverImageUpdated;

			internal byte[] mNewPngCoverImage;

			internal global::System.TimeSpan? mNewPlayedTime;

			public global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description)
			{
				return default;
			}

			public global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default;
			}

			public global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(global::System.TimeSpan newPlayedTime)
			{
				return default;
			}

			public global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate Build()
			{
				return default;
			}
		}

		private readonly bool mDescriptionUpdated;

		private readonly string mNewDescription;

		private readonly bool mCoverImageUpdated;

		private readonly byte[] mNewPngCoverImage;

		private readonly global::System.TimeSpan? mNewPlayedTime;

		public bool IsDescriptionUpdated => false;

		public string UpdatedDescription => null;

		public bool IsCoverImageUpdated => false;

		public byte[] UpdatedPngCoverImage => null;

		public bool IsPlayedTimeUpdated => false;

		public global::System.TimeSpan? UpdatedPlayedTime => null;

		private SavedGameMetadataUpdate(global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder builder)
		{
			mDescriptionUpdated = false;
			mNewDescription = null;
			mCoverImageUpdated = false;
			mNewPngCoverImage = null;
			mNewPlayedTime = null;
		}
	}
}
