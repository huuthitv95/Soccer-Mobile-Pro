namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineFramingTransposer : global::Cinemachine.CinemachineComponentBase
    {
        public enum FramingMode
        {
            Horizontal = 0,
            Vertical = 1,
            HorizontalAndVertical = 2,
            None = 3
        }

        public enum AdjustmentMode
        {
            ZoomOnly = 0,
            DollyOnly = 1,
            DollyThenZoom = 2
        }

        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        public global::System.Action OnGUICallback;
        public float m_LookaheadTime;
        public float m_LookaheadSmoothing;
        public float m_XDamping;
        public float m_YDamping;
        public float m_ZDamping;
        [global::UnityEngine.Space]
        public float m_ScreenX;
        public float m_ScreenY;
        public float m_CameraDistance;
        [global::UnityEngine.Space]
        public float m_DeadZoneWidth;
        public float m_DeadZoneHeight;
        public float m_DeadZoneDepth;
        [global::UnityEngine.Space]
        public bool m_UnlimitedSoftZone;
        public float m_SoftZoneWidth;
        public float m_SoftZoneHeight;
        public float m_BiasX;
        public float m_BiasY;
        [global::UnityEngine.Space]
        public global::Cinemachine.CinemachineFramingTransposer.FramingMode m_GroupFramingMode;
        public global::Cinemachine.CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode;
        public float m_GroupFramingSize;
        public float m_MaxDollyIn;
        public float m_MaxDollyOut;
        public float m_MinimumDistance;
        public float m_MaximumDistance;
        public float m_MinimumFOV;
        public float m_MaximumFOV;
        public float m_MinimumOrthoSize;
        public float m_MaximumOrthoSize;
        private const float kMinimumCameraDistance = 0.01f;
        private global::UnityEngine.Vector3 m_PreviousCameraPosition;
        private global::Cinemachine.Utility.PositionPredictor m_Predictor;
        private float m_prevTargetHeight;
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

        public override bool IsValid => false;
        public override global::Cinemachine.CinemachineCore.Stage Stage => global::Cinemachine.CinemachineCore.Stage.Body;
        public global::UnityEngine.Vector3 TrackedPoint { get; private set; }
        public global::UnityEngine.Bounds m_LastBounds { get; private set; }
        public global::UnityEngine.Matrix4x4 m_lastBoundsMatrix { get; private set; }
        public global::Cinemachine.CinemachineTargetGroup TargetGroup => null;

        private void OnValidate()
        {
        }

        public override void MutateCameraState(ref global::Cinemachine.CameraState curState, float deltaTime)
        {
        }

        private global::UnityEngine.Rect ScreenToOrtho(global::UnityEngine.Rect rScreen, float orthoSize, float aspect)
        {
            return default;
        }

        private global::UnityEngine.Vector3 OrthoOffsetToScreenBounds(global::UnityEngine.Vector3 targetPos2D, global::UnityEngine.Rect screenRect)
        {
            return default;
        }

        private float AdjustCameraDepthAndLensForGroupFraming(global::Cinemachine.CinemachineTargetGroup group, float targetZ, ref global::Cinemachine.CameraState curState, float deltaTime)
        {
            return 0f;
        }

        private float GetTargetHeight(global::UnityEngine.Bounds b)
        {
            return 0f;
        }
    }
}