namespace DG.Tweening.Plugins.Core.PathCore
{
    [global::System.Serializable]
    public class Path
    {
        public float[] wpLengths;
        [global::UnityEngine.SerializeField]
        internal global::DG.Tweening.PathType type;
        [global::UnityEngine.SerializeField]
        internal int subdivisionsXSegment;
        [global::UnityEngine.SerializeField]
        internal int subdivisions;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.Vector3[] wps;
        [global::UnityEngine.SerializeField]
        internal global::DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints;
        [global::UnityEngine.SerializeField]
        internal float length;
        [global::UnityEngine.SerializeField]
        internal bool isFinalized;
        [global::UnityEngine.SerializeField]
        internal float[] timesTable;
        [global::UnityEngine.SerializeField]
        internal float[] lengthsTable;
        internal int linearWPIndex;
        internal bool addedExtraStartWp;
        internal bool addedExtraEndWp;
        private global::DG.Tweening.Plugins.Core.PathCore.Path _incrementalClone;
        private int _incrementalIndex;
        private global::DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder _decoder;
        private bool _changed;
        internal global::UnityEngine.Vector3[] nonLinearDrawWps;
        internal global::UnityEngine.Vector3 targetPosition;
        internal global::UnityEngine.Vector3? lookAtPosition;
        internal global::UnityEngine.Color gizmoColor;
        internal Path()
        {
        }

        internal void FinalizePath(bool isClosedPath, global::DG.Tweening.AxisConstraint lockPositionAxes, global::UnityEngine.Vector3 currTargetVal)
        {
        }

        internal global::UnityEngine.Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
        {
            return default;
        }

        internal float ConvertToConstantPathPerc(float perc)
        {
            return 0f;
        }

        internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward)
        {
            return 0;
        }

        internal static void RefreshNonLinearDrawWps(global::DG.Tweening.Plugins.Core.PathCore.Path p)
        {
        }

        internal void Destroy()
        {
        }

        internal global::DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(int loopIncrement)
        {
            return null;
        }

        internal void Draw()
        {
        }

        private static void Draw(global::DG.Tweening.Plugins.Core.PathCore.Path p)
        {
        }
    }
}