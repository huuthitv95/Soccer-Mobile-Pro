namespace LeTai.TrueShadow.Demo
{
    public class SymbolsManager : global::UnityEngine.MonoBehaviour
    {
        [global::UnityEngine.SerializeField]
        private float cellSize;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject shapePrefab;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Sprite[] sprites;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color[] colors;
        [global::UnityEngine.SerializeField]
        private float maxReactionDistance;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationCurve reactionCurve;
        [global::UnityEngine.SerializeField]
        private float heightOffset;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 shadowSizeMinMax;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 shadowDistanceMinMax;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Gradient shadowGradient;
        [global::UnityEngine.SerializeField]
        private global::LeTai.TrueShadow.TrueShadow[] samples;
        private float colorScale;
        private global::UnityEngine.RectTransform selfRt;
        private global::UnityEngine.Camera interectionCam;
        private global::UnityEngine.Vector2[] initialPositions;
        private global::UnityEngine.RectTransform[] rectTransforms;
        private global::LeTai.TrueShadow.TrueShadow[] shadows;
        private void Start()
        {
        }

        private void Spawn()
        {
        }

        private void Update()
        {
        }

        private void React()
        {
        }

        public void SetMaxSize(float maxSize)
        {
        }

        public void SetColorScale(float scale)
        {
        }
    }
}