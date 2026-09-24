public class Win_ControllerConfig : global::Common.WindowBase
{
    [global::System.Serializable]
    private sealed class ButtonMapping
    {
        public global::UnityEngine.UI.Button button;
        public global::UnityEngine.UI.Text buttonDescription;
        public global::UnityEngine.UI.Text buttonIdText;
        public int idx;
        public global::EngineMessages.InputFunction AttackFunction;
        public global::EngineMessages.InputFunction DefenceFunction;
        public string attackDesc;
        public string defenceDesc;
        private Win_ControllerConfig owner;
        public int CurrentFaceButtonIndex { get; private set; }

        public void Initialize(Win_ControllerConfig configWindow)
        {
        }

        public void Refresh(bool attacking)
        {
        }

        public global::EngineMessages.InputFunction GetFunction(bool attacking)
        {
            return global::EngineMessages.InputFunction.Up;
        }
    }

    [global::System.Serializable]
    private sealed class MappingPanel
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject panel;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject[] arrows;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Button[] btns;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject[] highlights;
        private Win_ControllerConfig.ButtonMapping current;
        public void Initialize(Win_ControllerConfig owner)
        {
        }

        public void Show(Win_ControllerConfig.ButtonMapping buttonMapping)
        {
        }

        public void Hide()
        {
        }

        private void UpdateArrows(Win_ControllerConfig.ButtonMapping buttonMapping)
        {
        }

        private void UpdateHighlights(Win_ControllerConfig.ButtonMapping buttonMapping)
        {
        }
    }

    private const string OffenseMapName = "Offense";
    private const string DefenseMapName = "Defense";
    private const string GamepadBindingGroup = "Gamepad";
    private static readonly string[] FaceButtonPaths;
    private static readonly string[] JoystickFaceButtonPaths;
    [global::UnityEngine.SerializeField]
    private Win_ControllerConfig.ButtonMapping[] btns;
    [global::UnityEngine.SerializeField]
    private Win_ControllerConfig.MappingPanel mappingPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform toggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSave;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReset;
    private global::FL.GameInput workingActions;
    private int slotId;
    private bool attacking;
    private bool uiInitialized;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p1Marker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p2Marker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text L1Text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text R1Text;
    public void Initialize(int playerSlotId)
    {
    }

    public void ShowMark(bool p1)
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    public void CloseWindow()
    {
    }

    private void InitializeUi()
    {
    }

    private void OnReset()
    {
    }

    private void UpdateButtonBinding(Win_ControllerConfig.ButtonMapping current, int newFaceButtonIndex)
    {
    }

    private void ResetBindings()
    {
    }

    private void RefreshButtonMappings()
    {
    }

    private int GetFaceButtonIndex(Win_ControllerConfig.ButtonMapping mapping, bool forAttack)
    {
        return 0;
    }

    private void ApplyFaceButtonOverride(Win_ControllerConfig.ButtonMapping mapping, bool forAttack, int faceButtonIndex)
    {
    }

    private global::UnityEngine.InputSystem.InputAction GetAction(Win_ControllerConfig.ButtonMapping mapping, bool forAttack)
    {
        return null;
    }

    private static int FindFaceButtonBindingIndex(global::UnityEngine.InputSystem.InputAction action, string[] faceButtonPaths)
    {
        return 0;
    }

    private static bool HasBindingGroup(string groups, string targetGroup)
    {
        return false;
    }
}