namespace Unity.SharpZipLib.Zip.Compression
{
	internal class InflaterDynHeader
	{
		private static readonly int[] MetaCodeLengthIndex;

		private readonly global::Unity.SharpZipLib.Zip.Compression.Streams.StreamManipulator input;

		private readonly global::System.Collections.Generic.IEnumerator<bool> state;

		private readonly global::System.Collections.Generic.IEnumerable<bool> stateMachine;

		private byte[] codeLengths;

		private global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree litLenTree;

		private global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree distTree;

		private int litLenCodeCount;

		private int distanceCodeCount;

		private int metaCodeCount;

		public global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree LiteralLengthTree => null;

		public global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree DistanceTree => null;

		public bool AttemptRead()
		{
			return false;
		}

		public InflaterDynHeader(global::Unity.SharpZipLib.Zip.Compression.Streams.StreamManipulator input)
		{
		}

		private global::System.Collections.Generic.IEnumerable<bool> CreateStateMachine()
		{
			return null;
		}
	}
}
