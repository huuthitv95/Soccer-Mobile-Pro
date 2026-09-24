public class Win_DownloadImage : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField inputField;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOk;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    private global::System.Action<global::UnityEngine.Texture2D> action;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::System.Action<global::UnityEngine.Texture2D> action)
    {
    }

    private void download()
    {
    }
}