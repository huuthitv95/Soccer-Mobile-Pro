public class GUIMomentChallenge : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject specialRewardNode;
    [global::UnityEngine.SerializeField]
    private GUIChallengeRoundRewardItem[] rewardItems;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text round1Text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text round2Text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject round1FinishedIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject round2FinishedIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text currentRewardNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text lastRountDescText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text coinCountText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject coinRewardNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text coinRewardText;
    public void Updater(MomentChallengeManager challengeManager)
    {
    }

    private bool UpdateSpecialReward(MomentChallengeManager challengeManager)
    {
        return false;
    }
}