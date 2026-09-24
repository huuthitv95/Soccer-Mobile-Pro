public class Win_ChooseInputType : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform plan1;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform plan2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform plan5;
    private global::UnityEngine.UI.Toggle tgA;
    private global::UnityEngine.UI.Toggle tgB;
    private global::System.Action action;
    public override void OnOpen(object parameter)
    {
    }

    private void updateNextBtn()
    {
    }

    public void SetOnCompleteAction(global::System.Action action)
    {
    }
}