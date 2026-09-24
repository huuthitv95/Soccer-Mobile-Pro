public class Win_SubstitutedOutTip : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private ChangeGraphicColor[] changeGraphicColors;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject card;
    private const float DisplayDuration = 3f;
    private global::UnityEngine.Coroutine closeCoroutine;
    public void Show(bool isRedCardSentOff, global::System.Action onClosed = null)
    {
    }

    public override void OnClose()
    {
    }
}