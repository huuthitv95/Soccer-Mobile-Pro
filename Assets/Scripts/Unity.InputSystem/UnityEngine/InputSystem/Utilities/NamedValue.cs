namespace UnityEngine.InputSystem.Utilities
{
    public struct NamedValue : global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.NamedValue>
    {
        public const string Separator = ",";
        public string name { get; set; }
        public global::UnityEngine.InputSystem.Utilities.PrimitiveValue value { get; set; }
        public global::System.TypeCode type => global::System.TypeCode.Empty;

        public global::UnityEngine.InputSystem.Utilities.NamedValue ConvertTo(global::System.TypeCode type)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.NamedValue From<TValue>(string name, TValue value)
            where TValue : struct
        {
            return default;
        }

        public override string ToString()
        {
            return null;
        }

        public bool Equals(global::UnityEngine.InputSystem.Utilities.NamedValue other)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.Utilities.NamedValue left, global::UnityEngine.InputSystem.Utilities.NamedValue right)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.Utilities.NamedValue left, global::UnityEngine.InputSystem.Utilities.NamedValue right)
        {
            return false;
        }

        public static global::UnityEngine.InputSystem.Utilities.NamedValue[] ParseMultiple(string parameterString)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Utilities.NamedValue Parse(string str)
        {
            return default;
        }

        private static global::UnityEngine.InputSystem.Utilities.NamedValue ParseParameter(string parameterString, ref int index)
        {
            return default;
        }

        public void ApplyToObject(object instance)
        {
        }

        public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters)
            where TParameterList : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.NamedValue>
        {
        }
    }
}