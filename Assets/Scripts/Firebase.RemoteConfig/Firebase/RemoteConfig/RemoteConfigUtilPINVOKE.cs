namespace Firebase.RemoteConfig
{
    internal class RemoteConfigUtilPINVOKE
    {
        protected class SWIGExceptionHelper
        {
            public delegate void ExceptionDelegate(string message);
            public delegate void ExceptionArgumentDelegate(string message, string paramName);
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            public static extern void SWIGRegisterExceptionCallbacks_RemoteConfigUtil(global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            [global::System.Runtime.InteropServices.PreserveSig]
            public static extern void SWIGRegisterExceptionCallbacksArgument_RemoteConfigUtil(global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
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
            private static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            public static extern void SWIGRegisterStringCallback_RemoteConfigUtil(global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            private static string CreateString(string cString)
            {
                return null;
            }

            static SWIGStringHelper()
            {
            }
        }

        protected static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        protected static global::Firebase.RemoteConfig.RemoteConfigUtilPINVOKE.SWIGStringHelper swigStringHelper;
        static RemoteConfigUtilPINVOKE()
        {
        }

        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr ConfigUpdateInternal_updated_keys_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void delete_ConfigUpdateInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern ulong ConfigInfoInternal_fetch_time_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int ConfigInfoInternal_last_fetch_status_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int ConfigInfoInternal_last_fetch_failure_reason_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern ulong ConfigInfoInternal_throttled_end_time_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void delete_ConfigInfoInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FirebaseRemoteConfigInternal_FetchAndActivate(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FirebaseRemoteConfigInternal_GetKeys(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FirebaseRemoteConfigInternal_GetInfo(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FirebaseRemoteConfigInternal_App_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern global::System.IntPtr FirebaseRemoteConfigInternal_GetInstanceInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void FirebaseRemoteConfigInternal_ReleaseReferenceInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern global::System.IntPtr FirebaseRemoteConfigInternal_GetValueInternal(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr ConfigValueInternal_data_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int ConfigValueInternal_source_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void delete_ConfigValueInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
    }
}