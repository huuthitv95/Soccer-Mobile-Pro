namespace Unity.SharpZipLib.Zip
{
	public interface IEntryFactory
	{
		global::Unity.SharpZipLib.Core.INameTransform NameTransform { set; }

		global::Unity.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName);

		global::Unity.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName);
	}
}
