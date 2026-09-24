namespace UnityEngine.InputSystem.Utilities
{
    internal struct JsonParser
    {
        public enum JsonValueType
        {
            None = 0,
            Bool = 1,
            Real = 2,
            Integer = 3,
            String = 4,
            Array = 5,
            Object = 6,
            Any = 7
        }

        public struct JsonString : global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString>
        {
            public global::UnityEngine.InputSystem.Utilities.Substring text;
            public bool hasEscapes;
            public override string ToString()
            {
                return null;
            }

            public bool Equals(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString other)
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

            public static bool operator ==(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString right)
            {
                return false;
            }

            public static bool operator !=(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString right)
            {
                return false;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString(string str)
            {
                return default;
            }
        }

        public struct JsonValue : global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>
        {
            public global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType type;
            public bool boolValue;
            public double realValue;
            public long integerValue;
            public global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString stringValue;
            public global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> arrayValue;
            public global::System.Collections.Generic.Dictionary<string, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> objectValue;
            public object anyValue;
            public bool ToBoolean()
            {
                return false;
            }

            public long ToInteger()
            {
                return 0L;
            }

            public double ToDouble()
            {
                return 0.0;
            }

            public override string ToString()
            {
                return null;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(bool val)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(long val)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(double val)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(string str)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonString str)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(global::System.Collections.Generic.Dictionary<string, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj)
            {
                return default;
            }

            public static implicit operator global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue(global::System.Enum val)
            {
                return default;
            }

            public bool Equals(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue other)
            {
                return false;
            }

            private static bool Equals(object obj, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue value)
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

            public static bool operator ==(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right)
            {
                return false;
            }

            public static bool operator !=(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right)
            {
                return false;
            }
        }

        private readonly string m_Text;
        private readonly int m_Length;
        private int m_Position;
        private bool m_MatchAnyElementInArray;
        private bool m_DryRun;
        public bool isAtEnd => false;

        public JsonParser(string json)
        {
            m_Text = null;
            m_Length = 0;
            m_Position = 0;
            m_MatchAnyElementInArray = false;
            m_DryRun = false;
        }

        public void Reset()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public bool NavigateToProperty(string path)
        {
            return false;
        }

        public bool CurrentPropertyHasValueEqualTo(global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue expectedValue)
        {
            return false;
        }

        public bool ParseToken(char token)
        {
            return false;
        }

        public bool ParseValue()
        {
            return false;
        }

        public bool ParseValue(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool ParseStringValue(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool ParseArrayValue(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool ParseObjectValue(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool ParseNumber(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool ParseBooleanValue(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool ParseNullValue(out global::UnityEngine.InputSystem.Utilities.JsonParser.JsonValue result)
        {
            result = default;
            return false;
        }

        public bool SkipToValue()
        {
            return false;
        }

        private bool SkipString(string text)
        {
            return false;
        }

        private void SkipWhitespace()
        {
        }
    }
}