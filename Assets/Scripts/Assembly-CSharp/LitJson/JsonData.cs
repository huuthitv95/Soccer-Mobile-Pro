namespace LitJson
{
    public class JsonData : global::LitJson.IJsonWrapper, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.IOrderedDictionary, global::System.Collections.IDictionary, global::System.IEquatable<global::LitJson.JsonData>
    {
        private global::System.Collections.Generic.IList<global::LitJson.JsonData> inst_array;
        private bool inst_boolean;
        private double inst_double;
        private int inst_int;
        private long inst_long;
        private global::System.Collections.Generic.IDictionary<string, global::LitJson.JsonData> inst_object;
        private string inst_string;
        private string json;
        private global::LitJson.JsonType type;
        private global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::LitJson.JsonData>> object_list;
        public int Count => 0;
        public bool IsArray => false;
        public bool IsBoolean => false;
        public bool IsDouble => false;
        public bool IsInt => false;
        public bool IsLong => false;
        public bool IsObject => false;
        public bool IsString => false;
        public global::System.Collections.Generic.ICollection<string> Keys => null;

        int global::System.Collections.ICollection.Count => 0;

        bool global::System.Collections.ICollection.IsSynchronized => false;

        object global::System.Collections.ICollection.SyncRoot => null;

        bool global::System.Collections.IDictionary.IsFixedSize => false;

        bool global::System.Collections.IDictionary.IsReadOnly => false;

        global::System.Collections.ICollection global::System.Collections.IDictionary.Keys => null;

        global::System.Collections.ICollection global::System.Collections.IDictionary.Values => null;

        bool global::LitJson.IJsonWrapper.IsArray => false;

        bool global::LitJson.IJsonWrapper.IsBoolean => false;

        bool global::LitJson.IJsonWrapper.IsDouble => false;

        bool global::LitJson.IJsonWrapper.IsInt => false;

        bool global::LitJson.IJsonWrapper.IsLong => false;

        bool global::LitJson.IJsonWrapper.IsObject => false;

        bool global::LitJson.IJsonWrapper.IsString => false;

        bool global::System.Collections.IList.IsFixedSize => false;

        bool global::System.Collections.IList.IsReadOnly => false;

        // C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.
        object global::System.Collections.IDictionary.this[object key]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        // C# has no syntax for parameterized property 'System.Collections.Specialized.IOrderedDictionary.Item'.
        object global::System.Collections.Specialized.IOrderedDictionary.this[int idx]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        // C# has no syntax for parameterized property 'System.Collections.IList.Item'.
        object global::System.Collections.IList.this[int index]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public global::LitJson.JsonData this[string prop_name]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public global::LitJson.JsonData this[int index]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool ContainsKey(string key)
        {
            return false;
        }

        public JsonData()
        {
        }

        public JsonData(bool boolean)
        {
        }

        public JsonData(double number)
        {
        }

        public JsonData(int number)
        {
        }

        public JsonData(long number)
        {
        }

        public JsonData(object obj)
        {
        }

        public JsonData(string str)
        {
        }

        public static implicit operator global::LitJson.JsonData(bool data)
        {
            return null;
        }

        public static implicit operator global::LitJson.JsonData(double data)
        {
            return null;
        }

        public static implicit operator global::LitJson.JsonData(int data)
        {
            return null;
        }

        public static implicit operator global::LitJson.JsonData(long data)
        {
            return null;
        }

        public static implicit operator global::LitJson.JsonData(string data)
        {
            return null;
        }

        public static explicit operator bool (global::LitJson.JsonData data)
        {
            return false;
        }

        public static explicit operator double (global::LitJson.JsonData data)
        {
            return 0.0;
        }

        public static explicit operator int (global::LitJson.JsonData data)
        {
            return 0;
        }

        public static explicit operator long (global::LitJson.JsonData data)
        {
            return 0L;
        }

        public static explicit operator string (global::LitJson.JsonData data)
        {
            return null;
        }

        void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
        {
        }

        void global::System.Collections.IDictionary.Add(object key, object value)
        {
        }

        void global::System.Collections.IDictionary.Clear()
        {
        }

        bool global::System.Collections.IDictionary.Contains(object key)
        {
            return false;
        }

        global::System.Collections.IDictionaryEnumerator global::System.Collections.IDictionary.GetEnumerator()
        {
            return null;
        }

        void global::System.Collections.IDictionary.Remove(object key)
        {
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        bool global::LitJson.IJsonWrapper.GetBoolean()
        {
            return false;
        }

        double global::LitJson.IJsonWrapper.GetDouble()
        {
            return 0.0;
        }

        int global::LitJson.IJsonWrapper.GetInt()
        {
            return 0;
        }

        long global::LitJson.IJsonWrapper.GetLong()
        {
            return 0L;
        }

        string global::LitJson.IJsonWrapper.GetString()
        {
            return null;
        }

        void global::LitJson.IJsonWrapper.SetBoolean(bool val)
        {
        }

        void global::LitJson.IJsonWrapper.SetDouble(double val)
        {
        }

        void global::LitJson.IJsonWrapper.SetInt(int val)
        {
        }

        void global::LitJson.IJsonWrapper.SetLong(long val)
        {
        }

        void global::LitJson.IJsonWrapper.SetString(string val)
        {
        }

        string global::LitJson.IJsonWrapper.ToJson()
        {
            return null;
        }

        void global::LitJson.IJsonWrapper.ToJson(global::LitJson.JsonWriter writer)
        {
        }

        int global::System.Collections.IList.Add(object value)
        {
            return 0;
        }

        void global::System.Collections.IList.Clear()
        {
        }

        bool global::System.Collections.IList.Contains(object value)
        {
            return false;
        }

        int global::System.Collections.IList.IndexOf(object value)
        {
            return 0;
        }

        void global::System.Collections.IList.Insert(int index, object value)
        {
        }

        void global::System.Collections.IList.Remove(object value)
        {
        }

        void global::System.Collections.IList.RemoveAt(int index)
        {
        }

        global::System.Collections.IDictionaryEnumerator global::System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
        {
            return null;
        }

        void global::System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value)
        {
        }

        void global::System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx)
        {
        }

        private global::System.Collections.ICollection EnsureCollection()
        {
            return null;
        }

        private global::System.Collections.IDictionary EnsureDictionary()
        {
            return null;
        }

        private global::System.Collections.IList EnsureList()
        {
            return null;
        }

        private global::LitJson.JsonData ToJsonData(object obj)
        {
            return null;
        }

        private static void WriteJson(global::LitJson.IJsonWrapper obj, global::LitJson.JsonWriter writer)
        {
        }

        public int Add(object value)
        {
            return 0;
        }

        public bool Remove(object obj)
        {
            return false;
        }

        public void Clear()
        {
        }

        public bool Equals(global::LitJson.JsonData x)
        {
            return false;
        }

        public global::LitJson.JsonType GetJsonType()
        {
            return global::LitJson.JsonType.None;
        }

        public void SetJsonType(global::LitJson.JsonType type)
        {
        }

        public string ToJson()
        {
            return null;
        }

        public void ToJson(global::LitJson.JsonWriter writer)
        {
        }

        public override string ToString()
        {
            return null;
        }
    }
}