namespace UnityEngine.InputSystem.Utilities
{
    internal sealed class SavedStructState<T> : global::UnityEngine.InputSystem.Utilities.ISavedState where T : struct
    {
        public delegate void TypedRestore(ref T state);
        private T m_State;
        private global::UnityEngine.InputSystem.Utilities.SavedStructState<T>.TypedRestore m_RestoreAction;
        private global::System.Action m_StaticDisposeCurrentState;
        internal SavedStructState(ref T state, global::UnityEngine.InputSystem.Utilities.SavedStructState<T>.TypedRestore restoreAction, global::System.Action staticDisposeCurrentState = null)
        {
        }

        public void StaticDisposeCurrentState()
        {
        }

        public void RestoreSavedState()
        {
        }
    }
}