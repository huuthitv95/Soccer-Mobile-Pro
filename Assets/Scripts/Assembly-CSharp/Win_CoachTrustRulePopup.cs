public class Win_CoachTrustRulePopup : global::Common.WindowBase
{
    [global::System.Serializable]
    private struct RuleItem
    {
        public global::UnityEngine.UI.Image icon;
        public global::UnityEngine.UI.Text levelText;
        public global::UnityEngine.UI.Image progressBar;
        public global::UnityEngine.UI.Extensions.Gradient2 progressGradient;
    }

    [global::UnityEngine.SerializeField]
    private Win_CoachTrustRulePopup.RuleItem[] ruleItems;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] valuesText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text currentValueText;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(int currentTrust)
    {
    }
}