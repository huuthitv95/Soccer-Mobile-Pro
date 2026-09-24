namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorLabel : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorValues type;
        public string prefix;
        public float minValue;
        public float maxValue;
        public int precision;
        private global::UnityEngine.UI.Text label;
        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDestroy()
        {
        }

        private void ColorChanged(global::UnityEngine.Color color)
        {
        }

        private void HSVChanged(float hue, float sateration, float value)
        {
        }

        private void UpdateValue()
        {
        }

        private string ConvertToDisplayString(float value)
        {
            return null;
        }
    }
}