namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachinePath : global::Cinemachine.CinemachinePathBase
    {
        [global::System.Serializable]
        public struct Waypoint
        {
            public global::UnityEngine.Vector3 position;
            public global::UnityEngine.Vector3 tangent;
            public float roll;
        }

        public bool m_Looped;
        public global::Cinemachine.CinemachinePath.Waypoint[] m_Waypoints;
        public override float MinPos => 0f;
        public override float MaxPos => 0f;
        public override bool Looped => false;
        public override int DistanceCacheSampleStepsPerSegment => 0;

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

        private void OnValidate()
        {
        }
    }
}