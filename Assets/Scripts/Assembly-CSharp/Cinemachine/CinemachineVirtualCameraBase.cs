namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    public abstract class CinemachineVirtualCameraBase : global::UnityEngine.MonoBehaviour, global::Cinemachine.ICinemachineCamera
    {
        public delegate void OnPostPipelineStageDelegate(global::Cinemachine.CinemachineVirtualCameraBase vcam, global::Cinemachine.CinemachineCore.Stage stage, ref global::Cinemachine.CameraState newState, float deltaTime);
        [global::UnityEngine.HideInInspector]
        [global::Cinemachine.NoSaveDuringPlay]
        public global::System.Action CinemachineGUIDebuggerCallback;
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        public string[] m_ExcludedPropertiesInInspector;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        [global::Cinemachine.NoSaveDuringPlay]
        public global::Cinemachine.CinemachineCore.Stage[] m_LockStageInInspector;
        private int m_ValidatingStreamVersion;
        private bool m_OnValidateCalled;
        [global::Cinemachine.NoSaveDuringPlay]
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private int m_StreamingVersion;
        [global::Cinemachine.NoSaveDuringPlay]
        public int m_Priority;
        protected global::Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate OnPostPipelineStage;
        private bool m_previousStateIsValid;
        private global::UnityEngine.Transform m_previousLookAtTarget;
        private global::UnityEngine.Transform m_previousFollowTarget;
        private bool mSlaveStatusUpdated;
        private global::Cinemachine.CinemachineVirtualCameraBase m_parentVcam;
        private int m_QueuePriority;
        public int ValidatingStreamVersion
        {
            get
            {
                return 0;
            }

            private set
            {
            }
        }

        public string Name => null;
        public virtual string Description => null;

        public int Priority
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.GameObject VirtualCameraGameObject => null;
        public abstract global::Cinemachine.CameraState State { get; }
        public virtual global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;
        public global::Cinemachine.ICinemachineCamera ParentCamera => null;
        public abstract global::UnityEngine.Transform LookAt { get; set; }
        public abstract global::UnityEngine.Transform Follow { get; set; }

        public bool PreviousStateIsValid
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public virtual void AddPostPipelineStageHook(global::Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
        }

        public virtual void RemovePostPipelineStageHook(global::Cinemachine.CinemachineVirtualCameraBase.OnPostPipelineStageDelegate d)
        {
        }

        protected void InvokePostPipelineStageCallback(global::Cinemachine.CinemachineVirtualCameraBase vcam, global::Cinemachine.CinemachineCore.Stage stage, ref global::Cinemachine.CameraState newState, float deltaTime)
        {
        }

        public virtual bool IsLiveChild(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        public abstract void UpdateCameraState(global::UnityEngine.Vector3 worldUp, float deltaTime);
        public virtual void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        protected virtual void Start()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        protected virtual void OnValidate()
        {
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void Update()
        {
        }

        protected virtual void OnTransformParentChanged()
        {
        }

        private void UpdateSlaveStatus()
        {
        }

        protected global::UnityEngine.Transform ResolveLookAt(global::UnityEngine.Transform localLookAt)
        {
            return null;
        }

        protected global::UnityEngine.Transform ResolveFollow(global::UnityEngine.Transform localFollow)
        {
            return null;
        }

        private void UpdateVcamPoolStatus()
        {
        }

        public void MoveToTopOfPrioritySubqueue()
        {
        }
    }
}