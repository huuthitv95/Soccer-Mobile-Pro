public class GUIGamePadSetting : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject readyNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject connectingNode;
    [global::UnityEngine.SerializeField]
    private GUIWheel inputOptions;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image inputOptionsImage;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSetting;
    private static readonly string touchInputNameKey;
    private static readonly string gamePadInputNameKey;
    private global::System.Collections.Generic.IReadOnlyList<LocalBattleInputDevice> availableInputs;
    private global::System.Func<LocalBattleInputDevice, string> controllerDescriptionResolver;
    private LocalBattleInputDevice currentInput;
    private int playerSlotId;
    private void Awake()
    {
    }

    public void ShowConnecting()
    {
    }

    public void ShowReady(int slotId, global::System.Collections.Generic.IReadOnlyList<LocalBattleInputDevice> inputs, LocalBattleInputDevice selectedInput, global::System.Func<LocalBattleInputDevice, string> getControllerDescription, global::System.Action<LocalBattleInputDevice> onSelected)
    {
    }

    private int IndexOfInput(LocalBattleInputDevice input)
    {
        return 0;
    }

    private string GetInputOptionName(int index)
    {
        return null;
    }

    private void UpdateInputOptions(LocalBattleInputDevice input)
    {
    }

    private void OpenInputSettings()
    {
    }
}