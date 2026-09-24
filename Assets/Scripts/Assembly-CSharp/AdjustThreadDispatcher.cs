public class AdjustThreadDispatcher : global::UnityEngine.MonoBehaviour
{
    private static readonly global::System.Collections.Generic.Queue<global::System.Action> executionQueue;
    private static AdjustThreadDispatcher instance;
    public static void RunOnMainThread(global::System.Action action)
    {
    }

    private void Update()
    {
    }

    private static void Initialize()
    {
    }
}