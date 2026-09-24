public class Win_FakeMatchResult : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] winGO;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] drawGO;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] loseGO;
    [global::UnityEngine.SerializeField]
    private GUITeam home;
    [global::UnityEngine.SerializeField]
    private GUITeam away;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text score;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    private void SetVisable(global::UnityEngine.GameObject[] gameObjects, bool visable)
    {
    }

    public override void OnOpen(object parameter)
    {
    }
}