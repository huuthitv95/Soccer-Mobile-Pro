namespace Unity.SharpZipLib.Core
{
	public interface IScanFilter
	{
		bool IsMatch(string name);
	}
}
