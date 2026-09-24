namespace GooglePlayGames.BasicApi.SavedGame
{
	public interface IConflictResolver
	{
		void ChooseMetadata(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata);

		void ResolveConflict(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, global::GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
	}
}
