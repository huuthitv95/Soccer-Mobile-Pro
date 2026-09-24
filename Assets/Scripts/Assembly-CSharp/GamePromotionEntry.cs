public class GamePromotionEntry : global::UnityEngine.MonoBehaviour
{
    private enum PromotionType
    {
        SSS = 0
    }

    private static global::System.Collections.Generic.LinkedList<GamePromotionEntry> entries;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject target;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject coinRewardGroup;
    [global::UnityEngine.SerializeField]
    private GamePromotionEntry.PromotionType promotionType;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void OnClickPromotion()
    {
    }

    public void CheckPopup()
    {
    }

    public static void UpdateCoinRewardGroups()
    {
    }

    private void UpdateState()
    {
    }
}