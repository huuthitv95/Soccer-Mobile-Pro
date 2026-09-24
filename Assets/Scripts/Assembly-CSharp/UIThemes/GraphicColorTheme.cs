namespace UIThemes
{
    public class GraphicColorTheme : global::UIThemes.UIThemes, global::UIThemes.IUnconventionalUITheme
    {
        [global::System.Serializable]
        public struct GraphicColorParams
        {
            public global::UnityEngine.Color color;
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic graphic;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic[] graphicGroup;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Events.UnityEvent<global::UnityEngine.Color> onColorChanged;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.Color> parameterSets;
        protected override void OnApplyTheme(int themeIdx)
        {
        }

        public void ApplyUnconventional(int themeIdx)
        {
        }
    }
}