namespace UIThemes
{
    public abstract class UIThemes : global::UnityEngine.MonoBehaviour
    {
        [global::UnityEngine.SerializeField]
        protected bool m_needRegister;
        [global::UnityEngine.SerializeField]
        protected global::System.Collections.Generic.List<global::UIThemes.ThemeMapping> m_themeMappings;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        protected global::UIThemes.UIThemeType _themeType;
        public bool NeedRegister => false;

        protected global::UIThemes.UIThemeType ThemeType
        {
            get
            {
                return global::UIThemes.UIThemeType.NotSet;
            }

            set
            {
            }
        }

        public global::UIThemes.UIThemeType IgnoredHighlightTypes => global::UIThemes.UIThemeType.NotSet;
        public global::UIThemes.UIThemeType HighlightType => global::UIThemes.UIThemeType.NotSet;

        protected bool CheckSupport(global::UIThemes.UIThemeType themeType)
        {
            return false;
        }

        public void ApplyTheme(global::UIThemes.UIThemeType themeType, global::UIThemes.UIThemeType fallbackThemeType)
        {
        }

        protected virtual int MatchThemeType(global::UIThemes.UIThemeType themeType)
        {
            return 0;
        }

        protected abstract void OnApplyTheme(int themeIdx);
        public global::UIThemes.UIThemeType GetThemeType()
        {
            return global::UIThemes.UIThemeType.NotSet;
        }
    }
}