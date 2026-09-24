namespace LeTai.TrueShadow
{
    internal class ChangeTracker<T> : global::LeTai.TrueShadow.IChangeTracker
    {
        private T previousValue;
        private readonly global::System.Func<T> getValue;
        private readonly global::System.Func<T, T> onChange;
        private readonly global::System.Func<T, T, bool> compare;
        public ChangeTracker(global::System.Func<T> getValue, global::System.Func<T, T> onChange, global::System.Func<T, T, bool> compare = null)
        {
        }

        public void Forget()
        {
        }

        public void Check()
        {
        }
    }
}