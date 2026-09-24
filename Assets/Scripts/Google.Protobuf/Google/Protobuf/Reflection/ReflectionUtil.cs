namespace Google.Protobuf.Reflection
{
    internal static class ReflectionUtil
    {
        private interface IReflectionHelper
        {
            global::System.Func<global::Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(global::System.Reflection.MethodInfo method);
            global::System.Action<global::Google.Protobuf.IMessage> CreateActionIMessage(global::System.Reflection.MethodInfo method);
            global::System.Func<global::Google.Protobuf.IMessage, object> CreateFuncIMessageObject(global::System.Reflection.MethodInfo method);
            global::System.Action<global::Google.Protobuf.IMessage, object> CreateActionIMessageObject(global::System.Reflection.MethodInfo method);
        }

        private class ReflectionHelper<T1, T2> : global::Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper
        {
            public global::System.Func<global::Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(global::System.Reflection.MethodInfo method)
            {
                return null;
            }

            public global::System.Action<global::Google.Protobuf.IMessage> CreateActionIMessage(global::System.Reflection.MethodInfo method)
            {
                return null;
            }

            public global::System.Func<global::Google.Protobuf.IMessage, object> CreateFuncIMessageObject(global::System.Reflection.MethodInfo method)
            {
                return null;
            }

            public global::System.Action<global::Google.Protobuf.IMessage, object> CreateActionIMessageObject(global::System.Reflection.MethodInfo method)
            {
                return null;
            }
        }

        public enum SampleEnum
        {
            X = 0
        }

        internal static readonly global::System.Type[] EmptyTypes;
        private static bool CanConvertEnumFuncToInt32Func { get; }

        static ReflectionUtil()
        {
        }

        internal static void ForceInitialize<T>()
        {
        }

        internal static global::System.Func<global::Google.Protobuf.IMessage, object> CreateFuncIMessageObject(global::System.Reflection.MethodInfo method)
        {
            return null;
        }

        internal static global::System.Func<global::Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(global::System.Reflection.MethodInfo method)
        {
            return null;
        }

        internal static global::System.Action<global::Google.Protobuf.IMessage, object> CreateActionIMessageObject(global::System.Reflection.MethodInfo method)
        {
            return null;
        }

        internal static global::System.Action<global::Google.Protobuf.IMessage> CreateActionIMessage(global::System.Reflection.MethodInfo method)
        {
            return null;
        }

        private static global::Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(global::System.Type t1, global::System.Type t2)
        {
            return null;
        }

        private static bool CheckCanConvertEnumFuncToInt32Func()
        {
            return false;
        }

        public static global::Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod()
        {
            return global::Google.Protobuf.Reflection.ReflectionUtil.SampleEnum.X;
        }
    }
}