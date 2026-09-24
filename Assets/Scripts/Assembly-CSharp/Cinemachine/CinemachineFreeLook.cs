namespace Cinemachine
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class CinemachineFreeLook : global::Cinemachine.CinemachineVirtualCameraBase
    {
        [global::System.Serializable]
        public struct Orbit
        {
            public float m_Height;
            public float m_Radius;
            public Orbit(float h, float r)
            {
                m_Height = 0f;
                m_Radius = 0f;
            }
        }

        public delegate global::Cinemachine.CinemachineVirtualCamera CreateRigDelegate(global::Cinemachine.CinemachineFreeLook vcam, string name, global::Cinemachine.CinemachineVirtualCamera copyFrom);
        public delegate void DestroyRigDelegate(global::UnityEngine.GameObject rig);
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_LookAt;
        [global::Cinemachine.NoSaveDuringPlay]
        public global::UnityEngine.Transform m_Follow;
        public bool m_CommonLens;
        [global::Cinemachine.LensSettingsProperty]
        public global::Cinemachine.LensSettings m_Lens;
        public global::Cinemachine.AxisState m_YAxis;
        public global::Cinemachine.AxisState m_XAxis;
        public global::Cinemachine.CinemachineOrbitalTransposer.Heading m_Heading;
        public global::Cinemachine.CinemachineOrbitalTransposer.Recentering m_RecenterToTargetHeading;
        public global::Cinemachine.CinemachineTransposer.BindingMode m_BindingMode;
        public float m_SplineCurvature;
        public global::Cinemachine.CinemachineFreeLook.Orbit[] m_Orbits;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private float m_LegacyHeadingBias;
        private bool mUseLegacyRigDefinitions;
        private bool mIsDestroyed;
        private global::Cinemachine.CameraState m_State;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        [global::Cinemachine.NoSaveDuringPlay]
        private global::Cinemachine.CinemachineVirtualCamera[] m_Rigs;
        private global::Cinemachine.CinemachineOrbitalTransposer[] mOrbitals;
        private global::Cinemachine.CinemachineBlend mBlendA;
        private global::Cinemachine.CinemachineBlend mBlendB;
        public static global::Cinemachine.CinemachineFreeLook.CreateRigDelegate CreateRigOverride;
        public static global::Cinemachine.CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride;
        private global::Cinemachine.CinemachineFreeLook.Orbit[] m_CachedOrbits;
        private float m_CachedTension;
        private global::UnityEngine.Vector4[] m_CachedKnots;
        private global::UnityEngine.Vector4[] m_CachedCtrl1;
        private global::UnityEngine.Vector4[] m_CachedCtrl2;
        public static string[] RigNames => null;
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

        public override global::Cinemachine.ICinemachineCamera LiveChildOrSelf => null;

        protected override void OnValidate()
        {
        }

        public global::Cinemachine.CinemachineVirtualCamera GetRig(int i)
        {
            return null;
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDestroy()
        {
        }

        private void OnTransformChildrenChanged()
        {
        }

        private void Reset()
        {
        }

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

        public override void OnTransitionFromCamera(global::Cinemachine.ICinemachineCamera fromCam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        private void InvalidateRigCache()
        {
        }

        private void DestroyRigs()
        {
        }

        private global::Cinemachine.CinemachineVirtualCamera[] CreateRigs(global::Cinemachine.CinemachineVirtualCamera[] copyFrom)
        {
            return null;
        }

        private void UpdateRigCache()
        {
        }

        private int LocateExistingRigs(string[] rigNames, bool forceOrbital)
        {
            return 0;
        }

        private void PushSettingsToRigs()
        {
        }

        private global::Cinemachine.CameraState CalculateNewState(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
            return default;
        }

        private global::Cinemachine.CameraState PullStateFromVirtualCamera(global::UnityEngine.Vector3 worldUp)
        {
            return default;
        }

        public global::UnityEngine.Vector3 GetLocalPositionForCameraFromInput(float t)
        {
            return default;
        }

        private void UpdateCachedSpline()
        {
        }
    }
}