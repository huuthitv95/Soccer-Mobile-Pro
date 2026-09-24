public class ConfigVariant<T> where T : class
{
	private global::System.Collections.Generic.Dictionary<string, T> variantMap;

	private global::System.Collections.Generic.Dictionary<string, global::FLDataTable.LeagueVariant> configs;

	private string configPath;

	private global::System.Func<string, global::FLDataTable.LeagueVariant, ConfigVariantID, T> parseFunc;

	private global::System.Func<string, global::System.Collections.Generic.List<string>, ConfigVariantID, T> oldParseFunc;

	private ConfigVariantID id;

	private bool useOldParseFunc;

	private int nameIdx;

	public ConfigVariant(string path, global::System.Func<string, global::FLDataTable.LeagueVariant, ConfigVariantID, T> parseFunc, ConfigVariantID id)
	{
	}

	public ConfigVariant(string path, int nameIdx, global::System.Func<string, global::System.Collections.Generic.List<string>, ConfigVariantID, T> parseFunc, ConfigVariantID id)
	{
	}

	public T GetVariant(string name)
	{
		return null;
	}
}
