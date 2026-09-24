namespace Cinemachine
{
    internal class StaticPointVirtualCamera : global::Cinemachine.ICinemachineCamera
    {
        public string Name { get; private set; }
        public string Description => null;
        public int Priority { get; set; }
        public global::UnityEngine.Transform LookAt { get; set; }
        public global::UnityEngine.Transform Follow { get; set; }
        public global::Cinemachine.CameraState State { get; private set; }
        public global::UnityEngine.GameObject VirtualCameraGameObject => null;
        public global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;
        public global::Cinemachine.ICinemachineCamera ParentCamera => null;

        public StaticPointVirtualCamera(global::Cinemachine.CameraState state, string name)
        {
        }

        public void SetState(global::Cinemachine.CameraState state)
        {
        }

        public bool IsLiveChild(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        public void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        public void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }
    }
}