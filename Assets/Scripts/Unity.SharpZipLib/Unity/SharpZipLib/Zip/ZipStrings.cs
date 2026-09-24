namespace Unity.SharpZipLib.Zip
{
	public static class ZipStrings
	{
		private static int codePage;

		public static int CodePage => 0;

		public static int SystemDefaultCodePage { get; }

		public static bool UseUnicode => false;

		static ZipStrings()
		{
		}

		private static global::System.Text.Encoding EncodingFromFlag(int flags)
		{
			return null;
		}

		public static string ConvertToStringExt(int flags, byte[] data, int count)
		{
			return null;
		}

		public static string ConvertToStringExt(int flags, byte[] data)
		{
			return null;
		}

		public static byte[] ConvertToArray(string str)
		{
			return null;
		}

		public static byte[] ConvertToArray(int flags, string str)
		{
			return null;
		}
	}
}
