namespace UnityEngine.InputSystem.Composites
{
    public class ButtonWithOneModifier : global::UnityEngine.InputSystem.InputBindingComposite<float>
    {
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public int modifier;
        [global::UnityEngine.InputSystem.Layouts.InputControl]
        public int button;
        public bool overrideModifiersNeedToBePressedFirst;
        public override float ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return 0f;
        }

        private bool ModifierIsPressed(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return false;
        }

        public override float EvaluateMagnitude(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
            return 0f;
        }

        protected override void FinishSetup(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
        {
        }
    }
}