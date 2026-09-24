public class Win_OneTimeMessage : global::Common.WindowBase
{
	public enum OneTimeMessageType
	{
		PlayerCareer = 0
	}

	private static global::System.Collections.Generic.Dictionary<Win_OneTimeMessage.OneTimeMessageType, string> windowNameMap;

	private static bool NeedToShow(Win_OneTimeMessage.OneTimeMessageType type)
	{
		return false;
	}

	private static bool ShowMessage(Win_OneTimeMessage.OneTimeMessageType type)
	{
		return false;
	}

	public static bool TryShowMessage()
	{
		return false;
	}
}
