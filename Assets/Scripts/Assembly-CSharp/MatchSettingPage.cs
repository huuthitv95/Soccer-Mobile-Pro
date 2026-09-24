public class MatchSettingPage : SettingPageBase
{
    [global::UnityEngine.SerializeField]
    private GUIMatchDuration matchDuration;
    [global::UnityEngine.SerializeField]
    private NormalDifficultyOption difficulty;
    [global::UnityEngine.SerializeField]
    private DynamicDifficultyOption dynamicDifficulty;
    [global::UnityEngine.SerializeField]
    private GUIPlaySpeedOption playSpeed;
    [global::UnityEngine.SerializeField]
    private SliderWithLabel cameraHeight;
    [global::UnityEngine.SerializeField]
    private GUIWheel cameraMode;
    [global::UnityEngine.SerializeField]
    private SwitchToggles Radar;
    [global::UnityEngine.SerializeField]
    private GUIWheel substituteType;
    private Win_Setting.GameSettingCategory currentCategory;
    private bool useLegacyDifficultySetting;
    public override void Init(Win_Setting.GameSettingCategory category, bool inGame)
    {
    }

    public override void OnClose()
    {
    }

    private void InitCameraHeight()
    {
    }

    private void InitCameraMode()
    {
    }

    private void InitRadar()
    {
    }

    private void InitSubstituteType()
    {
    }
}