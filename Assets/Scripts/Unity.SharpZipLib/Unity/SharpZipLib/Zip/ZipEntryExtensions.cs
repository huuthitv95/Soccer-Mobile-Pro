namespace Unity.SharpZipLib.Zip
{
    public static class ZipEntryExtensions
    {
        public static bool HasFlag(this global::Unity.SharpZipLib.Zip.ZipEntry entry, global::Unity.SharpZipLib.Zip.GeneralBitFlags flag)
        {
            return false;
        }

        public static void SetFlag(this global::Unity.SharpZipLib.Zip.ZipEntry entry, global::Unity.SharpZipLib.Zip.GeneralBitFlags flag, bool enabled = true)
        {
        }
    }
}