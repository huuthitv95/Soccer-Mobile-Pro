namespace UnityEngine.UI.Extensions
{
    public class HoverTooltip : global::UnityEngine.MonoBehaviour
    {
        public int horizontalPadding;
        public int verticalPadding;
        public global::UnityEngine.UI.Text thisText;
        public global::UnityEngine.UI.HorizontalLayoutGroup hlG;
        public global::UnityEngine.RectTransform bgImage;
        private global::UnityEngine.UI.Image bgImageSource;
        private bool firstUpdate;
        private bool inside;
        private global::UnityEngine.RenderMode GUIMode;
        private global::UnityEngine.Camera GUICamera;
        private global::UnityEngine.Vector3 lowerLeft;
        private global::UnityEngine.Vector3 upperRight;
        private float currentYScaleFactor;
        private float currentXScaleFactor;
        private float defaultYOffset;
        private float defaultXOffset;
        private float tooltipRealHeight;
        private float tooltipRealWidth;
        private void Start()
        {
        }

        public void SetTooltip(string text)
        {
        }

        public void SetTooltip(string[] texts)
        {
        }

        public void SetTooltip(string text, bool test)
        {
        }

        public void OnScreenSpaceCamera()
        {
        }

        public void HideTooltip()
        {
        }

        private void Update()
        {
        }

        private void LayoutInit()
        {
        }

        private void NewTooltip()
        {
        }

        public void ActivateTooltipVisibility()
        {
        }

        public void HideTooltipVisibility()
        {
        }
    }
}