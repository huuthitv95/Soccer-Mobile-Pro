public class Win_ConfirmRV : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOK;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    private global::UnityEngine.Events.UnityAction closeAction;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(global::UnityEngine.Events.UnityAction action, string pos, global::UnityEngine.Events.UnityAction closeAction)
    {
    }
}