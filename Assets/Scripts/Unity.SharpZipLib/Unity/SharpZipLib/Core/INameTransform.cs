namespace Unity.SharpZipLib.Core
{
	public interface INameTransform
	{
		string TransformFile(string name);

		string TransformDirectory(string name);
	}
}
