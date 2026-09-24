namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class SVBoxSlider : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        private global::UnityEngine.UI.Extensions.BoxSlider slider;
        private global::UnityEngine.UI.RawImage image;
        private float lastH;
        private bool listen;
        public global::UnityEngine.RectTransform RectTransform => null;

        private void Awake()
        {
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

        private void SliderChanged(float saturation, float value)
        {
        }

        private void HSVChanged(float h, float s, float v)
        {
        }

        private void RegenerateSVTexture()
        {
        }
    }
}