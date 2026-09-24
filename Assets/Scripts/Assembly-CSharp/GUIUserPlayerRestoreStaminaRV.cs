public class GUIUserPlayerRestoreStaminaRV : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject boost;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject boosted;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject full;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private GUIStaminaPrgress currentStamina;
    [global::UnityEngine.SerializeField]
    private GUIStaminaPrgress targetStamina;
    [global::UnityEngine.SerializeField]
    private GUIStaminaPrgress boostedStamina;
    private ClubPlayer player;
    private InGamePlayer inGamePlayer;
    private PlayerTemporaryBoostManager manager;
    private bool isInGameMode;
    private bool inGameBoosted;
    private void OnDestroy()
    {
    }

    public void InitForPlayer(ClubPlayer player, PlayerTemporaryBoostManager manager)
    {
    }

    public void InitForInGamePlayer(InGamePlayer player, bool boosted, PlayerTemporaryBoostManager manager)
    {
    }

    private void UnregisterManagerEvent()
    {
    }

    private void OnNotifyStaminaBoostAdded(int playerId)
    {
    }

    private void OnVideoSucceed()
    {
    }

    private void ApplyOutGameBoost()
    {
    }

    private void ApplyInGameBoost()
    {
    }

    private void RefreshView()
    {
    }

    private void RefreshOutGameView()
    {
    }

    private void RefreshInGameView()
    {
    }
}