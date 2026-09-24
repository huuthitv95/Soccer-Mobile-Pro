namespace UIThemes
{
    public class Gradient2Theme : global::UIThemes.UIThemes, global::UIThemes.IUnconventionalUITheme
    {
        [global::System.Serializable]
        public struct Gradient2Params
        {
            public global::UnityEngine.UI.Extensions.Gradient2.Type gradientType;
            public global::UnityEngine.UI.Extensions.Gradient2.Blend blendMode;
            public bool modifyVertices;
            public float offset;
            public float zoom;
            public global::UnityEngine.Gradient effectGradient;
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.Gradient2 _gradient2Component;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UIThemes.Gradient2Theme.Gradient2Params> parameterSets;
        protected override void OnApplyTheme(int themeIdx)
        {
        }

        public void ApplyUnconventional(int themeIdx)
        {
        }
    }
}