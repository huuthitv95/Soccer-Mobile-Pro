namespace UnityEngine.UI.Extensions
{
    public class CUIBezierCurve : global::UnityEngine.MonoBehaviour
    {
        public static readonly int CubicBezierCurvePtNum;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Vector3[] controlPoints;
        public global::System.Action OnRefresh;
        public global::UnityEngine.Vector3[] ControlPoints => null;

        public void Refresh()
        {
        }

        public global::UnityEngine.Vector3 GetPoint(float _time)
        {
            return default;
        }

        public global::UnityEngine.Vector3 GetTangent(float _time)
        {
            return default;
        }

        public void ReportSet()
        {
        }
    }
}