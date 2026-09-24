public class WireSide
{
    public enum Side
    {
        Top = 0,
        Left = 1,
        Right = 2,
        Back = 3
    }

    public WireSide.Side side;
    public global::UnityEngine.Vector3 position;
    public float width;
    public float height;
    public int col;
    public int row;
    public GoalNet goalNet;
    private float gridWidth;
    private float gridHeight;
    public WireSide(WireSide.Side side_, global::UnityEngine.Vector3 position_, GoalNet goalNet_)
    {
    }

    public int Index(int u, int v)
    {
        return 0;
    }

    public void Awake()
    {
    }

    public void BuildMesh(ref global::System.Collections.Generic.List<MeshVertex> vertices, ref global::System.Collections.Generic.List<int> triangles, ref global::System.Collections.Generic.List<global::UnityEngine.Vector2> uv, ref global::System.Collections.Generic.List<global::UnityEngine.Vector2> uv2)
    {
    }

    public void BuildConstraints(ref global::System.Collections.Generic.List<MeshVertex> meshVertices, ref global::System.Collections.Generic.List<WireConstraint> constraints, ref global::System.Collections.Generic.List<int> pins)
    {
    }
}