namespace UnityEngine.InputSystem.Utilities
{
    internal struct CallbackArray<TDelegate>
        where TDelegate : global::System.Delegate
    {
        private bool m_CannotMutateCallbacksArray;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_Callbacks;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToAdd;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToRemove;
        public int length => 0;

        // C# has no syntax for parameterized property 'Item'.
        public TDelegate this[int index]
        {
            get
            {
                return null;
            }
        }

        public void Clear()
        {
        }

        public void AddCallback(TDelegate dlg)
        {
        }

        public void RemoveCallback(TDelegate dlg)
        {
        }

        public void LockForChanges()
        {
        }

        public void UnlockForChanges()
        {
        }
    }
}