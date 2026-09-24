namespace Coffee.UISoftMaskInternal
{
    public abstract class PreloadedProjectSettings : global::UnityEngine.ScriptableObject
    {
    }

    public abstract class PreloadedProjectSettings<T> : global::Coffee.UISoftMaskInternal.PreloadedProjectSettings where T : global::Coffee.UISoftMaskInternal.PreloadedProjectSettings<T>
    {
        private static T s_Instance;
        public static T instance => null;

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }
    }
}