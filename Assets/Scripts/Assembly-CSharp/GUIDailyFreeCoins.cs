public class GUIDailyFreeCoins : global::UnityEngine.MonoBehaviour
{
    private enum ItemState
    {
        Locked = 0,
        Current = 1,
        Claimed = 2
    }

    [global::System.Serializable]
    private struct GUIItems
    {
        [global::UnityEngine.SerializeField]
        private ColorParamsHolder2 colorHolder;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject currentFlag;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text rewardText;
        public void Refresh(GUIDailyFreeCoins.ItemState itemState, string reward)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text cutDownText;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private global::FLGameData.RewardType rewardType;
    [global::UnityEngine.SerializeField]
    private GUIDailyFreeCoins.GUIItems[] items;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject freeFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject disableFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Events.UnityEvent OnAllClaimed;
    private int[] rewards;
    private void Start()
    {
    }

    private void OnVideoRewarded()
    {
    }

    private void RefreshUI()
    {
    }

    private void UpdateCountdownText()
    {
    }
}