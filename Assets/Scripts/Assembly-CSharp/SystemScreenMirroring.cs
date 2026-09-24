public static class SystemScreenMirroring
{
	public static ScreenMirroringOpenResult OpenSystemUI()
	{
		return ScreenMirroringOpenResult.SystemSettingsOpened;
	}

	private static ScreenMirroringOpenResult OpenAndroidSystemUI()
	{
		return ScreenMirroringOpenResult.SystemSettingsOpened;
	}
}
