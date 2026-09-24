namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineVirtualCamera : global::Cinemachine.CinemachineVirtualCameraBase
    {
        public delegate global::UnityEngine.Transform CreatePipelineDelegate(global::Cinemachine.CinemachineVirtualCamera vcam, string name, global::Cinemachine.CinemachineComponentBase[] copyFrom);
        public delegate void DestroyPipelineDelegate(global::UnityEngine.GameObject pipeline);
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_LookAt;
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_Follow;
        [global::Cinemachine.LensSettingsProperty]
        public global::Cinemachine.LensSettings m_Lens;
        public const string PipelineName = "cm";
        public static global::Cinemachine.CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride;
        public static global::Cinemachine.CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride;
        private global::Cinemachine.CameraState m_State;
        private global::Cinemachine.CinemachineComponentBase[] m_ComponentPipeline;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Transform m_ComponentOwner;
        public override global::Cinemachine.CameraState State => default;

        public override global::UnityEngine.Transform LookAt
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override global::UnityEngine.Transform Follow
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool UserIsDragging { get; set; }

        public override void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnValidate()
        {
        }

        private void OnTransformChildrenChanged()
        {
        }

        private void Reset()
        {
        }

        private void DestroyPipeline()
        {
        }

        private global::UnityEngine.Transform CreatePipeline(global::Cinemachine.CinemachineVirtualCamera copyFrom)
        {
            return null;
        }

        public void InvalidateComponentPipeline()
        {
        }

        public global::UnityEngine.Transform GetComponentOwner()
        {
            return null;
        }

        public global::Cinemachine.CinemachineComponentBase[] GetComponentPipeline()
        {
            return null;
        }

        public global::Cinemachine.CinemachineComponentBase GetCinemachineComponent(global::Cinemachine.CinemachineCore.Stage stage)
        {
            return null;
        }

        public T GetCinemachineComponent<T>()
            where T : global::Cinemachine.CinemachineComponentBase
        {
            return null;
        }

        public T AddCinemachineComponent<T>()
            where T : global::Cinemachine.CinemachineComponentBase
        {
            return null;
        }

        public void DestroyCinemachineComponent<T>()
            where T : global::Cinemachine.CinemachineComponentBase
        {
        }

        public void OnPositionDragged(global::UnityEngine.Vector3 delta)
        {
        }

        private void UpdateComponentPipeline()
        {
        }

        private global::Cinemachine.CameraState CalculateNewState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
            return default;
        }

        private global::Cinemachine.CinemachineCore.Stage AdvancePipelineStage(ref global::Cinemachine.CameraState state, float deltaTime, global::Cinemachine.CinemachineCore.Stage curStage, int maxStage)
        {
            return global::Cinemachine.CinemachineCore.Stage.Body;
        }

        private global::Cinemachine.CameraState PullStateFromVirtualCamera(global::UnityEngine.Vector3 worldUp)
        {
            return default;
        }

        internal void SetStateRawPosition(global::UnityEngine.Vector3 pos)
        {
        }
    }
}