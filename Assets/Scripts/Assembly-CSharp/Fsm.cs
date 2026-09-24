public class Fsm<T, StateId>
    where T : class
{
    protected readonly global::System.Collections.Generic.Dictionary<StateId, IFsmState<T, StateId>> m_States;
    protected global::System.Collections.Generic.Dictionary<string, object> m_Datas;
    public FsmChangeStateEvent<T, StateId> m_Event;
    public FsmChangeStateEvent<T, StateId> OnStateChange => null;
    public string Name { get; protected set; }
    public T Owner { get; protected set; }
    public int IFsmStateCount => 0;
    public bool IsRunning => false;
    public bool IsDestroyed { get; protected set; }
    public IFsmState<T, StateId> CurrentState { get; protected set; }
    public float CurrentStateTime { get; protected set; }
    public global::System.Type OwnerType => null;

    public static Fsm<T, StateId> Create(string name, T owner, global::System.Collections.Generic.List<IFsmState<T, StateId>> states)
    {
        return null;
    }

    public void Clear()
    {
    }

    public void Start(StateId stateId)
    {
    }

    public bool HasState(StateId stateId)
    {
        return false;
    }

    public IFsmState<T, StateId> GetState(StateId stateId)
    {
        return null;
    }

    public IFsmState<T, StateId>[] GetAllStates()
    {
        return null;
    }

    public virtual void Update(float elapseSeconds, float realElapseSeconds)
    {
    }

    public virtual void Shutdown()
    {
    }

    public void ChangeState(StateId stateType)
    {
    }

    public bool HasData(string name)
    {
        return false;
    }

    public virtual void Kill()
    {
    }

    public TData GetData<TData>(string name)
    {
        return default;
    }

    public object GetData(string name)
    {
        return null;
    }

    public void SetData<TData>(string name, TData data)
    {
    }

    public void SetData(string name, object data)
    {
    }

    public bool RemoveData(string name)
    {
        return false;
    }
}