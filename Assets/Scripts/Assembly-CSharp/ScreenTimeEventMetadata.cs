internal static class ScreenTimeEventMetadata
{
	public static ScreenTimeEventType GetEventType(ScreenTimeEvent eventId)
	{
		return ScreenTimeEventType.UI;
	}

	public static string GetEventName(ScreenTimeEventType eventType)
	{
		return null;
	}
}
