public class Win_Stadium : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform toggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject mask;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button close;
    [global::UnityEngine.SerializeField]
    private new global::UnityEngine.UI.Text name;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text year;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text capacity;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image image;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShop;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnDownload;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider progressSlider;
    private int[] stadiums;
    private int[] stadiums_noIap;
    private global::System.Action<int> action;
    private int currentStadiumIdx;
    private global::System.Collections.Generic.List<global::UnityEngine.Coroutine> Coroutines;
    private PlayAssetDeliverLoader.LoadTask curTask;
    public Win_Stadium Init(global::System.Action<int> onSelect, int cur)
    {
        return null;
    }

    private void OpenShop()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private void UpdateItem(int idx, global::UnityEngine.Transform item)
    {
    }

    private void OnSelect(int idx, bool isOn)
    {
    }

    private void UpdateDownloadAction()
    {
    }

    public void OnOpen()
    {
    }

    private void OnDisable()
    {
    }

    private void UpdateItem(global::UnityEngine.Transform item, string bundleName, string assetFullName)
    {
    }

    private global::System.Collections.IEnumerator UpdatePrograss(PlayAssetDeliverLoader.LoadTask task, global::UnityEngine.Transform item)
    {
        return null;
    }
}