public class RewardWithVideo : global::UnityEngine.MonoBehaviour
{
    public enum RewindType
    {
        Free = 0,
        Medal = 1,
        Video = 2,
        RewindCoin = 3,
        GoldCoin = 4
    }

    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> rewardVideoBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button closeBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    [global::UnityEngine.SerializeField]
    private string VideoLogName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text _videohint;
    [global::UnityEngine.SerializeField]
    private bool hideWindow;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<ADButtonStateBase> rewardVideoBtnNew;
    public global::System.Func<bool> CheckCanWatchVideo;
    private ScreenTimeTracker screenTimeTracker;
    public global::UnityEngine.Events.UnityEvent OnVideoSucceed;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action m_OnVideoStart;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action m_OnVideoAbort;
    public static bool VideoCheat;
    private static global::System.DateTime lastRVSucceedTime;
    private global::System.Collections.Generic.List<string> IVReplaceRVPrefix;
    private global::System.Collections.Generic.List<string> IVReplaceRVSuffix;
    public string VideoTunnel => null;

    public event global::System.Action OnVideoStart
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public event global::System.Action OnVideoAbort
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public void SetTunnel(VideoTunnel t)
    {
    }

    public void SetTunnel(string t)
    {
    }

    private void UpdateButtonState(ADButtonStateBase btn, bool state)
    {
    }

    public void AddButton(ADButtonStateBase btn)
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    private void RefreshAdLoaded()
    {
    }

    private global::System.Collections.IEnumerator ShowClose()
    {
        return null;
    }

    public void OnVideoButton()
    {
    }

    public void RemoveAllListeners()
    {
    }

    public void Close()
    {
    }

    private bool MatchPrePostFix(int pre, int post)
    {
        return false;
    }

    private bool IVReplaceRV()
    {
        return false;
    }
}