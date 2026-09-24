public class Win_CommonDifficultyPopup : global::Common.WindowBase
{
    private const string CommonDifficultyKey = "CommonDifficulty";
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button higherDifficultyBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button lowerDifficultyBtn;
    [global::UnityEngine.SerializeField]
    private StringID desc;
    private IMatchManager matchManager;
    private Win_DifficultyOption.DifficultyMode mode;
    private int valueWhenInit;
    private int currentValue;
    private bool useModeDifficulty;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(bool needHigher, bool needLower)
    {
    }

    private void OnHigherDifficultyBtnClick()
    {
    }

    private void OnLowerDifficultyBtnClick()
    {
    }

    public void UpdateDifficulty(int idx)
    {
    }

    public override void OnClose()
    {
    }
}