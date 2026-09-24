public class DebugReplayController : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button upspeed;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button downspeed;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button play;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button pause;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text speedTxt;
    private TestSample _matchController;
    public TestSample MatchController
    {
        set
        {
        }
    }

    public void PauseReplay()
    {
    }

    public void ResumeReplay()
    {
    }

    public void OnSpeedUp()
    {
    }

    public void OnSpeedDown()
    {
    }
}