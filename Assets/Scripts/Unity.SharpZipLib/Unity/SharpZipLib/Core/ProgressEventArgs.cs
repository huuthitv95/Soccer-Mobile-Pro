namespace Unity.SharpZipLib.Core
{
	public class ProgressEventArgs : global::System.EventArgs
	{
		private string name_;

		private long processed_;

		private long target_;

		private bool continueRunning_;

		public bool ContinueRunning => false;

		public ProgressEventArgs(string name, long processed, long target)
		{
		}
	}
}
