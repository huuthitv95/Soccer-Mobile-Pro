namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public class CinemachineConfiner : global::Cinemachine.CinemachineExtension
    {
        public enum Mode
        {
            Confine2D = 0,
            Confine3D = 1
        }

        private class VcamExtraState
        {
            public global::UnityEngine.Vector3 m_previousDisplacement;
            public float confinerDisplacement;
        }

        public global::Cinemachine.CinemachineConfiner.Mode m_ConfineMode;
        public global::UnityEngine.Collider m_BoundingVolume;
        public global::UnityEngine.Collider2D m_BoundingShape2D;
        public bool m_ConfineScreenEdges;
        public float m_Damping;
        private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::UnityEngine.Vector2>> m_pathCache;
        public bool IsValid => false;

        public bool CameraWasDisplaced(global::Cinemachine.CinemachineVirtualCameraBase vcam)
        {
            return false;
        }

        private void OnValidate()
        {
        }

        protected override void PostPipelineStageCallback(global::Cinemachine.CinemachineVirtualCameraBase vcam, global::Cinemachine.CinemachineCore.Stage stage, ref global::Cinemachine.CameraState state, float deltaTime)
        {
        }

        public void InvalidatePathCache()
        {
        }

        private bool ValidatePathCache()
        {
            return false;
        }

        private global::UnityEngine.Vector3 ConfinePoint(global::UnityEngine.Vector3 camPos)
        {
            return default;
        }

        private global::UnityEngine.Vector3 ConfineScreenEdges(global::Cinemachine.CinemachineVirtualCameraBase vcam, ref global::Cinemachine.CameraState state)
        {
            return default;
        }
    }
}