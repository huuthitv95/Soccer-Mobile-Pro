namespace Facebook.MiniJSON
{
    public static class Json
    {
        private sealed class Parser : global::System.IDisposable
        {
            private enum TOKEN
            {
                NONE = 0,
                CURLY_OPEN = 1,
                CURLY_CLOSE = 2,
                SQUARED_OPEN = 3,
                SQUARED_CLOSE = 4,
                COLON = 5,
                COMMA = 6,
                STRING = 7,
                NUMBER = 8,
                TRUE = 9,
                FALSE = 10,
                NULL = 11
            }

            private global::System.IO.StringReader json;
            private char PeekChar => '\0';
            private char NextChar => '\0';
            private string NextWord => null;
            private global::Facebook.MiniJSON.Json.Parser.TOKEN NextToken => global::Facebook.MiniJSON.Json.Parser.TOKEN.NONE;

            private Parser(string jsonString)
            {
            }

            public static object Parse(string jsonString)
            {
                return null;
            }

            public void Dispose()
            {
            }

            private global::System.Collections.Generic.Dictionary<string, object> ParseObject()
            {
                return null;
            }

            private global::System.Collections.Generic.List<object> ParseArray()
            {
                return null;
            }

            private object ParseValue()
            {
                return null;
            }

            private object ParseByToken(global::Facebook.MiniJSON.Json.Parser.TOKEN token)
            {
                return null;
            }

            private string ParseString()
            {
                return null;
            }

            private object ParseNumber()
            {
                return null;
            }

            private void EatWhitespace()
            {
            }
        }

        private sealed class Serializer
        {
            private global::System.Text.StringBuilder builder;
            private Serializer()
            {
            }

            public static string Serialize(object obj)
            {
                return null;
            }

            private void SerializeValue(object value)
            {
            }

            private void SerializeObject(global::System.Collections.IDictionary obj)
            {
            }

            private void SerializeArray(global::System.Collections.IList array)
            {
            }

            private void SerializeString(string str)
            {
            }

            private void SerializeOther(object value)
            {
            }
        }

        private static global::System.Globalization.NumberFormatInfo numberFormat;
        public static object Deserialize(string json)
        {
            return null;
        }

        public static string Serialize(object obj)
        {
            return null;
        }
    }
}