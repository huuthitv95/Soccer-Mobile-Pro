public class SubstitutionStateMachine : HFSM<TimelinePlayerControler, string>
{
    private struct SubstitutionGoupData
    {
        public string InAnim;
        public string OutAnim;
        public global::UnityEngine.Vector3 distToBentch;
        public SubstitutionGoupData(string inAnim, string outAnim, global::UnityEngine.Vector3 dist)
        {
            InAnim = null;
            OutAnim = null;
            distToBentch = default;
        }
    }

    private class SubstitutionState : HFSM<TimelinePlayerControler, string>
    {
        private global::UnityEngine.GameObject bench;
        private global::UnityEngine.Vector3 distToBench;
        private string anim;
        private string benchanim;
        private global::UnityEngine.Animator animator;
        private bool hideOut;
        public SubstitutionState(TimelinePlayerControler ctr, string name) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(global::UnityEngine.GameObject bench, global::UnityEngine.Vector3 distToBench, string anim, string benchanim, bool hideOut)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }
    }

    private bool isController;
    private int slotIdx;
    private static int batchIdx;
    private ClubPlayer bench;
    private global::UnityEngine.GameObject benchGo;
    private float timer;
    private static global::System.Collections.Generic.List<SubstitutionStateMachine.SubstitutionGoupData> subsGropus;
    private global::System.Collections.Generic.KeyValuePair<int, int> boardNums;
    public SubstitutionStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public static void ResetAnimGroup()
    {
    }

    public void Start((int, int, bool) data)
    {
    }

    private void SetupStartState()
    {
    }

    public override void Update(float elapseSeconds, float realElapseSeconds)
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