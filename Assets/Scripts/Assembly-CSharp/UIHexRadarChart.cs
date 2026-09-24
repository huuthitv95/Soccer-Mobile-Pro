public class UIHexRadarChart : global::UnityEngine.UI.MaskableGraphic
{
    [global::UnityEngine.SerializeField]
    private int axisCount;
    [global::UnityEngine.SerializeField]
    private int ringCount;
    [global::UnityEngine.SerializeField]
    private float lineThickness;
    [global::UnityEngine.SerializeField]
    private float startAngle;
    [global::UnityEngine.SerializeField]
    private float minValue;
    [global::UnityEngine.SerializeField]
    private float maxValue;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color gridColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color radialColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color borderColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color fillColor;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<float> values;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.Vector2> outerPoints;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.Vector2> valuePoints;
    public override global::UnityEngine.Texture mainTexture => null;

    protected UIHexRadarChart()
    {
    }

    protected override void OnEnable()
    {
    }

    public void SetValues(global::System.Collections.Generic.IList<float> newValues)
    {
    }

    public void SetValues(global::System.Collections.Generic.IEnumerator<int> enumerator)
    {
    }

    public void SetValues(global::System.Collections.Generic.IEnumerable<int> enumerator)
    {
    }

    public void SetValues(global::System.Collections.Generic.IEnumerator<sbyte> enumerator)
    {
    }

    public void SetValue(global::System.Collections.Generic.IEnumerator<float> valueEnumerator)
    {
    }

    private void EnsureValueCount()
    {
    }

    protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private void BuildPoints(global::UnityEngine.Vector2 center, float radius)
    {
    }

    private void DrawGrid(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.Vector2 center)
    {
    }

    private void DrawRadarFill(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.Vector2 center)
    {
    }

    private void DrawRadarBorder(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private static global::UnityEngine.Color32 MultiplyColor(global::UnityEngine.Color a, global::UnityEngine.Color b)
    {
        return default;
    }

    private static void AddLine(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.Vector2 from, global::UnityEngine.Vector2 to, float thickness, global::UnityEngine.Color32 color)
    {
    }
}