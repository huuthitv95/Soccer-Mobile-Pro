namespace UnityEngine.InputSystem.Composites
{
    [global::System.ComponentModel.DisplayName]
    public class TwoModifiersComposite : global::UnityEngine.InputSystem.InputBindingComposite
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public int modifier1;
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public int modifier2;
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public int binding;
        public bool overrideModifiersNeedToBePressedFirst;
        private int m_ValueSizeInBytes;
        private global::System.Type m_ValueType;
        private bool m_BindingIsButton;
        public override global::System.Type valueType => null;
        public override int valueSizeInBytes => 0;

        public override float EvaluateMagnitude(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return 0f;
        }

        public unsafe override void ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context, void* buffer, int bufferSize)
        {
        }

        private bool ModifiersArePressed(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return false;
        }

        protected override void FinishSetup(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
        }

        public override object ReadValueAsObject(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return null;
        }
    }
}