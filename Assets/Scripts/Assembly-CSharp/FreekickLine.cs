public class FreekickLine : MatchListener
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer line;
    private bool needHide;
    private global::UnityEngine.Coroutine co;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public override void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel tol, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    private void Show()
    {
    }

    private global::System.Collections.IEnumerator Hide()
    {
        return null;
    }

    public override void PreDestroy(IMatch match)
    {
    }
}