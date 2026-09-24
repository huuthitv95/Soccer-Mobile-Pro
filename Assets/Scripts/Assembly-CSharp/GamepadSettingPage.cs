public class GamepadSettingPage : SettingPageBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTouchInputDetails;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfigureTouchInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject gamePadConnected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject gamePadDisconnected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfigureGamepad;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfigureGamepadP2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p1GamePad;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p2GamePad;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p2GamePadConnected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject p2GamePadDisconnected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject touchInput;
    private bool inGame;
    public override void Init(Win_Setting.GameSettingCategory category, bool inGame)
    {
    }

    public override void OnClose()
    {
    }

    private void CheckGamePadState()
    {
    }

    private static int GetConnectedGamepadCount()
    {
        return 0;
    }

    public static bool IsValidGamepad(string devicename)
    {
        return false;
    }
}