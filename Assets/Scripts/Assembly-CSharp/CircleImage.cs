public class CircleImage : global::UnityEngine.UI.Image
{
    private readonly global::UnityEngine.Color32 GRAY_COLOR;
    public int segements;
    [global::UnityEngine.SerializeField]
    public float showPercent;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> _vertexList;
    public bool accurateRaycast;
    protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private void AddVertex(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private void AddTriangle(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private global::UnityEngine.Color32 GetOriginColor()
    {
        return default;
    }

    private global::UnityEngine.UIVertex GetUIVertex(global::UnityEngine.Color32 col, global::UnityEngine.Vector3 pos, global::UnityEngine.Vector2 uvPos, global::UnityEngine.Vector2 uvCenter, global::UnityEngine.Vector2 uvScale)
    {
        return default;
    }

    public override bool IsRaycastLocationValid(global::UnityEngine.Vector2 screenPoint, global::UnityEngine.Camera eventCamera)
    {
        return false;
    }

    private int GetCrossPointNum(global::UnityEngine.Vector2 clickPos, global::System.Collections.Generic.List<global::UnityEngine.Vector3> _vertexList)
    {
        return 0;
    }

    private bool IsYInRang(global::UnityEngine.Vector2 clickPos, global::UnityEngine.Vector3 vert1, global::UnityEngine.Vector3 vert2)
    {
        return false;
    }

    private float GetX(global::UnityEngine.Vector3 vert1, global::UnityEngine.Vector3 vert2, float y)
    {
        return 0f;
    }
}