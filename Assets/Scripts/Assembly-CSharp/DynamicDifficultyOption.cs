[global::System.Serializable]
public struct DynamicDifficultyOption
{
    public global::UnityEngine.Transform node;
    [global::UnityEngine.SerializeField]
    private SwitchToggles dynamicDifficulty;
    private bool stateWhenInit;
    private bool init;
    public void Init()
    {
    }

    public void EnableDynamicDifficulty(bool enable)
    {
    }

    public bool CheckNotifyDifficultyChange(global::FLMessageSystem.OnAdjustDifficultyMessage.DifficultyAdjustReason reason)
    {
        return false;
    }
}