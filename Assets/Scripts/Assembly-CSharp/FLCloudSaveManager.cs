public class FLCloudSaveManager : global::Common.Singleton<FLCloudSaveManager>
{
    public struct SavedDataInfo
    {
        public string filename;
        public string desc;
        public global::System.DateTime lastModified;
        public string DisplayName => null;
    }

    private global::System.Threading.CancellationTokenSource operation;
    private readonly ICloudSaveStorage storage;
    private readonly CloudSaveTransfer transfer;
    private global::System.Collections.Generic.List<CloudSaveFile> files;
    private string stage;
    public string LastError { get; private set; }
    public bool IsBusy => false;
    public bool IsAuthenucated => false;
    public string UploadSuccessMessageKey => null;
    public global::System.Collections.Generic.List<FLCloudSaveManager.SavedDataInfo> AllSavedGames => null;

    public void Authenticate(global::System.Action<bool> onLoginResult)
    {
    }

    public void FetchAllSavedGames(global::System.Action<bool, global::System.Collections.Generic.List<FLCloudSaveManager.SavedDataInfo>> callback)
    {
    }

    public void CreateNew(string name, bool includedEditedData, global::System.Action<bool> callback)
    {
    }

    public void SaveGameData(string filename, bool includedEditedData, global::System.Action<bool> callback)
    {
    }

    public void LoadGameData(string filename, global::System.Action<bool> callback)
    {
    }

    public void DeleteSavedGame(FLCloudSaveManager.SavedDataInfo game, global::System.Action<bool> callback)
    {
    }

    private void RunOperation(string action, global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> work, global::System.Action<bool> callback)
    {
    }

    private void ReportStage(string value)
    {
    }
}