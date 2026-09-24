public class AnimationPreview : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Material matLine;
    private bool start;
    private global::System.Collections.Generic.LinkedList<global::EngineMessages.FrameDetail> _frameBuffer;
    private global::EngineMessages.InputData _eventList;
    [global::UnityEngine.SerializeField]
    private global::Common.PlayerBoneHolder _skinPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject _ball;
    private global::System.Collections.Generic.List<string> _animNames;
    private int _animLength;
    private static readonly string NativeAnimPrefix;
    private static readonly string NativeNewAnimPrefix;
    private static readonly string AutoGeneratePrefix;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject _animNameTemplate;
    private int _curAnimID;
    private int _curFrame;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider _progressBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text _frameCountText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text _curanimName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text _extraAnimInfo;
    [global::UnityEngine.SerializeField]
    private bool _Usefilter;
    [global::UnityEngine.SerializeField]
    private int _IncommingSpeedFilter;
    [global::UnityEngine.SerializeField]
    private int _OutgoingSpeedFilter;
    [global::UnityEngine.SerializeField]
    private float[] AngleFilters;
    [global::UnityEngine.SerializeField]
    private bool[] validFilters;
    private global::System.Collections.Generic.Dictionary<global::UnityEngine.KeyCode, float> _pressTimer;
    private global::UnityEngine.KeyCode[] _checkKeylist;
    private bool _autoPlay;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> _saveDummys;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> _missingDummys;
    private int CurrentFrame
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    private void Awake()
    {
    }

    private void OnValidate()
    {
    }

    public void StartTest()
    {
    }

    public void RegisterAllEvent()
    {
    }

    public void ReceiveMessage(global::Common.GameMessage message)
    {
    }

    private void SoccerMatchAI_OnGetServerFrame(global::EngineMessages.FrameDetail obj)
    {
    }

    public void UnRegisterAllEvnet()
    {
    }

    public void StartMatch()
    {
    }

    private void Update()
    {
    }

    public void AutoPlay()
    {
    }

    private void OnApplicationQuit()
    {
    }

    private void OnLoadDummy(global::Common.GameMessage message)
    {
    }

    private void OnReloadAnimFrame(global::Common.GameMessage message)
    {
    }

    private void InitialAnimationList(global::Common.GameMessage message)
    {
    }

    public void OnAnimButtonClick()
    {
    }

    private void PlayAnimation(bool reload)
    {
    }

    public void OnSearchAnimation(string search)
    {
    }

    private void CheckAnimAngleVelocity()
    {
    }

    private void OnAnimFilterResult(global::EngineMessages.AnimationList animationList)
    {
    }

    private void OnRefreshList(global::System.Collections.Generic.List<string> names)
    {
    }

    public void OnProgressBarChanged(float frame)
    {
    }

    private void BindKeyFunction(global::UnityEngine.KeyCode key, global::System.Action action)
    {
    }

    private void CheckKeyboard()
    {
    }

    public void RequestGKDummys()
    {
    }

    private void OnRecieveGKDummy(global::EngineMessages.AnimationDummys animationDummys)
    {
    }

    private void OnDrawGizmos()
    {
    }

    public void OnSaveName()
    {
    }
}