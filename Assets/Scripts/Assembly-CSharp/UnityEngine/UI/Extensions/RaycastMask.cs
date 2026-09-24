namespace UnityEngine.UI.Extensions
{
    public class RaycastMask : global::UnityEngine.MonoBehaviour, global::UnityEngine.ICanvasRaycastFilter
    {
        private global::UnityEngine.UI.Image _image;
        private global::UnityEngine.Sprite _sprite;
        private void Start()
        {
        }

        public bool IsRaycastLocationValid(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }
    }
}