namespace UIThemes
{
	public static class UIThemeTypeExtensions
	{
		public static bool IsHighlight(this global::UIThemes.UIThemeType themeType)
		{
			return false;
		}

		public static bool IsNormal(this global::UIThemes.UIThemeType themeType)
		{
			return false;
		}

		public static global::UIThemes.UIThemeType ToHighlight(this global::UIThemes.UIThemeType themeType)
		{
			return global::UIThemes.UIThemeType.NotSet;
		}

		public static global::UIThemes.UIThemeType ToNormal(this global::UIThemes.UIThemeType themeType)
		{
			return global::UIThemes.UIThemeType.NotSet;
		}
	}
}
