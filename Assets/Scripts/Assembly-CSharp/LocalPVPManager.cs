public class LocalPVPManager
{
	public static global::FLGameProgressSetting.EasySave.RedPointData RedPoint;

	public int ConnectedControllerCount => 0;

	public bool KeyboardInputAvailable => false;

	public string GetControllerDescription(LocalBattleInputDevice device)
	{
		return null;
	}

	public bool TryCreateInputConfig(LocalBattleInputDevice playerOneDevice, LocalBattleInputDevice playerTwoDevice, out LocalBattleInputConfig inputConfig)
	{
		inputConfig = null;
		return false;
	}
}
