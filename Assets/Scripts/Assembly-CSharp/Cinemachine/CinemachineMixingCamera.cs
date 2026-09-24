namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineMixingCamera : global::Cinemachine.CinemachineVirtualCameraBase
    {
        public const int MaxCameras = 8;
        public float m_Weight0;
        public float m_Weight1;
        public float m_Weight2;
        public float m_Weight3;
        public float m_Weight4;
        public float m_Weight5;
        public float m_Weight6;
        public float m_Weight7;
        private global::Cinemachine.CameraState m_State;
        private global::Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        private global::System.Collections.Generic.Dictionary<global::Cinemachine.CinemachineVirtualCameraBase, int> m_indexMap;
        private global::Cinemachine.ICinemachineCamera LiveChild { get; set; }
        public override global::Cinemachine.CameraState State => default;
        public override global::UnityEngine.Transform LookAt { get; set; }
        public override global::UnityEngine.Transform Follow { get; set; }
        public override global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;
        public global::Cinemachine.CinemachineVirtualCameraBase[] ChildCameras => null;

        public float GetWeight(int index)
        {
            return 0f;
        }

        public void SetWeight(int index, float w)
        {
        }

        public float GetWeight(global::Cinemachine.CinemachineVirtualCameraBase vcam)
        {
            return 0f;
        }

        public void SetWeight(global::Cinemachine.CinemachineVirtualCameraBase vcam, float w)
        {
        }

        public override void RemovePostPipelineStageHook(global::Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
        }

        protected override void OnEnable()
        {
        }

        public void OnTransformChildrenChanged()
        {
        }

        protected override void OnValidate()
        {
        }

        public override bool IsLiveChild(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        protected void InvalidateListOfChildren()
        {
        }

        protected void ValidateListOfChildren()
        {
        }

        public override void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }
    }
}