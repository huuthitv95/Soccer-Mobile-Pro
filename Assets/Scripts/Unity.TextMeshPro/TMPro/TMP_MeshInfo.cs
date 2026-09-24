namespace TMPro
{
    public struct TMP_MeshInfo
    {
        private static readonly global::UnityEngine.Color32 s_DefaultColor;
        private static readonly global::UnityEngine.Vector3 s_DefaultNormal;
        private static readonly global::UnityEngine.Vector4 s_DefaultTangent;
        private static readonly global::UnityEngine.Bounds s_DefaultBounds;
        public global::UnityEngine.Mesh mesh;
        public int vertexCount;
        public global::UnityEngine.Vector3[] vertices;
        public global::UnityEngine.Vector3[] normals;
        public global::UnityEngine.Vector4[] tangents;
        public global::UnityEngine.Vector2[] uvs0;
        public global::UnityEngine.Vector2[] uvs2;
        public global::UnityEngine.Color32[] colors32;
        public int[] triangles;
        public global::UnityEngine.Material material;
        public TMP_MeshInfo(global::UnityEngine.Mesh mesh, int size)
        {
            this.mesh = null;
            vertexCount = 0;
            vertices = null;
            normals = null;
            tangents = null;
            uvs0 = null;
            uvs2 = null;
            colors32 = null;
            triangles = null;
            material = null;
        }

        public TMP_MeshInfo(global::UnityEngine.Mesh mesh, int size, bool isVolumetric)
        {
            this.mesh = null;
            vertexCount = 0;
            vertices = null;
            normals = null;
            tangents = null;
            uvs0 = null;
            uvs2 = null;
            colors32 = null;
            triangles = null;
            material = null;
        }

        public void ResizeMeshInfo(int size)
        {
        }

        public void ResizeMeshInfo(int size, bool isVolumetric)
        {
        }

        public void Clear()
        {
        }

        public void Clear(bool uploadChanges)
        {
        }

        public void ClearUnusedVertices()
        {
        }

        public void ClearUnusedVertices(int startIndex)
        {
        }

        public void ClearUnusedVertices(int startIndex, bool updateMesh)
        {
        }

        public void SortGeometry(global::TMPro.VertexSortingOrder order)
        {
        }

        public void SortGeometry(global::System.Collections.Generic.IList<int> sortingOrder)
        {
        }

        public void SwapVertexData(int src, int dst)
        {
        }
    }
}