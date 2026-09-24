namespace Unity.SharpZipLib.Core
{
	public class ScanFailureEventArgs : global::System.EventArgs
	{
		private string name_;

		private global::System.Exception exception_;

		private bool continueRunning_;

		public bool ContinueRunning => false;

		public ScanFailureEventArgs(string name, global::System.Exception e)
		{
		}
	}
}
