public class Win_PreMatchFormation : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform fromationList;
    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text formationName;
    [global::UnityEngine.SerializeField]
    private global::Game.UI.Tween.UISequentialTweenController tweenController;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image leftBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image rightBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image logoImage;
    [global::UnityEngine.SerializeField]
    private GUILocalPVPDecorator localPVPDecorator;
    private CupMatchBase match;
    public override void OnOpen(object parameter)
    {
    }

    public void Show(bool home)
    {
    }

    private void Fill(bool home, bool isMyTeam)
    {
    }

    private void SetUpForSpecialCup(CupMatchBase match)
    {
    }
}