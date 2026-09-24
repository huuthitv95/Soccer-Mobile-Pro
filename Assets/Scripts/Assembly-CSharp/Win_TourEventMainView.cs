public class Win_TourEventMainView : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUITourEventTopBar topBar;
    [global::UnityEngine.SerializeField]
    private GUITourEventMainViewItem[] chapterItems;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text countDown;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text eventName;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem allChapterCompletionReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnInfo;
    private global::FL.TourEvent.TourEventManager manager;
    private global::UnityEngine.UI.Button boundNextButton;
    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    private void RecoverFromOcclusion()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    private void BindButtons()
    {
    }

    private void Refresh()
    {
    }

    private void UpdateTeamButton()
    {
    }

    private void UpdateStaticText()
    {
    }

    private void UpdateChapters()
    {
    }

    private void UpdateAllChapterCompletionReward()
    {
    }

    private void OnChapterRewardClick(int chapterId)
    {
    }

    private void OnRewardClick()
    {
    }

    private void OnNextClick()
    {
    }

    private void OnTeamClick()
    {
    }

    private void OnInfoClick()
    {
    }

    private void OpenCurrentChapterMap()
    {
    }

    private global::FL.TourEvent.TourEventChapterConfig GetCurrentChapter()
    {
        return null;
    }

    private int GetClaimableChapterRewardId()
    {
        return 0;
    }

    private void TryOpenPendingRewardOrReplacementPack()
    {
    }

    private void OpenPendingReplacementPack()
    {
    }
}