namespace Common
{
    public class ViewManager : global::Common.Singleton<global::Common.ViewManager>, global::Common.IMessageReceiver, global::Common.IUpdate
    {
        public class WindowCloseEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        private const string baseDir = "Assets/GameData/";
        private global::Common.ViewBase currentView;
        private global::Common.WindowBase currentWindow;
        private global::System.Collections.Generic.Stack<string> viewPath;
        public global::Common.ViewManager.WindowCloseEvent OnWindowClose;
        public global::Common.ViewManager.WindowCloseEvent OnWindowOpen;
        private global::System.Collections.Generic.List<global::Common.WindowBase> windows;
        private global::System.Collections.Generic.List<global::Common.WindowBase> covers;
        private global::System.Collections.Generic.List<global::Common.WindowBase> closingWindows;
        public global::UnityEngine.Camera UICamera;
        public int defaultCameraDepth;
        private ScreenEffects screenEffects;
        public GaussianBlurEffect GaussianBlurEffect;
        public static int _depth;
        private global::LRUCache.LRUCache<string, global::UnityEngine.GameObject> winOriginCache;
        private global::UnityEngine.Camera currentEffectCamera;
        private bool closingAllWindows;
        public global::Common.BannerHelper BannerHelper { get; }
        public string CurrentViewId { get; set; }
        public string CurrentWindowId { get; set; }
        public global::UnityEngine.GameObject MatchWidthRoot { get; private set; }
        public global::UnityEngine.GameObject MatchWCoverRoot { get; private set; }
        public global::UnityEngine.GameObject ViewRoot { get; private set; }
        public global::UnityEngine.GameObject WinRoot { get; private set; }
        public global::UnityEngine.GameObject TopRoot { get; private set; }
        public global::UnityEngine.GameObject CoverRoot { get; private set; }
        public global::UnityEngine.RectTransform audioADPlaceHolder { get; private set; }
        public global::UnityEngine.GameObject SponsorBannerRoot { get; private set; }
        public global::UnityEngine.GameObject SponsorInterstitialRoot { get; private set; }
        public global::UnityEngine.Canvas UICanvas { get; private set; }
        public global::UnityEngine.Canvas TempUICanvas { get; private set; }
        public bool Initialized { get; private set; }
        public bool AllowOpenWindow { get; set; }
        public global::UIThemes.UIThemeType ThemeType { get; private set; }
        public global::UIThemes.UIThemeType DetailThemeType { get; private set; }

        public static int depth
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int WindowCount => 0;
        public bool HasAnyWindowOrCover => false;
        public bool IsClosingAllWindows => false;

        private void CheckBannerStatus()
        {
        }

        private void CheckWindowScreenTimeState()
        {
        }

        public bool HasFullScreenWindow()
        {
            return false;
        }

        public bool HasWindowOpen()
        {
            return false;
        }

        public void SetTheme(global::UIThemes.UIThemeType themeType, global::UIThemes.UIThemeType detailThemeType)
        {
        }

        private void SetupTheme(global::Common.WindowBase win)
        {
        }

        public void HideUI()
        {
        }

        public void ShowUI()
        {
        }

        public void ChangeMatchWidthRootScaler(float value = 1f)
        {
        }

        public void Init()
        {
        }

        private void FillParent(global::UnityEngine.RectTransform rect, global::UnityEngine.RectTransform parent)
        {
        }

        public void SwitchView(string viewId, object parameter = null)
        {
        }

        public global::Common.ViewBase GetCurrentView()
        {
            return null;
        }

        public void CloseCurrentView()
        {
        }

        public void SetAllWindowAlpha(float alpha)
        {
        }

        public T GetWindow<T>(string winId)
            where T : global::Common.WindowBase
        {
            return null;
        }

        public void ClearWindowCache()
        {
        }

        public global::Common.WindowBase OpenWindow(string winid, bool closeOther = false, object parmeter = null, bool onTop = false, bool alwaysMatchWidth = false, global::UnityEngine.Camera effectCamera = null, bool enableCameraEffect = true)
        {
            return null;
        }

        private global::System.Collections.IEnumerator PlayTween(WindowTweenBase tween)
        {
            return null;
        }

        public static float AdaptToFullscreen(global::UnityEngine.Vector2 designResolution, global::UnityEngine.Rect currentFullScreen)
        {
            return 0f;
        }

        public float AdaptToFullscreen()
        {
            return 0f;
        }

        public bool HasPopupWindow()
        {
            return false;
        }

        public void SetCurrentEffectCamera(global::UnityEngine.Camera cam)
        {
        }

        public T OpenWindow<T>(string winid, bool closeOther = false, object parmeter = null, bool onTop = false, bool alwaysMatchWidth = false, global::UnityEngine.Camera effectCamera = null, bool enableCameraEffect = true)
            where T : global::Common.WindowBase
        {
            return null;
        }

        public bool IsWindowClosing(string winId)
        {
            return false;
        }

        public bool IsWindowOpen(string winId)
        {
            return false;
        }

        public bool CloseWindow(string windowId, bool withAnim = true)
        {
            return false;
        }

        public void CloseAllWindow()
        {
        }

        public void CloseAllWindow(bool withAnim)
        {
        }

        public void CloseWindow(global::Common.WindowBase window, bool withAnim = true)
        {
        }

        private global::System.Collections.IEnumerator DelayCloseWindow(global::Common.WindowBase window, bool withAnim = true)
        {
            return null;
        }

        public global::Common.WindowBase OpenCover(string id, object parameter = null, bool alwaysMatchWidth = false)
        {
            return null;
        }

        public bool CloseCover(string id)
        {
            return false;
        }

        public void ReceiveMessage(global::Common.GameMessage message)
        {
        }

        public void OnUpdate(float deltaTime)
        {
        }

        public void OnCurrentWindowUpdate(float deltaTime)
        {
        }

        public global::Common.WindowBase GetCurrentWindow()
        {
            return null;
        }
    }
}