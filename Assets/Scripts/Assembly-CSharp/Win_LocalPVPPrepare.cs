public class Win_LocalPVPPrepare : global::Common.WindowBase
{
    private static readonly LocalBattleInputDevice[] touchInputOnly;
    private static readonly LocalBattleInputDevice[] touchInputAndGamepad2;
    private static readonly LocalBattleInputDevice[] gamepad1Only;
    private static readonly LocalBattleInputDevice[] gamepad2Only;
    [global::UnityEngine.SerializeField]
    private GUIGamePadSetting p1;
    [global::UnityEngine.SerializeField]
    private GUIGamePadSetting p2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnProjectionScreen;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject battleBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject blurBg;
    private ForwardBackwardController navigation;
    private LocalBattleInputDevice playerOneInput;
    private LocalBattleInputDevice playerTwoInput;
    private bool deviceChangeSubscribed;
    private bool matchRecovery;
    private MatchInputRouter matchInputRouter;
    private LocalBattleInputConfig matchInputConfig;
    private global::System.Action resumeMatchAction;
    private global::System.Action returnToMainAction;
    public void ShowBlurBg()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void OnDestroy()
    {
    }

    private void OnDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
    {
    }

    public void InitializeMatchRecovery(MatchInputRouter inputRouter, LocalBattleInputConfig inputConfig, global::System.Action onResumeMatch, global::System.Action onReturnToMain)
    {
    }

    private void RefreshInputState()
    {
    }

    private bool RefreshPlayerTwoInput(int controllerCount, bool keyboardAvailable)
    {
        return false;
    }

    private void OnMatchControllerConnectionChanged(int slotId, bool connected)
    {
    }

    private void RefreshMatchRecoveryState()
    {
    }

    private bool RefreshMatchRecoveryPlayer(GUIGamePadSetting playerSetting, int slotId, LocalBattleInputDevice inputDevice)
    {
        return false;
    }

    private string GetMatchControllerDescription(int slotId)
    {
        return null;
    }

    private static bool IsControllerInput(LocalBattleInputDevice inputDevice)
    {
        return false;
    }

    private static LocalBattleInputDevice[] GetSingleInput(LocalBattleInputDevice inputDevice)
    {
        return null;
    }

    private void OpenProjectionScreen()
    {
    }

    private void UnsubscribeDeviceChange()
    {
    }

    private void UnsubscribeMatchInput()
    {
    }

    private void ReturnToMainView()
    {
    }

    public void OnLocalBattleClick()
    {
    }
}