namespace UnityEngine.Timeline
{
    [global::System.Serializable]
    public class TimelineClip : global::UnityEngine.Timeline.ICurvesOwner, global::UnityEngine.ISerializationCallbackReceiver
    {
        private enum Versions
        {
            Initial = 0,
            ClipInFromGlobalToLocal = 1
        }

        private static class TimelineClipUpgrade
        {
            public static void UpgradeClipInFromGlobalToLocal(global::UnityEngine.Timeline.TimelineClip clip)
            {
            }
        }

        public enum ClipExtrapolation
        {
            None = 0,
            Hold = 1,
            Loop = 2,
            PingPong = 3,
            Continue = 4
        }

        public enum BlendCurveMode
        {
            Auto = 0,
            Manual = 1
        }

        private const int k_LatestVersion = 1;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private int m_Version;
        public static readonly global::UnityEngine.Timeline.ClipCaps kDefaultClipCaps;
        public static readonly float kDefaultClipDurationInSeconds;
        public static readonly double kTimeScaleMin;
        public static readonly double kTimeScaleMax;
        internal static readonly string kDefaultCurvesName;
        internal static readonly double kMinDuration;
        internal static readonly double kMaxTimeValue;
        [global::UnityEngine.SerializeField]
        private double m_Start;
        [global::UnityEngine.SerializeField]
        private double m_ClipIn;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Object m_Asset;
        [global::UnityEngine.SerializeField]
        private double m_Duration;
        [global::UnityEngine.SerializeField]
        private double m_TimeScale;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TrackAsset m_ParentTrack;
        [global::UnityEngine.SerializeField]
        private double m_EaseInDuration;
        [global::UnityEngine.SerializeField]
        private double m_EaseOutDuration;
        [global::UnityEngine.SerializeField]
        private double m_BlendInDuration;
        [global::UnityEngine.SerializeField]
        private double m_BlendOutDuration;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationCurve m_MixInCurve;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationCurve m_MixOutCurve;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendInCurveMode;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendOutCurveMode;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<string> m_ExposedParameterNames;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.AnimationClip m_AnimationCurves;
        [global::UnityEngine.SerializeField]
        private bool m_Recordable;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PostExtrapolationMode;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PreExtrapolationMode;
        [global::UnityEngine.SerializeField]
        private double m_PostExtrapolationTime;
        [global::UnityEngine.SerializeField]
        private double m_PreExtrapolationTime;
        [global::UnityEngine.SerializeField]
        private string m_DisplayName;
        public bool hasPreExtrapolation => false;
        public bool hasPostExtrapolation => false;

        public double timeScale
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public double start
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public double duration
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public double end => 0.0;

        public double clipIn
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public string displayName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public double clipAssetDuration => 0.0;

        public global::UnityEngine.AnimationClip curves
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        string global::UnityEngine.Timeline.ICurvesOwner.defaultCurvesName => null;
        public bool hasCurves => false;

        public global::UnityEngine.Object asset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        global::UnityEngine.Object global::UnityEngine.Timeline.ICurvesOwner.assetOwner => null;

        global::UnityEngine.Timeline.TrackAsset global::UnityEngine.Timeline.ICurvesOwner.targetTrack => null;

        [global::System.Obsolete]
        public global::UnityEngine.Object underlyingAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TrackAsset parentTrack
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public double easeInDuration
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public double easeOutDuration
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public double eastOutTime => 0.0;
        public double easeOutTime => 0.0;

        public double blendInDuration
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public double blendOutDuration
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TimelineClip.BlendCurveMode blendInCurveMode
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.BlendCurveMode.Auto;
            }

            set
            {
            }
        }

        public global::UnityEngine.Timeline.TimelineClip.BlendCurveMode blendOutCurveMode
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.BlendCurveMode.Auto;
            }

            set
            {
            }
        }

        public bool hasBlendIn => false;
        public bool hasBlendOut => false;

        public global::UnityEngine.AnimationCurve mixInCurve
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float mixInPercentage => 0f;
        public double mixInDuration => 0.0;

        public global::UnityEngine.AnimationCurve mixOutCurve
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public double mixOutTime => 0.0;
        public double mixOutDuration => 0.0;
        public float mixOutPercentage => 0f;

        public bool recordable
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        [global::System.Obsolete]
        public global::System.Collections.Generic.List<string> exposedParameters => null;
        public global::UnityEngine.Timeline.ClipCaps clipCaps => global::UnityEngine.Timeline.ClipCaps.None;
        public global::UnityEngine.AnimationClip animationClip => null;

        public global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation postExtrapolationMode
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation.None;
            }

            internal set
            {
            }
        }

        public global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation preExtrapolationMode
        {
            get
            {
                return global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation.None;
            }

            internal set
            {
            }
        }

        public double extrapolatedStart => 0.0;
        public double extrapolatedDuration => 0.0;

        private void UpgradeToLatestVersion()
        {
        }

        internal TimelineClip(global::UnityEngine.Timeline.TrackAsset parent)
        {
        }

        internal int Hash()
        {
            return 0;
        }

        public float EvaluateMixOut(double time)
        {
            return 0f;
        }

        public float EvaluateMixIn(double time)
        {
            return 0f;
        }

        private static global::UnityEngine.AnimationCurve GetDefaultMixInCurve()
        {
            return null;
        }

        private static global::UnityEngine.AnimationCurve GetDefaultMixOutCurve()
        {
            return null;
        }

        public double ToLocalTime(double time)
        {
            return 0.0;
        }

        public double ToLocalTimeUnbound(double time)
        {
            return 0.0;
        }

        internal double FromLocalTimeUnbound(double time)
        {
            return 0.0;
        }

        private static double SanitizeTimeValue(double value, double defaultValue)
        {
            return 0.0;
        }

        internal void SetPostExtrapolationTime(double time)
        {
        }

        internal void SetPreExtrapolationTime(double time)
        {
        }

        public bool IsExtrapolatedTime(double sequenceTime)
        {
            return false;
        }

        public bool IsPreExtrapolatedTime(double sequenceTime)
        {
            return false;
        }

        public bool IsPostExtrapolatedTime(double sequenceTime)
        {
            return false;
        }

        private static double GetExtrapolatedTime(double time, global::UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, double duration)
        {
            return 0.0;
        }

        public void CreateCurves(string curvesClipName)
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public void ConformEaseValues()
        {
        }

        private static double CalculateEasingRatio(double easeIn, double easeOut)
        {
            return 0.0;
        }

        private void UpdateDirty(double oldValue, double newValue)
        {
        }
    }
}