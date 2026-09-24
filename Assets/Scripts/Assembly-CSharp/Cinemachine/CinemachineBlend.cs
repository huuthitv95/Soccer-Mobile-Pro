namespace Cinemachine
{
    public class CinemachineBlend
    {
        public global::Cinemachine.ICinemachineCamera CamA { get; set; }
        public global::Cinemachine.ICinemachineCamera CamB { get; set; }
        public global::UnityEngine.AnimationCurve BlendCurve { get; set; }
        public float TimeInBlend { get; set; }
        public float BlendWeight => 0f;
        public bool IsValid => false;
        public float Duration { get; set; }
        public bool IsComplete => false;
        public string Description => null;
        public global::Cinemachine.CameraState State => default;

        public bool Uses(global::Cinemachine.ICinemachineCamera cam)
        {
            return false;
        }

        public CinemachineBlend(global::Cinemachine.ICinemachineCamera a, global::Cinemachine.ICinemachineCamera b, global::UnityEngine.AnimationCurve curve, float duration, float t)
        {
        }

        public void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }
    }
}