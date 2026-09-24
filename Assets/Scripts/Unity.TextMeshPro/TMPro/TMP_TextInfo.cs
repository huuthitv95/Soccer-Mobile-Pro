namespace TMPro
{
    [global::System.Serializable]
    public class TMP_TextInfo
    {
        internal static global::UnityEngine.Vector2 k_InfinityVectorPositive;
        internal static global::UnityEngine.Vector2 k_InfinityVectorNegative;
        public global::TMPro.TMP_Text textComponent;
        public int characterCount;
        public int spriteCount;
        public int spaceCount;
        public int wordCount;
        public int linkCount;
        public int lineCount;
        public int pageCount;
        public int materialCount;
        public global::TMPro.TMP_CharacterInfo[] characterInfo;
        public global::TMPro.TMP_WordInfo[] wordInfo;
        public global::TMPro.TMP_LinkInfo[] linkInfo;
        public global::TMPro.TMP_LineInfo[] lineInfo;
        public global::TMPro.TMP_PageInfo[] pageInfo;
        public global::TMPro.TMP_MeshInfo[] meshInfo;
        private global::TMPro.TMP_MeshInfo[] m_CachedMeshInfo;
        public TMP_TextInfo()
        {
        }

        internal TMP_TextInfo(int characterCount)
        {
        }

        public TMP_TextInfo(global::TMPro.TMP_Text textComponent)
        {
        }

        public void Clear()
        {
        }

        internal void ClearAllData()
        {
        }

        public void ClearMeshInfo(bool updateMesh)
        {
        }

        public void ClearAllMeshInfo()
        {
        }

        public void ResetVertexLayout(bool isVolumetric)
        {
        }

        public void ClearUnusedVertices(global::TMPro.MaterialReference[] materials)
        {
        }

        public void ClearLineInfo()
        {
        }

        internal void ClearPageInfo()
        {
        }

        public global::TMPro.TMP_MeshInfo[] CopyMeshInfoVertexData()
        {
            return null;
        }

        public static void Resize<T>(ref T[] array, int size)
        {
        }

        public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
        {
        }
    }
}