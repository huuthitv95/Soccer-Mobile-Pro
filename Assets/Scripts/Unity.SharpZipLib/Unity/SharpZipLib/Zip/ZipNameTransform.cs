namespace Unity.SharpZipLib.Zip
{
	public class ZipNameTransform : global::Unity.SharpZipLib.Core.INameTransform
	{
		private string trimPrefix_;

		private static readonly char[] InvalidEntryChars;

		private static readonly char[] InvalidEntryCharsRelaxed;

		public string TrimPrefix
		{
			set
			{
			}
		}

		public ZipNameTransform()
		{
		}

		public ZipNameTransform(string trimPrefix)
		{
		}

		static ZipNameTransform()
		{
		}

		public string TransformDirectory(string name)
		{
			return null;
		}

		public string TransformFile(string name)
		{
			return null;
		}

		private static string MakeValidName(string name, char replacement)
		{
			return null;
		}
	}
}
