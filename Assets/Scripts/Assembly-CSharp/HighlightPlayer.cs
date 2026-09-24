public class HighlightPlayer
{
    private TestSample aiMatch;
    private CupMatchBase match;
    private HighlightArchive HighlightArchive;
    private global::System.Action quitAction;
    private global::UnityEngine.UI.Button btnSkip;
    private global::UnityEngine.UI.Button btnNext;
    private global::UnityEngine.Transform root;
    private HighlightArchive.HL_MatchPhase start;
    private HighlightArchive.HL_MatchPhase end;
    private global::EngineMessages.ShootHighlightArchiveData? current;
    private global::UnityEngine.Vector3 shootPos;
    private global::System.Collections.Generic.LinkedList<global::EngineMessages.CompactFrameDetail> frames;
    private global::UnityEngine.Coroutine co;
    private float ReplaySpeed;
    private static float aiframeDt;
    private global::UnityEngine.Camera[] cameras;
    private global::UnityEngine.Camera[] camerasMirror;
    private global::UnityEngine.Camera selectCamera;
    private int currentRandomIndex;
    private global::UnityEngine.Vector3? lastBallPos;
    private global::UnityEngine.Vector3 Target => default;

    public HighlightPlayer(TestSample aiMatch, HighlightArchive HighlightArchive, CupMatchBase match, global::System.Action quitAction, global::UnityEngine.Transform root, global::EngineMessages.MatchPhase matchPhase)
    {
    }

    public void Start()
    {
    }

    private void load()
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

    public void StartReplayCamera()
    {
    }

    public void StopRelayCamera()
    {
    }

    public void UpdateCamera(bool smooth = true)
    {
    }

    public static bool ApplyAvatar(global::EngineMessages.ShootHighlightArchiveData? current, TestSample aiMatch)
    {
        return false;
    }

    public static void Reset(TestSample aiMatch)
    {
    }
}