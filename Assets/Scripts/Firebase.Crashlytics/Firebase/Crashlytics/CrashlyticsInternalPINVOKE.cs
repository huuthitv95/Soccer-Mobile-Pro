namespace Firebase.Crashlytics
{
    internal class CrashlyticsInternalPINVOKE
    {
        protected class SWIGExceptionHelper
        {
            public delegate void ExceptionDelegate(string message);
            public delegate void ExceptionArgumentDelegate(string message, string paramName);
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            internal static extern void SWIGRegisterExceptionCallbacks_CrashlyticsInternal(global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            [global::System.Runtime.InteropServices.PreserveSig]
            internal static extern void SWIGRegisterExceptionCallbacksArgument_CrashlyticsInternal(global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
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
            private static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            internal static extern void SWIGRegisterStringCallback_CrashlyticsInternal(global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            private static string CreateString(string cString)
            {
                return null;
            }

            static SWIGStringHelper()
            {
            }
        }

        protected static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        protected static global::Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper swigStringHelper;
        static CrashlyticsInternalPINVOKE()
        {
        }

        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr new_StackFrames__SWIG_0();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StackFrames_Add(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint StackFrames_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr StackFrames_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_StackFrames(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsFrame_library_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsFrame_symbol_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsFrame_fileName_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsFrame_lineNumber_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr new_FirebaseCrashlyticsFrame();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_FirebaseCrashlyticsFrame(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FirebaseCrashlyticsInternal_GetInstance__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, out int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsInternal_Log(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsInternal_SetCustomKey(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsInternal_SetUserId(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsInternal_LogException(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, global::System.Runtime.InteropServices.HandleRef jarg4);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseCrashlyticsInternal_LogExceptionAsFatal(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, global::System.Runtime.InteropServices.HandleRef jarg4);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool FirebaseCrashlyticsInternal_IsCrashlyticsCollectionEnabled(global::System.Runtime.InteropServices.HandleRef jarg1);
    }
}