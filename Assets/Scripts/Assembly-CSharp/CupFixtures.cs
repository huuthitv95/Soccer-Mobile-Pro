public class CupFixtures : global::Common.WindowBase
{
    private const int MaxSupportedKnockoutStageCount = 5;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round32_l;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round32_r;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round16_l;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round16_r;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round8_l;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round8_r;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round4_l;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform round4_r;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform final;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<global::UnityEngine.Transform> matchList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform champion;
    [global::UnityEngine.SerializeField]
    private CupModeThemeBG themeBG;
    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle toggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform knockoutPanel;
    [global::UnityEngine.SerializeField]
    private GUIPointStatisticsBoard PointStatisticsBoard;
    [global::UnityEngine.SerializeField]
    private EventThemeTitle themeTitle;
    public CupFixtures Fill(bool afterMatch)
    {
        return null;
    }

    public static bool Support(FACup mgr)
    {
        return false;
    }

    public override void OnOpen(object parameter)
    {
    }

    private static int GetMatchListStartIndex(FACup mgr)
    {
        return 0;
    }

    private global::System.Collections.IEnumerator DelayLayout()
    {
        return null;
    }

    private void CalculateLineLength(global::UnityEngine.RectTransform src, global::UnityEngine.RectTransform target, ref global::UnityEngine.Vector2 v2, int idx, bool isHome, bool isRight)
    {
    }

    private void Connection(global::UnityEngine.Transform cur, global::UnityEngine.Transform next, bool isRight)
    {
    }

    public void Connection()
    {
    }
}