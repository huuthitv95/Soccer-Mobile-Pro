public class DrawTrainingArea : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GenerateRectangleOutlineMesh rect;
    [global::UnityEngine.SerializeField]
    private GenerateAnnulusMesh annulus;
    [global::UnityEngine.SerializeField]
    private GenerateArcMesh arc;
    [global::UnityEngine.SerializeField]
    private GenerateArcMesh arc2;
    [global::UnityEngine.SerializeField]
    private DrawConcentricCircularArcsMesh concentricCircularArcs;
    public void ShowRect(global::UnityEngine.Vector3 pos, global::UnityEngine.Vector2 size)
    {
    }

    public void ShowAnnulus(global::UnityEngine.Vector3 pos, float r)
    {
    }

    public void ShowArc(global::UnityEngine.Vector3 pos, float minR, float MaxR, float minAngle, float MaxAngle)
    {
    }

    public void Draw(int type, global::System.Collections.Generic.List<float> config)
    {
    }
}