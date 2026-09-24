namespace SlideInputState
{
    public class KickBallState : FsmState<SlideInput, global::System.Type>
    {
        public class SlideInputParameter : global::Common.Singleton<global::SlideInputState.KickBallState.SlideInputParameter>
        {
            public float maxSpeedThresholdForPower;
            public float minSpeedThresholdForPower;
            public float SpeedForPerfectDistance;
            public float minPower;
            public float maxPower;
            public float MaxDistanceOffsetRatioAtOverspeed;
            public float MaxDistanceOffsetRatioAtUnderspeed;
            public float maxSpeedThresholdForAngle;
            public float minSpeedThresholdForAngle;
            public float minSpeedForPerfectAngle;
            public float maxSpeedForPerfectAngle;
            public float maxAngleDecayCoefficientAtOverspeed;
            public float maxAngleDecayCoefficientAtUnderspeed;
            public float maxTargetPositionOffsetAtUnderspeed;
        }

        private global::UnityEngine.RaycastHit[] hits;
        private global::System.Collections.Generic.List<global::UnityEngine.Vector2> gestures;
        private global::System.DateTime startTouchTm;
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

        public bool AngleTest(global::UnityEngine.Vector3 hitPoint, global::UnityEngine.Vector3 groudPoint, out global::UnityEngine.Vector3 offset, IMatch _match)
        {
            offset = default;
            return false;
        }

        private void HitTest(bool shotCast, global::UnityEngine.Vector3 hitPoint, global::UnityEngine.Vector3 groudPoint, IMatch _match, Fsm<SlideInput, global::System.Type> fsm, bool isFalseTriggering = false)
        {
        }

        public static float GetArcNormalizedAngle(global::System.Collections.Generic.List<global::UnityEngine.Vector2> ges)
        {
            return 0f;
        }

        public override void OnEnter(Fsm<SlideInput, global::System.Type> fsm)
        {
        }

        public override void OnLeave(Fsm<SlideInput, global::System.Type> fsm, bool isShutdown)
        {
        }
    }
}