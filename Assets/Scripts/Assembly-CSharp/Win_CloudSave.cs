public class Win_CloudSave : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    private global::System.Collections.Generic.List<FLCloudSaveManager.SavedDataInfo> savedDataInfos;
    private const int MAX_SAVE_DATA = 4;
    public override void OnOpen(object parameter)
    {
    }

    private void UpdateUI()
    {
    }

    public override void OnClose()
    {
    }

    private bool CheckNetwork()
    {
        return false;
    }

    private void OnCreateClick()
    {
    }

    private void OnUploadClick(FLCloudSaveManager.SavedDataInfo data)
    {
    }

    private void OnInstallClick(FLCloudSaveManager.SavedDataInfo data)
    {
    }

    private void OndeleteClick(FLCloudSaveManager.SavedDataInfo data)
    {
    }
}