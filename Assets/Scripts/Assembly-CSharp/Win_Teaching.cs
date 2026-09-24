public class Win_Teaching : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUITeaching pageView;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_Close;
    private global::System.Collections.Generic.List<bool> flags;
    [global::UnityEngine.SerializeField]
    private StringID text;
    private global::System.Action action;
    public override void OnOpen(object parameter)
    {
    }

    public void SetOnCompleteAction(global::System.Action action)
    {
    }
}