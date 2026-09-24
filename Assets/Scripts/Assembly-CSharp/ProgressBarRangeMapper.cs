public class ProgressBarRangeMapper : global::UnityEngine.EventSystems.UIBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image progressBar;
    [global::UnityEngine.SerializeField]
    private float minValue;
    [global::UnityEngine.SerializeField]
    private float maxValue;
    public float _value;
    protected override void OnDidApplyAnimationProperties()
    {
    }

    public void SetProgress(float value)
    {
    }

    public void SetRange(float min, float max, float current)
    {
    }
}