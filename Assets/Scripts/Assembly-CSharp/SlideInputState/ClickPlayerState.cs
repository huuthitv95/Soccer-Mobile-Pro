namespace SlideInputState
{
    public class ClickPlayerState : FsmState<SlideInput, global::System.Type>
    {
        private global::UnityEngine.RaycastHit[] hits;
        public override global::System.Type Id
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override void OnUpdate(Fsm<SlideInput, global::System.Type> fsm, float elapseSeconds, float realElapseSeconds)
        {
        }

        public override void OnEnter(Fsm<SlideInput, global::System.Type> fsm)
        {
        }
    }
}