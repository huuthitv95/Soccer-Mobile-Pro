public class CheerSloganBanner : global::UnityEngine.MonoBehaviour
{
    private class SloganByTeam
    {
        public string[] slogan;
        public global::System.Collections.Generic.List<int> sloganOrder;
        public LanguageSetting.eLanguage language;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] homeBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] awayBanner;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI[] homeText;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI[] homeText2;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI[] homeText3;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI[] awayText;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI[] awayText2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] HomeInShadow;
    private static string[] commonText;
    private global::System.Collections.Generic.List<int> commonTextOrder;
    private int currentCommonTextIndex;
    private static global::System.Collections.Generic.Dictionary<int, CheerSloganBanner.SloganByTeam> sloganByTeam;
    private bool isVaild;
    public void init()
    {
    }

    private void CheckLoadConfig()
    {
    }

    public void ShowHome(global::UnityEngine.Color mainColor, TeamsData teamsData)
    {
    }

    public void ShowAway(global::UnityEngine.Color mainColor, TeamsData teamsData)
    {
    }

    private void SetBannerColor(global::UnityEngine.GameObject[] banners, global::UnityEngine.Color mainColor)
    {
    }

    private void SetBannerText(global::TMPro.TextMeshProUGUI[] texts, int teamId, string nation)
    {
    }
}