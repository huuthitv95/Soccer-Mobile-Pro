namespace UnityEngine.UI.Extensions
{
    public class TabNavigationHelper : global::UnityEngine.MonoBehaviour
    {
        private global::UnityEngine.EventSystems.EventSystem _system;
        private global::UnityEngine.UI.Selectable StartingObject;
        private global::UnityEngine.UI.Selectable LastObject;
        public global::UnityEngine.UI.Selectable[] NavigationPath;
        public global::UnityEngine.UI.Extensions.NavigationMode NavigationMode;
        public bool CircularNavigation;
        private void Start()
        {
        }

        public void Update()
        {
        }

        private void SelectDefaultObject(out global::UnityEngine.UI.Selectable next)
        {
            next = null;
        }

        private void selectGameObject(global::UnityEngine.UI.Selectable selectable)
        {
        }
    }
}