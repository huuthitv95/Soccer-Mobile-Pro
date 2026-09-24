public class GUICoinReward : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text numberText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button okButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text desc;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hideWhenClosing;
    private int coinAmount;
    public void DoubleCoin()
    {
    }

    public void Init(int coinAmount, global::UnityEngine.Events.UnityAction onOkClicked)
    {
    }

    public void SetDesc(string title, string description)
    {
    }

    public void EnableRewardWithVideo(global::UnityEngine.Events.UnityAction onVideoSucceed, string pos = null)
    {
    }

    public void OnClosing()
    {
    }
}