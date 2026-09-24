public class VertexFadeEffect
{
    private class Vector3Comparer : global::System.Collections.Generic.IComparer<int>
    {
        private global::UnityEngine.Vector3[] _vertices;
        public Vector3Comparer(global::UnityEngine.Vector3[] vertices)
        {
        }

        public int Compare(int a, int b)
        {
            return 0;
        }
    }

    private class LinkedVertexCountComparer : global::System.Collections.Generic.IComparer<int>
    {
        private VertexFadeEffect.CVertexData[] _vertices;
        public LinkedVertexCountComparer(VertexFadeEffect.CVertexData[] vertices)
        {
        }

        public int Compare(int x, int y)
        {
            return 0;
        }
    }

    private class CVertexData
    {
        public int masterVertex;
        public global::System.Collections.Generic.List<int> replicaVertices;
        public global::System.Collections.Generic.List<int> linkedVertices;
        public bool isMarked;
    }

    private static global::System.Collections.Generic.Dictionary<global::UnityEngine.Mesh, bool[]> _centralitiesCache;
    private global::System.Collections.Generic.List<global::UnityEngine.Material> _materials;
    private global::System.Collections.Generic.List<global::UnityEngine.Mesh> _meshs;
    private bool _reverse;
    public void Start(global::UnityEngine.GameObject go, bool reverse)
    {
    }

    public void UpdateTransition(float percent)
    {
    }

    public void End()
    {
    }

    private void SetCentralVertex(bool[] centralities, VertexFadeEffect.CVertexData[] vertexDataArray, int index, bool isCentralVertex)
    {
    }

    private bool[] GetVertexCentralities(global::UnityEngine.Mesh mesh)
    {
        return null;
    }
}