internal sealed class CloudSaveArchive
{
    private sealed class PreparedFile
    {
        internal string Name;
        internal long Length;
        internal byte[] Hash;
    }

    internal const int BufferSize = 65536;
    internal const string Password = "QnokQHxMXUoV";
    private const int MaxEntries = 100000;
    private readonly int currentVersion;
    private readonly global::System.Collections.Generic.HashSet<string> archiveTypes;
    private readonly byte[] buffer;
    private readonly byte[] compareBuffer;
    internal CloudSaveArchive(int currentVersion, string[] archiveTypes)
    {
    }

    internal static global::Unity.SharpZipLib.Zip.ZipOutputStream CreateZip(string path, bool game)
    {
        return null;
    }

    internal static void PackEdited(string path, string saveRoot, global::System.Threading.CancellationToken cancellation)
    {
    }

    internal void Prepare(string gamePath, string editedPath, string directory, global::System.Threading.CancellationToken cancellation)
    {
    }

    internal void InstallPrepared(string directory, string saveRoot, string id)
    {
    }

    private void ExtractGame(string path, string target, global::System.Collections.Generic.List<CloudSaveArchive.PreparedFile> files, global::System.Threading.CancellationToken cancellation)
    {
    }

    private void ExtractEdited(string path, string target, global::System.Collections.Generic.List<CloudSaveArchive.PreparedFile> files, global::System.Threading.CancellationToken cancellation)
    {
    }

    private string ValidateGamePath(string root, string relative)
    {
        return null;
    }

    private static string ValidateEditedPath(string target, string relative, bool file)
    {
        return null;
    }

    private void ValidateVersion(int version)
    {
    }

    private static void CheckCompressedLength(string path)
    {
    }

    private static string ReadName(global::System.IO.BinaryReader reader)
    {
        return null;
    }

    private static byte[] ReadBytes(global::System.IO.BinaryReader reader, int count)
    {
        return null;
    }

    private static void ReadExactly(global::System.IO.Stream input, byte[] bytes, int count)
    {
    }

    private static void RequireHash(byte[] expected, byte[] actual)
    {
    }
}