namespace Cinemachine
{
    public struct CameraState
    {
        public struct CustomBlendable
        {
            public global::UnityEngine.Object m_Custom;
            public float m_Weight;
            public CustomBlendable(global::UnityEngine.Object custom, float weight)
            {
                m_Custom = null;
                m_Weight = 0f;
            }
        }

        public static global::UnityEngine.Vector3 kNoPoint;
        private global::Cinemachine.CameraState.CustomBlendable mCustom0;
        private global::Cinemachine.CameraState.CustomBlendable mCustom1;
        private global::Cinemachine.CameraState.CustomBlendable mCustom2;
        private global::Cinemachine.CameraState.CustomBlendable mCustom3;
        private global::System.Collections.Generic.List<global::Cinemachine.CameraState.CustomBlendable> m_CustomOverflow;
        public global::Cinemachine.LensSettings Lens { get; set; }
        public global::UnityEngine.Vector3 ReferenceUp { get; set; }
        public global::UnityEngine.Vector3 ReferenceLookAt { get; set; }
        public bool HasLookAt => false;
        public global::UnityEngine.Vector3 RawPosition { get; set; }
        public global::UnityEngine.Quaternion RawOrientation { get; set; }
        internal global::UnityEngine.Vector3 PositionDampingBypass { get; set; }
        public float ShotQuality { get; set; }
        public global::UnityEngine.Vector3 PositionCorrection { get; set; }
        public global::UnityEngine.Quaternion OrientationCorrection { get; set; }
        public global::UnityEngine.Vector3 CorrectedPosition => default;
        public global::UnityEngine.Quaternion CorrectedOrientation => default;
        public global::UnityEngine.Vector3 FinalPosition => default;
        public global::UnityEngine.Quaternion FinalOrientation => default;
        public static global::Cinemachine.CameraState Default => default;
        public int NumCustomBlendables { get; private set; }

        public global::Cinemachine.CameraState.CustomBlendable GetCustomBlendable(int index)
        {
            return default;
        }

        private int FindCustomBlendable(global::UnityEngine.Object custom)
        {
            return 0;
        }

        public void AddCustomBlendable(global::Cinemachine.CameraState.CustomBlendable b)
        {
        }

        public static global::Cinemachine.CameraState Lerp(global::Cinemachine.CameraState stateA, global::Cinemachine.CameraState stateB, float t)
        {
            return default;
        }

        private float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
        {
            return 0f;
        }
    }
}