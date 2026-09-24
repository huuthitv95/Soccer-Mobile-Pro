namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineSmoothPath : global::Cinemachine.CinemachinePathBase
    {
        [global::System.Serializable]
        public struct Waypoint
        {
            public global::UnityEngine.Vector3 position;
            public float roll;
            internal global::UnityEngine.Vector4 AsVector4 => default;

            internal static global::Cinemachine.CinemachineSmoothPath.Waypoint FromVector4(global::UnityEngine.Vector4 v)
            {
                return default;
            }
        }

        public bool m_Looped;
        public global::Cinemachine.CinemachineSmoothPath.Waypoint[] m_Waypoints;
        public global::Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints1;
        public global::Cinemachine.CinemachineSmoothPath.Waypoint[] m_ControlPoints2;
        private bool m_IsLoopedCache;
        public override float MinPos => 0f;
        public override float MaxPos => 0f;
        public override bool Looped => false;
        public override int DistanceCacheSampleStepsPerSegment => 0;

        private void OnValidate()
        {
        }

        public override void InvalidateDistanceCache()
        {
        }

        private void UpdateControlPoints()
        {
        }

        private float GetBoundingIndices(float pos, out int indexA, out int indexB)
        {
            indexA = default;
            indexB = default;
            return 0f;
        }

        public override global::UnityEngine.Vector3 EvaluatePosition(float pos)
        {
            return default;
        }

        public override global::UnityEngine.Vector3 EvaluateTangent(float pos)
        {
            return default;
        }

        public override global::UnityEngine.Quaternion EvaluateOrientation(float pos)
        {
            return default;
        }
    }
}