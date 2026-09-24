namespace UIThemes
{
    [global::System.Serializable]
    public struct UnconventionalUIThemeGroup
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Object[] unconventionalThemes;
        private global::System.Collections.Generic.IEnumerable<global::UIThemes.IUnconventionalUITheme> UnconventionalThemes => null;

        public void ApplyUnconventional(int themeIdx)
        {
        }
    }
}