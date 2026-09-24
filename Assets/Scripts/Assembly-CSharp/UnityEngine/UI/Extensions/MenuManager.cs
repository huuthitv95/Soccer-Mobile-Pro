namespace UnityEngine.UI.Extensions
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class MenuManager : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.Menu[] MenuScreens;
        public int StartScreen;
        private global::System.Collections.Generic.Stack<global::UnityEngine.UI.Extensions.Menu> menuStack;
        public static global::UnityEngine.UI.Extensions.MenuManager Instance { get; set; }

        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public void CreateInstance<T>()
            where T : global::UnityEngine.UI.Extensions.Menu
        {
        }

        public void CreateInstance(string MenuName)
        {
        }

        public void OpenMenu(global::UnityEngine.UI.Extensions.Menu instance)
        {
        }

        private global::UnityEngine.GameObject GetPrefab(string PrefabName)
        {
            return null;
        }

        private T GetPrefab<T>()
            where T : global::UnityEngine.UI.Extensions.Menu
        {
            return null;
        }

        public void CloseMenu(global::UnityEngine.UI.Extensions.Menu menu)
        {
        }

        public void CloseTopMenu()
        {
        }

        private void Update()
        {
        }
    }
}