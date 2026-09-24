public class GUIBottomBar : global::UnityEngine.MonoBehaviour
{
    public enum BackBtnType
    {
        Back = 0,
        Home = 1
    }

    public enum NextBtnType
    {
        Next = 0,
        Play = 1
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button[] backBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button[] nextBtn;
    public void SetBackAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void SetNextAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void SetBackBtnType(GUIBottomBar.BackBtnType type)
    {
    }

    public void SetNextBtnType(GUIBottomBar.NextBtnType type)
    {
    }

    public void Init(global::UnityEngine.Events.UnityAction backAction, global::UnityEngine.Events.UnityAction nextAction, GUIBottomBar.BackBtnType backType = GUIBottomBar.BackBtnType.Back, GUIBottomBar.NextBtnType nextType = GUIBottomBar.NextBtnType.Next)
    {
    }
}