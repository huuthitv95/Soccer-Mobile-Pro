public class GameSettingManager : global::Common.Singleton<GameSettingManager>
{
    public class SimpleSettingOption<T>
    {
        private T[] options;
        private string[] optionNames;
        public string key;
        public int defaultValue;
        public SimpleSettingOption(T[] options, string[] optionNames, string key, int defaultValue)
        {
        }

        public int GetCurrentIdx()
        {
            return 0;
        }

        public T GetCurrentValue()
        {
            return default;
        }

        public void SetCurrentIdx(int idx)
        {
        }

        public string GetOptiontName(int idx)
        {
            return null;
        }

        public int GetOptionCount()
        {
            return 0;
        }

        public int Reset()
        {
            return 0;
        }
    }

    public MatchDurationSettingManager CommonMatchDurationSetting;
    public MatchDurationSettingManager FriendlyMatchDurationSetting;
    public ConfigFramerate FramerateSetting;
    public ConfigResolution ResolutionSetting;
    public GameSettingManager.SimpleSettingOption<int> JoystickTypeSetting;
    private global::System.Collections.Generic.List<int> playSpeed;
    private global::System.Collections.Generic.List<string> playSpeedStr;
    private const string cameraModeSaveKey = "camera_mode";
    private const string playerCareerCameraModeSaveKey = "camera_mode_playercareer";
    private const int playerCareerProCameraOptionIndex = 6;
    private const int playerCareerDynamicParallelOptionIndex = 7;
    private readonly string[] cameraModeOptions;
    private readonly string[] playerCareerCameraModeOptions;
    private string[] substitutionOptions;
    public int PlaySpeedLevel => 0;
    public int PlaySpeedOptionCount => 0;

    public float GetPlaySpeedValue()
    {
        return 0f;
    }

    public void SetPlaySpeedLevel(int value)
    {
    }

    public string GetPlaySpeedString(int level)
    {
        return null;
    }

    public int GetGameViewSetting()
    {
        return 0;
    }

    public void SetGameViewSetting(int value)
    {
    }

    private string[] GetCameraModeOptions(bool playerCareer)
    {
        return null;
    }

    private string GetCameraModeSaveKey(bool playerCareer)
    {
        return null;
    }

    public int GetCameraMode()
    {
        return 0;
    }

    public int GetCameraMode(bool playerCareer)
    {
        return 0;
    }

    public int GetCameraModeOptionIndex(bool playerCareer)
    {
        return 0;
    }

    public int GetCameraModeFromOption(int option, bool playerCareer)
    {
        return 0;
    }

    public int GetCameraModeOptionFromMode(int mode, bool playerCareer)
    {
        return 0;
    }

    public void SetCameraMode(int value)
    {
    }

    public void SetCameraMode(int value, bool playerCareer)
    {
    }

    public string GetCameraModeString(int v)
    {
        return null;
    }

    public string GetCameraModeString(int v, bool playerCareer)
    {
        return null;
    }

    public int GetCameraModeCount()
    {
        return 0;
    }

    public int GetCameraModeCount(bool playerCareer)
    {
        return 0;
    }

    public int CultureCameraMode(int current, int offset)
    {
        return 0;
    }

    public int CultureCameraMode(int current, int offset, bool playerCareer)
    {
        return 0;
    }

    public int GetSubstitutionOption()
    {
        return 0;
    }

    public void SetSubstitutionOption(int value)
    {
    }

    public string GetSubstitutionOptionString(int v)
    {
        return null;
    }

    public int GetSubstitutionOptionCount()
    {
        return 0;
    }
}