internal static class CloudSaveRestore
{
    internal static readonly string[] EditedRoots;
    private const string TransactionName = ".cloud-restore";
    internal static string SafePath(string root, string relative)
    {
        return null;
    }

    internal static void ClearDownload(string directory)
    {
    }

    internal static string Recover(string saveRoot)
    {
        return null;
    }

    internal static void Install(string saveRoot, string id, bool hasEdited, global::System.Action<string> writeStage)
    {
    }

    private static global::System.Collections.Generic.Dictionary<string, bool> ReadJournal(string path, out string id)
    {
        id = null;
        return null;
    }

    private static void Rollback(string saveRoot, string transaction, global::System.Collections.Generic.Dictionary<string, bool> targets)
    {
    }

    private static bool Exists(string path)
    {
        return false;
    }

    private static void Move(string source, string destination)
    {
    }

    private static void Delete(string path)
    {
    }
}