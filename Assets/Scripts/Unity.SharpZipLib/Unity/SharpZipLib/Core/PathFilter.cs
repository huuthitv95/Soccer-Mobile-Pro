namespace Unity.SharpZipLib.Core
{
	public class PathFilter : global::Unity.SharpZipLib.Core.IScanFilter
	{
		private readonly global::Unity.SharpZipLib.Core.NameFilter nameFilter_;

		public PathFilter(string filter)
		{
		}

		public virtual bool IsMatch(string name)
		{
			return false;
		}
	}
}
