[global::UnityEngine.DisallowMultipleComponent]
public class UmpManager : global::UnityEngine.MonoBehaviour
{
    private enum RequestState
    {
        None = 0,
        Requesting = 1,
        UpdateError = 2,
        UpdateOK = 3,
        ShowWindow = 4
    }

    public static UmpManager inst;
    [global::UnityEngine.HideInInspector]
    public bool Denied;
    private global::System.Action<bool, bool> afterCMP;
    public global::System.Action<bool, bool> AfterIDFA;
    private const string payClassName = "com.androidgamegou.googleiap.GoogleBillingPay";
    private UmpManager.RequestState requesting;
    public bool UmpConfinished { get; set; }

    private void Awake()
    {
    }

    public void Request(global::System.Action<bool, bool> action)
    {
    }

    private void OnRequestFinish(bool finished, global::GoogleMobileAds.Ump.Api.FormError error)
    {
    }

    public void ShowPrivacyOptionsForm()
    {
    }

    private void OnConsentInfoUpdated(global::GoogleMobileAds.Ump.Api.FormError error)
    {
    }

    public void Show(global::System.Action<global::System.Action> beforeRepeatDlg)
    {
    }

    public void Clear()
    {
    }

    public void Reset()
    {
    }

    public bool Required()
    {
        return false;
    }

    public bool IsEEA()
    {
        return false;
    }

    private bool GetPurposeConsent()
    {
        return false;
    }
}