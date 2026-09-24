namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineComposer : global::Cinemachine.CinemachineComponentBase
    {
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        public global::System.Action OnGUICallback;
        public global::UnityEngine.Vector3 m_TrackedObjectOffset;
        public float m_LookaheadTime;
        public float m_LookaheadSmoothing;
        [global::UnityEngine.Space]
        public float m_HorizontalDamping;
        public float m_VerticalDamping;
        [global::UnityEngine.Space]
        public float m_ScreenX;
        public float m_ScreenY;
        public float m_DeadZoneWidth;
        public float m_DeadZoneHeight;
        public float m_SoftZoneWidth;
        public float m_SoftZoneHeight;
        public float m_BiasX;
        public float m_BiasY;
        private global::UnityEngine.Vector3 m_CameraPosPrevFrame;
        private global::UnityEngine.Vector3 m_LookAtPrevFrame;
        private global::UnityEngine.Vector2 m_ScreenOffsetPrevFrame;
        private global::UnityEngine.Quaternion m_CameraOrientationPrevFrame;
        private global::Cinemachine.Utility.PositionPredictor m_Predictor;
        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;
        public global::UnityEngine.Vector3 TrackedPoint { get; private set; }

        public global::UnityEngine.Rect SoftGuideRect
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Rect HardGuideRect
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        protected virtual global::UnityEngine.Vector3 GetLookAtPointAndSetTrackedPoint(global::UnityEngine.Vector3 lookAt)
        {
            return default;
        }

        public override void PrePipelineMutateCameraState(ref global::Cinemachine.CameraState curState)
        {
        }

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        private global::UnityEngine.Rect ScreenToFOV(global::UnityEngine.Rect rScreen, float fov, float fovH, float aspect)
        {
            return default;
        }

        private bool RotateToScreenBounds(ref global::Cinemachine.CameraState state, global::UnityEngine.Rect screenRect, ref global::UnityEngine.Quaternion rigOrientation, float fov, float fovH, float deltaTime)
        {
            return false;
        }

        private bool ClampVerticalBounds(ref global::UnityEngine.Rect r, global::UnityEngine.Vector3 dir, global::UnityEngine.Vector3 up, float fov)
        {
            return false;
        }
    }
}