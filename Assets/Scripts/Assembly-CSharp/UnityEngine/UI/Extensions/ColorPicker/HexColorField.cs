namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class HexColorField : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl ColorPicker;
        public bool displayAlpha;
        private global::UnityEngine.UI.InputField hexInputField;
        private const string hexRegex = "^#?(?:[0-9a-fA-F]{3,4}){1,2}$";
        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        private void UpdateHex(global::UnityEngine.Color newColor)
        {
        }

        private void UpdateColor(string newHex)
        {
        }

        private string ColorToHex(global::UnityEngine.Color32 color)
        {
            return null;
        }

        public static bool HexToColor(string hex, out global::UnityEngine.Color32 color)
        {
            color = default;
            return false;
        }
    }
}