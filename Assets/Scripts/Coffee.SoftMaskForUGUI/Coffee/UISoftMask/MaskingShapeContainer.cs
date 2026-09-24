namespace Coffee.UISoftMask
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class MaskingShapeContainer : global::UnityEngine.MonoBehaviour, global::UnityEngine.ICanvasRaycastFilter, global::UnityEngine.UI.IMaterialModifier
    {
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::Coffee.UISoftMask.MaskingShape> m_MaskingShapes;
        private global::System.Action _checkTransformChanged;
        private bool _dirty;
        private global::UnityEngine.UI.Mask _mask;
        private bool _needTerminal;
        private global::Coffee.UISoftMask.TerminalMaskingShape _terminal;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        bool global::UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        global::UnityEngine.Material global::UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        public bool IsInside(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera, bool defaultValid = false, float threshold = 0.01f)
        {
            return false;
        }

        public void SetContainerDirty()
        {
        }

        private void CheckTransformChanged()
        {
        }

        public bool IsInScreen()
        {
            return false;
        }

        public void DrawSoftMaskBuffer(global::UnityEngine.Rendering.CommandBuffer cb, int softMaskDepth)
        {
        }

        public void Register(global::Coffee.UISoftMask.MaskingShape shape)
        {
        }

        public void Unregister(global::Coffee.UISoftMask.MaskingShape shape)
        {
        }

        private global::Coffee.UISoftMask.TerminalMaskingShape FindTerminal()
        {
            return null;
        }
    }
}