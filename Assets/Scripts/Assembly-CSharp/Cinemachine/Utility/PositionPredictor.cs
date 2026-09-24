namespace Cinemachine.Utility
{
    internal class PositionPredictor
    {
        private global::UnityEngine.Vector3 m_Position;
        private const float kSmoothingDefault = 10f;
        private float mSmoothing;
        private global::Cinemachine.Utility.GaussianWindow1D_Vector3 m_Velocity;
        private global::Cinemachine.Utility.GaussianWindow1D_Vector3 m_Accel;
        public float Smoothing
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool IsEmpty => false;

        public void Reset()
        {
        }

        public void AddPosition(global::UnityEngine.Vector3 pos)
        {
        }

        public global::UnityEngine.Vector3 PredictPosition(float lookaheadTime)
        {
            return default;
        }
    }
}