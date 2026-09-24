public class GUI26CupTourEventMapNode : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle nodeToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject lockedMarker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject completeMarker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject selectableMarker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image nodeIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Sprite[] nodeIconsByType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text fatigueDesc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color[] fatigueDescColorsByState;
    private global::FL.TourEvent.TourEventNodeConfig nodeConfig;
    private global::System.Action<GUI26CupTourEventMapNode> onSelected;
    private bool selectionCallbackEnabled;
    private global::FL.EventChallengeStateHandler.ChallengeState state;
    public int NodeId => 0;
    public global::FL.TourEvent.TourEventNodeConfig NodeConfig => null;

    public void Updater(global::FL.TourEvent.TourEventNodeConfig nodeConfig, global::FL.EventChallengeStateHandler.ChallengeState state, bool canSelect, string fatigueText, global::System.Action<GUI26CupTourEventMapNode> onSelected)
    {
    }

    public void SetSelected(bool selected)
    {
    }

    public void SetToggleGroupAllowSwitchOff(bool allow)
    {
    }

    public void SetSelectionCallbackEnabled(bool enabled)
    {
    }

    private void UpdateToggle(bool canSelect)
    {
    }

    private void UpdateIcon(global::FL.TourEvent.TourEventNodeConfig nodeConfig)
    {
    }

    private void UpdateMarkers(global::FL.EventChallengeStateHandler.ChallengeState state)
    {
    }

    private void UpdateFatigueText(global::FL.EventChallengeStateHandler.ChallengeState state, string fatigueText)
    {
    }

    private void OnToggleValueChanged(bool isOn)
    {
    }

    private void SetActive(global::UnityEngine.GameObject target, bool active)
    {
    }
}