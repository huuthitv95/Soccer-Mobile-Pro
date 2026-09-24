namespace UIThemes
{
    public class ImageTheme : global::UIThemes.UIThemes, global::UIThemes.IUnconventionalUITheme
    {
        [global::System.Serializable]
        public struct ImageParams
        {
            public global::UnityEngine.UI.Image.Type imageType;
            public global::SL.UIAtlasType atlasType;
            public string spriteName;
            public global::UnityEngine.Color color;
            public bool preserveAspect;
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image _imageComponent;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UIThemes.ImageTheme.ImageParams> parameterSets;
        protected virtual void Awake()
        {
        }

        protected override void OnApplyTheme(int themeIdx)
        {
        }

        public void ApplyUnconventional(int themeIdx)
        {
        }
    }
}