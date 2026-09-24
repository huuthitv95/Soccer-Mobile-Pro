public class Win_AgeVerificationTips : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button debugCloseBtn;
    private int closeTimes;
    public override void OnOpen(object param)
    {
    }

    private void OnCloseBtnClick()
    {
    }

    public void QuitGame()
    {
    }

    private void UpdateUI(AmazonAgeVerificationResult result)
    {
    }

    private string GetDisplayMessage(AmazonAgeVerificationResult result)
    {
        return null;
    }

    public static void CheckShowAgeVerificationTips()
    {
    }

    private static bool ShouldShowDialog(AmazonAgeVerificationResult result)
    {
        return false;
    }
}