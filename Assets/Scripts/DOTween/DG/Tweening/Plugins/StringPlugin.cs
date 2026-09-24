namespace DG.Tweening.Plugins
{
    public class StringPlugin : global::DG.Tweening.Plugins.Core.ABSTweenPlugin<string, string, global::DG.Tweening.Plugins.Options.StringOptions>
    {
        private static readonly global::System.Text.StringBuilder _Buffer;
        private static readonly global::System.Collections.Generic.List<char> _OpenedTags;
        public override void SetFrom(global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> t, string fromValue, bool setImmediately)
        {
        }

        public override void Reset(global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> t)
        {
        }

        public override string ConvertToStartValue(global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> t, string value)
        {
            return null;
        }

        public override void SetRelativeEndValue(global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> t)
        {
        }

        public override void SetChangeValue(global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> t)
        {
        }

        public override float GetSpeedBasedDuration(global::DG.Tweening.Plugins.Options.StringOptions options, float unitsXSecond, string changeValue)
        {
            return 0f;
        }

        public override void EvaluateAndApply(global::DG.Tweening.Plugins.Options.StringOptions options, global::DG.Tweening.Tween t, bool isRelative, global::DG.Tweening.Core.DOGetter<string> getter, global::DG.Tweening.Core.DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, global::DG.Tweening.Core.Enums.UpdateNotice updateNotice)
        {
        }

        private global::System.Text.StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled)
        {
            return null;
        }

        private char[] ScrambledCharsToUse(global::DG.Tweening.Plugins.Options.StringOptions options)
        {
            return null;
        }
    }
}