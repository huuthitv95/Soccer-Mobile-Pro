namespace LeTai.TrueShadow
{
    internal class ShadowSettingSnapshot
    {
        public readonly global::LeTai.TrueShadow.TrueShadow shadow;
        public readonly global::UnityEngine.Canvas canvas;
        public readonly global::UnityEngine.RectTransform canvasRt;
        public readonly float canvasScale;
        public readonly float size;
        public readonly global::UnityEngine.Vector2 canvasRelativeOffset;
        public readonly global::UnityEngine.Vector2 dimensions;
        private const int DIMENSIONS_HASH_STEP = 1;
        private int hash;
        internal ShadowSettingSnapshot(global::LeTai.TrueShadow.TrueShadow shadow)
        {
        }

        private void CalcHash()
        {
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return false;
        }
    }
}