namespace Cinemachine
{
    public abstract class CinemachineComponentBase : global::UnityEngine.MonoBehaviour
    {
        protected const float Epsilon = 0.0001f;
        private global::Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;
        public global::Cinemachine.CinemachineVirtualCameraBase VirtualCamera => null;
        public global::UnityEngine.Transform FollowTarget => null;
        public global::UnityEngine.Transform LookAtTarget => null;
        public global::Cinemachine.CameraState VcamState => default;
        public abstract bool IsValid { get; }
        public abstract global::Cinemachine.CinemachineCore.Stage Stage { get; }

        public virtual void PrePipelineMutateCameraState(ref global::Cinemachine.CameraState state)
        {
        }

        public abstract void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime);
        public virtual void OnPositionDragged(global::UnityEngine.Vector3 delta)
        {
        }
    }
}