namespace UnityEngine.InputSystem
{
    public abstract class InputProcessor
    {
        public enum CachingPolicy
        {
            CacheResult = 0,
            EvaluateOnEveryRead = 1
        }

        internal static global::UnityEngine.InputSystem.Utilities.TypeTable s_Processors;
        public virtual global::UnityEngine.InputSystem.InputProcessor.CachingPolicy cachingPolicy => global::UnityEngine.InputSystem.InputProcessor.CachingPolicy.CacheResult;

        public abstract object ProcessAsObject(object value, global::UnityEngine.InputSystem.InputControl control);
        public unsafe abstract void Process(void* buffer, int bufferSize, global::UnityEngine.InputSystem.InputControl control);
        internal static global::System.Type GetValueTypeFromType(global::System.Type processorType)
        {
            return null;
        }
    }

    public abstract class InputProcessor<TValue> : global::UnityEngine.InputSystem.InputProcessor where TValue : struct
    {
        public abstract TValue Process(TValue value, global::UnityEngine.InputSystem.InputControl control);
        public override object ProcessAsObject(object value, global::UnityEngine.InputSystem.InputControl control)
        {
            return null;
        }

        public unsafe override void Process(void* buffer, int bufferSize, global::UnityEngine.InputSystem.InputControl control)
        {
        }
    }
}