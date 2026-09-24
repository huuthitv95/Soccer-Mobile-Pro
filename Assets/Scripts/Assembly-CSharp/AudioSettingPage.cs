public class AudioSettingPage : SettingPageBase
{
    [global::UnityEngine.SerializeField]
    private SliderWithLabel music;
    [global::UnityEngine.SerializeField]
    private SliderWithLabel commentary;
    [global::UnityEngine.SerializeField]
    private SliderWithLabel sound;
    public override void Init(Win_Setting.GameSettingCategory category, bool inGame)
    {
    }

    public override void OnClose()
    {
    }
}