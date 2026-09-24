public class Win_Input : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField inputField;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOk;
    private global::System.Action<string> action;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::System.Action<string> action)
    {
    }
}