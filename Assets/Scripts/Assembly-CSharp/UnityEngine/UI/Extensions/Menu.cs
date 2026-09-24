namespace UnityEngine.UI.Extensions
{
    public abstract class Menu<T> : global::UnityEngine.UI.Extensions.Menu where T : global::UnityEngine.UI.Extensions.Menu<T>
    {
        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        protected static void Open()
        {
        }

        protected static void Close()
        {
        }

        public override void OnBackPressed()
        {
        }
    }

    public abstract class Menu : global::UnityEngine.MonoBehaviour
    {
        public bool DestroyWhenClosed;
        public bool DisableMenusUnderneath;
        public abstract void OnBackPressed();
    }
}