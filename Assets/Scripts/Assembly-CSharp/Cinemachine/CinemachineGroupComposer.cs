namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineGroupComposer : global::Cinemachine.CinemachineComposer
    {
        public enum FramingMode
        {
            Horizontal = 0,
            Vertical = 1,
            HorizontalAndVertical = 2
        }

        public enum AdjustmentMode
        {
            ZoomOnly = 0,
            DollyOnly = 1,
            DollyThenZoom = 2
        }

        [global::UnityEngine.Space]
        public float m_GroupFramingSize;
        public global::Cinemachine.CinemachineGroupComposer.FramingMode m_FramingMode;
        public float m_FrameDamping;
        public global::Cinemachine.CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode;
        public float m_MaxDollyIn;
        public float m_MaxDollyOut;
        public float m_MinimumDistance;
        public float m_MaximumDistance;
        public float m_MinimumFOV;
        public float m_MaximumFOV;
        public float m_MinimumOrthoSize;
        public float m_MaximumOrthoSize;
        private float m_prevTargetHeight;
        public global::Cinemachine.CinemachineTargetGroup TargetGroup => null;
        public global::UnityEngine.Bounds m_LastBounds { get; private set; }
        public global::UnityEngine.Matrix4x4 m_lastBoundsMatrix { get; private set; }

        private void OnValidate()
        {
        }

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        private float GetTargetHeight(global::UnityEngine.Bounds b)
        {
            return 0f;
        }
    }
}