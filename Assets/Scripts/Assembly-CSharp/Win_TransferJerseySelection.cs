public class Win_TransferJerseySelection : global::Common.WindowBase
{
    public class Parameter
    {
        public global::FL.PlayerCareer PlayerCareer;
    }

    private const int MinKitNumber = 1;
    private const int MaxKitNumber = 99;
    private const int DefaultKitNumber = 99;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField kitNumberInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button confirmButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text salaryText;
    private ClubPlayer player;
    private bool settingInputText;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    private void Fill(global::FL.PlayerCareer playerCareer)
    {
    }

    private void BindUIEvents()
    {
    }

    private void Refresh()
    {
    }

    private void OnKitNumberValueChanged(string value)
    {
    }

    private void OnKitNumberEndEdit(string value)
    {
    }

    private int NormalizeKitNumber(int kitNumber)
    {
        return 0;
    }

    private void SetKitNumberInputText(string value)
    {
    }

    private void ApplyKitNumber(int kitNumber)
    {
    }

    private void ApplyPlayerModel()
    {
    }

    private void Confirm()
    {
    }
}