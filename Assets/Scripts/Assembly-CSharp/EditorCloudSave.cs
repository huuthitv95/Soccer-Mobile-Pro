internal sealed class EditorCloudSave : ICloudSaveStorage
{
	private const string DirectoryPath = "./EditorCloudSave";

	public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<CloudSaveFile>> FetchAsync(global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	public global::System.Threading.Tasks.Task<byte[]> ReadAsync(string name, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	public global::System.Threading.Tasks.Task<CloudSaveFile> WriteAsync(string name, byte[] data, string description, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	public global::System.Threading.Tasks.Task DeleteAsync(string name, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	private static CloudSaveFile Metadata(string path)
	{
		return null;
	}
}
