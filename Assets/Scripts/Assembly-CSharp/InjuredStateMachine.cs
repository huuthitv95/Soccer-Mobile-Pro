public class InjuredStateMachine : HFSM<TimelinePlayerControler, string>
{
    private class Injured1 : HFSM<TimelinePlayerControler, string>
    {
        private string nextState;
        private global::System.Func<bool> finishedFlag;
        private global::System.Action notifyFinish;
        private global::UnityEngine.Vector3 mainPlayerPos;
        private int role;
        private global::UnityEngine.Vector3 orgPos;
        private global::UnityEngine.Quaternion orgQua;
        private global::UnityEngine.Vector3 cameraPos;
        private float timer;
        public Injured1(TimelinePlayerControler owner, string name, string Next) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(int role, global::UnityEngine.Vector3 mainPlayerPos, global::UnityEngine.Vector3 cameraPos, global::System.Func<bool> finishedFlag, global::System.Action notifyFinish)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }
    }

    private class Injured0 : HFSM<TimelinePlayerControler, string>
    {
        private string nextState;
        private global::System.Func<bool> finishedFlag;
        private global::System.Action notifyFinish;
        private global::UnityEngine.Vector3 mainPlayerPos;
        private int role;
        private global::UnityEngine.Vector3 orgPos;
        private global::UnityEngine.Quaternion orgQua;
        private global::UnityEngine.Vector3 cameraPos;
        private global::UnityEngine.Quaternion cameraRotation;
        private float timer;
        private global::UnityEngine.Vector3 OrgCameraPos;
        private global::UnityEngine.Quaternion OrgCameraRotation;
        public Injured0(TimelinePlayerControler owner, string name, string Next) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void Init(int role, global::UnityEngine.Vector3 mainPlayerPos, global::UnityEngine.Vector3 cameraPos, global::UnityEngine.Quaternion camreaRotation, global::System.Func<bool> finishedFlag, global::System.Action notifyFinish)
        {
        }

        public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
        {
        }

        public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
        {
        }

        public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }
    }

    private static InjuredStateMachine leader;
    private static global::UnityEngine.Vector3 mianPlayerPos1;
    private static global::UnityEngine.Quaternion mianPlayerRotation1;
    private static global::UnityEngine.Vector3 cameraPostion1;
    private static bool commonInitialized;
    private static bool flag1;
    private static bool flag0;
    public InjuredStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start(TimelinePlayerControler injuredPlayer)
    {
    }

    public override void Kill()
    {
    }

    private void OnShutdown()
    {
    }

    public override void Shutdown()
    {
    }
}