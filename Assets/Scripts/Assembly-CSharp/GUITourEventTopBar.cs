public class GUITourEventTopBar : global::UnityEngine.MonoBehaviour
{
    private const int VideoRewardPoint = 5;
    private static GUITourEventTopBar activePointSubscriber;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text pointText;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShop;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRedeem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject rvCooling;
    private global::FL.TourEvent.TourEventManager manager;
    private global::FL.PointsStoreMananger pointStoreManager;
    private global::UnityEngine.Vector3 pointTextScale;
    private void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    public void Bind(global::FL.TourEvent.TourEventManager manager)
    {
    }

    public void Refresh()
    {
    }

    public void Dispose()
    {
    }

    private void BindButtons()
    {
    }

    private void SubscribePointChange()
    {
    }

    private void UnsubscribePointChange()
    {
    }

    private void UpdatePointText(int count)
    {
    }

    private void SetPointText(int count, bool animate)
    {
    }

    private void UpdateVideoReward()
    {
    }

    private void HideRvCooling()
    {
    }

    private void UpdateRedeemEntry()
    {
    }

    private void OnVideoReward()
    {
    }

    private void OpenShop()
    {
    }

    private void OpenRedeem()
    {
    }
}