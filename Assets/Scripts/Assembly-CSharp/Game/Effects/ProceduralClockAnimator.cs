namespace Game.Effects
{
    public class ProceduralClockAnimator : global::UnityEngine.MonoBehaviour
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Transform hand;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 baseEuler;
        [global::UnityEngine.SerializeField]
        private float tickInterval;
        [global::UnityEngine.SerializeField]
        private float degreesPerTick;
        [global::UnityEngine.SerializeField]
        private int ticksPerLoop;
        [global::UnityEngine.SerializeField]
        private bool loop;
        [global::UnityEngine.SerializeField]
        private float settleDuration;
        [global::UnityEngine.SerializeField]
        private float overshootDegrees;
        [global::UnityEngine.SerializeField]
        private float bounceFrequency;
        [global::UnityEngine.SerializeField]
        private float bounceDamping;
        private float _time;
        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void Update()
        {
        }

        private float EvaluateBounce(float tickTime)
        {
            return 0f;
        }
    }
}