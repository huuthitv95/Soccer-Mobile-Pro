public class Win_MatchStartInfo : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUITeam homeTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam awayTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text roundText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage rawImage;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] normalBg;
    [global::UnityEngine.SerializeField]
    private GUILocalPVPDecorator localPVPDecorator;
    public void Show(CupMatchBase match)
    {
    }

    private void SetUpForSpecialCup(CupMatchBase match)
    {
    }

    private global::DG.Tweening.Tween OnDisableAnim()
    {
        return null;
    }

    private void CloseWindow()
    {
    }
}