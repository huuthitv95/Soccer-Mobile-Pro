namespace FL.UI.Effects
{
    public class GiftHintShake : global::UnityEngine.MonoBehaviour
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform target;
        [global::UnityEngine.SerializeField]
        private float shakeDuration;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 shakeStrength;
        [global::UnityEngine.SerializeField]
        private bool enablePositionShake;
        [global::UnityEngine.SerializeField]
        private bool enableRotationSwing;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 rotationStrength;
        [global::UnityEngine.SerializeField]
        private bool enableScaleShake;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector3 scaleStrength;
        [global::UnityEngine.SerializeField]
        private int vibrato;
        [global::UnityEngine.SerializeField]
        private float randomness;
        [global::UnityEngine.SerializeField]
        private float restInterval;
        [global::UnityEngine.SerializeField]
        private bool fadeOut;
        [global::UnityEngine.SerializeField]
        private bool playOnEnable;
        private global::DG.Tweening.Sequence shakeSequence;
        private void Awake()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void Play()
        {
        }

        public void Stop()
        {
        }
    }
}