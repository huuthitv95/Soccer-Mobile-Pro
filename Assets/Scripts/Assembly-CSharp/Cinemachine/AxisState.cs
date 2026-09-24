namespace Cinemachine
{
    [global::System.Serializable]
    public struct AxisState
    {
        [global::Cinemachine.NoSaveDuringPlay]
        public float Value;
        public float m_MaxSpeed;
        public float m_AccelTime;
        public float m_DecelTime;
        public string m_InputAxisName;
        [global::Cinemachine.NoSaveDuringPlay]
        public float m_InputAxisValue;
        [global::Cinemachine.NoSaveDuringPlay]
        public bool m_InvertAxis;
        private float mCurrentSpeed;
        private float mMinValue;
        private float mMaxValue;
        private bool mWrapAround;
        private const float Epsilon = 0.0001f;
        public AxisState(float maxSpeed, float accelTime, float decelTime, float val, string name, bool invert)
        {
            Value = 0f;
            m_MaxSpeed = 0f;
            m_AccelTime = 0f;
            m_DecelTime = 0f;
            m_InputAxisName = null;
            m_InputAxisValue = 0f;
            m_InvertAxis = false;
            mCurrentSpeed = 0f;
            mMinValue = 0f;
            mMaxValue = 0f;
            mWrapAround = false;
        }

        public void Validate()
        {
        }

        public void SetThresholds(float minValue, float maxValue, bool wrapAround)
        {
        }

        public bool Update(float deltaTime)
        {
            return false;
        }

        private float GetMaxSpeed()
        {
            return 0f;
        }
    }
}