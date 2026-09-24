namespace UnityEngine.UI.Extensions
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CUIGraphic : global::UnityEngine.UI.BaseMeshEffect
    {
        public static readonly int bottomCurveIdx;
        public static readonly int topCurveIdx;
        [global::UnityEngine.SerializeField]
        protected bool isCurved;
        [global::UnityEngine.SerializeField]
        protected bool isLockWithRatio;
        [global::UnityEngine.SerializeField]
        protected float resolution;
        protected global::UnityEngine.RectTransform rectTrans;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Graphic uiGraphic;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Extensions.CUIGraphic refCUIGraphic;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Extensions.CUIBezierCurve[] refCurves;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        protected global::UnityEngine.UI.Extensions.Vector3_Array2D[] refCurvesControlRatioPoints;
        protected global::System.Collections.Generic.List<global::UnityEngine.UIVertex> reuse_quads;
        public bool IsCurved => false;
        public bool IsLockWithRatio => false;
        public global::UnityEngine.RectTransform RectTrans => null;
        public global::UnityEngine.UI.Graphic UIGraphic => null;
        public global::UnityEngine.UI.Extensions.CUIGraphic RefCUIGraphic => null;
        public global::UnityEngine.UI.Extensions.CUIBezierCurve[] RefCurves => null;
        public global::UnityEngine.UI.Extensions.Vector3_Array2D[] RefCurvesControlRatioPoints => null;

        protected void solveDoubleEquationWithVector(float _x_1, float _y_1, float _x_2, float _y_2, global::UnityEngine.Vector3 _constant_1, global::UnityEngine.Vector3 _contant_2, out global::UnityEngine.Vector3 _x, out global::UnityEngine.Vector3 _y)
        {
            _x = default;
            _y = default;
        }

        protected global::UnityEngine.UIVertex uiVertexLerp(global::UnityEngine.UIVertex _a, global::UnityEngine.UIVertex _b, float _time)
        {
            return default;
        }

        protected global::UnityEngine.UIVertex uiVertexBerp(global::UnityEngine.UIVertex v_bottomLeft, global::UnityEngine.UIVertex v_topLeft, global::UnityEngine.UIVertex v_topRight, global::UnityEngine.UIVertex v_bottomRight, float _xTime, float _yTime)
        {
            return default;
        }

        protected void tessellateQuad(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> _quads, int _thisQuadIdx)
        {
        }

        protected void tessellateGraphic(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> _verts)
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        public void Refresh()
        {
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        public virtual void ReportSet()
        {
        }

        public void FixTextToRectTrans()
        {
        }

        public void ReferenceCUIForBCurves()
        {
        }

        public override void ModifyMesh(global::UnityEngine.Mesh _mesh)
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper _vh)
        {
        }

        protected virtual void modifyVertices(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> _verts)
        {
        }

        public void UpdateCurveControlPointPositions()
        {
        }

        public global::UnityEngine.Vector3 GetBCurveSandwichSpacePoint(float _xTime, float _yTime)
        {
            return default;
        }

        public global::UnityEngine.Vector3 GetBCurveSandwichSpaceTangent(float _xTime, float _yTime)
        {
            return default;
        }
    }
}