public class Commentary : MatchListener
{
    [global::UnityEngine.SerializeField]
    private TestSample messageCenter;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI textMeshPro;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Animation anim;
    [global::UnityEngine.SerializeField]
    private Tween_MessageBoard messageBoard;
    private global::UnityEngine.Coroutine commentaryCO;
    private global::UnityEngine.Color colorCommentaryBad;
    private bool ScoreChanged;
    private TestSample aiMatch;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    private void Awake()
    {
    }

    private void AutoCommentary(string strId, global::UnityEngine.Color color, bool isGoal = false)
    {
    }

    private global::System.Collections.IEnumerator HideCommentary(float time)
    {
        return null;
    }

    private void showMsg(string id)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}