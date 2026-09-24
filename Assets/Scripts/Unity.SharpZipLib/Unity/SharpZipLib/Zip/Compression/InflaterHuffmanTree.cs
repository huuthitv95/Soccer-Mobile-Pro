namespace Unity.SharpZipLib.Zip.Compression
{
    public class InflaterHuffmanTree
    {
        private short[] tree;
        public static global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree defLitLenTree;
        public static global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree defDistTree;
        static InflaterHuffmanTree()
        {
        }

        public InflaterHuffmanTree(global::System.Collections.Generic.IList<byte> codeLengths)
        {
        }

        private void BuildTree(global::System.Collections.Generic.IList<byte> codeLengths)
        {
        }

        public int GetSymbol(global::Unity.SharpZipLib.Zip.Compression.Streams.StreamManipulator input)
        {
            return 0;
        }
    }
}