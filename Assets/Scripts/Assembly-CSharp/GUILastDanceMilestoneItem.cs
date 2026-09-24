public class GUILastDanceMilestoneItem : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text reward;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text milestone;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button claimButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject claimedNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject normalNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject canClaimEffect;
    private global::FL.LastDanceEventManager.ProgressRewardInfo info;
    private global::System.Action<int, global::UnityEngine.RectTransform> onClaim;
    public void Bind(global::FL.LastDanceEventManager.ProgressRewardInfo info, global::System.Action<int, global::UnityEngine.RectTransform> onClaim)
    {
    }

    private void OnDestroy()
    {
    }

    private void OnClaimClick()
    {
    }

    private global::UnityEngine.RectTransform GetRewardEffectStart()
    {
        return null;
    }
}