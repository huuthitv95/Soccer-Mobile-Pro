namespace Firebase
{
    internal class AppUtilPINVOKE
    {
        protected class SWIGExceptionHelper
        {
            public delegate void ExceptionDelegate(string message);
            public delegate void ExceptionArgumentDelegate(string message, string paramName);
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
            private static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            public static extern void SWIGRegisterExceptionCallbacks_AppUtil(global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
            [global::System.Runtime.InteropServices.PreserveSig]
            public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
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
            public static bool Pending => false;

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
            private static global::Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;
            [global::System.Runtime.InteropServices.PreserveSig]
            public static extern void SWIGRegisterStringCallback_AppUtil(global::Firebase.AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
            private static string CreateString(string cString)
            {
                return null;
            }

            static SWIGStringHelper()
            {
            }
        }

        protected static global::Firebase.AppUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
        protected static global::Firebase.AppUtilPINVOKE.SWIGStringHelper swigStringHelper;
        static AppUtilPINVOKE()
        {
        }

        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_FutureBase(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int FutureBase_status(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int FutureBase_error(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string FutureBase_error_message(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr new_StringStringMap__SWIG_0();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint StringStringMap_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringStringMap_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string StringStringMap_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringStringMap_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool StringStringMap_ContainsKey(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringStringMap_Add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool StringStringMap_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr StringStringMap_create_iterator_begin(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string StringStringMap_get_next_key(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringStringMap_destroy_iterator(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_StringStringMap(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr new_StringList__SWIG_0();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringList_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringList_Add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint StringList_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string StringList_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string StringList_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringList_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringList_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void StringList_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool StringList_Contains(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int StringList_IndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool StringList_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_StringList(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void CharVector_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void CharVector_Add(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint CharVector_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern byte CharVector_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern byte CharVector_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void CharVector_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, byte jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void CharVector_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, byte jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void CharVector_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool CharVector_Contains(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int CharVector_IndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool CharVector_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_CharVector(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FutureString_SWIG_OnCompletion(global::System.Runtime.InteropServices.HandleRef jarg1, global::Firebase.FutureString.SWIG_CompletionDelegate jarg2, int jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FutureString_SWIG_FreeCompletionData(global::System.IntPtr jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string FutureString_GetResult(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_FutureString(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FutureBool_SWIG_OnCompletion(global::System.Runtime.InteropServices.HandleRef jarg1, global::Firebase.FutureBool.SWIG_CompletionDelegate jarg2, int jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FutureBool_SWIG_FreeCompletionData(global::System.IntPtr jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool FutureBool_GetResult(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_FutureBool(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string FirebaseApp_NameInternal_get(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FirebaseApp_CreateInternal__SWIG_0();
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void FirebaseApp_ReleaseReferenceInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern int FirebaseApp_GetLogLevelInternal();
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void FirebaseApp_RegisterLibrariesInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void FirebaseApp_LogHeartbeatInternal(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern string FirebaseApp_DefaultName_get();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void PollCallbacks();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void AppEnableLogCallback(bool jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void SetEnabledAllAppCallbacks(bool jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool GetEnabledAppCallbackByName(string jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void SetLogFunction(global::Firebase.LogUtil.LogMessageDelegate jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern int CheckAndroidDependencies();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint VariantVariantMap_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void VariantVariantMap_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr VariantVariantMap_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void VariantVariantMap_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool VariantVariantMap_ContainsKey(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void VariantVariantMap_Add(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern bool VariantVariantMap_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr VariantVariantMap_create_iterator_begin(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr VariantVariantMap_get_next_key(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void VariantVariantMap_destroy_iterator(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_VariantVariantMap(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr new_VariantList__SWIG_0();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void VariantList_Add(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern uint VariantList_size(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr VariantList_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_VariantList(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern void delete_Variant(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_Null();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_EmptyVector();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_EmptyMap();
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_EmptyMutableBlob(uint jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_vector__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_map__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_FromInt64(long jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_FromDouble(double jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_FromBool(bool jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_FromString(string jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr Variant_untyped_mutable_blob_data(global::System.Runtime.InteropServices.HandleRef jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FutureString_SWIGUpcast(global::System.IntPtr jarg1);
        [global::System.Runtime.InteropServices.PreserveSig]
        public static extern global::System.IntPtr FutureBool_SWIGUpcast(global::System.IntPtr jarg1);
    }
}