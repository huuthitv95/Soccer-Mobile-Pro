public class Win_TrainingMatchTip : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text content;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRetry;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform normal;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform finish;
    private bool actionInvoked;
    private static int adFlag;
    public override void OnOpen(object parameter)
    {
    }

    public Win_TrainingMatchTip Fill(string title, string content)
    {
        return null;
    }

    public Win_TrainingMatchTip ShowFinishTip(string title, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> progressText, global::System.Action retryAction, global::System.Action nextAction)
    {
        return null;
    }

    private void InvokeAction(global::System.Action action)
    {
    }
}