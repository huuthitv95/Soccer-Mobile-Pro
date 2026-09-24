namespace Common
{
    public class WindowBase : global::UnityEngine.MonoBehaviour, global::Common.IMessageReceiver, global::Common.IUpdate
    {
        private enum BannerSupportType
        {
            All = 0,
            None = 1,
            Bottom = 2,
            Top = 3
        }

        public static global::System.Collections.Generic.Dictionary<string, ScreenTimeEvent> screenTimeEvent;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform[] windowContentRoots;
        [global::UnityEngine.SerializeField]
        private global::UIThemes.UIThemes[] m_themes;
        [global::UnityEngine.SerializeField]
        public bool EnableBannerAD;
        [global::UnityEngine.SerializeField]
        public bool SkipBannerADCheck;
        [global::UnityEngine.SerializeField]
        private global::Common.WindowBase.BannerSupportType bannerSupportType;
        public WindowTweenBase TweenClose;
        public WindowTweenBase TweenOpen;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_OnWindowClose;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_OnWindowClosed;
        public global::UnityEngine.UI.RawImage BlurImage;
        [global::UnityEngine.HideInInspector]
        public global::System.Collections.Generic.List<global::Common.WindowBase> hiddenWindows;
        [global::UnityEngine.HideInInspector]
        public global::System.Collections.Generic.List<global::Common.WindowBase> beneathWindows;
        [global::UnityEngine.SerializeField]
        protected bool _IsOpaqueBg;
        protected global::Common.WindowBase coverWin;
        [global::UnityEngine.SerializeField]
        private bool isOverridable;
        private global::Common.OccludedObjectRuleHandler occludedObjectRuleHandler;
        public ScreenTimeTracker screenTimeTracker;
        [global::UnityEngine.SerializeField]
        private bool disableTheme;
        private bool OpenTweenPlayed;
        private bool closing;
        public string WindowId { get; set; }
        public global::UnityEngine.Transform WinParent { get; set; }

        public virtual bool IsOpaqueBg
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public event global::System.Action OnWindowClose
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public event global::System.Action OnWindowClosed
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public static ScreenTimeTracker CreateScreenTimeTracker(string windowId)
        {
            return null;
        }

        public bool IsSupportBanner()
        {
            return false;
        }

        private void CheckContentPosForBanner()
        {
        }

        public void CheckSendScreenTimeEvent()
        {
        }

        public virtual void OnOccludedByOtherWin(global::Common.WindowBase other)
        {
        }

        private global::Common.OccludedObjectRuleHandler GetOccludedObjectRuleHandler()
        {
            return null;
        }

        public virtual void OnReBuildBlurImage()
        {
        }

        public virtual void RecoverFromInvisibility()
        {
        }

        public virtual void ApplyTheme(global::UIThemes.UIThemeType themeType, global::UIThemes.UIThemeType fallbackThemeType = global::UIThemes.UIThemeType.Default)
        {
        }

        public virtual void OnOpen(object parameter)
        {
        }

        public virtual void ReceiveMessage(global::Common.GameMessage message)
        {
        }

        public virtual void OnUpdate(float deltaTime)
        {
        }

        private void Start()
        {
        }

        public virtual void OnCurrentWindowUpdate(float deltaTime)
        {
        }

        public virtual void OnClose()
        {
        }

        public void OnClosed()
        {
        }

        protected virtual void OnPreviousWindowClose()
        {
        }

        public virtual void OnClosing()
        {
        }

        public void Close()
        {
        }

        protected void DelayClick(global::UnityEngine.UI.Button b)
        {
        }

        private global::System.Collections.IEnumerator DelayClickInternal(global::UnityEngine.UI.Button b)
        {
            return null;
        }

        public void InitBottomBtnForSingleBack()
        {
        }
    }
}