namespace LeTai.TrueShadow
{
    [global::System.Serializable]
    public struct QuickPreset
    {
        public string name;
        public float size;
        [global::LeTai.TrueShadow.SpreadSlider]
        public float spread;
        public float distance;
        public float alpha;
        public QuickPreset(string name, float size, float spread, float distance, float alpha)
        {
            this.name = null;
            this.size = 0f;
            this.spread = 0f;
            this.distance = 0f;
            this.alpha = 0f;
        }

        public void Apply(global::LeTai.TrueShadow.TrueShadow target)
        {
        }
    }
}