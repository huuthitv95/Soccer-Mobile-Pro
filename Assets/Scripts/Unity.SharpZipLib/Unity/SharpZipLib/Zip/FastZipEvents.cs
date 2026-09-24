namespace Unity.SharpZipLib.Zip
{
	public class FastZipEvents
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Unity.SharpZipLib.Core.DirectoryEventArgs> ProcessDirectory;

		public global::Unity.SharpZipLib.Core.ProcessFileHandler ProcessFile;

		public global::Unity.SharpZipLib.Core.ProgressHandler Progress;

		public global::Unity.SharpZipLib.Core.CompletedFileHandler CompletedFile;

		public global::Unity.SharpZipLib.Core.DirectoryFailureHandler DirectoryFailure;

		public global::Unity.SharpZipLib.Core.FileFailureHandler FileFailure;

		private global::System.TimeSpan progressInterval_;

		public global::System.TimeSpan ProgressInterval => default;

		public bool OnFileFailure(string file, global::System.Exception e)
		{
			return false;
		}

		public bool OnCompletedFile(string file)
		{
			return false;
		}

		public bool OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
			return false;
		}
	}
}
