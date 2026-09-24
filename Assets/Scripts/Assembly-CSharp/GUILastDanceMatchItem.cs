public class GUILastDanceMatchItem : global::UnityEngine.MonoBehaviour
{
    private const float RefreshSlideOffsetY = 80f;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text shortTitleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text roundText;
    [global::UnityEngine.SerializeField]
    private GUITeam userTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam opponentTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject passedFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn;
    private global::FL.LastDanceEventManager.SlotInfo slotInfo;
    private global::System.Action<global::FL.LastDanceEventManager.SlotInfo> onClick;
    private global::UnityEngine.RectTransform rectTransform;
    private global::UnityEngine.CanvasGroup canvasGroup;
    private global::UnityEngine.Vector2 defaultAnchoredPosition;
    private global::DG.Tweening.Sequence refreshSequence;
    private bool hasDefaultPosition;
    public int SlotId => 0;

    public void Bind(global::FL.LastDanceEventManager.SlotInfo slotInfo, global::System.Action<global::FL.LastDanceEventManager.SlotInfo> onClick)
    {
    }

    public void PlayRefreshAnimation(global::FL.LastDanceEventManager.SlotInfo slotInfo, global::System.Action<global::FL.LastDanceEventManager.SlotInfo> onClick, global::System.Action onComplete = null)
    {
    }

    private void ApplyData(global::FL.LastDanceEventManager.SlotInfo slotInfo, global::System.Action<global::FL.LastDanceEventManager.SlotInfo> onClick)
    {
    }

    private void OnDestroy()
    {
    }

    private void OnClick()
    {
    }

    private string Localized(string key)
    {
        return null;
    }

    private void EnsureAnimationState()
    {
    }

    private void StopRefreshAnimation(bool reset)
    {
    }

    private void ResetAnimationState()
    {
    }
}