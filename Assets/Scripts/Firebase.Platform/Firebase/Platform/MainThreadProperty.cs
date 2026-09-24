namespace Firebase.Platform
{
	internal class MainThreadProperty<T>
	{
		private global::System.Func<T> getPropertyDelegate;

		private int lastGetPropertyTickCount;

		private T cachedValue;

		public T Value => default;

		public MainThreadProperty(global::System.Func<T> getPropertyDelegate)
		{
		}
	}
}
