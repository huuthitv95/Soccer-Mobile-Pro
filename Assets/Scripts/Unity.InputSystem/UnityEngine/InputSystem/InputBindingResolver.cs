namespace UnityEngine.InputSystem
{
    internal struct InputBindingResolver : global::System.IDisposable
    {
        public int totalProcessorCount;
        public int totalCompositeCount;
        public int totalInteractionCount;
        public global::UnityEngine.InputSystem.InputActionMap[] maps;
        public global::UnityEngine.InputSystem.InputControl[] controls;
        public global::UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory;
        public global::UnityEngine.InputSystem.IInputInteraction[] interactions;
        public global::UnityEngine.InputSystem.InputProcessor[] processors;
        public global::UnityEngine.InputSystem.InputBindingComposite[] composites;
        public global::UnityEngine.InputSystem.InputBinding? bindingMask;
        private bool m_IsControlOnlyResolve;
        private global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Utilities.NameAndParameters> m_Parameters;
        public int totalMapCount => 0;
        public int totalActionCount => 0;
        public int totalBindingCount => 0;
        public int totalControlCount => 0;

        public void Dispose()
        {
        }

        public void StartWithPreviousResolve(global::UnityEngine.InputSystem.InputActionState state, bool isFullResolve)
        {
        }

        public void AddActionMap(global::UnityEngine.InputSystem.InputActionMap actionMap)
        {
        }

        private int InstantiateWithParameters<TType>(global::UnityEngine.InputSystem.Utilities.TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, global::UnityEngine.InputSystem.InputActionMap actionMap, ref global::UnityEngine.InputSystem.InputBinding binding)
        {
            return 0;
        }

        private static global::UnityEngine.InputSystem.InputBindingComposite InstantiateBindingComposite(ref global::UnityEngine.InputSystem.InputBinding binding, global::UnityEngine.InputSystem.InputActionMap actionMap)
        {
            return null;
        }

        private static void ApplyParameters(global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.NamedValue> parameters, object instance, global::UnityEngine.InputSystem.InputActionMap actionMap, ref global::UnityEngine.InputSystem.InputBinding binding, string objectRegistrationName, string namesAndParameters)
        {
        }

        private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount)
        {
            return 0;
        }
    }
}