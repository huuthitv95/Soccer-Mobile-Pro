public class DeferredAction
{
    private bool isDelayEnabled;
    private global::System.Action pendingAction;
    public bool InvokeOrDefer(global::System.Action callback)
    {
        return false;
    }

    public void SetDelayEnabled(bool isDelayEnabled)
    {
    }
}