namespace GooglePlayGames.Android
{
    internal class AndroidSavedGameClient : global::GooglePlayGames.BasicApi.SavedGame.ISavedGameClient
    {
        private class AndroidConflictResolver : global::GooglePlayGames.BasicApi.SavedGame.IConflictResolver
        {
            private readonly global::UnityEngine.AndroidJavaObject mSnapshotsClient;
            private readonly global::UnityEngine.AndroidJavaObject mConflict;
            private readonly global::GooglePlayGames.Android.AndroidSnapshotMetadata mOriginal;
            private readonly global::GooglePlayGames.Android.AndroidSnapshotMetadata mUnmerged;
            private readonly global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> mCompleteCallback;
            private readonly global::System.Action mRetryFileOpen;
            private readonly global::GooglePlayGames.Android.AndroidSavedGameClient mAndroidSavedGameClient;
            internal AndroidConflictResolver(global::GooglePlayGames.Android.AndroidSavedGameClient androidSavedGameClient, global::UnityEngine.AndroidJavaObject snapshotClient, global::UnityEngine.AndroidJavaObject conflict, global::GooglePlayGames.Android.AndroidSnapshotMetadata original, global::GooglePlayGames.Android.AndroidSnapshotMetadata unmerged, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completeCallback, global::System.Action retryOpen)
            {
            }

            public void ResolveConflict(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
            {
            }

            public void ChooseMetadata(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata)
            {
            }
        }

        private static readonly global::System.Text.RegularExpressions.Regex ValidFilenameRegex;
        private global::UnityEngine.AndroidJavaObject mSnapshotsClient;
        private global::GooglePlayGames.Android.AndroidClient mAndroidClient;
        public AndroidSavedGameClient(global::GooglePlayGames.Android.AndroidClient androidClient)
        {
        }

        public void OpenWithAutomaticConflictResolution(string filename, global::GooglePlayGames.BasicApi.DataSource source, global::GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
        }

        public void OpenWithManualConflictResolution(string filename, global::GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, global::GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
        }

        private void InternalOpen(string filename, global::GooglePlayGames.BasicApi.DataSource source, global::GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, global::GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
        }

        public void ReadBinaryData(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> completedCallback)
        {
        }

        public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
        }

        public void CommitUpdate(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
        }

        public void FetchAllSavedGames(global::GooglePlayGames.BasicApi.DataSource source, global::System.Action<global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, global::System.Collections.Generic.List<global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback)
        {
        }

        private global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus FailureStatus(global::UnityEngine.AndroidJavaObject exception)
        {
            return (global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus)0;
        }

        public void Delete(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata)
        {
        }

        public void DiscardAndClose(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata)
        {
        }

        private global::GooglePlayGames.BasicApi.SavedGame.ConflictCallback ToOnGameThread(global::GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback)
        {
            return null;
        }

        internal static bool IsValidFilename(string filename)
        {
            return false;
        }

        private static global::UnityEngine.AndroidJavaObject AsMetadataChange(global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate update)
        {
            return null;
        }

        private static global::System.Action<T1, T2> ToOnGameThread<T1, T2>(global::System.Action<T1, T2> toConvert)
        {
            return null;
        }
    }
}