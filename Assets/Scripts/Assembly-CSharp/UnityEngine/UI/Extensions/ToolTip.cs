namespace UnityEngine.UI.Extensions
{
    public class ToolTip : global::UnityEngine.MonoBehaviour
    {
        private global::UnityEngine.UI.Text _text;
        private global::UnityEngine.RectTransform _rectTransform;
        private bool _inside;
        private float width;
        private float height;
        private float YShift;
        private float xShift;
        private global::UnityEngine.RenderMode _guiMode;
        private global::UnityEngine.Camera _guiCamera;
        public void Awake()
        {
        }

        public void SetTooltip(string ttext)
        {
        }

        public void HideTooltip()
        {
        }

        private void FixedUpdate()
        {
        }

        public void OnScreenSpaceCamera()
        {
        }
    }
}