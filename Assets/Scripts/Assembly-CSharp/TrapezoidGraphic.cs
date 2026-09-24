public class TrapezoidGraphic : global::UnityEngine.UI.MaskableGraphic
{
    public enum SlantedSide
    {
        Left = 0,
        Right = 1,
        Both = 2
    }

    [global::UnityEngine.SerializeField]
    private TrapezoidGraphic.SlantedSide _slantedSide;
    [global::UnityEngine.SerializeField]
    private float _slantAngle;
    [global::UnityEngine.SerializeField]
    private float _edgeSoftness;
    protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vertexHelper)
    {
    }

    protected override void OnDidApplyAnimationProperties()
    {
    }

    private void AddAntialiasedEdge(global::UnityEngine.UI.VertexHelper vertexHelper, global::UnityEngine.Vector2 edgeStart, global::UnityEngine.Vector2 edgeEnd, global::UnityEngine.Vector2 startUv, global::UnityEngine.Vector2 endUv)
    {
    }

    private static void AddVertex(global::UnityEngine.UI.VertexHelper vertexHelper, global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 uv, global::UnityEngine.Color32 vertexColor)
    {
    }
}