public class GameCameraController : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private struct LinearParameter
    {
        public float Slope;
        public float Intercept;
        public LinearParameter(float s, float i)
        {
            Slope = 0f;
            Intercept = 0f;
        }
    }

    [global::System.Serializable]
    private class ParallelCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float ZMax;
        [global::UnityEngine.SerializeField]
        private float ZMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotX;
        [global::UnityEngine.SerializeField]
        private float cameraRotY;
        [global::UnityEngine.SerializeField]
        private float cameraRotZ;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 sideFixOffset;
        [global::UnityEngine.SerializeField]
        private float closerScale;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Vector3 offset;
        private float offsetScale;
        private float _heightValue;
        private global::UnityEngine.Camera m_camera;
        private float padOffset;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }
    }

    [global::System.Serializable]
    private class DynamicParallelCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float cameraHeight;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        [global::UnityEngine.SerializeField]
        private float frontBackBoundaryX;
        [global::UnityEngine.SerializeField]
        private float frontBackCloseFovScale;
        [global::UnityEngine.SerializeField]
        private float fovTransitionSpeed;
        [global::UnityEngine.SerializeField]
        private float fovTransitionSmoothTime;
        [global::UnityEngine.SerializeField]
        private float tiltTransitionSpeed;
        [global::UnityEngine.SerializeField]
        private float tiltTransitionSmoothTime;
        [global::UnityEngine.SerializeField]
        private float centerNearViewZ;
        [global::UnityEngine.SerializeField]
        private float centerFarViewZ;
        [global::UnityEngine.SerializeField]
        private float nearSideNearEdgeFollow;
        [global::UnityEngine.SerializeField]
        private float nearSideFarEdgeFollow;
        [global::UnityEngine.SerializeField]
        private float farSideNearEdgeFollow;
        [global::UnityEngine.SerializeField]
        private float farSideFarEdgeFollow;
        [global::UnityEngine.SerializeField]
        private float nearSidelineStartDistance;
        [global::UnityEngine.SerializeField]
        private float nearSidelineEndZ;
        [global::UnityEngine.SerializeField]
        private float nearSidelineHeightRange;
        [global::UnityEngine.SerializeField]
        private float nearSidelineOutsideFollowScale;
        [global::UnityEngine.SerializeField]
        private float farSidelineOutsideFollowScale;
        [global::UnityEngine.SerializeField]
        private float sidelineOutsideTransitionDistance;
        [global::UnityEngine.SerializeField]
        private float sidelineViewportMargin;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Camera camera;
        private float fovTransitionVelocity;
        private float tiltTransitionVelocity;
        private const float PadOffset = 3f;
        private const float HorizontalViewportMargin = 0.05f;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }

        private void GetVisibleZRange(float ballZ, out float nearZ, out float farZ)
        {
            nearZ = default;
            farZ = default;
        }

        private float GetTargetHeight(float ballZ)
        {
            return 0f;
        }

        private static float GetOutsideViewDistance(float distance, float followScale, float transitionDistance)
        {
            return 0f;
        }

        private static float GetCoverageCameraZ(float height, float viewAngle, float viewAngleTangent, float nearZ, float farZ, global::UnityEngine.Vector3 ballPosition)
        {
            return 0f;
        }

        private static void GetCoveragePitchRange(float height, float cameraZ, float nearZ, float farZ, global::UnityEngine.Vector3 ballPosition, out float minPitch, out float maxPitch)
        {
            minPitch = default;
            maxPitch = default;
        }
    }

    [global::System.Serializable]
    private class VerticalCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float ZMax;
        [global::UnityEngine.SerializeField]
        private float ZMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotX;
        [global::UnityEngine.SerializeField]
        private float cameraRotY;
        [global::UnityEngine.SerializeField]
        private float cameraRotZ;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 sideFixOffset;
        [global::UnityEngine.SerializeField]
        private float closerScale;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Vector3 offset;
        private float offsetScale;
        private float _heightValue;
        private global::UnityEngine.Camera m_camera;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }
    }

    [global::System.Serializable]
    private class DynamicCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float ZMax;
        [global::UnityEngine.SerializeField]
        private float ZMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotYRange;
        [global::UnityEngine.SerializeField]
        private float xAxisTrackingRange;
        [global::UnityEngine.SerializeField]
        private float cameraRotX;
        [global::UnityEngine.SerializeField]
        private float cameraHeight;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        [global::UnityEngine.SerializeField]
        private float minOffensiveOffsetX;
        [global::UnityEngine.SerializeField]
        private float maxOffensiveOffsetX;
        [global::UnityEngine.SerializeField]
        private float offensiveOffsetRange;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotYRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter xAxisTrackingRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraHeightParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter normalFovParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter minOffensiveOffsetXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter maxOffensiveOffsetXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter offensiveOffsetRangeParameter;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Vector3 offset;
        private float _heightValue;
        private global::UnityEngine.Camera m_camera;
        private AISampleBase aiMatch;
        private float lastXoffset;
        private global::UnityEngine.Vector3 velocity;
        private float dt;
        private global::System.DateTime lastUpdateTm;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void CopyLinearParameter(GameCameraController.DynamicCamera src)
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }
    }

    [global::System.Serializable]
    private class BroadcastCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float ZMax;
        [global::UnityEngine.SerializeField]
        private float ZMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotYRange;
        [global::UnityEngine.SerializeField]
        private float xAxisTrackingRange;
        [global::UnityEngine.SerializeField]
        private float cameraRotXMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotXMax;
        [global::UnityEngine.SerializeField]
        private float fovRange;
        [global::UnityEngine.SerializeField]
        private float cameraRotX;
        [global::UnityEngine.SerializeField]
        private float cameraRotY;
        [global::UnityEngine.SerializeField]
        private float cameraHeight;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotYRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter xAxisTrackingRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraHeightParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter normalFovParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter fovRangeParameter;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Vector3 offset;
        private float _heightValue;
        private global::UnityEngine.Camera m_camera;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void CopyLinearParameter(GameCameraController.BroadcastCamera src)
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }
    }

    [global::System.Serializable]
    private class ShortRangeCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float ZMax;
        [global::UnityEngine.SerializeField]
        private float ZMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotYRange;
        [global::UnityEngine.SerializeField]
        private float xAxisTrackingRange;
        [global::UnityEngine.SerializeField]
        private float cameraRotXMin;
        [global::UnityEngine.SerializeField]
        private float cameraRotXMax;
        [global::UnityEngine.SerializeField]
        private float cameraRotX;
        [global::UnityEngine.SerializeField]
        private float cameraRotY;
        [global::UnityEngine.SerializeField]
        private float cameraHeight;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        [global::UnityEngine.SerializeField]
        private float cameraHeightAssistRange;
        [global::UnityEngine.SerializeField]
        private float rotXAssistRange;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotYRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter xAxisTrackingRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraHeightParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter normalFovParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotYParameter;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Vector3 offset;
        private float offsetScale;
        private float _heightValue;
        private global::UnityEngine.Camera m_camera;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void CopyLinearParameter(GameCameraController.ShortRangeCamera src)
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }
    }

    [global::System.Serializable]
    private class LongRangeCamera : IGameCameraController
    {
        [global::UnityEngine.SerializeField]
        private float XMin;
        [global::UnityEngine.SerializeField]
        private float XMax;
        [global::UnityEngine.SerializeField]
        private float ZMax;
        [global::UnityEngine.SerializeField]
        private float ZMin;
        [global::UnityEngine.SerializeField]
        private float xAxisTrackingRange;
        [global::UnityEngine.SerializeField]
        private float minRotX;
        [global::UnityEngine.SerializeField]
        private float maxRotX;
        [global::UnityEngine.SerializeField]
        private float cameraRotX;
        [global::UnityEngine.SerializeField]
        private float cameraHeight;
        [global::UnityEngine.SerializeField]
        private float normalFov;
        private global::UnityEngine.Transform target;
        private global::UnityEngine.Vector3 offset;
        private float offsetScale;
        private float _heightValue;
        private global::UnityEngine.Camera m_camera;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter XMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMaxParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter ZMinParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter xAxisTrackingRangeParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter MinRotXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter MaxRotXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraRotXParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter cameraHeightParameter;
        [global::UnityEngine.SerializeField]
        private GameCameraController.LinearParameter normalFovParameter;
        public void Init(global::UnityEngine.Transform target, global::UnityEngine.Camera camera, float heightValue, AISampleBase aiMatch)
        {
        }

        public void SetOffset()
        {
        }

        public void CopyLinearParameter(GameCameraController.LongRangeCamera src)
        {
        }

        public void SetTarget(global::UnityEngine.Transform target)
        {
        }

        public void Update(bool smooth)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private GameCameraController.ParallelCamera parallelCamera;
    [global::UnityEngine.SerializeField]
    private GameCameraController.DynamicParallelCamera dynamicParallelCamera;
    [global::UnityEngine.SerializeField]
    private GameCameraController.VerticalCamera verticalCamera;
    [global::UnityEngine.SerializeField]
    private GameCameraController.DynamicCamera dynamicCamera;
    [global::UnityEngine.SerializeField]
    private GameCameraController.BroadcastCamera broadcastCamera;
    [global::UnityEngine.SerializeField]
    private GameCameraController.ShortRangeCamera shortRangeCamera;
    [global::UnityEngine.SerializeField]
    private GameCameraController.LongRangeCamera longRangeCamera;
    [global::UnityEngine.SerializeField]
    private ProCameraController proCameraController;
    private IGameCameraController currentCamera;
    private global::UnityEngine.Camera m_camera;
    private PlayerCareerModeCameraManager playerCareerModeCameraManager;
    public void SetCamera(global::UnityEngine.Camera c)
    {
    }

    public void InitCameraState(CameraSetting.MatchCameraMode mode, global::UnityEngine.Transform target, AISampleBase aiMatch)
    {
    }

    public bool IsProCamera()
    {
        return false;
    }

    public void UpdateProCameraGameViewSetting()
    {
    }

    public void UpdateCamera(bool useSmooth)
    {
    }

    public void SetTarget(global::UnityEngine.Transform target)
    {
    }
}