namespace UnityEngine.UI
{
    public class VertexHelper : global::System.IDisposable
    {
        private global::System.Collections.Generic.List<global::UnityEngine.Vector3> m_Positions;
        private global::System.Collections.Generic.List<global::UnityEngine.Color32> m_Colors;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector4> m_Uv0S;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector4> m_Uv1S;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector4> m_Uv2S;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector4> m_Uv3S;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector3> m_Normals;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector4> m_Tangents;
        private global::System.Collections.Generic.List<int> m_Indices;
        private static readonly global::UnityEngine.Vector4 s_DefaultTangent;
        private static readonly global::UnityEngine.Vector3 s_DefaultNormal;
        private bool m_ListsInitalized;
        public int currentVertCount => 0;
        public int currentIndexCount => 0;

        public VertexHelper()
        {
        }

        public VertexHelper(global::UnityEngine.Mesh m)
        {
        }

        private void InitializeListIfRequired()
        {
        }

        public void Dispose()
        {
        }

        public void Clear()
        {
        }

        public void PopulateUIVertex(ref global::UnityEngine.UIVertex vertex, int i)
        {
        }

        public void SetUIVertex(global::UnityEngine.UIVertex vertex, int i)
        {
        }

        public void FillMesh(global::UnityEngine.Mesh mesh)
        {
        }

        public void AddVert(global::UnityEngine.Vector3 position, global::UnityEngine.Color32 color, global::UnityEngine.Vector4 uv0, global::UnityEngine.Vector4 uv1, global::UnityEngine.Vector4 uv2, global::UnityEngine.Vector4 uv3, global::UnityEngine.Vector3 normal, global::UnityEngine.Vector4 tangent)
        {
        }

        public void AddVert(global::UnityEngine.Vector3 position, global::UnityEngine.Color32 color, global::UnityEngine.Vector4 uv0, global::UnityEngine.Vector4 uv1, global::UnityEngine.Vector3 normal, global::UnityEngine.Vector4 tangent)
        {
        }

        public void AddVert(global::UnityEngine.Vector3 position, global::UnityEngine.Color32 color, global::UnityEngine.Vector4 uv0)
        {
        }

        public void AddVert(global::UnityEngine.UIVertex v)
        {
        }

        public void AddTriangle(int idx0, int idx1, int idx2)
        {
        }

        public void AddUIVertexQuad(global::UnityEngine.UIVertex[] verts)
        {
        }

        public void AddUIVertexStream(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts, global::System.Collections.Generic.List<int> indices)
        {
        }

        public void AddUIVertexTriangleStream(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts)
        {
        }

        public void GetUIVertexStream(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> stream)
        {
        }
    }
}