namespace UnityEngine.InputSystem
{
    public class InputSettings : global::UnityEngine.ScriptableObject
    {
        public enum UpdateMode
        {
            ProcessEventsInDynamicUpdate = 1,
            ProcessEventsInFixedUpdate = 2,
            ProcessEventsManually = 3
        }

        public enum BackgroundBehavior
        {
            ResetAndDisableNonBackgroundDevices = 0,
            ResetAndDisableAllDevices = 1,
            IgnoreFocus = 2
        }

        public enum EditorInputBehaviorInPlayMode
        {
            PointersAndKeyboardsRespectGameViewFocus = 0,
            AllDevicesRespectGameViewFocus = 1,
            AllDeviceInputAlwaysGoesToGameView = 2
        }

        public enum InputActionPropertyDrawerMode
        {
            Compact = 0,
            MultilineEffective = 1,
            MultilineBoth = 2
        }

        [global::UnityEngine.SerializeField]
        private string[] m_SupportedDevices;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputSettings.UpdateMode m_UpdateMode;
        [global::UnityEngine.SerializeField]
        private int m_MaxEventBytesPerUpdate;
        [global::UnityEngine.SerializeField]
        private int m_MaxQueuedEventsPerUpdate;
        [global::UnityEngine.SerializeField]
        private bool m_CompensateForScreenOrientation;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputSettings.BackgroundBehavior m_BackgroundBehavior;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode;
        [global::UnityEngine.SerializeField]
        private float m_DefaultDeadzoneMin;
        [global::UnityEngine.SerializeField]
        private float m_DefaultDeadzoneMax;
        [global::UnityEngine.SerializeField]
        private float m_DefaultButtonPressPoint;
        [global::UnityEngine.SerializeField]
        private float m_ButtonReleaseThreshold;
        [global::UnityEngine.SerializeField]
        private float m_DefaultTapTime;
        [global::UnityEngine.SerializeField]
        private float m_DefaultSlowTapTime;
        [global::UnityEngine.SerializeField]
        private float m_DefaultHoldTime;
        [global::UnityEngine.SerializeField]
        private float m_TapRadius;
        [global::UnityEngine.SerializeField]
        private float m_MultiTapDelayTime;
        [global::UnityEngine.SerializeField]
        private bool m_DisableRedundantEventsMerging;
        [global::UnityEngine.SerializeField]
        private bool m_ShortcutKeysConsumeInputs;
        [global::System.NonSerialized]
        internal global::System.Collections.Generic.HashSet<string> m_FeatureFlags;
        internal static bool optimizedControlsFeatureEnabled;
        internal static bool readValueCachingFeatureEnabled;
        internal static bool paranoidReadValueCachingChecksEnabled;
        internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;
        public global::UnityEngine.InputSystem.InputSettings.UpdateMode updateMode
        {
            get
            {
                return (global::UnityEngine.InputSystem.InputSettings.UpdateMode)0;
            }

            set
            {
            }
        }

        public bool compensateForScreenOrientation
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public bool filterNoiseOnCurrent
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float defaultDeadzoneMin
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float defaultDeadzoneMax
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float defaultButtonPressPoint
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float buttonReleaseThreshold
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float defaultTapTime
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float defaultSlowTapTime
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float defaultHoldTime
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float tapRadius
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float multiTapDelayTime
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputSettings.BackgroundBehavior backgroundBehavior
        {
            get
            {
                return global::UnityEngine.InputSystem.InputSettings.BackgroundBehavior.ResetAndDisableNonBackgroundDevices;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode
        {
            get
            {
                return global::UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode.PointersAndKeyboardsRespectGameViewFocus;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode inputActionPropertyDrawerMode
        {
            get
            {
                return global::UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode.Compact;
            }

            set
            {
            }
        }

        public int maxEventBytesPerUpdate
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int maxQueuedEventsPerUpdate
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<string> supportedDevices
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool disableRedundantEventsMerging
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool shortcutKeysConsumeInput
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public void SetInternalFeatureFlag(string featureName, bool enabled)
        {
        }

        internal bool IsFeatureEnabled(string featureName)
        {
            return false;
        }

        internal void OnChange()
        {
        }
    }
}