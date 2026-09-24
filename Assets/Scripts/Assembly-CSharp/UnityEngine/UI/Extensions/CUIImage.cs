namespace UnityEngine.UI.Extensions
{
    public class CUIImage : global::UnityEngine.UI.Extensions.CUIGraphic
    {
        public static int SlicedImageCornerRefVertexIdx;
        public static int FilledImageCornerRefVertexIdx;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        public global::UnityEngine.Vector2 cornerPosRatio;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        protected global::UnityEngine.Vector2 oriCornerPosRatio;
        public global::UnityEngine.Vector2 OriCornerPosRatio => default;
        public global::UnityEngine.UI.Image UIImage => null;

        public static int ImageTypeCornerRefVertexIdx(global::UnityEngine.UI.Image.Type _type)
        {
            return 0;
        }

        public override void ReportSet()
        {
        }

        protected override void modifyVertices(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> _verts)
        {
        }
    }
}