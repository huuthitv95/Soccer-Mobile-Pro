public struct JerseyNumberConfig
{
	public const string DefaultStyle = "style_1";

	public string NumberText;

	public string Style;

	public TeamAvatarHelper.NumberColorPair Color;

	public int Length => 0;

	public JerseyNumberConfig(string numberText, TeamAvatarHelper.NumberColorPair color, string style = "style_1")
	{
		NumberText = null;
		Style = null;
		Color = default;
	}

	public string GetTexturePath(int digitIndex)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
