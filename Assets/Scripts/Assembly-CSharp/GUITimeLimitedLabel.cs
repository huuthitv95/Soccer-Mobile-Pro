public class GUITimeLimitedLabel : IGUIIAPComponents
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text timeLimitedText;
    public override void Refresh(BaseIAPItemInfo data, GUIIAPItem item)
    {
    }

    private void UpdateCountdownText(global::System.DateTime expireDate)
    {
    }
}