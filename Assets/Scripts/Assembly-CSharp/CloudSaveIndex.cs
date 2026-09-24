internal sealed class CloudSaveIndex
{
    internal const int MaxParts = 4096;
    private static readonly byte[] Identifier;
    private static readonly global::System.Text.RegularExpressions.Regex RevisionName;
    private static readonly global::System.Text.RegularExpressions.Regex PartName;
    private static readonly global::System.Text.RegularExpressions.Regex FileName;
    internal int GameParts;
    internal int EditedParts;
    internal long GameLength;
    internal long EditedLength;
    internal byte[] GameHash;
    internal byte[] EditedHash;
    internal bool HasChecksums => false;

    internal static string SlotName(string name)
    {
        return null;
    }

    internal static string NewRevision(string name)
    {
        return null;
    }

    internal static void ValidateName(string name)
    {
    }

    internal static bool IsPart(string name)
    {
        return false;
    }

    internal static string FileSlotName(string name)
    {
        return null;
    }

    internal static byte[] Hash(byte[] bytes)
    {
        return null;
    }

    internal static byte[] HashFile(string path)
    {
        return null;
    }

    internal byte[] Serialize()
    {
        return null;
    }

    internal static CloudSaveIndex Parse(byte[] bytes)
    {
        return null;
    }

    internal void ValidateContent(long length, byte[] actual, bool edited)
    {
    }
}