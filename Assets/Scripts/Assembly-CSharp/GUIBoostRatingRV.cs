public class GUIBoostRatingRV : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject boost;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject boosted;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text currentRating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text targetRating;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text boostedRating;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    private ClubPlayer player;
    private PlayerTemporaryBoostManager manager;
    private void OnDestroy()
    {
    }

    public void Init(ClubPlayer playe, PlayerTemporaryBoostManager manager)
    {
    }

    private void OnNotify(int playerId)
    {
    }

    private void OnVideoSucceed()
    {
    }

    private void RefreshView()
    {
    }
}