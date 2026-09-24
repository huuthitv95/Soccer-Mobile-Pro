namespace AdjustSdk
{
    public class JSONNode
    {
        // C# has no syntax for parameterized property 'Item'.
        public virtual global::AdjustSdk.JSONNode this[int aIndex]
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
        public virtual global::AdjustSdk.JSONNode this[string aKey]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual string Value
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual int Count => 0;
        public virtual global::System.Collections.Generic.IEnumerable<global::AdjustSdk.JSONNode> Childs => null;
        public global::System.Collections.Generic.IEnumerable<global::AdjustSdk.JSONNode> DeepChilds => null;

        public virtual int AsInt
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public virtual float AsFloat
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public virtual double AsDouble
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public virtual bool AsBool
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public virtual global::AdjustSdk.JSONArray AsArray => null;
        public virtual global::AdjustSdk.JSONClass AsObject => null;

        public virtual void Add(string aKey, global::AdjustSdk.JSONNode aItem)
        {
        }

        public virtual void Add(global::AdjustSdk.JSONNode aItem)
        {
        }

        public virtual global::AdjustSdk.JSONNode Remove(string aKey)
        {
            return null;
        }

        public virtual global::AdjustSdk.JSONNode Remove(int aIndex)
        {
            return null;
        }

        public virtual global::AdjustSdk.JSONNode Remove(global::AdjustSdk.JSONNode aNode)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public virtual string ToString(string aPrefix)
        {
            return null;
        }

        public static implicit operator global::AdjustSdk.JSONNode(string s)
        {
            return null;
        }

        public static implicit operator string (global::AdjustSdk.JSONNode d)
        {
            return null;
        }

        public static bool operator ==(global::AdjustSdk.JSONNode a, object b)
        {
            return false;
        }

        public static bool operator !=(global::AdjustSdk.JSONNode a, object b)
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

        internal static string Escape(string aText)
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode Parse(string aJSON)
        {
            return null;
        }

        public virtual void Serialize(global::System.IO.BinaryWriter aWriter)
        {
        }

        public void SaveToStream(global::System.IO.Stream aData)
        {
        }

        public void SaveToCompressedStream(global::System.IO.Stream aData)
        {
        }

        public void SaveToCompressedFile(string aFileName)
        {
        }

        public string SaveToCompressedBase64()
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode Deserialize(global::System.IO.BinaryReader aReader)
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode LoadFromCompressedFile(string aFileName)
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode LoadFromCompressedStream(global::System.IO.Stream aData)
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode LoadFromStream(global::System.IO.Stream aData)
        {
            return null;
        }

        public static global::AdjustSdk.JSONNode LoadFromBase64(string aBase64)
        {
            return null;
        }
    }
}