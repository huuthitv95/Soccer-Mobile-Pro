namespace Facebook.Unity
{
    internal class MethodArguments
    {
        private global::System.Collections.Generic.IDictionary<string, object> arguments;
        public MethodArguments()
        {
        }

        public MethodArguments(global::Facebook.Unity.MethodArguments methodArgs)
        {
        }

        private MethodArguments(global::System.Collections.Generic.IDictionary<string, object> arguments)
        {
        }

        public void AddPrimative<T>(string argumentName, T value)
            where T : struct
        {
        }

        public void AddNullablePrimitive<T>(string argumentName, T? nullable)
            where T : struct
        {
        }

        public void AddString(string argumentName, string value)
        {
        }

        public void AddCommaSeparatedList(string argumentName, global::System.Collections.Generic.IEnumerable<string> value)
        {
        }

        public void AddDictionary(string argumentName, global::System.Collections.Generic.IDictionary<string, object> dict)
        {
        }

        public void AddList<T>(string argumentName, global::System.Collections.Generic.IEnumerable<T> list)
        {
        }

        public void AddUri(string argumentName, global::System.Uri uri)
        {
        }

        public string ToJsonString()
        {
            return null;
        }

        private static global::System.Collections.Generic.Dictionary<string, string> ToStringDict(global::System.Collections.Generic.IDictionary<string, object> dict)
        {
            return null;
        }
    }
}