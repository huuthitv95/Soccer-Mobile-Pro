namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineCollider : global::Cinemachine.CinemachineExtension
    {
        public enum ResolutionStrategy
        {
            PullCameraForward = 0,
            PreserveCameraHeight = 1,
            PreserveCameraDistance = 2
        }

        private class VcamExtraState
        {
            public global::UnityEngine.Vector3 m_previousDisplacement;
            public float colliderDisplacement;
            public bool targetObscured;
            public global::System.Collections.Generic.List<global::UnityEngine.Vector3> debugResolutionPath;
            public void AddPointToDebugPath(global::UnityEngine.Vector3 p)
            {
            }
        }

        public global::UnityEngine.LayerMask m_CollideAgainst;
        [global::Cinemachine.TagField]
        public string m_IgnoreTag;
        public float m_MinimumDistanceFromTarget;
        [global::UnityEngine.Space]
        public bool m_AvoidObstacles;
        public float m_DistanceLimit;
        public float m_CameraRadius;
        public global::Cinemachine.CinemachineCollider.ResolutionStrategy m_Strategy;
        public int m_MaximumEffort;
        public float m_Damping;
        public float m_OptimalTargetDistance;
        private const float PrecisionSlush = 0.001f;
        private global::UnityEngine.RaycastHit[] m_CornerBuffer;
        private const float AngleThreshold = 0.1f;
        private global::UnityEngine.Collider[] mColliderBuffer;
        private global::UnityEngine.SphereCollider mCameraCollider;
        private global::UnityEngine.GameObject mCameraColliderGameObject;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::UnityEngine.Vector3>> DebugPaths => null;

        public bool IsTargetObscured(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        public bool CameraWasDisplaced(global::Cinemachine.CinemachineVirtualCameraBase vcam)
        {
            return false;
        }

        private void OnValidate()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void PostPipelineStageCallback(global::Cinemachine.CinemachineVirtualCameraBase vcam, global::Cinemachine.CinemachineCore.Stage stage, ref global::Cinemachine.CameraState state, float deltaTime)
        {
        }

        private global::UnityEngine.Vector3 PreserveLignOfSight(ref global::Cinemachine.CameraState state, ref global::Cinemachine.CinemachineCollider.VcamExtraState extra)
        {
            return default;
        }

        private bool RaycastIgnoreTag(global::UnityEngine.Ray ray, out global::UnityEngine.RaycastHit hitInfo, float rayLength)
        {
            hitInfo = default;
            return false;
        }

        private global::UnityEngine.Vector3 PushCameraBack(global::UnityEngine.Vector3 currentPos, global::UnityEngine.Vector3 pushDir, global::UnityEngine.RaycastHit obstacle, global::UnityEngine.Vector3 lookAtPos, global::UnityEngine.Plane startPlane, float targetDistance, int iterations, ref global::Cinemachine.CinemachineCollider.VcamExtraState extra)
        {
            return default;
        }

        private bool GetWalkingDirection(global::UnityEngine.Vector3 pos, global::UnityEngine.Vector3 pushDir, global::UnityEngine.RaycastHit obstacle, ref global::UnityEngine.Vector3 outDir)
        {
            return false;
        }

        private float GetPushBackDistance(global::UnityEngine.Ray ray, global::UnityEngine.Plane startPlane, float targetDistance, global::UnityEngine.Vector3 lookAtPos)
        {
            return 0f;
        }

        private float ClampRayToBounds(global::UnityEngine.Ray ray, float distance, global::UnityEngine.Bounds bounds)
        {
            return 0f;
        }

        private global::UnityEngine.Vector3 RespectCameraRadius(global::UnityEngine.Vector3 cameraPos, global::UnityEngine.Vector3 lookAtPos)
        {
            return default;
        }

        private void CleanupCameraCollider()
        {
        }

        private bool CheckForTargetObstructions(global::Cinemachine.CameraState state)
        {
            return false;
        }
    }
}