[global::System.Serializable]
public class SliderWithLabel
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text label;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider slider;
    private string format;
    private void UpdateLabel(float defaultValue)
    {
    }

    public void Initialize(float minValue, float maxValue, float defaultValue, global::UnityEngine.Events.UnityAction<float> OnValueChanged, string format = "F0")
    {
    }

    public void SetValue(float v, bool notify)
    {
    }
}