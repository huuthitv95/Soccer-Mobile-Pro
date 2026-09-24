namespace Coffee.UISoftMask
{
    public class CanvasViewChangeTrigger : global::UnityEngine.MonoBehaviour
    {
        private global::UnityEngine.Canvas _canvas;
        private global::System.Action _checkViewProjectionMatrix;
        private int _lastCameraVpHash;
        private int _lastResHash;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_onCanvasViewChanged;
        public event global::System.Action onCanvasViewChanged
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        private void CheckViewProjectionMatrix()
        {
        }

        public static global::Coffee.UISoftMask.CanvasViewChangeTrigger Find(global::UnityEngine.Transform transform)
        {
            return null;
        }
    }
}