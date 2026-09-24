public class Win_SupportConfirm : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text desc;
    private global::UnityEngine.Events.UnityAction<Win_Setting.SupportType> confirmAction;
    private int curStep;
    public override void OnOpen(object parameter)
    {
    }

    public Win_SupportConfirm Fill(global::UnityEngine.Events.UnityAction<Win_Setting.SupportType> confirmAction)
    {
        return null;
    }

    private void UpdateSecondStep(Win_Setting.SupportType type)
    {
    }

    private void UpdateFirstStep()
    {
    }

    private void RegistButton(Win_Setting.SupportType type, global::UnityEngine.UI.Button button)
    {
    }

    public void OnClickClose()
    {
    }
}