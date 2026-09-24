public class Win_TutorialTip : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text content;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOK;
    public override void OnOpen(object parameter)
    {
    }

    public static bool NeedShowTutorialTip()
    {
        return false;
    }

    public void ShowTutorialTip()
    {
    }

    public void ShowTutorialFinishTip()
    {
    }

    private void StartTrainingMatch()
    {
    }

    public static void StartTrainingMatch(int progress)
    {
    }
}