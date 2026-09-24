internal sealed class CloudSaveTransfer
{
	private readonly ICloudSaveStorage storage;

	private readonly int partSize;

	private readonly global::System.Action<string> reportStage;

	internal CloudSaveTransfer(ICloudSaveStorage storage, int partSize, global::System.Action<string> reportStage)
	{
	}

	internal global::System.Threading.Tasks.Task<CloudSaveFile> UploadAsync(string slot, string gamePath, string editedPath, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	private global::System.Threading.Tasks.Task<byte[]> UploadParts(string prefix, global::System.IO.FileStream stream, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	internal global::System.Threading.Tasks.Task DownloadAsync(string name, string directory, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	private global::System.Threading.Tasks.Task DownloadParts(string prefix, int count, string path, CloudSaveIndex index, bool edited, global::System.Threading.CancellationToken cancellation)
	{
		return null;
	}

	internal static global::System.Collections.Generic.List<CloudSaveFile> VisibleSlots(global::System.Collections.Generic.List<CloudSaveFile> files)
	{
		return null;
	}
}
