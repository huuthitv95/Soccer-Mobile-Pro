public class Win_Explain : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private HyperlinkText text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button close;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button confirm;
    private global::System.Action<string> onclick;
    public override void OnOpen(object parameter)
    {
    }

    public Win_Explain Fill(string context, global::System.Action<string> onClick, string btnText)
    {
        return null;
    }

    public void CloseWindow()
    {
    }
}