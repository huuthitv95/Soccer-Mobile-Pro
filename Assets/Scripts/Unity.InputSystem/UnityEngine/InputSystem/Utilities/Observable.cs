namespace UnityEngine.InputSystem.Utilities
{
	public static class Observable
	{
		public static global::System.IObservable<TValue> Where<TValue>(this global::System.IObservable<TValue> source, global::System.Func<TValue, bool> predicate)
		{
			return null;
		}

		public static global::System.IObservable<TResult> Select<TSource, TResult>(this global::System.IObservable<TSource> source, global::System.Func<TSource, TResult> filter)
		{
			return null;
		}

		public static global::System.IObservable<TResult> SelectMany<TSource, TResult>(this global::System.IObservable<TSource> source, global::System.Func<TSource, global::System.Collections.Generic.IEnumerable<TResult>> filter)
		{
			return null;
		}

		public static global::System.IObservable<TValue> Take<TValue>(this global::System.IObservable<TValue> source, int count)
		{
			return null;
		}

		public static global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(this global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> source, global::UnityEngine.InputSystem.InputDevice device)
		{
			return null;
		}

		public static global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice<TDevice>(this global::System.IObservable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr> source) where TDevice : global::UnityEngine.InputSystem.InputDevice
		{
			return null;
		}

		public static global::System.IDisposable CallOnce<TValue>(this global::System.IObservable<TValue> source, global::System.Action<TValue> action)
		{
			return null;
		}

		public static global::System.IDisposable Call<TValue>(this global::System.IObservable<TValue> source, global::System.Action<TValue> action)
		{
			return null;
		}
	}
}
