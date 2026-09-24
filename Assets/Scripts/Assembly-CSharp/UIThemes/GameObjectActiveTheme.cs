namespace UIThemes
{
    public class GameObjectActiveTheme : global::UIThemes.UIThemes, global::UIThemes.IUnconventionalUITheme
    {
        [global::System.Serializable]
        public struct GameObjectActiveParams
        {
            public global::System.Collections.Generic.List<global::UnityEngine.GameObject> gameObjects;
        }

        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UIThemes.GameObjectActiveTheme.GameObjectActiveParams> parameterSets;
        private void HideAllGameObjects()
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