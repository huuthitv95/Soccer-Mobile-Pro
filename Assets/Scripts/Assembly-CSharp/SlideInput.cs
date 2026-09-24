public class SlideInput : MatchListener
{
    public struct InputData
    {
        public global::UnityEngine.Touch t;
        public global::UnityEngine.Vector2 lastTouch;
        public int availableTouchCount;
        public bool validInput;
    }

    private struct AutoOption
    {
        public bool enable;
        public global::EngineMessages.InputFunction inputFunction;
        public global::UnityEngine.Vector3 position;
        public float curve;
        public global::System.Action action;
        public InGameCameraModel cameraModel;
        public int teamId;
        public int takerId;
        public AutoOption(bool enable)
        {
            this.enable = false;
            inputFunction = global::EngineMessages.InputFunction.Up;
            position = default;
            curve = 0f;
            action = null;
            cameraModel = InGameCameraModel.NORMAL;
            teamId = 0;
            takerId = 0;
        }
    }

    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject _touchTrack;
    [global::UnityEngine.SerializeField]
    private global::SL.TutorialHint tutorial;
    [global::UnityEngine.SerializeField]
    private SlideArea _slideArea;
    public bool IsGoalKick;
    private global::DG.Tweening.Sequence s;
    public bool EnableInput;
    public Fsm<SlideInput, global::System.Type> m_fsm;
    private SlideInput.InputData inputData;
    public IMatch aiMatch;
    public bool faceLeft;
    public bool IsThrowIn;
    private float timer;
    private readonly global::System.Collections.Generic.Dictionary<InGameCameraModel, int> timeout;
    private SlideInput.AutoOption autoOption;
    private global::System.Collections.Generic.HashSet<InGameCameraModel> TutorialFalgSet;
    private global::UnityEngine.Coroutine coroutine;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public void SetupGoalKickArea(global::UnityEngine.Vector3 ball)
    {
    }

    public void StartBlink()
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public override void OnMatchReset(IMatch match)
    {
    }

    public void OnSlideCamera(float offset)
    {
    }

    private void Start()
    {
    }

    public override void OnUpdate(IMatch match)
    {
    }

    private global::System.Collections.IEnumerator WaitAI(InGameCameraModel from, InGameCameraModel tol, bool faceLeft, global::UnityEngine.Vector3 ballPos, int setPieceTeamId, bool needTutorial)
    {
        return null;
    }

    private void CheckShoot()
    {
    }

    public void StopCountdown()
    {
    }

    private void StartAutoOption(InGameCameraModel cameraModel, global::EngineMessages.InputFunction func, global::UnityEngine.Vector3 pos, float curve = 0.8f)
    {
    }

    private bool IsScreenInputTeam(int teamId)
    {
        return false;
    }

    public override void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel tol, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isUser, int takerid)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}