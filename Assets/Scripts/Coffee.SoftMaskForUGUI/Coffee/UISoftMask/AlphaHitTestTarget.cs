namespace Coffee.UISoftMask
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class AlphaHitTestTarget : global::UnityEngine.MonoBehaviour, global::UnityEngine.ICanvasRaycastFilter
    {
        private global::UnityEngine.UI.Graphic _graphic;
        public global::UnityEngine.UI.Graphic graphic => null;

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        bool global::UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }
    }
}