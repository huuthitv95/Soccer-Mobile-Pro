namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineStateDrivenCamera : global::Cinemachine.CinemachineVirtualCameraBase
    {
        [global::System.Serializable]
        public struct Instruction
        {
            public int m_FullHash;
            public global::Cinemachine.CinemachineVirtualCameraBase m_VirtualCamera;
            public float m_ActivateAfter;
            public float m_MinDuration;
        }

        [global::System.Serializable]
        public struct ParentHash
        {
            public int m_Hash;
            public int m_ParentHash;
            public ParentHash(int h, int p)
            {
                m_Hash = 0;
                m_ParentHash = 0;
            }
        }

        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_LookAt;
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_Follow;
        [global::UnityEngine.Space]
        public global::UnityEngine.Animator m_AnimatedTarget;
        public int m_LayerIndex;
        public bool m_ShowDebugText;
        public bool m_EnableAllChildCameras;
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        public global::Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        public global::Cinemachine.CinemachineStateDrivenCamera.Instruction[] m_Instructions;
        [global::Cinemachine.CinemachineBlendDefinitionProperty]
        public global::Cinemachine.CinemachineBlendDefinition m_DefaultBlend;
        public global::Cinemachine.CinemachineBlenderSettings m_CustomBlends;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        public global::Cinemachine.CinemachineStateDrivenCamera.ParentHash[] m_ParentHash;
        private global::Cinemachine.CameraState m_State;
        private float mActivationTime;
        private global::Cinemachine.CinemachineStateDrivenCamera.Instruction mActiveInstruction;
        private float mPendingActivationTime;
        private global::Cinemachine.CinemachineStateDrivenCamera.Instruction mPendingInstruction;
        private global::Cinemachine.CinemachineBlend mActiveBlend;
        private global::System.Collections.Generic.Dictionary<int, int> mInstructionDictionary;
        private global::System.Collections.Generic.Dictionary<int, int> mStateParentLookup;
        private global::System.Collections.Generic.List<global::UnityEngine.AnimatorClipInfo> m_clipInfoList;
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

        public override void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        protected override void OnEnable()
        {
        }

        public void OnTransformChildrenChanged()
        {
        }

        public static string CreateFakeHashName(int parentHash, string stateName)
        {
            return null;
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

        private global::Cinemachine.CinemachineVirtualCameraBase ChooseCurrentCamera(float deltaTime)
        {
            return null;
        }

        private int GetClipHash(int hash, global::System.Collections.Generic.List<global::UnityEngine.AnimatorClipInfo> clips)
        {
            return 0;
        }

        private global::UnityEngine.AnimationCurve LookupBlendCurve(global::Cinemachine.ICinemachineCamera fromKey, global::Cinemachine.ICinemachineCamera toKey, out float duration)
        {
            duration = default;
            return null;
        }

        private global::Cinemachine.CinemachineBlend CreateBlend(global::Cinemachine.ICinemachineCamera camA, global::Cinemachine.ICinemachineCamera camB, global::UnityEngine.AnimationCurve blendCurve, float duration, global::Cinemachine.CinemachineBlend activeBlend, float deltaTime)
        {
            return null;
        }
    }
}