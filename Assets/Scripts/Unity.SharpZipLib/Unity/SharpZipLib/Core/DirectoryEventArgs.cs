namespace Unity.SharpZipLib.Core
{
	public class DirectoryEventArgs : global::Unity.SharpZipLib.Core.ScanEventArgs
	{
		private readonly bool hasMatchingFiles_;

		public bool HasMatchingFiles => false;

		public DirectoryEventArgs(string name, bool hasMatchingFiles)
			: base(null)
		{
		}
	}
}
