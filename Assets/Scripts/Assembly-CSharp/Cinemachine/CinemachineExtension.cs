namespace Cinemachine
{
    public abstract class CinemachineExtension : global::UnityEngine.MonoBehaviour
    {
        protected const float Epsilon = 0.0001f;
        private global::Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;
        private global::System.Collections.Generic.Dictionary<global::Cinemachine.ICinemachineCamera, object> mExtraState;
        public global::Cinemachine.CinemachineVirtualCameraBase VirtualCamera => null;

        protected virtual void Awake()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        private void ConnectToVcam()
        {
        }

        protected abstract void PostPipelineStageCallback(global::Cinemachine.CinemachineVirtualCameraBase vcam, global::Cinemachine.CinemachineCore.Stage stage, ref global::Cinemachine.CameraState state, float deltaTime);
        protected T GetExtraState<T>(global::Cinemachine.ICinemachineCamera vcam)
            where T : class, new()
        {
            return null;
        }

        protected global::System.Collections.Generic.List<T> GetAllExtraStates<T>()
            where T : class, new()
        {
            return null;
        }
    }
}