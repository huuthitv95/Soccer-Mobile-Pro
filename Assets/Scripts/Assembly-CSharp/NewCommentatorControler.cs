public class NewCommentatorControler : ICommentatorControler
{
    private struct OverviewCommentary
    {
        public int timeStart;
        public int timeEnd;
        public global::System.Func<IMatch, AllCommentaryIds.CommentaryID> getCommentary;
        public OverviewCommentary(int timeStart, int timeEnd, global::System.Func<IMatch, AllCommentaryIds.CommentaryID> getComment)
        {
            this.timeStart = 0;
            this.timeEnd = 0;
            getCommentary = null;
        }
    }

    private const int eventInterval = 0;
    private global::System.Collections.Generic.Dictionary<OpCode, global::System.Collections.Generic.List<CommentatorTrigger>> triggers;
    private global::System.Collections.Generic.Dictionary<FLClientOpCode, global::System.Collections.Generic.List<CommentatorTrigger>> clientTriggers;
    private global::System.Collections.Generic.List<CommentatorTrigger> allTriggers;
    private IMatch aimatch;
    private global::System.Collections.Generic.Queue<NewCommentatorControler.OverviewCommentary> overviewCommentaries;
    private bool secondHalfOverview;
    private float lastMatchTime;
    private global::LRUCache.LRUCache<AllCommentaryIds.CommentaryID, global::UnityEngine.AudioClip> clipCache;
    private AudioAdTrigger.OnceOnlyTrigger audioAdTrigger;
    private AudioAdTrigger.OnceOnlyTrigger audioAdTrigger2;
    private int currentEventInterval;
    private float lastEventTime;
    private CommentatorTrigger.CommentatorCommand currentPlayCommand;
    private CommentatorTrigger.CommentatorCommand? highestPriorityCommands;
    private global::UnityEngine.WaitForSeconds waitForSeconds;
    public global::UnityEngine.AudioSource audioSource { private get; set; }
    public global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public global::System.Collections.Generic.IEnumerable<FLClientOpCode> FocusClientOpcode => null;
    public global::System.Func<string, global::UnityEngine.AudioClip> LoadClip { private get; set; }
    public global::UnityEngine.MonoBehaviour monoHelper { private get; set; }

    public void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public void HandleMessage(FLClientOpCode code, object message, IMatch match)
    {
    }

    public void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public void OnMatchStart(IMatch match)
    {
    }

    private bool CheckOverviewCommentary(IMatch match)
    {
        return false;
    }

    private static AllCommentaryIds.CommentaryID CheckFirstHalfOverview(IMatch match)
    {
        return null;
    }

    private static AllCommentaryIds.CommentaryID CheckSecondHalfOverview(IMatch match)
    {
        return null;
    }

    public void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    private void PlaySound(AllCommentaryIds.CommentaryID id)
    {
    }

    private global::System.Collections.IEnumerator CheckHighestPriorityCommands()
    {
        return null;
    }

    private bool HandleCommand(CommentatorTrigger.CommentatorCommand command, IMatch match)
    {
        return false;
    }

    private global::System.Collections.IEnumerator DelayedCommands(CommentatorTrigger.CommentatorCommand command, IMatch match)
    {
        return null;
    }
}