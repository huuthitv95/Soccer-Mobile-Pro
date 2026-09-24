internal static class MatchABTest
{
    private enum MatchConfigValueType
    {
        String = 0,
        Int = 1,
        Float = 2,
        Bool = 3
    }

    private static readonly global::System.Collections.Generic.Dictionary<global::SL.ABTest.CONFIG_NAME, MatchABTest.MatchConfigValueType> MatchConfigDefinitions;
    private static readonly global::System.Collections.Generic.Dictionary<global::SL.ABTest.CONFIG_NAME, object> FixedValues;
    public static bool HasFixedValues { get; private set; }

    public static void ClearValues()
    {
    }

    public static void CopyValues()
    {
    }

    public static T GetParsedValue<T>(global::SL.ABTest.CONFIG_NAME configName)
    {
        return default;
    }

    private static object ReadConfiguredValue(global::SL.ABTest.CONFIG_NAME configName, MatchABTest.MatchConfigValueType valueType)
    {
        return null;
    }

    private static bool TryGetConfigValueType(global::SL.ABTest.CONFIG_NAME configName, out MatchABTest.MatchConfigValueType configValueType)
    {
        configValueType = default;
        return false;
    }

    private static void EnsureValuesCopied(global::SL.ABTest.CONFIG_NAME configName)
    {
    }
}