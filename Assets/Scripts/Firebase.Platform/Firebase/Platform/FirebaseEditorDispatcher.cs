namespace Firebase.Platform
{
    internal sealed class FirebaseEditorDispatcher
    {
        private static global::System.Type EditorApplicationType => null;
        public static bool EditorIsPlaying => false;
        public static bool EditorIsPlayingOrWillChangePlaymode => false;

        public static void StartEditorUpdate()
        {
        }

        public static void StopEditorUpdate()
        {
        }

        public static void Update()
        {
        }

        public static void ListenToPlayState(bool start = true)
        {
        }

        private static void PlayModeStateChanged()
        {
        }

        private static void PlayModeStateChangedWithArg<T>(T t)
        {
        }

        private static void AddRemoveCallbackToField(global::System.Reflection.FieldInfo eventField, global::System.Action callback, object target = null, bool add = true, string errorMessage = null)
        {
        }
    }
}