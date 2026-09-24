[global::System.Serializable]
public sealed class LocalBattleInputConfig
{
    private static readonly LocalBattleInputDevice[] availableDevices;
    public LocalBattleInputDevice PlayerOneDevice;
    public LocalBattleInputDevice PlayerTwoDevice;
    public bool PlayerOneUseTouchInput;
    public bool PlayerTwoUseTouchInput;
    public static global::System.Collections.Generic.IReadOnlyList<LocalBattleInputDevice> AvailableDevices => null;
    public bool UsesTouchInput => false;

    public LocalBattleInputConfig()
    {
    }

    public LocalBattleInputConfig(LocalBattleInputDevice playerOneDevice, LocalBattleInputDevice playerTwoDevice)
    {
    }

    public void AutoConfigure()
    {
    }

    public void Validate()
    {
    }
}