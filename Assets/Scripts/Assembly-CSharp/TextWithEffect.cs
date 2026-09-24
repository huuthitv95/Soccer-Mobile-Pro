public class TextWithEffect : global::UnityEngine.UI.BaseMeshEffect
{
    private enum EffectType
    {
        DoubleArc = 0
    }

    private enum HorizontalAligmentType
    {
        Left = 0,
        Center = 1,
        Right = 2
    }

    private class Line
    {
        private int _startVertexIndex;
        private int _endVertexIndex;
        private int _vertexCount;
        public int StartVertexIndex => 0;
        public int EndVertexIndex => 0;
        public int VertexCount => 0;

        public Line(int startVertexIndex, int length)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private TextWithEffect.EffectType effectType;
    [global::UnityEngine.SerializeField]
    private float StartAngle;
    [global::UnityEngine.SerializeField]
    private float Range;
    [global::UnityEngine.SerializeField]
    private float Yoffset;
    [global::UnityEngine.SerializeField]
    private float wordSpace;
    private float LineSpacing;
    public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private void SetWordSpace(global::UnityEngine.UI.VertexHelper vh)
    {
    }

    private void DoubleArcTextEffect(global::UnityEngine.UI.VertexHelper vh)
    {
    }
}