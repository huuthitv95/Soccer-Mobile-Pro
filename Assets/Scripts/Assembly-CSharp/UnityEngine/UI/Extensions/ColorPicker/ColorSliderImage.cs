namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorSliderImage : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorValues type;
        public global::UnityEngine.UI.Slider.Direction direction;
        private global::UnityEngine.UI.RawImage image;
        private global::UnityEngine.RectTransform RectTransform => null;

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

        private void ColorChanged(global::UnityEngine.Color newColor)
        {
        }

        private void ColorChanged(float hue, float saturation, float value)
        {
        }

        private void RegenerateTexture()
        {
        }
    }
}