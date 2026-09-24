[global::UnityEngine.DisallowMultipleComponent]
public class UIABStateAnimationGroup : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<UIABStateAnimation> items;
    [global::UnityEngine.SerializeField]
    private bool autoCollectFromChildren;
    [global::UnityEngine.SerializeField]
    private bool includeInactiveChildren;
    [global::UnityEngine.SerializeField]
    private UIABStateAnimationGroupRule groupRule;
    [global::UnityEngine.SerializeField]
    private int defaultStateAIndex;
    [global::UnityEngine.SerializeField]
    private bool defaultStateIsA;
    private bool currentStateIsA;
    [global::UnityEngine.SerializeField]
    private bool applyDefaultStateOnEnable;
    private bool suppressNotify;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void RefreshItems()
    {
    }

    public void SetStateA(int index, bool instant = false)
    {
    }

    public void SetStateB(int index, bool instant = false)
    {
    }

    public void SetAllStateA(bool instant = false)
    {
    }

    public void SetAllStateB(bool instant = false)
    {
    }

    public void ChangeSyncAllState()
    {
    }

    public void Register(UIABStateAnimation item)
    {
    }

    public void Unregister(UIABStateAnimation item)
    {
    }

    private bool IsValidIndex(int index)
    {
        return false;
    }

    private void NormalizeStates()
    {
    }

    private void OnItemStateChanged(UIABStateAnimation sender, ABAnimationState oldState, ABAnimationState newState)
    {
    }

    private void SetAllState(ABAnimationState targetState, bool instant)
    {
    }

    private void SetAllStateFromSender(UIABStateAnimation sender, ABAnimationState targetState)
    {
    }

    private void Rebind()
    {
    }

    private void UnbindAll()
    {
    }
}