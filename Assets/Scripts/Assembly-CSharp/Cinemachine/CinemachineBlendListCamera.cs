namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineBlendListCamera : global::Cinemachine.CinemachineVirtualCameraBase
    {
        [global::System.Serializable]
        public struct Instruction
        {
            public global::Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera;
            public float m_Hold;
            [global::Cinemachine.CinemachineBlendDefinitionProperty]
            public global::Cinemachine.CinemachineBlendDefinition m_Blend;
        }

        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_LookAt;
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_Follow;
        public bool m_ShowDebugText;
        public bool m_EnableAllChildCameras;
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        public global::Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        public global::Cinemachine.CinemachineBlendListCamera.Instruction[] m_Instructions;
        private global::Cinemachine.CameraState m_State;
        private float mActivationTime;
        private int mCurrentInstruction;
        private global::Cinemachine.CinemachineBlend mActiveBlend;
        public override string Description => null;
        public global::Cinemachine.ICinemachineCamera LiveChild { get; set; }
        public override global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;
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

        public global::Cinemachine.CinemachineVirtualCameraBase[] ChildCameras => null;
        public bool IsBlending => false;

        public override bool IsLiveChild(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        public override void RemovePostPipelineStageHook(global::Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
        }

        public override void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        public override void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        protected override void OnEnable()
        {
        }

        public void OnTransformChildrenChanged()
        {
        }

        private void InvalidateListOfChildren()
        {
        }

        private void UpdateListOfChildren()
        {
        }

        public void ValidateInstructions()
        {
        }

        private void AdvanceCurrentInstruction()
        {
        }

        private global::Cinemachine.CinemachineBlend CreateBlend(global::Cinemachine.ICinemachineCamera camA, global::Cinemachine.ICinemachineCamera camB, global::UnityEngine.AnimationCurve blendCurve, float duration, global::Cinemachine.CinemachineBlend activeBlend, float deltaTime)
        {
            return null;
        }
    }
}