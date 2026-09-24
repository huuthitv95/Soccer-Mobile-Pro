namespace LitJson
{
    public class JsonMockWrapper : global::LitJson.IJsonWrapper, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.IOrderedDictionary, global::System.Collections.IDictionary
    {
        public bool IsArray => false;
        public bool IsBoolean => false;
        public bool IsDouble => false;
        public bool IsInt => false;
        public bool IsLong => false;
        public bool IsObject => false;
        public bool IsString => false;

        bool global::System.Collections.IList.IsFixedSize => false;

        bool global::System.Collections.IList.IsReadOnly => false;

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

        int global::System.Collections.ICollection.Count => 0;

        bool global::System.Collections.ICollection.IsSynchronized => false;

        object global::System.Collections.ICollection.SyncRoot => null;

        bool global::System.Collections.IDictionary.IsFixedSize => false;

        bool global::System.Collections.IDictionary.IsReadOnly => false;

        global::System.Collections.ICollection global::System.Collections.IDictionary.Keys => null;

        global::System.Collections.ICollection global::System.Collections.IDictionary.Values => null;

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

        public bool GetBoolean()
        {
            return false;
        }

        public double GetDouble()
        {
            return 0.0;
        }

        public int GetInt()
        {
            return 0;
        }

        public global::LitJson.JsonType GetJsonType()
        {
            return global::LitJson.JsonType.None;
        }

        public long GetLong()
        {
            return 0L;
        }

        public string GetString()
        {
            return null;
        }

        public void SetBoolean(bool val)
        {
        }

        public void SetDouble(double val)
        {
        }

        public void SetInt(int val)
        {
        }

        public void SetJsonType(global::LitJson.JsonType type)
        {
        }

        public void SetLong(long val)
        {
        }

        public void SetString(string val)
        {
        }

        public string ToJson()
        {
            return null;
        }

        public void ToJson(global::LitJson.JsonWriter writer)
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

        void global::System.Collections.IList.Insert(int i, object v)
        {
        }

        void global::System.Collections.IList.Remove(object value)
        {
        }

        void global::System.Collections.IList.RemoveAt(int index)
        {
        }

        void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
        {
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        void global::System.Collections.IDictionary.Add(object k, object v)
        {
        }

        void global::System.Collections.IDictionary.Clear()
        {
        }

        bool global::System.Collections.IDictionary.Contains(object key)
        {
            return false;
        }

        void global::System.Collections.IDictionary.Remove(object key)
        {
        }

        global::System.Collections.IDictionaryEnumerator global::System.Collections.IDictionary.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IDictionaryEnumerator global::System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
        {
            return null;
        }

        void global::System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v)
        {
        }

        void global::System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i)
        {
        }
    }
}