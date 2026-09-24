public class GUITourEventMainViewItem : global::UnityEngine.MonoBehaviour
{
    private static readonly global::UnityEngine.Color ClaimedColor;
    private static readonly global::UnityEngine.Color DefaultProgressColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic[] progressGraphics;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject currentChapterActiveMark;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text chapterNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject CompletedNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject InProgressNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject LockedNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject claimedNode;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem rewardItem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnOpenMap;
    public void Updater(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventManager manager, bool isCurrentChapter)
    {
    }

    private void UpdateChapterName(global::FL.TourEvent.TourEventChapterConfig chapter)
    {
    }

    private void UpdateProgressColor(bool claimed)
    {
    }

    private void UpdateReward(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventManager manager)
    {
    }

    private bool IsChapterUnlocked(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventManager manager)
    {
        return false;
    }

    private void BindOpenMapButton(global::FL.TourEvent.TourEventChapterConfig chapter, global::FL.TourEvent.TourEventManager manager, bool unlocked)
    {
    }

    private void SetActive(global::UnityEngine.GameObject target, bool active)
    {
    }
}