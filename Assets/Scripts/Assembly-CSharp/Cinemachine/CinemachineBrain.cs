namespace Cinemachine
{
    [global::Cinemachine.SaveDuringPlay]
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineBrain : global::UnityEngine.MonoBehaviour
    {
        public enum UpdateMethod
        {
            FixedUpdate = 0,
            LateUpdate = 1,
            SmartUpdate = 2
        }

        [global::System.Serializable]
        public class BrainEvent : global::UnityEngine.Events.UnityEvent<global::Cinemachine.CinemachineBrain>
        {
        }

        [global::System.Serializable]
        public class VcamEvent : global::UnityEngine.Events.UnityEvent<global::Cinemachine.ICinemachineCamera>
        {
        }

        private class OverrideStackFrame
        {
            public int id;
            public global::Cinemachine.ICinemachineCamera camera;
            public global::Cinemachine.CinemachineBlend blend;
            public float deltaTime;
            public float timeOfOverride;
            public bool Active => false;
            public bool Expired => false;
        }

        public bool m_ShowDebugText;
        public bool m_ShowCameraFrustum;
        public bool m_IgnoreTimeScale;
        public global::UnityEngine.Transform m_WorldUpOverride;
        public global::Cinemachine.CinemachineBrain.UpdateMethod m_UpdateMethod;
        [global::Cinemachine.CinemachineBlendDefinitionProperty]
        public global::Cinemachine.CinemachineBlendDefinition m_DefaultBlend;
        public global::Cinemachine.CinemachineBlenderSettings m_CustomBlends;
        private global::UnityEngine.Camera m_OutputCamera;
        public global::Cinemachine.CinemachineBrain.BrainEvent m_CameraCutEvent;
        public global::Cinemachine.CinemachineBrain.VcamEvent m_CameraActivatedEvent;
        internal static global::Cinemachine.CinemachineBrain.BrainEvent sPostProcessingHandler;
        private global::Cinemachine.ICinemachineCamera mActiveCameraPreviousFrame;
        private global::Cinemachine.ICinemachineCamera mOutgoingCameraPreviousFrame;
        private global::Cinemachine.CinemachineBlend mActiveBlend;
        private bool mPreviousFrameWasOverride;
        private global::System.Collections.Generic.List<global::Cinemachine.CinemachineBrain.OverrideStackFrame> mOverrideStack;
        private int mNextOverrideId;
        private global::Cinemachine.CinemachineBrain.OverrideStackFrame mOverrideBlendFromNothing;
        private global::UnityEngine.WaitForFixedUpdate mWaitForFixedUpdate;
        private static int msCurrentFrame;
        private static int msFirstBrainObjectId;
        private static int msSubframes;
        public global::UnityEngine.Camera OutputCamera => null;
        internal global::UnityEngine.Component PostProcessingComponent { get; set; }
        public static global::Cinemachine.ICinemachineCamera SoloCamera { get; set; }
        public global::UnityEngine.Vector3 DefaultWorldUp => default;
        public bool IsBlending => false;
        public global::Cinemachine.CinemachineBlend ActiveBlend => null;
        public global::Cinemachine.ICinemachineCamera ActiveVirtualCamera => null;
        public global::Cinemachine.CameraState CurrentCameraState { get; private set; }

        public static global::UnityEngine.Color GetSoloGUIColor()
        {
            return default;
        }

        private global::Cinemachine.CinemachineBrain.OverrideStackFrame GetOverrideFrame(int id)
        {
            return null;
        }

        private global::Cinemachine.CinemachineBrain.OverrideStackFrame GetNextActiveFrame(int overrideId)
        {
            return null;
        }

        private global::Cinemachine.CinemachineBrain.OverrideStackFrame GetActiveOverride()
        {
            return null;
        }

        internal int SetCameraOverride(int overrideId, global::Cinemachine.ICinemachineCamera camA, global::Cinemachine.ICinemachineCamera camB, float weightB, float deltaTime)
        {
            return 0;
        }

        internal void ReleaseCameraOverride(int overrideId)
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void Start()
        {
        }

        private global::System.Collections.IEnumerator AfterPhysics()
        {
            return null;
        }

        private void LateUpdate()
        {
        }

        public void ForceUpdate()
        {
        }

        private float GetEffectiveDeltaTime(bool fixedDelta)
        {
            return 0f;
        }

        private void UpdateVirtualCameras(global::Cinemachine.CinemachineCore.UpdateFilter updateFilter, float deltaTime)
        {
        }

        private void ProcessActiveCamera(float deltaTime)
        {
        }

        public bool IsLive(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        private bool IsLiveItself(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        private global::Cinemachine.ICinemachineCamera TopCameraFromPriorityQueue()
        {
            return null;
        }

        private global::UnityEngine.AnimationCurve LookupBlendCurve(global::Cinemachine.ICinemachineCamera fromKey, global::Cinemachine.ICinemachineCamera toKey, out float duration)
        {
            duration = default;
            return null;
        }

        private global::Cinemachine.CinemachineBlend CreateBlend(global::Cinemachine.ICinemachineCamera camA, global::Cinemachine.ICinemachineCamera camB, global::UnityEngine.AnimationCurve blendCurve, float duration, global::Cinemachine.CinemachineBlend activeBlend)
        {
            return null;
        }

        private void PushStateToUnityCamera(global::Cinemachine.CameraState state, global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        private void AddSubframe()
        {
        }

        internal static int GetSubframeCount()
        {
            return 0;
        }
    }
}