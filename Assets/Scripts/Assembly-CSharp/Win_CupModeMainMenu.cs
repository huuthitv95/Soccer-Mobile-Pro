public class Win_CupModeMainMenu : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] roundNames;
    [global::UnityEngine.SerializeField]
    private GUIMatchList matchList;
    [global::UnityEngine.SerializeField]
    private GUIPointStatisticsBoard pointStatisticsBoard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform knockoutPreview;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform matchInfoBG;
    [global::UnityEngine.SerializeField]
    private ForwardBackwardController forwardBackwardController;
    private CupMatchBase match;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(IMatchManager cup, CupMatchBase match)
    {
    }

    private global::System.Collections.IEnumerator DelayCheckDifficultyOption()
    {
        return null;
    }

    public void OpenSettingView()
    {
    }

    private void UpdateTeamsInfo(CupMatchBase match, global::UnityEngine.Transform UI_home, global::UnityEngine.Transform UI_away)
    {
    }

    private void ToPrematch()
    {
    }

    private void BackToMainMenu()
    {
    }
}