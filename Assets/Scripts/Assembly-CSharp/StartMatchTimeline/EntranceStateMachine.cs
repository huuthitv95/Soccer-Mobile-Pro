namespace StartMatchTimeline
{
    public class EntranceStateMachine : HFSM<TimelinePlayerControler, string>
    {
        private global::StartMatchTimeline.EntranceRole role;
        private int indexInGroup;
        private int groupSize;
        public EntranceStateMachine(TimelinePlayerControler ctr, int indexInGroup, int groupSize, string id = "entrance") : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
        {
        }

        public void BuildStates(TimelinePlayerControler ctr, global::StartMatchTimeline.EntranceRole role)
        {
        }

        private void BuildStarter(TimelinePlayerControler ctr, string animName, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, bool driveCamera)
        {
        }

        private void BuildWalker(TimelinePlayerControler ctr, global::UnityEngine.Vector3 startMin, global::UnityEngine.Vector3 startMax, global::UnityEngine.Vector3 endMin, global::UnityEngine.Vector3 endMax)
        {
        }

        private void BuildCircle(TimelinePlayerControler ctr, global::UnityEngine.Vector3 center, float radius)
        {
        }
    }
}