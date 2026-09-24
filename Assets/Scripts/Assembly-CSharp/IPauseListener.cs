public interface IPauseListener
{
	void OnPause(Fsm<TimelinePlayerControler, string> fsm);

	void OnResume(Fsm<TimelinePlayerControler, string> fsm);
}
