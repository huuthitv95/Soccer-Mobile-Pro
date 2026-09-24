public class Win_SearchPlayer : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRegion;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAge;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPosition;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo btnVideo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCoin;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text expectedQualifiedPlayers;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReset;
    private static string region;
    private static int minAge;
    private static int maxAge;
    private static int minRating;
    private static int maxRating;
    private static GeneralScoutManager.PosScout position;
    private GeneralScoutManager scoutManager;
    public void CloseWindow()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    private void updateExpectedQualifiedPlayers()
    {
    }

    public void Fill(GeneralScoutManager generalScoutManager, global::System.Action onSearch)
    {
    }

    private void UpdatePositionIcon()
    {
    }

    private void UpdateRegionIcon()
    {
    }

    private void UpdateUI()
    {
    }

    public static string GetPositionString(GeneralScoutManager.PosScout pos)
    {
        return null;
    }

    public static string GetRegionString(string region)
    {
        return null;
    }

    public static string GetAgeString(int min, int max)
    {
        return null;
    }

    public static string GetRatingString(int min, int max)
    {
        return null;
    }
}