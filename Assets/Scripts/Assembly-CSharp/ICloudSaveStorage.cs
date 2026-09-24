internal interface ICloudSaveStorage
{
	global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<CloudSaveFile>> FetchAsync(global::System.Threading.CancellationToken cancellation);

	global::System.Threading.Tasks.Task<byte[]> ReadAsync(string name, global::System.Threading.CancellationToken cancellation);

	global::System.Threading.Tasks.Task<CloudSaveFile> WriteAsync(string name, byte[] data, string description, global::System.Threading.CancellationToken cancellation);

	global::System.Threading.Tasks.Task DeleteAsync(string name, global::System.Threading.CancellationToken cancellation);
}
