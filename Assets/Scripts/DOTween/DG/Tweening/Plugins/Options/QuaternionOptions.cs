namespace DG.Tweening.Plugins.Options
{
    public struct QuaternionOptions : global::DG.Tweening.Plugins.Options.IPlugOptions
    {
        public global::DG.Tweening.RotateMode rotateMode;
        public global::DG.Tweening.AxisConstraint axisConstraint;
        public global::UnityEngine.Vector3 up;
        public void Reset()
        {
        }
    }
}