namespace Cinemachine
{
    public abstract class CinemachinePathBase : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class Appearance
        {
            public global::UnityEngine.Color pathColor;
            public global::UnityEngine.Color inactivePathColor;
            public float width;
        }

        public enum PositionUnits
        {
            PathUnits = 0,
            Distance = 1
        }

        public int m_Resolution;
        public global::Cinemachine.CinemachinePathBase.Appearance m_Appearance;
        private float[] m_DistanceToPos;
        private float[] m_PosToDistance;
        private int m_CachedSampleSteps;
        private float m_PathLength;
        private float m_cachedPosStepSize;
        private float m_cachedDistanceStepSize;
        public abstract float MinPos { get; }
        public abstract float MaxPos { get; }
        public abstract bool Looped { get; }
        public abstract int DistanceCacheSampleStepsPerSegment { get; }
        public float PathLength => 0f;

        public virtual float NormalizePos(float pos)
        {
            return 0f;
        }

        public abstract global::UnityEngine.Vector3 EvaluatePosition(float pos);
        public abstract global::UnityEngine.Vector3 EvaluateTangent(float pos);
        public abstract global::UnityEngine.Quaternion EvaluateOrientation(float pos);
        public virtual float FindClosestPoint(global::UnityEngine.Vector3 p, int startSegment, int searchRadius, int stepsPerSegment)
        {
            return 0f;
        }

        public float MinUnit(global::Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            return 0f;
        }

        public float MaxUnit(global::Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            return 0f;
        }

        public virtual float NormalizeUnit(float pos, global::Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            return 0f;
        }

        public global::UnityEngine.Vector3 EvaluatePositionAtUnit(float pos, global::Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            return default;
        }

        public global::UnityEngine.Vector3 EvaluateTangentAtUnit(float pos, global::Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            return default;
        }

        public global::UnityEngine.Quaternion EvaluateOrientationAtUnit(float pos, global::Cinemachine.CinemachinePathBase.PositionUnits units)
        {
            return default;
        }

        public virtual void InvalidateDistanceCache()
        {
        }

        public bool DistanceCacheIsValid()
        {
            return false;
        }

        public float NormalizePathDistance(float distance)
        {
            return 0f;
        }

        public float GetPathPositionFromDistance(float distance)
        {
            return 0f;
        }

        public float GetPathDistanceFromPosition(float pos)
        {
            return 0f;
        }

        private void ResamplePath(int stepsPerSegment)
        {
        }
    }
}