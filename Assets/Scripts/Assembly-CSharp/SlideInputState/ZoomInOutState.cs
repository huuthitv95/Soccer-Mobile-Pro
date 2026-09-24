namespace SlideInputState
{
    public class ZoomInOutState : FsmState<SlideInput, global::System.Type>
    {
        private float? oldDistance;
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