public class FsmState<T, StateId> : IFsmState<T, StateId> where T : class
{
    public virtual StateId Id { get; set; }

    public FsmState()
    {
    }

    public FsmState(StateId id)
    {
    }

    public virtual void OnInit(Fsm<T, StateId> fsm)
    {
    }

    public virtual void OnEnter(Fsm<T, StateId> fsm)
    {
    }

    public virtual void OnUpdate(Fsm<T, StateId> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }

    public virtual void OnLeave(Fsm<T, StateId> fsm, bool isShutdown)
    {
    }

    public virtual void OnDestroy(Fsm<T, StateId> fsm)
    {
    }

    public void ChangeState(Fsm<T, StateId> fsm, StateId stateType)
    {
    }
}