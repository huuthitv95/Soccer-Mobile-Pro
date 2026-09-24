namespace UnityEngine.InputSystem.XR
{
    [global::System.Serializable]
    public class TrackedPoseDriver : global::UnityEngine.MonoBehaviour, global::UnityEngine.ISerializationCallbackReceiver
    {
        public enum TrackingType
        {
            RotationAndPosition = 0,
            RotationOnly = 1,
            PositionOnly = 2
        }

        [global::System.Flags]
        private enum TrackingStates
        {
            None = 0,
            Position = 1,
            Rotation = 2
        }

        public enum UpdateType
        {
            UpdateAndBeforeRender = 0,
            Update = 1,
            BeforeRender = 2
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType m_TrackingType;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType m_UpdateType;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreTrackingState;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_PositionInput;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_RotationInput;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputActionProperty m_TrackingStateInput;
        private global::UnityEngine.Vector3 m_CurrentPosition;
        private global::UnityEngine.Quaternion m_CurrentRotation;
        private global::UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStates m_CurrentTrackingState;
        private bool m_RotationBound;
        private bool m_PositionBound;
        private bool m_TrackingStateBound;
        private bool m_IsFirstUpdate;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        [global::System.Obsolete]
        private global::UnityEngine.InputSystem.InputAction m_PositionAction;
        [global::System.Obsolete]
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.InputSystem.InputAction m_RotationAction;
        public global::UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType trackingType
        {
            get
            {
                return global::UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType.RotationAndPosition;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType updateType
        {
            get
            {
                return global::UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType.UpdateAndBeforeRender;
            }

            set
            {
            }
        }

        public bool ignoreTrackingState
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty positionInput
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty rotationInput
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputActionProperty trackingStateInput
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputAction positionAction
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputAction rotationAction
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private void BindActions()
        {
        }

        private void UnbindActions()
        {
        }

        private void BindPosition()
        {
        }

        private void BindRotation()
        {
        }

        private void BindTrackingState()
        {
        }

        private void UnbindPosition()
        {
        }

        private void UnbindRotation()
        {
        }

        private void UnbindTrackingState()
        {
        }

        private void OnPositionPerformed(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnPositionCanceled(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnRotationPerformed(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnRotationCanceled(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnTrackingStatePerformed(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        private void OnTrackingStateCanceled(global::UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
        }

        protected void Reset()
        {
        }

        protected virtual void Awake()
        {
        }

        protected void OnEnable()
        {
        }

        protected void OnDisable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        protected void UpdateCallback()
        {
        }

        private void ReadTrackingState()
        {
        }

        protected virtual void OnUpdate()
        {
        }

        protected virtual void OnBeforeRender()
        {
        }

        protected virtual void PerformUpdate()
        {
        }

        protected virtual void SetLocalTransform(global::UnityEngine.Vector3 newPosition, global::UnityEngine.Quaternion newRotation)
        {
        }

        private bool HasStereoCamera(out global::UnityEngine.Camera cameraComponent)
        {
            cameraComponent = null;
            return false;
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }
    }
}