namespace LeTai.Effects
{
    public class ScalableBlurConfig : global::LeTai.Effects.BlurConfig
    {
        [global::UnityEngine.SerializeField]
        private float radius;
        [global::UnityEngine.SerializeField]
        private int iteration;
        [global::UnityEngine.SerializeField]
        private int maxDepth;
        [global::UnityEngine.SerializeField]
        private float strength;
        private static readonly float UNIT_VARIANCE;
        public float Radius
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int Iteration
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int MaxDepth
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public float Strength
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        protected virtual void SetAdvancedFieldFromSimple()
        {
        }

        private void OnValidate()
        {
        }
    }
}