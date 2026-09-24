namespace Cinemachine
{
    internal class BlendSourceVirtualCamera : global::Cinemachine.ICinemachineCamera
    {
        public global::Cinemachine.CinemachineBlend Blend { get; private set; }
        public string Name => null;
        public string Description => null;
        public int Priority { get; set; }
        public global::UnityEngine.Transform LookAt { get; set; }
        public global::UnityEngine.Transform Follow { get; set; }
        public global::Cinemachine.CameraState State { get; private set; }
        public global::UnityEngine.GameObject VirtualCameraGameObject => null;
        public global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;
        public global::Cinemachine.ICinemachineCamera ParentCamera => null;

        public BlendSourceVirtualCamera(global::Cinemachine.CinemachineBlend blend, float deltaTime)
        {
        }

        public bool IsLiveChild(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        public global::Cinemachine.CameraState CalculateNewState(float deltaTime)
        {
            return default;
        }

        public void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        public void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }
    }
}