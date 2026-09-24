namespace Coffee.UISoftMaskInternal
{
    internal static class UIExtraCallbacks
    {
        private static bool s_IsInitializedAfterCanvasRebuild;
        private static readonly global::Coffee.UISoftMaskInternal.FastAction s_AfterCanvasRebuildAction;
        private static readonly global::Coffee.UISoftMaskInternal.FastAction s_LateAfterCanvasRebuildAction;
        private static readonly global::Coffee.UISoftMaskInternal.FastAction s_BeforeCanvasRebuildAction;
        private static readonly global::Coffee.UISoftMaskInternal.FastAction s_OnScreenSizeChangedAction;
        private static global::UnityEngine.Vector2Int s_LastScreenSize;
        public static event global::System.Action onLateAfterCanvasRebuild
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action onBeforeCanvasRebuild
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action onAfterCanvasRebuild
        {
            add
            {
            }

            remove
            {
            }
        }

        public static event global::System.Action onScreenSizeChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        static UIExtraCallbacks()
        {
        }

        private static void InitializeAfterCanvasRebuild()
        {
        }

        private static void InitializeOnLoad()
        {
        }

        private static void OnBeforeCanvasRebuild()
        {
        }

        private static void OnAfterCanvasRebuild()
        {
        }
    }
}