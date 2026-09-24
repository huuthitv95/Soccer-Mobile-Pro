namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineOrbitalTransposer : global::Cinemachine.CinemachineTransposer
    {
        [global::System.Serializable]
        public struct Heading
        {
            public enum HeadingDefinition
            {
                PositionDelta = 0,
                Velocity = 1,
                TargetForward = 2,
                WorldForward = 3
            }

            public global::Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition m_HeadingDefinition;
            public int m_VelocityFilterStrength;
            public float m_HeadingBias;
            public Heading(global::Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias)
            {
                m_HeadingDefinition = global::Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition.PositionDelta;
                m_VelocityFilterStrength = 0;
                m_HeadingBias = 0f;
            }
        }

        [global::System.Serializable]
        public struct Recentering
        {
            public bool m_enabled;
            public float m_RecenterWaitTime;
            public float m_RecenteringTime;
            [global::UnityEngine.HideInInspector]
            [global::UnityEngine.SerializeField]
            private int m_LegacyHeadingDefinition;
            [global::UnityEngine.SerializeField]
            [global::UnityEngine.HideInInspector]
            private int m_LegacyVelocityFilterStrength;
            public Recentering(bool enabled, float recenterWaitTime, float recenteringSpeed)
            {
                m_enabled = false;
                m_RecenterWaitTime = 0f;
                m_RecenteringTime = 0f;
                m_LegacyHeadingDefinition = 0;
                m_LegacyVelocityFilterStrength = 0;
            }

            public void Validate()
            {
            }

            internal bool LegacyUpgrade(ref global::Cinemachine.CinemachineOrbitalTransposer.Heading.HeadingDefinition heading, ref int velocityFilter)
            {
                return false;
            }
        }

        internal delegate float UpdateHeadingDelegate(global::Cinemachine.CinemachineOrbitalTransposer orbital, float deltaTime, global::UnityEngine.Vector3 up);
        private class HeadingTracker
        {
            private struct Item
            {
                public global::UnityEngine.Vector3 velocity;
                public float weight;
                public float time;
            }

            private global::Cinemachine.CinemachineOrbitalTransposer.HeadingTracker.Item[] mHistory;
            private int mTop;
            private int mBottom;
            private int mCount;
            private global::UnityEngine.Vector3 mHeadingSum;
            private float mWeightSum;
            private float mWeightTime;
            private global::UnityEngine.Vector3 mLastGoodHeading;
            private static float mDecayExponent;
            public int FilterSize => 0;

            public HeadingTracker(int filterSize)
            {
            }

            private void ClearHistory()
            {
            }

            private static float Decay(float time)
            {
                return 0f;
            }

            public void Add(global::UnityEngine.Vector3 velocity)
            {
            }

            private void PopBottom()
            {
            }

            public void DecayHistory()
            {
            }

            public global::UnityEngine.Vector3 GetReliableHeading()
            {
                return default;
            }
        }

        [global::UnityEngine.Space]
        public global::Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;
        public global::Cinemachine.CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading;
        public global::Cinemachine.AxisState m_XAxis;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private float m_LegacyRadius;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private float m_LegacyHeightOffset;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private float m_LegacyHeadingBias;
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        public bool m_HeadingIsSlave;
        internal global::Cinemachine.CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater;
        private float mLastHeadingAxisInputTime;
        private float mHeadingRecenteringVelocity;
        private global::UnityEngine.Vector3 mLastTargetPosition;
        private global::Cinemachine.CinemachineOrbitalTransposer.HeadingTracker mHeadingTracker;
        private global::UnityEngine.Rigidbody mTargetRigidBody;
        private global::UnityEngine.Quaternion mHeadingPrevFrame;
        private global::UnityEngine.Vector3 mOffsetPrevFrame;
        private global::UnityEngine.Transform PreviousTarget { get; set; }

        protected override void OnValidate()
        {
        }

        public float UpdateHeading(float deltaTime, global::UnityEngine.Vector3 up, ref global::Cinemachine.AxisState axis)
        {
            return 0f;
        }

        private void OnEnable()
        {
        }

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        public override void OnPositionDragged(global::UnityEngine.Vector3 delta)
        {
        }

        private static string GetFullName(global::UnityEngine.GameObject current)
        {
            return null;
        }

        private float GetTargetHeading(float currentHeading, global::UnityEngine.Quaternion targetOrientation, float deltaTime)
        {
            return 0f;
        }
    }
}