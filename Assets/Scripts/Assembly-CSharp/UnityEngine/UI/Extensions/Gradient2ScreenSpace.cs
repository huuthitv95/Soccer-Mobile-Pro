namespace UnityEngine.UI.Extensions
{
    [global::UnityEngine.DisallowMultipleComponent]
    public sealed class Gradient2ScreenSpace : global::UnityEngine.EventSystems.UIBehaviour
    {
        private readonly global::UnityEngine.Vector2[] _localScreenCorners;
        private global::UnityEngine.UI.Extensions.Gradient2 _gradient;
        private global::UnityEngine.RectTransform _rectTransform;
        private global::UnityEngine.Canvas _canvas;
        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        private void LateUpdate()
        {
        }

        private void CacheReferences()
        {
        }

        private void RefreshScreenBounds()
        {
        }

        private bool TryGetLocalScreenCorners(global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        private bool TryGetLocalScreenCorner(global::UnityEngine.Vector2 screenPoint, global::UnityEngine.Camera eventCamera, int index)
        {
            return false;
        }

        private global::UnityEngine.Vector2 GetGradientDirection()
        {
            return default;
        }
    }
}