namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineTransposer : global::Cinemachine.CinemachineComponentBase
    {
        public enum BindingMode
        {
            LockToTargetOnAssign = 0,
            LockToTargetWithWorldUp = 1,
            LockToTargetNoRoll = 2,
            LockToTarget = 3,
            WorldSpace = 4,
            SimpleFollowWithWorldUp = 5
        }

        public global::Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;
        public global::UnityEngine.Vector3 m_FollowOffset;
        public float m_XDamping;
        public float m_YDamping;
        public float m_ZDamping;
        public float m_PitchDamping;
        public float m_YawDamping;
        public float m_RollDamping;
        private global::UnityEngine.Vector3 m_PreviousTargetPosition;
        private global::UnityEngine.Quaternion m_PreviousReferenceOrientation;
        private global::UnityEngine.Quaternion m_targetOrientationOnAssign;
        private global::UnityEngine.Transform m_previousTarget;
        protected global::UnityEngine.Vector3 EffectiveOffset => default;
        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;
        protected global::UnityEngine.Vector3 Damping => default;
        protected global::UnityEngine.Vector3 AngularDamping => default;

        protected virtual void OnValidate()
        {
        }

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        public override void OnPositionDragged(global::UnityEngine.Vector3 delta)
        {
        }

        protected void InitPrevFrameStateInfo(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        protected void TrackTarget(float deltaTime, global::UnityEngine.Vector3 up, global::UnityEngine.Vector3 desiredCameraOffset, out global::UnityEngine.Vector3 outTargetPosition, out global::UnityEngine.Quaternion outTargetOrient)
        {
            outTargetPosition = default;
            outTargetOrient = default;
        }

        public global::UnityEngine.Vector3 GeTargetCameraPosition(global::UnityEngine.Vector3 worldUp)
        {
            return default;
        }

        public global::UnityEngine.Quaternion GetReferenceOrientation(global::UnityEngine.Vector3 worldUp)
        {
            return default;
        }

        private static global::UnityEngine.Quaternion Uppify(global::UnityEngine.Quaternion q, global::UnityEngine.Vector3 up)
        {
            return default;
        }
    }
}