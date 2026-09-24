public class Win_CloudSavePanel : global::Common.WindowBase
{
    private enum PanelType
    {
        Create = 0,
        Upload = 1,
        Download = 2,
        Delete = 3
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform createPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform uploadPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform downloadPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform deletePanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    public override void OnOpen(object parameter)
    {
    }

    private void ShowPanel(Win_CloudSavePanel.PanelType panelType)
    {
    }

    public void ShowCreatePanel(global::System.Action<bool> OnCreate)
    {
    }

    public void ShowUploadPanel(FLCloudSaveManager.SavedDataInfo data, global::System.Action<bool> OnUpload)
    {
    }

    public void ShowDownloadPanel(FLCloudSaveManager.SavedDataInfo data, global::System.Action<bool> OnDownload)
    {
    }

    public void ShowDeletePanel(FLCloudSaveManager.SavedDataInfo data, global::System.Action<bool> OnDelete)
    {
    }

    private void SetBusy(bool busy, global::UnityEngine.UI.Button confirm)
    {
    }
}