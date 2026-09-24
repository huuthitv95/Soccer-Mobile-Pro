namespace Unity.SharpZipLib.Zip
{
	public interface ITaggedData
	{
		short TagID { get; }

		void SetData(byte[] data, int offset, int count);
	}
}
