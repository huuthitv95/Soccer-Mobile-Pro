namespace Cinemachine
{
    public sealed class NoiseSettings : global::UnityEngine.ScriptableObject
    {
        [global::System.Serializable]
        public struct NoiseParams
        {
            public float Amplitude;
            public float Frequency;
        }

        [global::System.Serializable]
        public struct TransformNoiseParams
        {
            public global::Cinemachine.NoiseSettings.NoiseParams X;
            public global::Cinemachine.NoiseSettings.NoiseParams Y;
            public global::Cinemachine.NoiseSettings.NoiseParams Z;
        }

        [global::UnityEngine.SerializeField]
        private global::Cinemachine.NoiseSettings.TransformNoiseParams[] m_Position;
        [global::UnityEngine.SerializeField]
        private global::Cinemachine.NoiseSettings.TransformNoiseParams[] m_Orientation;
        public global::Cinemachine.NoiseSettings.TransformNoiseParams[] PositionNoise => null;
        public global::Cinemachine.NoiseSettings.TransformNoiseParams[] OrientationNoise => null;

        public void CopyFrom(global::Cinemachine.NoiseSettings other)
        {
        }
    }
}