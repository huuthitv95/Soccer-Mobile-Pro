namespace Firebase.Analytics
{
    internal class FirebaseAnalyticsInternalPINVOKE
    {
        protected class SWIGExceptionHelper
        {
            public delegate void ExceptionDelegate(string message);
            public delegate void ExceptionArgumentDelegate(string message, string paramName);
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            internal static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            [global::System.Runtime.InteropServices.PreserveSig]
            internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
            private static void SetPendingApplicationException(string message)
            {
            }

            private static void SetPendingArithmeticException(string message)
            {
            }

            private static void SetPendingDivideByZeroException(string message)
            {
            }

            private static void SetPendingIndexOutOfRangeException(string message)
            {
            }

            private static void SetPendingInvalidCastException(string message)
            {
            }

            private static void SetPendingInvalidOperationException(string message)
            {
            }

            private static void SetPendingIOException(string message)
            {
            }

            private static void SetPendingNullReferenceException(string message)
            {
            }

            private static void SetPendingOutOfMemoryException(string message)
            {
            }

            private static void SetPendingOverflowException(string message)
            {
            }

            private static void SetPendingSystemException(string message)
            {
            }

            private static void SetPendingArgumentException(string message, string paramName)
            {
            }

            private static void SetPendingArgumentNullException(string message, string paramName)
            {
            }

            private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
            {
            }

            static SWIGExceptionHelper()
            {
            }
        }

        public class SWIGPendingException
        {
            [global::System.ThreadStatic]
            private static global::System.Exception pendingException;
            private static int numExceptionsPending;
            private static object exceptionsLock;
            public static void Set(global::System.Exception e)
            {
            }

            public static global::System.Exception Retrieve()
            {
                return null;
            }

            static SWIGPendingException()
            {
            }
        }

        protected class SWIGStringHelper
        {
            public delegate string SWIGStringDelegate(string message);
            private static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            internal static extern void SWIGRegisterStringCallback_FirebaseAnalyticsInternal(global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            private static string CreateString(string cString)
            {
                return null;
            }

            static SWIGStringHelper()
            {
            }
        }

        protected static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        protected static global::Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper swigStringHelper;
        static FirebaseAnalyticsInternalPINVOKE()
        {
        }

        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr new_IntIntMap__SWIG_0();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint IntIntMap_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void IntIntMap_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int IntIntMap_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void IntIntMap_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool IntIntMap_ContainsKey(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void IntIntMap_Add(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool IntIntMap_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr IntIntMap_create_iterator_begin(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int IntIntMap_get_next_key(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void IntIntMap_destroy_iterator(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_IntIntMap(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void LogEvent__SWIG_2(string jarg1, string jarg2, long jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void LogEvent__SWIG_4(string jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void SetUserProperty(string jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr GetAnalyticsInstanceId();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void LogEvent__SWIG_5(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void SetConsentWithInts(global::System.Runtime.InteropServices.HandleRef jarg1);
    }
}