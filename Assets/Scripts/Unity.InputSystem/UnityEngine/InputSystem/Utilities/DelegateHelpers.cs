namespace UnityEngine.InputSystem.Utilities
{
    internal static class DelegateHelpers
    {
        public static void InvokeCallbacksSafe(ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action> callbacks, string callbackName, object context = null)
        {
        }

        public static void InvokeCallbacksSafe<TValue>(ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<TValue>> callbacks, TValue argument, string callbackName, object context = null)
        {
        }

        public static void InvokeCallbacksSafe<TValue1, TValue2>(ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<TValue1, TValue2>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null)
        {
        }

        public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue<TValue1, TValue2>(ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Func<TValue1, TValue2, bool>> callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null)
        {
            return false;
        }

        public static void InvokeCallbacksSafe_AndInvokeReturnedActions<TValue>(ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Func<TValue, global::System.Action>> callbacks, TValue argument, string callbackName, object context = null)
        {
        }

        public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject<TValue, TReturn>(ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Func<TValue, TReturn>> callbacks, TValue argument, string callbackName, object context = null)
        {
            return false;
        }
    }
}