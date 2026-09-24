namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineBasicMultiChannelPerlin : global::Cinemachine.CinemachineComponentBase
    {
        [global::UnityEngine.HideInInspector]
        public global::Cinemachine.NoiseSettings m_NoiseProfile;
        public float m_AmplitudeGain;
        public float m_FrequencyGain;
        private bool mInitialized;
        private float mNoiseTime;
        private global::UnityEngine.Vector3 mNoiseOffsets;
        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        private void Initialize()
        {
        }

        private static global::UnityEngine.Vector3 GetCombinedFilterResults(global::Cinemachine.NoiseSettings.TransformNoiseParams[] noiseParams, float time, global::UnityEngine.Vector3 noiseOffsets)
        {
            return default;
        }
    }
}