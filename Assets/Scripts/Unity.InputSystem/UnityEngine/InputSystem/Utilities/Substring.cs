namespace UnityEngine.InputSystem.Utilities
{
    internal struct Substring : global::System.IComparable<global::UnityEngine.InputSystem.Utilities.Substring>, global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.Substring>
    {
        private readonly string m_String;
        private readonly int m_Index;
        private readonly int m_Length;
        public bool isEmpty => false;
        public int length => 0;
        public int index => 0;

        // C# has no syntax for parameterized property 'Item'.
        public char this[int index]
        {
            get
            {
                return '\0';
            }
        }

        public Substring(string str)
        {
            m_String = null;
            m_Index = 0;
            m_Length = 0;
        }

        public Substring(string str, int index, int length)
        {
            m_String = null;
            m_Index = 0;
            m_Length = 0;
        }

        public Substring(string str, int index)
        {
            m_String = null;
            m_Index = 0;
            m_Length = 0;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public bool Equals(string other)
        {
            return false;
        }

        public bool Equals(global::UnityEngine.InputSystem.Utilities.Substring other)
        {
            return false;
        }

        public bool Equals(global::UnityEngine.InputSystem.Utilities.InternedString other)
        {
            return false;
        }

        public int CompareTo(global::UnityEngine.InputSystem.Utilities.Substring other)
        {
            return 0;
        }

        public static int Compare(global::UnityEngine.InputSystem.Utilities.Substring left, global::UnityEngine.InputSystem.Utilities.Substring right, global::System.StringComparison comparison)
        {
            return 0;
        }

        public bool StartsWith(string str)
        {
            return false;
        }

        public string Substr(int index = 0, int length = -1)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.Utilities.Substring a, global::UnityEngine.InputSystem.Utilities.Substring b)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.Utilities.Substring a, global::UnityEngine.InputSystem.Utilities.Substring b)
        {
            return false;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.Utilities.Substring a, global::UnityEngine.InputSystem.Utilities.InternedString b)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.Utilities.Substring a, global::UnityEngine.InputSystem.Utilities.InternedString b)
        {
            return false;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.Utilities.InternedString a, global::UnityEngine.InputSystem.Utilities.Substring b)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.Utilities.InternedString a, global::UnityEngine.InputSystem.Utilities.Substring b)
        {
            return false;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.Substring(string s)
        {
            return default;
        }
    }
}