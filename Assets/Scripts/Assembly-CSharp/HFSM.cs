public class HFSM<T, StateId> : Fsm<T, StateId>, IFsmState<T, StateId> where T : class
{
    private global::System.Collections.Generic.List<HFSMTransition<T, StateId>> stateBundle;
    public global::System.Action<HFSM<T, StateId>> OnLogicAction;
    public global::System.Action<HFSM<T, StateId>> OnEnterAction;
    public global::System.Action<HFSM<T, StateId>> OnExitAction;
    public virtual StateId Id { get; set; }
    public virtual StateId StartState { get; set; }

    public HFSM(string name, T owner, StateId Id, global::System.Collections.Generic.List<IFsmState<T, StateId>> states, StateId StartState, global::System.Action<HFSM<T, StateId>> OnLogicAction, global::System.Action<HFSM<T, StateId>> OnEnterAction, global::System.Action<HFSM<T, StateId>> OnExitAction)
    {
    }

    public void AddTransition(HFSMTransition<T, StateId> t)
    {
    }

    public void ClearTransition()
    {
    }

    public void AddState(IFsmState<T, StateId> state)
    {
    }

    public virtual void ChangeState(Fsm<T, StateId> fsm, StateId stateType)
    {
    }

    public virtual void OnDestroy(Fsm<T, StateId> fsm)
    {
    }

    public virtual void OnEnter(Fsm<T, StateId> fsm)
    {
    }

    public virtual void OnInit(Fsm<T, StateId> fsm)
    {
    }

    public virtual void OnLeave(Fsm<T, StateId> fsm, bool isShutdown)
    {
    }

    public virtual void OnUpdate(Fsm<T, StateId> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}