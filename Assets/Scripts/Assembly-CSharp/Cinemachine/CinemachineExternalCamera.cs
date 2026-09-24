namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineExternalCamera : global::Cinemachine.CinemachineVirtualCameraBase
    {
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_LookAt;
        private global::UnityEngine.Camera m_Camera;
        private global::Cinemachine.CameraState m_State;
        public override global::Cinemachine.CameraState State => default;

        public override global::UnityEngine.Transform LookAt
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override global::UnityEngine.Transform Follow { get; set; }

        public override void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }
    }
}