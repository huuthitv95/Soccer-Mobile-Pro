namespace UnityEngine.InputSystem
{
    public abstract class InputBindingComposite
    {
        internal static global::UnityEngine.InputSystem.Utilities.TypeTable s_Composites;
        public abstract global::System.Type valueType { get; }
        public abstract int valueSizeInBytes { get; }

        public unsafe abstract void ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize);
        public abstract object ReadValueAsObject(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context);
        public virtual float EvaluateMagnitude(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return 0f;
        }

        protected virtual void FinishSetup(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
        }

        internal void CallFinishSetup(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
        }

        internal static global::System.Type GetValueType(string composite)
        {
            return null;
        }

        public static string GetExpectedControlLayoutName(string composite, string part)
        {
            return null;
        }

        internal static global::System.Collections.Generic.IEnumerable<string> GetPartNames(string composite)
        {
            return null;
        }

        internal static string GetDisplayFormatString(string composite)
        {
            return null;
        }
    }

    public abstract class InputBindingComposite<TValue> : global::UnityEngine.InputSystem.InputBindingComposite where TValue : struct
    {
        public override global::System.Type valueType => null;
        public override int valueSizeInBytes => 0;

        public abstract TValue ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context);
        public unsafe override void ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize)
        {
        }

        public override object ReadValueAsObject(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return null;
        }
    }
}