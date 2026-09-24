namespace DG.Tweening.Plugins.Options
{
    public struct PathOptions : global::DG.Tweening.Plugins.Options.IPlugOptions
    {
        public global::DG.Tweening.PathMode mode;
        public global::DG.Tweening.Plugins.Options.OrientType orientType;
        public global::DG.Tweening.AxisConstraint lockPositionAxis;
        public global::DG.Tweening.AxisConstraint lockRotationAxis;
        public bool isClosedPath;
        public global::UnityEngine.Vector3 lookAtPosition;
        public global::UnityEngine.Transform lookAtTransform;
        public float lookAhead;
        public bool hasCustomForwardDirection;
        public global::UnityEngine.Quaternion forward;
        public bool useLocalPosition;
        public global::UnityEngine.Transform parent;
        public bool isRigidbody;
        internal global::UnityEngine.Quaternion startupRot;
        internal float startupZRot;
        internal bool addedExtraStartWp;
        internal bool addedExtraEndWp;
        public void Reset()
        {
        }
    }
}