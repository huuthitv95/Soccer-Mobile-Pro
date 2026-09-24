namespace UnityEngine.UI.Extensions
{
    public class BezierPath
    {
        public int SegmentsPerCurve;
        public float MINIMUM_SQR_DISTANCE;
        public float DIVISION_THRESHOLD;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector2> controlPoints;
        private int curveCount;
        public void SetControlPoints(global::System.Collections.Generic.List<global::UnityEngine.Vector2> newControlPoints)
        {
        }

        public void SetControlPoints(global::UnityEngine.Vector2[] newControlPoints)
        {
        }

        public global::System.Collections.Generic.List<global::UnityEngine.Vector2> GetControlPoints()
        {
            return null;
        }

        public void Interpolate(global::System.Collections.Generic.List<global::UnityEngine.Vector2> segmentPoints, float scale)
        {
        }

        public void SamplePoints(global::System.Collections.Generic.List<global::UnityEngine.Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale)
        {
        }

        public global::UnityEngine.Vector2 CalculateBezierPoint(int curveIndex, float t)
        {
            return default;
        }

        public global::System.Collections.Generic.List<global::UnityEngine.Vector2> GetDrawingPoints0()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::UnityEngine.Vector2> GetDrawingPoints1()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::UnityEngine.Vector2> GetDrawingPoints2()
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::UnityEngine.Vector2> FindDrawingPoints(int curveIndex)
        {
            return null;
        }

        private int FindDrawingPoints(int curveIndex, float t0, float t1, global::System.Collections.Generic.List<global::UnityEngine.Vector2> pointList, int insertionIndex)
        {
            return 0;
        }

        private global::UnityEngine.Vector2 CalculateBezierPoint(float t, global::UnityEngine.Vector2 p0, global::UnityEngine.Vector2 p1, global::UnityEngine.Vector2 p2, global::UnityEngine.Vector2 p3)
        {
            return default;
        }
    }
}