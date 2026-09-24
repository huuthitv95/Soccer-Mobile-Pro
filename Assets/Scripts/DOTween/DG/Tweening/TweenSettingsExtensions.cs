namespace DG.Tweening
{
	public static class TweenSettingsExtensions
	{
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetLink<T>(this T t, global::UnityEngine.GameObject gameObject) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetTarget<T>(this T t, object target) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetLoops<T>(this T t, int loops) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetLoops<T>(this T t, int loops, global::DG.Tweening.LoopType loopType) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetEase<T>(this T t, global::DG.Tweening.Ease ease) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetEase<T>(this T t, global::DG.Tweening.Ease ease, float overshoot) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetEase<T>(this T t, global::UnityEngine.AnimationCurve animCurve) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetUpdate<T>(this T t, bool isIndependentUpdate) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetUpdate<T>(this T t, global::DG.Tweening.UpdateType updateType, bool isIndependentUpdate) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T OnStart<T>(this T t, global::DG.Tweening.TweenCallback action) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T OnUpdate<T>(this T t, global::DG.Tweening.TweenCallback action) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T OnStepComplete<T>(this T t, global::DG.Tweening.TweenCallback action) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T OnComplete<T>(this T t, global::DG.Tweening.TweenCallback action) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T OnKill<T>(this T t, global::DG.Tweening.TweenCallback action) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static global::DG.Tweening.Sequence Append(this global::DG.Tweening.Sequence s, global::DG.Tweening.Tween t)
		{
			return null;
		}

		public static global::DG.Tweening.Sequence Join(this global::DG.Tweening.Sequence s, global::DG.Tweening.Tween t)
		{
			return null;
		}

		public static global::DG.Tweening.Sequence Insert(this global::DG.Tweening.Sequence s, float atPosition, global::DG.Tweening.Tween t)
		{
			return null;
		}

		public static global::DG.Tweening.Sequence AppendInterval(this global::DG.Tweening.Sequence s, float interval)
		{
			return null;
		}

		public static global::DG.Tweening.Sequence PrependInterval(this global::DG.Tweening.Sequence s, float interval)
		{
			return null;
		}

		public static global::DG.Tweening.Sequence AppendCallback(this global::DG.Tweening.Sequence s, global::DG.Tweening.TweenCallback callback)
		{
			return null;
		}

		public static global::DG.Tweening.Sequence InsertCallback(this global::DG.Tweening.Sequence s, float atPosition, global::DG.Tweening.TweenCallback callback)
		{
			return null;
		}

		public static global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this global::DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true) where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
		{
			return null;
		}

		public static T SetDelay<T>(this T t, float delay) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static T SetRelative<T>(this T t) where T : global::DG.Tweening.Tween
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> t, bool snapping)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> t, global::DG.Tweening.AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.VectorOptions> t, global::DG.Tweening.AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Color, global::UnityEngine.Color, global::DG.Tweening.Plugins.Options.ColorOptions> t, bool alphaOnly)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<string, string, global::DG.Tweening.Plugins.Options.StringOptions> t, bool richTextEnabled, global::DG.Tweening.ScrambleMode scrambleMode = global::DG.Tweening.ScrambleMode.None, string scrambleChars = null)
		{
			return null;
		}

		public static global::DG.Tweening.Tweener SetOptions(this global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3[], global::DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool snapping)
		{
			return null;
		}
	}
}
