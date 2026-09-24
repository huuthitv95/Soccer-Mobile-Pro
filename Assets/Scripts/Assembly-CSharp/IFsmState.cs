public interface IFsmState<T, StateId> where T : class
{
	StateId Id { get; set; }

	void OnInit(Fsm<T, StateId> fsm);

	void OnEnter(Fsm<T, StateId> fsm);

	void OnUpdate(Fsm<T, StateId> fsm, float elapseSeconds, float realElapseSeconds);

	void OnLeave(Fsm<T, StateId> fsm, bool isShutdown);

	void OnDestroy(Fsm<T, StateId> fsm);

	void ChangeState(Fsm<T, StateId> fsm, StateId stateType);
}
