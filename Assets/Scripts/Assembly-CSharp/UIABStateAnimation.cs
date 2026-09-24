[global::UnityEngine.DisallowMultipleComponent]
public abstract class UIABStateAnimation : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private bool isStateA;
    [global::UnityEngine.SerializeField]
    private bool applyInitialStateOnAwake;
    [global::UnityEngine.SerializeField]
    private ABAnimationStateChangedUnityEvent onStateChanged;
    [global::UnityEngine.SerializeField]
    private ABAnimationStateBoolChangedUnityEvent onIsStateAChanged;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<UIABStateAnimation, ABAnimationState, ABAnimationState> m_StateChanged;
    public bool IsStateA => false;
    public ABAnimationState CurrentState => ABAnimationState.A;
    public ABAnimationStateChangedUnityEvent OnStateChanged => null;
    public ABAnimationStateBoolChangedUnityEvent OnIsStateAChanged => null;

    public event global::System.Action<UIABStateAnimation, ABAnimationState, ABAnimationState> StateChanged
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    protected virtual void Awake()
    {
    }

    protected virtual void OnDisable()
    {
    }

    public void PlayStateA()
    {
    }

    public void PlayStateB()
    {
    }

    public void ToggleState()
    {
    }

    public void SetState(ABAnimationState targetState, bool instant = false)
    {
    }

    public void SetStateWithoutNotify(ABAnimationState targetState, bool instant = false)
    {
    }

    private bool SetStateInternal(ABAnimationState targetState, bool withoutNotify, bool instant)
    {
        return false;
    }

    protected abstract void PlayStateAnimation(ABAnimationState state, bool instant);
    protected abstract void StopAnimationInternal();
}