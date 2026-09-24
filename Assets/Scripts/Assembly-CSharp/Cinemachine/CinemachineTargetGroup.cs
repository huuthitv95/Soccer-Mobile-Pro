namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineTargetGroup : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public struct Target
        {
            public global::UnityEngine.Transform target;
            public float weight;
            public float radius;
        }

        public enum PositionMode
        {
            GroupCenter = 0,
            GroupAverage = 1
        }

        public enum RotationMode
        {
            Manual = 0,
            GroupAverage = 1
        }

        public enum UpdateMethod
        {
            Update = 0,
            FixedUpdate = 1,
            LateUpdate = 2
        }

        public global::Cinemachine.CinemachineTargetGroup.PositionMode m_PositionMode;
        public global::Cinemachine.CinemachineTargetGroup.RotationMode m_RotationMode;
        public global::Cinemachine.CinemachineTargetGroup.UpdateMethod m_UpdateMethod;
        [global::Cinemachine.NoSaveDuringPlay]
        public global::Cinemachine.CinemachineTargetGroup.Target[] m_Targets;
        private float m_lastRadius;
        public global::UnityEngine.Bounds BoundingBox => default;
        public bool IsEmpty => false;

        public global::UnityEngine.Bounds GetViewSpaceBoundingBox(global::UnityEngine.Matrix4x4 mView)
        {
            return default;
        }

        private global::UnityEngine.Vector3 CalculateAveragePosition(out float averageWeight)
        {
            averageWeight = default;
            return default;
        }

        private global::UnityEngine.Quaternion CalculateAverageOrientation()
        {
            return default;
        }

        private void OnValidate()
        {
        }

        private void FixedUpdate()
        {
        }

        private void Update()
        {
        }

        private void LateUpdate()
        {
        }

        private void UpdateTransform()
        {
        }
    }
}