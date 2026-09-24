public class MeshVertex
{
    public WireSide.Side side;
    public global::UnityEngine.Vector3 position;
    public global::UnityEngine.Vector3 previous;
    public global::UnityEngine.Vector3 original;
    public global::UnityEngine.Vector3 acceleration;
    public const float DAMPING = 0.03f;
    public const float DRAG = 0.97f;
    public const float MASS = 20f;
    private const float invMass = 0.05f;
    public MeshVertex(float x, float y, float z, WireSide.Side wire_side)
    {
    }

    public void AddForce(global::UnityEngine.Vector3 force)
    {
    }

    public void Integrate(float timesq)
    {
    }
}