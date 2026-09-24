namespace FLTest.GlobalConfig
{
    [global::FLTest.GlobalConfig.GlobalConfig]
    public class TesterConfig
    {
        public class GameObjectConfig
        {
            public string FullPath;
            public bool AutoHideOnMatchStart;
            private bool _hide;
            private bool _show;
            private void Hide()
            {
            }

            private void Show()
            {
            }
        }

        public global::System.Collections.Generic.List<global::FLTest.GlobalConfig.TesterConfig.GameObjectConfig> GameObjects;
        public bool HideBottomButtons;
        private static readonly global::FLTest.GlobalConfig.TesterConfig _config;
        private static global::FLTest.GlobalConfig.TesterConfig Config => null;
        public static bool IsHideBottomButtonsEnabled => false;

        public static void HideConfiguredGameObjects()
        {
        }

        public static void ShowConfiguredGameObjects()
        {
        }

        public static void ApplyAutoHideOnMatchStart()
        {
        }

        public static void OnReloaded()
        {
        }

        private static void SetConfiguredGameObjectsActive(bool active)
        {
        }

        private static bool SetGameObjectActive(string configuredPath, bool active)
        {
            return false;
        }

        private static global::UnityEngine.GameObject FindGameObjectByFullPath(string path)
        {
            return null;
        }

        private static global::UnityEngine.GameObject FindInScene(global::UnityEngine.SceneManagement.Scene scene, string[] pathParts, int rootIndex)
        {
            return null;
        }

        private static string NormalizePath(string path)
        {
            return null;
        }
    }
}