public class Win_InGameButtonSettings : global::Common.WindowBase, InGameButtonConfiguratorGroup
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform joystickLimitArea;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform buttonLimitArea;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRest;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSave;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<GUIInGameButtonConfigurator> buttons;
    [global::UnityEngine.SerializeField]
    private GUIInGameButtonConfigurator joystick;
    [global::UnityEngine.SerializeField]
    private GUIWheel joystickMode;
    [global::UnityEngine.SerializeField]
    private SliderWithLabel opacitySlider;
    [global::UnityEngine.SerializeField]
    private SliderWithLabel sizeSlider;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform att_defGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle attackToggle;
    private global::UnityEngine.Rect joystickLimitRect;
    private global::UnityEngine.Rect buttonLimitRect;
    public static global::System.Action OnSaveButtonConfig;
    public GUIInGameButtonConfigurator CurrentSelected { get; set; }

    public override void OnOpen(object parameter)
    {
    }

    public void InitSlider()
    {
    }

    private void InitJoystickMode()
    {
    }

    private void InitAttDefSwitch()
    {
    }

    public override void OnClose()
    {
    }

    private void OnSave()
    {
    }

    private void UpdateButtonText(bool attack)
    {
    }

    private void OnRest()
    {
    }

    private void UpdateUI(global::System.Collections.Generic.IEnumerable<IngameButtonConfiguration.IngameButtonConfig> datas)
    {
    }

    public bool CheckIntersect(GUIInGameButtonConfigurator configurator, ref IngameButtonConfiguration.IngameButtonConfig config, bool checkHideWarning = true)
    {
        return false;
    }

    public bool CheckValid()
    {
        return false;
    }

    public void NotifySelectedChanged(GUIInGameButtonConfigurator configurator)
    {
    }

    public void OnDragEnd()
    {
    }
}