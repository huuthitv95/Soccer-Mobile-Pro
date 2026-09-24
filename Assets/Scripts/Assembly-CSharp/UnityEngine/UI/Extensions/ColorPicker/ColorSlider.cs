namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorSlider : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl ColorPicker;
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorValues type;
        private global::UnityEngine.UI.Slider slider;
        private bool listen;
        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        private void ColorChanged(global::UnityEngine.Color newColor)
        {
        }

        private void HSVChanged(float hue, float saturation, float value)
        {
        }

        private void SliderChanged(float newValue)
        {
        }
    }
}