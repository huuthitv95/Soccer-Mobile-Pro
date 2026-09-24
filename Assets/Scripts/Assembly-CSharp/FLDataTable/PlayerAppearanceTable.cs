namespace FLDataTable
{
    public class PlayerAppearanceTable
    {
        public static global::System.Collections.Generic.Dictionary<int, int> dataByid;
        private static global::System.IO.MemoryStream dataByidStream;
        private static global::System.IO.BinaryReader dataByidReader;
        private static byte[] dataByidBytes;
        public int id;
        public sbyte skinID;
        public short faceTextureID;
        public short hairMeshNameID;
        public sbyte hairColorIdx;
        public short BeardID;
        public sbyte eyeID;
        public sbyte eyebrowID;
        public sbyte[] headData;
        public short headMeshID;
        public sbyte BeardColor;
        public string skin => null;
        public string faceTexture => null;
        public string hairMeshName => null;
        public string Beard => null;
        public string eye => null;
        public string eyebrow => null;
        public string headMesh => null;

        public static global::FLDataTable.PlayerAppearanceTable Get(int key)
        {
            return null;
        }

        public static void DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
        {
        }

        public static global::FLDataTable.PlayerAppearanceTable Deserialize(global::System.IO.BinaryReader reader)
        {
            return null;
        }
    }
}