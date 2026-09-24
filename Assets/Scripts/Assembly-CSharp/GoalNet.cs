public class GoalNet : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.Vector3 size;
    public global::System.Collections.Generic.List<int> gridSize;
    [global::UnityEngine.HideInInspector]
    public WireSide top;
    [global::UnityEngine.HideInInspector]
    public WireSide left;
    [global::UnityEngine.HideInInspector]
    public WireSide right;
    [global::UnityEngine.HideInInspector]
    public WireSide back;
    private global::System.Collections.Generic.List<MeshVertex> meshVertices;
    private global::System.Collections.Generic.List<WireConstraint> constraints;
    private global::System.Collections.Generic.List<int> pins;
    private global::System.Collections.Generic.List<int> triangles;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> uv2s;
    private global::UnityEngine.Mesh mesh;
    private bool visible;
    private string[] textures;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> vertices;
    private global::UnityEngine.Vector3[] newvertices;
    private bool FirstFrameFlag;
    private global::UnityEngine.Vector3[] restStateVertices;
    private void Start()
    {
    }

    public void ChangeTexture(int index, global::UnityEngine.Color color)
    {
    }

    public void SetDetailTexture(global::UnityEngine.Texture texture)
    {
    }

    public int GetTextureCount()
    {
        return 0;
    }

    public void Simulate(global::UnityEngine.Vector3 ballPosition_, global::UnityEngine.Vector3 ballVelocity_, float time, bool ballTouchesNet, bool ballIsInGoal)
    {
    }

    public void UpdateRestStateVertices()
    {
    }

    public unsafe void UpdateVertices(byte* vertices, int startIndex, int arraysize)
    {
    }

    public void ResetVertices()
    {
    }

    public void UpdateVertices(global::EngineMessages.FrameDetail frameDetail, int startIndex)
    {
    }

    private void OnBecameVisible()
    {
    }

    private void OnBecameInvisible()
    {
    }
}