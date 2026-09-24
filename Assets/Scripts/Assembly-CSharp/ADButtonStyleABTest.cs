public class ADButtonStyleABTest : ADButtonStateBase
{
    [global::UnityEngine.SerializeField]
    private ADButtonStateBase[] adButtonStyles;
    private ADButtonStateBase currentStyle;
    public override global::UnityEngine.UI.Button Button => null;

    private void EnsureCurrentStyle()
    {
    }

    protected override void OnUpdateForADState(bool state)
    {
    }
}