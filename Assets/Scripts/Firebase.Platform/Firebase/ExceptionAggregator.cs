namespace Firebase
{
    internal class ExceptionAggregator
    {
        [global::System.ThreadStatic]
        private static global::System.Collections.Generic.List<global::System.Exception> threadLocalExceptions;
        private static global::System.Collections.Generic.List<global::System.Exception> Exceptions => null;

        public static global::System.Exception GetAndClearPendingExceptions()
        {
            return null;
        }

        public static void ThrowAndClearPendingExceptions()
        {
        }

        public static global::System.Exception LogException(global::System.Exception exception)
        {
            return null;
        }

        public static void Wrap(global::System.Action action)
        {
        }
    }
}