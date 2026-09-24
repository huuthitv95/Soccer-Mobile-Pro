namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineTrackedDolly : global::Cinemachine.CinemachineComponentBase
    {
        public enum CameraUpMode
        {
            Default = 0,
            Path = 1,
            PathNoRoll = 2,
            FollowTarget = 3,
            FollowTargetNoRoll = 4
        }

        [global::System.Serializable]
        public struct AutoDolly
        {
            public bool m_Enabled;
            public float m_PositionOffset;
            public int m_SearchRadius;
            public int m_SearchResolution;
            public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment)
            {
                m_Enabled = false;
                m_PositionOffset = 0f;
                m_SearchRadius = 0;
                m_SearchResolution = 0;
            }
        }

        public global::Cinemachine.CinemachinePathBase m_Path;
        public float m_PathPosition;
        public global::Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
        public global::UnityEngine.Vector3 m_PathOffset;
        public float m_XDamping;
        public float m_YDamping;
        public float m_ZDamping;
        public global::Cinemachine.CinemachineTrackedDolly.CameraUpMode m_CameraUp;
        public float m_PitchDamping;
        public float m_YawDamping;
        public float m_RollDamping;
        public global::Cinemachine.CinemachineTrackedDolly.AutoDolly m_AutoDolly;
        private float m_PreviousPathPosition;
        private global::UnityEngine.Quaternion m_PreviousOrientation;
        private global::UnityEngine.Vector3 m_PreviousCameraPosition;
        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;
        private global::UnityEngine.Vector3 AngularDamping => default;

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        public override void OnPositionDragged(global::UnityEngine.Vector3 delta)
        {
        }

        private global::UnityEngine.Quaternion GetTargetOrientationAtPathPoint(global::UnityEngine.Quaternion pathOrientation, global::UnityEngine.Vector3 up)
        {
            return default;
        }
    }
}