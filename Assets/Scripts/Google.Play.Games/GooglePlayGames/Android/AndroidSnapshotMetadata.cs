namespace GooglePlayGames.Android
{
	internal class AndroidSnapshotMetadata : global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata
	{
		private global::UnityEngine.AndroidJavaObject mJavaSnapshot;

		private global::UnityEngine.AndroidJavaObject mJavaMetadata;

		private global::UnityEngine.AndroidJavaObject mJavaContents;

		public global::UnityEngine.AndroidJavaObject JavaSnapshot => null;

		public global::UnityEngine.AndroidJavaObject JavaMetadata => null;

		public global::UnityEngine.AndroidJavaObject JavaContents => null;

		public bool IsOpen => false;

		public string Filename => null;

		public string Description => null;

		public string CoverImageURL => null;

		public global::System.TimeSpan TotalTimePlayed => default;

		public global::System.DateTime LastModifiedTimestamp => default;

		public AndroidSnapshotMetadata(global::UnityEngine.AndroidJavaObject javaSnapshot)
		{
		}

		public AndroidSnapshotMetadata(global::UnityEngine.AndroidJavaObject javaMetadata, global::UnityEngine.AndroidJavaObject javaContents)
		{
		}
	}
}
