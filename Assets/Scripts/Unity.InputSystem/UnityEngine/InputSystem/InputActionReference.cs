namespace UnityEngine.InputSystem
{
    public class InputActionReference : global::UnityEngine.ScriptableObject
    {
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputActionAsset m_Asset;
        [global::UnityEngine.SerializeField]
        internal string m_ActionId;
        [global::System.NonSerialized]
        private global::UnityEngine.InputSystem.InputAction m_Action;
        public global::UnityEngine.InputSystem.InputActionAsset asset => null;
        public global::UnityEngine.InputSystem.InputAction action => null;

        public void Set(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public void Set(global::UnityEngine.InputSystem.InputActionAsset asset, string mapName, string actionName)
        {
        }

        private void SetInternal(global::UnityEngine.InputSystem.InputActionAsset asset, global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public override string ToString()
        {
            return null;
        }

        internal static string GetDisplayName(global::UnityEngine.InputSystem.InputAction action)
        {
            return null;
        }

        internal string ToDisplayName()
        {
            return null;
        }

        public static implicit operator global::UnityEngine.InputSystem.InputAction(global::UnityEngine.InputSystem.InputActionReference reference)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.InputActionReference Create(global::UnityEngine.InputSystem.InputAction action)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.InputAction ToInputAction()
        {
            return null;
        }
    }
}