public class ForwardBackwardController : global::UnityEngine.MonoBehaviour
{
    public enum BackBtnStyle
    {
        Back = 0,
        Home = 1
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnHome;
    private void SetBackBtnStyle(ForwardBackwardController.BackBtnStyle style)
    {
    }

    public void AutoCheckBackBtnStyle()
    {
    }

    public void Init(bool showBackBtn, global::UnityEngine.Events.UnityAction backAction, bool showNextBtn, global::UnityEngine.Events.UnityAction nextAction, ForwardBackwardController.BackBtnStyle backBtnStyle = ForwardBackwardController.BackBtnStyle.Back)
    {
    }

    public void SetBackBtnAction(bool showBackBtn, global::UnityEngine.Events.UnityAction back)
    {
    }

    public void SetNextBtnAction(bool showNextBtn, global::UnityEngine.Events.UnityAction next)
    {
    }

    public void SetBackCloseAction()
    {
    }

    public void SetNextCloseAction()
    {
    }

    public global::UnityEngine.UI.Button GetBackKeyHandler()
    {
        return null;
    }

    public static void SetCloseAction(global::UnityEngine.UI.Button button, global::Common.WindowBase window)
    {
    }

    public static void SetBtnAction(global::UnityEngine.UI.Button btn, bool showBtn, global::UnityEngine.Events.UnityAction action)
    {
    }

    public void SetNextBtnActive(bool active)
    {
    }
}