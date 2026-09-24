namespace Cinemachine
{
    public sealed class CinemachineCore
    {
        public enum Stage
        {
            Body = 0,
            Aim = 1,
            Noise = 2
        }

        public delegate float AxisInputDelegate(string axisName);
        private struct UpdateStatus
        {
            private const int kWindowSize = 30;
            public int lastUpdateFrame;
            public int lastUpdateSubframe;
            public int windowStart;
            public int numWindowLateUpdateMoves;
            public int numWindowFixedUpdateMoves;
            public int numWindows;
            public global::Cinemachine.CinemachineCore.UpdateFilter preferredUpdate;
            public global::UnityEngine.Matrix4x4 targetPos;
            public UpdateStatus(int currentFrame)
            {
                lastUpdateFrame = 0;
                lastUpdateSubframe = 0;
                windowStart = 0;
                numWindowLateUpdateMoves = 0;
                numWindowFixedUpdateMoves = 0;
                numWindows = 0;
                preferredUpdate = global::Cinemachine.CinemachineCore.UpdateFilter.Fixed;
                targetPos = default;
            }

            public global::Cinemachine.CinemachineCore.UpdateFilter ChoosePreferredUpdate(int currentFrame, global::UnityEngine.Matrix4x4 pos, global::Cinemachine.CinemachineCore.UpdateFilter updateFilter)
            {
                return global::Cinemachine.CinemachineCore.UpdateFilter.Fixed;
            }
        }

        public enum UpdateFilter
        {
            Fixed = 0,
            ForcedFixed = 1,
            Late = 2,
            ForcedLate = 3
        }

        public static readonly int kStreamingVersion;
        public static readonly string kVersionString;
        private static global::Cinemachine.CinemachineCore sInstance;
        public static bool sShowHiddenObjects;
        public static global::Cinemachine.CinemachineCore.AxisInputDelegate GetInputAxis;
        private global::System.Collections.Generic.List<global::Cinemachine.CinemachineBrain> mActiveBrains;
        private global::System.Collections.Generic.List<global::Cinemachine.ICinemachineCamera> mActiveCameras;
        private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Cinemachine.ICinemachineCamera>> mChildCameras;
        private global::System.Collections.Generic.Dictionary<global::Cinemachine.ICinemachineCamera, global::Cinemachine.CinemachineCore.UpdateStatus> mUpdateStatus;
        public static global::Cinemachine.CinemachineCore Instance => null;
        public int BrainCount => 0;
        public int VirtualCameraCount => 0;
        internal global::Cinemachine.CinemachineCore.UpdateFilter CurrentUpdateFilter { get; set; }

        public global::Cinemachine.CinemachineBrain GetActiveBrain(int index)
        {
            return null;
        }

        internal void AddActiveBrain(global::Cinemachine.CinemachineBrain brain)
        {
        }

        internal void RemoveActiveBrain(global::Cinemachine.CinemachineBrain brain)
        {
        }

        public global::Cinemachine.ICinemachineCamera GetVirtualCamera(int index)
        {
            return null;
        }

        internal void AddActiveCamera(global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        internal void RemoveActiveCamera(global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        internal void AddChildCamera(global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        internal void RemoveChildCamera(global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        internal void UpdateAllActiveVirtualCameras(global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
        }

        internal bool UpdateVirtualCamera(global::Cinemachine.ICinemachineCamera vcam, global::UnityEngine.Vector3 worldUp, float deltaTime)
        {
            return false;
        }

        private static bool GetTargetPosition(global::Cinemachine.ICinemachineCamera vcam, out global::UnityEngine.Matrix4x4 targetPos)
        {
            targetPos = default;
            return false;
        }

        public global::Cinemachine.CinemachineCore.UpdateFilter GetVcamUpdateStatus(global::Cinemachine.ICinemachineCamera vcam)
        {
            return global::Cinemachine.CinemachineCore.UpdateFilter.Fixed;
        }

        public bool IsLive(global::Cinemachine.ICinemachineCamera vcam)
        {
            return false;
        }

        public void GenerateCameraActivationEvent(global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        public void GenerateCameraCutEvent(global::Cinemachine.ICinemachineCamera vcam)
        {
        }

        public global::Cinemachine.CinemachineBrain FindPotentialTargetBrain(global::Cinemachine.ICinemachineCamera vcam)
        {
            return null;
        }
    }
}