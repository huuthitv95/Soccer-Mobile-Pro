public class GUIMasterLeagueTopBar : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    public GUICoinNumber CoinNumber;
    private TeamsData team;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSetting;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCoin;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject plus;
    private global::UnityEngine.Rect rect;
    private FinancialManager financialManager;
    public void Fill(TeamsData team, FinancialManager financialManager)
    {
    }

    private void OpenCoinPopup()
    {
    }

    private void OnDestroy()
    {
    }
}