public class HighlightSingleCycle
{
    private TestSample aiMatch;
    private CupMatchBase match;
    private HighlightArchive HighlightArchive;
    private global::System.Action quitAction;
    private global::System.Action onFirstFrame;
    private global::System.Action onCycleOver;
    private global::System.Collections.Generic.LinkedList<global::EngineMessages.CompactFrameDetail> frames;
    private global::UnityEngine.Coroutine co;
    private global::EngineMessages.ShootHighlightArchiveData? current;
    private int pos;
    private bool isPlaying;
    private bool isStop;
    private bool restart;
    private float ReplaySpeed;
    private static float aiframeDt;
    public HighlightSingleCycle(CupMatchBase match, TestSample aiMatch, HighlightArchive HighlightArchive, global::System.Action quitAction)
    {
    }

    public void Stop()
    {
    }

    public void Restart()
    {
    }

    public bool IsPlaying()
    {
        return false;
    }

    public bool PlayOrPause()
    {
        return false;
    }

    public void Start(int startPos, global::System.Action onFirstFrame, global::System.Action onCycleOver)
    {
    }

    private void Load()
    {
    }

    private void OnReplayOver()
    {
    }

    private global::System.Collections.IEnumerator Replay(IMatch match, global::System.Collections.Generic.LinkedListNode<global::EngineMessages.CompactFrameDetail> start, global::System.Collections.Generic.LinkedListNode<global::EngineMessages.CompactFrameDetail> end, global::System.Action OnFinish)
    {
        return null;
    }

    private global::System.Collections.IEnumerator DoReplay(IMatch match, global::System.Collections.Generic.LinkedListNode<global::EngineMessages.CompactFrameDetail> start, global::System.Collections.Generic.LinkedListNode<global::EngineMessages.CompactFrameDetail> end, global::System.Action OnFirstFramePlay)
    {
        return null;
    }
}