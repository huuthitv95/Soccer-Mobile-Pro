[global::System.Serializable]
public class NormalDifficultyOption
{
    [global::UnityEngine.SerializeField]
    private string saveKey;
    [global::UnityEngine.SerializeField]
    private GUIWheel difficulty;
    [global::UnityEngine.SerializeField]
    private global::FLGameData.DifficultySettingsGroup difficultySettingsGroup;
    private int valueWhenInit;
    public global::UnityEngine.Transform node => null;

    public NormalDifficultyOption(string saveKey, GUIWheel node, global::FLGameData.DifficultySettingsGroup difficultySettingsGroup)
    {
    }

    public void initDifficultySetting(Win_Setting.GameSettingCategory category, bool inGame)
    {
    }

    public void UpdateDifficulty(int idx)
    {
    }

    public int GetDifficulty()
    {
        return 0;
    }

    public bool CheckNotifyDifficultyChange(global::FLMessageSystem.OnAdjustDifficultyMessage.DifficultyAdjustReason reason)
    {
        return false;
    }
}