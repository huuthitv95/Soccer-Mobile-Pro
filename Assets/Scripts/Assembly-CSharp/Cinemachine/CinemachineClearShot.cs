namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineClearShot : global::Cinemachine.CinemachineVirtualCameraBase
    {
        private struct Pair
        {
            public int a;
            public float b;
        }

        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_LookAt;
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_Follow;
        [global::Cinemachine.NoSaveDuringPlay]
        public bool m_ShowDebugText;
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        public global::Cinemachine.CinemachineVirtualCameraBase[] m_ChildCameras;
        public float m_ActivateAfter;
        public float m_MinDuration;
        public bool m_RandomizeChoice;
        [global::Cinemachine.CinemachineBlendDefinitionProperty]
        public global::Cinemachine.CinemachineBlendDefinition m_DefaultBlend;
        [global::UnityEngine.HideInInspector]
        public global::Cinemachine.CinemachineBlenderSettings m_CustomBlends;
        private global::Cinemachine.CameraState m_State;
        private float mActivationTime;
        private float mPendingActivationTime;
        private global::Cinemachine.ICinemachineCamera mPendingCamera;
        private global::Cinemachine.CinemachineBlend mActiveBlend;
        private bool mRandomizeNow;
        private global::Cinemachine.CinemachineVirtualCameraBase[] m_RandomizedChilden;
        public override string Description => null;
        public global::Cinemachine.ICinemachineCamera LiveChild { get; set; }
        public override global::Cinemachine.CameraState State => default;
        public override global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;

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

        public bool IsBlending => false;
        public global::Cinemachine.CinemachineVirtualCameraBase[] ChildCameras => null;

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

        private void InvalidateListOfChildren()
        {
        }

        public void ResetRandomization()
        {
        }

        private void UpdateListOfChildren()
        {
        }

        private global::Cinemachine.ICinemachineCamera ChooseCurrentCamera(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
            return null;
        }

        private global::Cinemachine.CinemachineVirtualCameraBase[] Randomize(global::Cinemachine.CinemachineVirtualCameraBase[] src)
        {
            return null;
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

        public override void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }
    }
}