namespace UnityEngine.InputSystem.Utilities
{
    internal struct TypeTable
    {
        public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::System.Type> table;
        public global::System.Collections.Generic.IEnumerable<string> names => null;
        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.InternedString> internedNames => null;

        public void Initialize()
        {
        }

        public global::UnityEngine.InputSystem.Utilities.InternedString FindNameForType(global::System.Type type)
        {
            return default;
        }

        public void AddTypeRegistration(string name, global::System.Type type)
        {
        }

        public global::System.Type LookupTypeRegistration(string name)
        {
            return null;
        }
    }
}