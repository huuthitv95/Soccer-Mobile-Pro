namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineFollowZoom : global::Cinemachine.CinemachineExtension
    {
        private class VcamExtraState
        {
            public float m_previousFrameZoom;
        }

        public float m_Width;
        public float m_Damping;
        public float m_MinFOV;
        public float m_MaxFOV;
        private void OnValidate()
        {
        }

        protected override void PostPipelineStageCallback(global::Cinemachine.CinemachineVirtualCameraBase vcam, global::Cinemachine.CinemachineCore.Stage stage, ref global::Cinemachine.CameraState state, float deltaTime)
        {
        }
    }
}