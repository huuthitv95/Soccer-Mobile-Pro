internal sealed class GoogleCloudSaveInterface : ICloudSaveStorage
{
    private global::GooglePlayGames.BasicApi.SavedGame.ISavedGameClient Client => null;

    public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<CloudSaveFile>> FetchAsync(global::System.Threading.CancellationToken cancellation)
    {
        return null;
    }

    private global::System.Threading.Tasks.Task<global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> OpenAsync(string name, global::System.Threading.CancellationToken cancellation)
    {
        return null;
    }

    public global::System.Threading.Tasks.Task<byte[]> ReadAsync(string name, global::System.Threading.CancellationToken cancellation)
    {
        return null;
    }

    public global::System.Threading.Tasks.Task<CloudSaveFile> WriteAsync(string name, byte[] data, string description, global::System.Threading.CancellationToken cancellation)
    {
        return null;
    }

    public global::System.Threading.Tasks.Task DeleteAsync(string name, global::System.Threading.CancellationToken cancellation)
    {
        return null;
    }

    private void CloseSnapshot(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game)
    {
    }

    private static bool Succeeded<T>(global::GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus status, global::System.Threading.Tasks.TaskCompletionSource<T> completion)
    {
        return false;
    }

    private static CloudSaveFile Metadata(global::GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata game)
    {
        return null;
    }
}