public class TouchInputSystem : InputSystem
{
    private class SaveActionTrigger
    {
        private enum InputState
        {
            None = 0,
            LeftSavedWaiting = 1,
            RightSavedWaiting = 2
        }

        private enum ButtonState
        {
            None = 0,
            LeftSaved = 1,
            RightSaved = 2
        }

        private enum TouchState
        {
            None = 0,
            TouchDown = 1,
            LeftSaved = 2,
            RightSaved = 3
        }

        private bool Enable;
        private TouchInputSystem.SaveActionTrigger.TouchState touchSate;
        private TouchInputSystem.SaveActionTrigger.ButtonState buttonState;
        private TouchInputSystem.SaveActionTrigger.InputState inputState;
        private global::System.Action SendLeftSave;
        private global::System.Action SendRightSave;
        private global::System.Func<bool> CheckEnableInput;
        private global::System.Action ConfirmLeftSaveAction;
        private global::System.Action ConfirmRightSaveAction;
        private global::UnityEngine.Vector2 startPosition;
        public void SetEnable(bool enable)
        {
        }

        public SaveActionTrigger(global::System.Action sendLeftSave, global::System.Action sendRightSave, global::System.Func<bool> checkEnableInput, global::System.Action ConfirmLeftSaveAction, global::System.Action ConfirmRightSaveAction)
        {
        }

        private void TrySendAction()
        {
        }

        public void OnButtonClick(bool left)
        {
        }

        private void CheckInputForClick()
        {
        }

        private void CheckInputForTouch()
        {
        }

        private void OnEndTouch(global::UnityEngine.Vector2 endPosition)
        {
        }

        public void Update()
        {
        }
    }

    private struct NoInputChecker
    {
        private float lastInputTime;
        private float lastCheckTime;
        private bool noInput;
        private global::UnityEngine.CanvasGroup canvasGroup;
        public void MarkNoInput(bool noInput)
        {
        }

        private void CheckAlpha()
        {
        }

        public NoInputChecker(global::UnityEngine.CanvasGroup group, bool noInput, float lastInputTime)
        {
            this.lastInputTime = 0f;
            lastCheckTime = 0f;
            this.noInput = false;
            canvasGroup = null;
        }
    }

    [global::UnityEngine.SerializeField]
    private Joystick[] joysticks;
    [global::UnityEngine.SerializeField]
    private Joystick joystick;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] touchPanels;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject singlePass;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button save_left;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button save_rigth;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject freekickPass;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject freekickShoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject freekickSinglePass;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject freekickSingleShoot;
    [global::UnityEngine.SerializeField]
    private FreekickWithIndicator freekickWithIndicator;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform clock;
    [global::UnityEngine.SerializeField]
    private TouchButton sprintSkills;
    public global::System.Func<string, string> stringLoader;
    private int _inputType;
    private TouchButtonConfig[][][] touchConfigs;
    private global::System.Collections.Generic.HashSet<string> disabledButtons;
    private TouchButtonConfig[] currentConfig;
    private bool joystickLocked;
    private bool saveLeftDown;
    private bool saveRightDown;
    private global::System.Collections.Generic.Queue<global::EngineMessages.InputEvent> pendingEvents;
    private TouchInputSystem.NoInputChecker noInputChecker;
    private TouchInputSystem.SaveActionTrigger saveActionTrigger;
    private global::UnityEngine.Vector2 leftSavePos;
    private bool enableJoystick;
    private global::UnityEngine.Sprite TouchNormal;
    private global::UnityEngine.Sprite TouchSpint;
    public FreekickWithIndicator FreekickWithIndicator => null;

    public int inputType
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public global::System.Collections.Generic.HashSet<string> DisabledButtons
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public bool EnableSprintSkill
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    private global::UnityEngine.GameObject touchPanel => null;
    public Joystick Joystick => null;
    private global::EngineMessages.InputFunction SaveLeft => global::EngineMessages.InputFunction.Up;
    private global::EngineMessages.InputFunction SaveRight => global::EngineMessages.InputFunction.Up;
    public bool ForceOffensive { get; internal set; }
    public bool ForceDefensive { get; internal set; }
    public bool UseLegacyHardwareAxisInput { get; set; }

    private void LockJoystickType(int type)
    {
    }

    public void ChangeJoystickType(int type)
    {
    }

    public void InitButtonTexts(global::System.Func<string, string> stringLoader)
    {
    }

    private void SendSaveLeft()
    {
    }

    private void SendSaveRight()
    {
    }

    private void ConfirmLeftSaveAction()
    {
    }

    private void ConfirmRightSaveAction()
    {
    }

    private void SaveInputFeedback(global::UnityEngine.UI.Button button)
    {
    }

    private void OnDestroy()
    {
    }

    public void ShowSinglePass(bool show)
    {
    }

    public void ShowTouchPanel(bool show)
    {
    }

    public void ShowFreeKickPass(bool show)
    {
    }

    public void ShowFreeKickSingle(bool show)
    {
    }

    public void ShowFreeKickSingleShoot(bool show)
    {
    }

    public void ShowFreekickWithIndicator(bool show)
    {
    }

    private void Start()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void ResetButton(bool skipSprintBtn = true)
    {
    }

    public void ShowClock(bool show)
    {
    }

    public void UpdateClockText(int str)
    {
    }

    public void ShotSimulation(global::UnityEngine.Vector3 pos, global::EngineMessages.InputFunction func, float curve)
    {
    }

    internal void SendShotSimulation(global::UnityEngine.Vector3 pos, global::EngineMessages.InputFunction func, float curve, int playerId)
    {
    }

    public void OnUpdate()
    {
    }

    public void ShowSaveButton(bool show, AISampleBase aiMatch, bool faceLeft)
    {
    }

    public void UpdateOffenseTeam(bool offense, int playerid)
    {
    }

    public void FetchEvents(ref global::EngineMessages.InputData eventList)
    {
    }

    public void OnMatchReset()
    {
    }

    private void ConfigurePlan5()
    {
    }
}