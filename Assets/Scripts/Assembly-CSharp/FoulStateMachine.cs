public class FoulStateMachine : HFSM<TimelinePlayerControler, string>
{
    private class FoulState : HFSM<TimelinePlayerControler, string>
    {
        private string anim;
        private FoulStateMachine FoulStateMachine;
        public FoulState(TimelinePlayerControler ctr, string name, FoulStateMachine foulStateMachine) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(string anim)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }

        public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
        {
        }
    }

    private float timer;
    private static bool resetBeforeStart;
    private global::UnityEngine.Transform card;
    public FoulStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start(global::System.Collections.Generic.KeyValuePair<int, global::UnityEngine.Transform> data)
    {
    }

    private void ShowCard(bool redCard)
    {
    }

    public override void Kill()
    {
    }

    private void OnShutdonw()
    {
    }

    public override void Shutdown()
    {
    }
}