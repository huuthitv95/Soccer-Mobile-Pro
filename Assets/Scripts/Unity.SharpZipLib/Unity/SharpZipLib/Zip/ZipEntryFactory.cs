namespace Unity.SharpZipLib.Zip
{
	public class ZipEntryFactory : global::Unity.SharpZipLib.Zip.IEntryFactory
	{
		public enum TimeSetting
		{
			LastWriteTime = 0,
			LastWriteTimeUtc = 1,
			CreateTime = 2,
			CreateTimeUtc = 3,
			LastAccessTime = 4,
			LastAccessTimeUtc = 5,
			Fixed = 6
		}

		private global::Unity.SharpZipLib.Core.INameTransform nameTransform_;

		private global::System.DateTime fixedDateTime_;

		private global::Unity.SharpZipLib.Zip.ZipEntryFactory.TimeSetting timeSetting_;

		private bool isUnicodeText_;

		private int getAttributes_;

		private int setAttributes_;

		public global::Unity.SharpZipLib.Core.INameTransform NameTransform
		{
			set
			{
			}
		}

		public global::Unity.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName)
		{
			return null;
		}

		public global::Unity.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, string entryName, bool useFileSystem)
		{
			return null;
		}

		public global::Unity.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName)
		{
			return null;
		}

		public global::Unity.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
		{
			return null;
		}
	}
}
